using System;
using System.Collections.Generic;
using System.Linq;
using Entidades;
using Datos;

namespace Logica
{
    public class GestionHospedajes
    {
        private const string ESTADO_DISPONIBLE = "Disponible";
        private const string ESTADO_OCUPADA = "Ocupada";
        private const string ESTADO_LIMPIEZA = "Limpieza";

        private readonly GestionTurnoCaja _gestionTurnoCaja = new GestionTurnoCaja();

        public List<MetodoPago> ObtenerMetodosPago()
        {
            return MetodoPagoDAO.ObtenerTodos();
        }

        /// <summary>
        /// Da de alta el hospedaje de un huésped nuevo o existente y pasa la habitación a Ocupada.
        /// Requiere una habitación Disponible y una fecha/hora de salida planificada posterior a hoy
        /// (hospedaje.fecha_salida/hora_salida son obligatorias en la base, no se puede dejar "abierto").
        /// </summary>
        public void RegistrarCheckIn(int nroHabitacion, int idUsuario, Huesped huesped, int idMetodo, DateTime fechaSalida, TimeSpan horaSalida)
        {
            if (fechaSalida.Date < DateTime.Now.Date)
            {
                throw new InvalidOperationException("La fecha de salida no puede ser anterior a hoy.");
            }

            Habitacion? habitacion = HabitacionDAO.ObtenerPorNumero(nroHabitacion);
            if (habitacion == null)
            {
                throw new InvalidOperationException($"No existe la habitación {nroHabitacion}.");
            }

            EstadoHabitacion? estadoDisponible = EstadoHabitacionDAO.ObtenerTodos().FirstOrDefault(e => e.NomEstadoHabitacion == ESTADO_DISPONIBLE);
            EstadoHabitacion? estadoOcupada = EstadoHabitacionDAO.ObtenerTodos().FirstOrDefault(e => e.NomEstadoHabitacion == ESTADO_OCUPADA);

            if (estadoDisponible == null || estadoOcupada == null)
            {
                throw new InvalidOperationException("No se encontraron los estados de habitación 'Disponible'/'Ocupada' en la base de datos.");
            }

            if (habitacion.IdEstado != estadoDisponible.IdEstado)
            {
                throw new InvalidOperationException($"La habitación {nroHabitacion} no está Disponible.");
            }

            if (HuespedDAO.ObtenerPorDni(huesped.DniHuesped) == null)
            {
                HuespedDAO.Crear(huesped);
            }

            TurnoCaja turno = _gestionTurnoCaja.ObtenerOAbrirTurno(idUsuario);

            HospedajeDAO.Crear(new Hospedaje
            {
                FechaSalida = fechaSalida,
                HoraSalida = horaSalida,
                IdMetodo = idMetodo,
                NroHabitacion = nroHabitacion,
                IdTurno = turno.IdTurno,
                DniHuesped = huesped.DniHuesped
            });

            HabitacionDAO.ActualizarEstado(nroHabitacion, estadoOcupada.IdEstado);
        }

        /// <summary>
        /// Cierra el hospedaje vigente de la habitación (pisa fecha/hora de salida con el momento real
        /// del check-out) y la pasa a Limpieza.
        /// </summary>
        public void RegistrarCheckOut(int nroHabitacion)
        {
            Habitacion? habitacion = HabitacionDAO.ObtenerPorNumero(nroHabitacion);
            if (habitacion == null)
            {
                throw new InvalidOperationException($"No existe la habitación {nroHabitacion}.");
            }

            EstadoHabitacion? estadoOcupada = EstadoHabitacionDAO.ObtenerTodos().FirstOrDefault(e => e.NomEstadoHabitacion == ESTADO_OCUPADA);
            EstadoHabitacion? estadoLimpieza = EstadoHabitacionDAO.ObtenerTodos().FirstOrDefault(e => e.NomEstadoHabitacion == ESTADO_LIMPIEZA);

            if (estadoOcupada == null || estadoLimpieza == null)
            {
                throw new InvalidOperationException("No se encontraron los estados de habitación 'Ocupada'/'Limpieza' en la base de datos.");
            }

            if (habitacion.IdEstado != estadoOcupada.IdEstado)
            {
                throw new InvalidOperationException($"La habitación {nroHabitacion} no está Ocupada.");
            }

            Hospedaje? hospedaje = HospedajeDAO.ObtenerActivoPorHabitacion(nroHabitacion);
            if (hospedaje == null)
            {
                throw new InvalidOperationException($"No se encontró el hospedaje vigente de la habitación {nroHabitacion}.");
            }

            HospedajeDAO.RegistrarSalida(hospedaje.IdHospedaje, DateTime.Now.Date, DateTime.Now.TimeOfDay);
            HabitacionDAO.ActualizarEstado(nroHabitacion, estadoLimpieza.IdEstado);
        }
    }
}
