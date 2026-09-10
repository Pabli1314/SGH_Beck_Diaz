using Logica;
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
    public partial class FAgregarUsuario : Form
    {
        public FAgregarUsuario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            LAdministrador administrador = new LAdministrador();
            try
            {
                // Obtener el ID del rol según el Radio Button seleccionado
                int idRolSeleccionado = 0;

                if (rAdministrador.Checked) idRolSeleccionado = 1;
                else if (rSupervisor.Checked) idRolSeleccionado = 2;
                else if (rRecepcionista.Checked) idRolSeleccionado = 3;

                // Llamar al método en la capa lógica pasando los valores
                administrador.agegarUsuario(txtNomUsuario.Text.Trim(), idRolSeleccionado);

                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                // Captura el 'throw' lanzado desde la lógica y muestra el mensaje al usuario
                MessageBox.Show(ex.Message, "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bLimpiar_Click(object sender, EventArgs e)
        {
            txtNomUsuario.Clear();


            rAdministrador.Checked = false;
            rRecepcionista.Checked = false;
            rSupervisor.Checked = false;

            txtNomUsuario.Focus();
        }

        private void FAgregarUsuario_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
