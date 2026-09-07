using Entidades;
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
        private readonly Usuario? _usuario;

        public FRecepcionista() : this(null)
        {
        }

        public FRecepcionista(Usuario? usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }

        private void FRecepcionista_Load(object sender, EventArgs e)
        {
            FReservas fr = new FReservas();
            fr.MdiParent = this;
            fr.Show();
            fr.WindowState = FormWindowState.Maximized;
        }

        private void BHuespedes_Click(object sender, EventArgs e)
        {

        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
