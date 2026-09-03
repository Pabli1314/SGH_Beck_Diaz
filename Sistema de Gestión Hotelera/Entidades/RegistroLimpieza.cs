using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class RegistroLimpieza
    {
        public int IdLimpieza { get; set; }
        public DateTime FechaLimpieza { get; set; } // Tiene DEFAULT en BD
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public int NroHabitacion { get; set; }
        public int IdUsuario { get; set; }
    }
}
