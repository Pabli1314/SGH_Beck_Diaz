using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Administrador
{
    public partial class FAdministrador : Form
    {
        public FAdministrador()
        {
            InitializeComponent();
        }

        private void FAdministrador_Load(object sender, EventArgs e)
        {
            this.vistaPrincipal();
        }

        private void BUsuarios_Click(object sender, EventArgs e)
        {
            FUsuarios fUsuarios = new FUsuarios();
            fUsuarios.MdiParent = this;
            fUsuarios.Dock = DockStyle.Fill;
            fUsuarios.Show();
        }

        private void vistaPrincipal()
        {
            FMainAdministrador fMainAdministrador = new FMainAdministrador();
            fMainAdministrador.MdiParent = this;
            fMainAdministrador.Dock = DockStyle.Fill;
            fMainAdministrador.Show();
        }

        private void BInicio_Click(object sender, EventArgs e)
        {
            this.vistaPrincipal();
        }
    }
}
