using Presentacion.Recepcionista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FRecepcionista : Form
    {
        public FRecepcionista()
        {
            InitializeComponent();
        }

        private void FRecepcionista_Load(object sender, EventArgs e)
        {
            FReservas fr = new FReservas();
            fr.MdiParent = this;
            fr.Dock = DockStyle.Fill;
            fr.Show();
        }

        private void BHuespedes_Click(object sender, EventArgs e)
        {

        }

        

        private void PMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
