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
    public partial class FCrearReserva : Form
    {
        public FCrearReserva()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposObligatorios(out string mensaje, out Control controlInvalido))
            {
                MessageBox.Show(mensaje, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controlInvalido.Focus();
                return;
            }

            MessageBox.Show("Reserva registrada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private bool ValidarCamposObligatorios(out string mensaje, out Control controlInvalido)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                mensaje = "Ingrese el nombre del huésped.";
                controlInvalido = txtNombre;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                mensaje = "Ingrese el apellido del huésped.";
                controlInvalido = txtApellido;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                mensaje = "Ingrese el documento o pasaporte del huésped.";
                controlInvalido = txtDocumento;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                mensaje = "Ingrese el teléfono del huésped.";
                controlInvalido = txtTelefono;
                return false;
            }

            mensaje = string.Empty;
            controlInvalido = null;
            return true;
        }
    }
}
