using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class TurnoCaja
    {
        public int IdTurno { get; set; }
        public DateTime FechaApertura { get; set; }
        public TimeSpan HoraApertura { get; set; }
        public DateTime? FechaCierre { get; set; }  // El '?' permite valores NULL
        public TimeSpan? HoraCierre { get; set; }  // El '?' permite valores NULL
        public decimal MontoInicial { get; set; }
        public decimal? MontoFinal { get; set; }    // Puede ser NULL
        public string Observaciones { get; set; }   // Puede ser NULL
        public int IdUsuario { get; set; }
    }
}
