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

        public List<Habitacion> ObtenerHabitaciones()
        {
            return HabitacionDAO.ObtenerTodas();
        }

        public List<EstadoHabitacion> ObtenerEstados()
        {
            return EstadoHabitacionDAO.ObtenerTodos();
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
    }
}
