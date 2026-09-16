using Entidades;
using Datos;

namespace Logica
{
    /// <summary>
    /// Versión mínima: solo resuelve qué turno de caja usar para poder cargar un hospedaje
    /// (que lo exige como FK). La apertura/cierre de turno con arqueo real es una función
    /// aparte, todavía no implementada (botón "Turno Caja/Pagos" del menú de recepción).
    /// </summary>
    public class GestionTurnoCaja
    {
        public TurnoCaja ObtenerOAbrirTurno(int idUsuario, decimal montoInicial = 0)
        {
            TurnoCaja? turnoAbierto = TurnoCajaDAO.ObtenerAbierto(idUsuario);
            if (turnoAbierto != null)
            {
                return turnoAbierto;
            }

            return TurnoCajaDAO.Abrir(idUsuario, montoInicial);
        }
    }
}
