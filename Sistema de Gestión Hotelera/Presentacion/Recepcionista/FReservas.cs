using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Recepcionista
{
    public partial class FReservas : Form
    {
        public FReservas()
        {
            InitializeComponent();
        }

        

        private void FReservas_Load(object sender, EventArgs e)
        {

        }

        private void bCrearReserva_Click(object sender, EventArgs e)
        {
            FCrearReserva fCrear = new FCrearReserva();
            fCrear.Show();
        }
    }
}
