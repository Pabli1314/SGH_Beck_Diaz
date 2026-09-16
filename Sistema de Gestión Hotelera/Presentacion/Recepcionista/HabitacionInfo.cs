using System;

namespace Presentacion.Recepcionista
{
    /// <summary>
    /// Vista de una habitación para la UI (tarjetas del tablero y pantalla de gestión).
    /// Hoy se arma con datos simulados (ver FReservas.ObtenerHabitacionesSimuladas);
    /// cuando haya persistencia real, se arma a partir de Entidades.Habitacion +
    /// Huesped/Hospedaje vía Logica.GestionHabitaciones.
    /// </summary>
    public class HabitacionInfo
    {
        public string NroHabitacion { get; set; }
        public string Tipo { get; set; }
        public EstadoOcupacion Estado { get; set; }
        public string Huesped { get; set; }
        public DateTime? HoraIngreso { get; set; }
    }
}
