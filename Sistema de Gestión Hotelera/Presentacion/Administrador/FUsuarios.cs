using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Presentacion.Administrador
{
    public partial class FUsuarios : Form
    {
          private LAdministrador lAdministrador = new LAdministrador();
        public FUsuarios()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                dgUusario.DataSource = lAdministrador.ObtenerUsuariosParaGrilla();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error de conexion a la BBDD", MessageBoxButtons.OK,  MessageBoxIcon.Error);
            }

            
        }
    }
}
