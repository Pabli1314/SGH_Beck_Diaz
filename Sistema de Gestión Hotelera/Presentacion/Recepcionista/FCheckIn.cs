using System;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion.Recepcionista
{
    /// <summary>Alta real de un hospedaje (huésped + hospedaje + pase de la habitación a Ocupada).</summary>
    public partial class FCheckIn : Form
    {
        private readonly int _nroHabitacion;
        private readonly int _idUsuario;
        private readonly GestionHospedajes _gestionHospedajes = new GestionHospedajes();

        public string NombreCompleto { get; private set; }
        public DateTime HoraIngreso { get; private set; }

        public FCheckIn(string nroHabitacion, int idUsuario)
        {
            InitializeComponent();
            _nroHabitacion = int.Parse(nroHabitacion);
            _idUsuario = idUsuario;
            lblTitulo.Text = $"Check-In — {nroHabitacion}";
        }

        private void FCheckIn_Load(object sender, EventArgs e)
        {
            cmbMetodoPago.DisplayMember = nameof(MetodoPago.NomMetodoPago);
            cmbMetodoPago.ValueMember = nameof(MetodoPago.IdMetodo);
            cmbMetodoPago.DataSource = _gestionHospedajes.ObtenerMetodosPago();

            dtpFechaSalida.MinDate = DateTime.Today;
            dtpFechaSalida.Value = DateTime.Today.AddDays(1);
            dtpHoraSalida.Value = DateTime.Today.AddHours(12);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out string mensaje, out Control controlInvalido))
            {
                MessageBox.Show(mensaje, "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controlInvalido.Focus();
                return;
            }

            var huesped = new Huesped
            {
                DniHuesped = txtDni.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Direccion = txtDireccion.Text.Trim()
            };

            int idMetodo = (int)cmbMetodoPago.SelectedValue;

            try
            {
                _gestionHospedajes.RegistrarCheckIn(_nroHabitacion, _idUsuario, huesped, idMetodo, dtpFechaSalida.Value, dtpHoraSalida.Value.TimeOfDay);

                NombreCompleto = $"{huesped.Nombre} {huesped.Apellido}";
                HoraIngreso = DateTime.Now;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo registrar el check-in", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar el check-in.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos(out string mensaje, out Control controlInvalido)
        {
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                mensaje = "Ingrese el DNI del huésped.";
                controlInvalido = txtDni;
                return false;
            }

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

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                mensaje = "Ingrese el teléfono del huésped.";
                controlInvalido = txtTelefono;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                mensaje = "Ingrese la dirección del huésped.";
                controlInvalido = txtDireccion;
                return false;
            }

            if (cmbMetodoPago.SelectedValue == null)
            {
                mensaje = "Seleccione el método de pago.";
                controlInvalido = cmbMetodoPago;
                return false;
            }

            mensaje = string.Empty;
            controlInvalido = null;
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
