using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using Datos;

namespace Logica
{
    public class GestionHabitaciones
    {
        private const string ESTADO_LIMPIEZA = "Limpieza";
        private const string ESTADO_DISPONIBLE = "Disponible";
        private const string ESTADO_MANTENIMIENTO = "Mantenimiento";
        private const string ESTADO_OCUPADA = "Ocupada";

        public List<Habitacion> ObtenerHabitaciones()
        {
            return HabitacionDAO.ObtenerTodas();
        }

        public List<EstadoHabitacion> ObtenerEstados()
        {
            return EstadoHabitacionDAO.ObtenerTodos();
        }

        public List<TipoHabitacion> ObtenerTiposHabitacion()
        {
            return TipoHabitacionDAO.ObtenerTodos();
        }

        /// <summary>
        /// Arma la vista combinada de habitaciones para Dashboard/Supervisión del Administrador:
        /// datos de la habitación + estado + huésped/horario vigente (si está Ocupada) + última
        /// limpieza registrada. Hace una consulta por habitación ocupada, aceptable para el
        /// tamaño de hotel que maneja este sistema.
        /// </summary>
        public List<HabitacionResumen> ObtenerResumenHabitaciones()
        {
            List<Habitacion> habitaciones = HabitacionDAO.ObtenerTodas();
            List<EstadoHabitacion> estados = EstadoHabitacionDAO.ObtenerTodos();
            List<TipoHabitacion> tipos = TipoHabitacionDAO.ObtenerTodos();

            var resumen = new List<HabitacionResumen>();

            foreach (Habitacion habitacion in habitaciones)
            {
                EstadoHabitacion? estado = estados.FirstOrDefault(e => e.IdEstado == habitacion.IdEstado);
                TipoHabitacion? tipo = tipos.FirstOrDefault(t => t.IdTipoHabitacion == habitacion.IdTipoHabitacion);

                var item = new HabitacionResumen
                {
                    NroHabitacion = habitacion.NroHabitacion,
                    Piso = habitacion.Piso,
                    TipoHabitacion = tipo?.Descripcion ?? "-",
                    IdEstado = habitacion.IdEstado,
                    Estado = estado?.NomEstadoHabitacion ?? "-"
                };

                if (item.Estado == ESTADO_OCUPADA)
                {
                    Hospedaje? hospedaje = HospedajeDAO.ObtenerActivoPorHabitacion(habitacion.NroHabitacion);
                    if (hospedaje != null)
                    {
                        Huesped? huesped = HuespedDAO.ObtenerPorDni(hospedaje.DniHuesped);
                        item.Huesped = huesped != null ? $"{huesped.Nombre} {huesped.Apellido}" : hospedaje.DniHuesped;
                        item.HoraEntrada = hospedaje.FechaEntrada.Date + hospedaje.HoraEntrada;
                        item.HoraSalidaEstimada = hospedaje.FechaSalida.Date + hospedaje.HoraSalida;
                    }
                }

                RegistroLimpieza? ultimaLimpieza = RegistroLimpiezaDAO.ObtenerUltimaPorHabitacion(habitacion.NroHabitacion);
                if (ultimaLimpieza != null)
                {
                    item.UltimaLimpieza = ultimaLimpieza.FechaLimpieza.Date + ultimaLimpieza.HoraFin;
                    item.DuracionUltimaLimpieza = ultimaLimpieza.HoraFin - ultimaLimpieza.HoraInicio;
                }

                resumen.Add(item);
            }

            return resumen;
        }

        // RF-05.3: solo puede pasar de Limpieza a Disponible; lo hace Supervisor/Administrador.
        public void MarcarComoDisponible(int nroHabitacion, int idUsuario)
        {
            Habitacion? habitacion = HabitacionDAO.ObtenerPorNumero(nroHabitacion);
            if (habitacion == null)
            {
                throw new InvalidOperationException($"No existe la habitación {nroHabitacion}.");
            }

            List<EstadoHabitacion> estados = EstadoHabitacionDAO.ObtenerTodos();
            EstadoHabitacion? estadoLimpieza = estados.FirstOrDefault(e => e.NomEstadoHabitacion == ESTADO_LIMPIEZA);
            EstadoHabitacion? estadoDisponible = estados.FirstOrDefault(e => e.NomEstadoHabitacion == ESTADO_DISPONIBLE);

            if (estadoLimpieza == null || estadoDisponible == null)
            {
                throw new InvalidOperationException("No se encontraron los estados de habitación 'Limpieza'/'Disponible' en la base de datos.");
            }

            if (habitacion.IdEstado != estadoLimpieza.IdEstado)
            {
                throw new InvalidOperationException($"La habitación {nroHabitacion} no está en estado Limpieza.");
            }

            HabitacionDAO.ActualizarEstado(nroHabitacion, estadoDisponible.IdEstado);

            // No existe todavía un registro del inicio de la limpieza (RF-05.2 no está implementado
            // aún), por lo que se toma el momento de esta confirmación como inicio y fin.
            TimeSpan ahora = DateTime.Now.TimeOfDay;
            RegistroLimpiezaDAO.Registrar(new RegistroLimpieza
            {
                HoraInicio = ahora,
                HoraFin = ahora,
                NroHabitacion = nroHabitacion,
                IdUsuario = idUsuario
            });
        }

        /// <summary>Envía una habitación Disponible a Mantenimiento (no requiere que haya una limpieza en curso).</summary>
        public void EnviarAMantenimiento(int nroHabitacion)
        {
            CambiarEstado(nroHabitacion, ESTADO_DISPONIBLE, ESTADO_MANTENIMIENTO);
        }

        /// <summary>Cierra el mantenimiento y devuelve la habitación a Disponible.</summary>
        public void FinalizarMantenimiento(int nroHabitacion)
        {
            CambiarEstado(nroHabitacion, ESTADO_MANTENIMIENTO, ESTADO_DISPONIBLE);
        }

        private void CambiarEstado(int nroHabitacion, string estadoActualRequerido, string estadoNuevo)
        {
            Habitacion? habitacion = HabitacionDAO.ObtenerPorNumero(nroHabitacion);
            if (habitacion == null)
            {
                throw new InvalidOperationException($"No existe la habitación {nroHabitacion}.");
            }

            List<EstadoHabitacion> estados = EstadoHabitacionDAO.ObtenerTodos();
            EstadoHabitacion? estadoActual = estados.FirstOrDefault(e => e.NomEstadoHabitacion == estadoActualRequerido);
            EstadoHabitacion? estadoDestino = estados.FirstOrDefault(e => e.NomEstadoHabitacion == estadoNuevo);

            if (estadoActual == null || estadoDestino == null)
            {
                throw new InvalidOperationException($"No se encontraron los estados de habitación '{estadoActualRequerido}'/'{estadoNuevo}' en la base de datos.");
            }

            if (habitacion.IdEstado != estadoActual.IdEstado)
            {
                throw new InvalidOperationException($"La habitación {nroHabitacion} no está en estado {estadoActualRequerido}.");
            }

            HabitacionDAO.ActualizarEstado(nroHabitacion, estadoDestino.IdEstado);
        }
    }
}
