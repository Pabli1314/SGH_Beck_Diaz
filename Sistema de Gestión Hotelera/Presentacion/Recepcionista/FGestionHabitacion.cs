using System;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion.Recepcionista
{
    /// <summary>
    /// Pantalla de gestión de una habitación puntual. Todas las transiciones de estado
    /// (Check-In, Check-Out, Limpieza→Disponible, Mantenimiento) están conectadas a la base
    /// de datos real; <see cref="_habitacion"/> se actualiza en memoria solo después de que
    /// la operación contra la base tuvo éxito, para que la tarjeta del tablero (FReservas)
    /// nunca muestre algo distinto de lo que quedó persistido.
    /// </summary>
    public partial class FGestionHabitacion : Form
    {
        private readonly HabitacionInfo _habitacion;
        private readonly Usuario? _usuario;
        private readonly GestionHabitaciones _gestionHabitaciones = new GestionHabitaciones();
        private readonly GestionHospedajes _gestionHospedajes = new GestionHospedajes();

        public FGestionHabitacion(HabitacionInfo habitacion) : this(habitacion, null)
        {
        }

        public FGestionHabitacion(HabitacionInfo habitacion, Usuario? usuario)
        {
            InitializeComponent();
            _habitacion = habitacion ?? throw new ArgumentNullException(nameof(habitacion));
            _usuario = usuario;
        }

        private void FGestionHabitacion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            Text = $"Gestión de Habitación {_habitacion.NroHabitacion}";
            lblNumero.Text = _habitacion.NroHabitacion;
            lblTipo.Text = _habitacion.Tipo;
            badgeEstado.FijarEstado(DibujoUtil.TextoPorEstado(_habitacion.Estado), DibujoUtil.ColorPorEstado(_habitacion.Estado));

            bool esOcupada = _habitacion.Estado == EstadoOcupacion.Ocupada;
            bool esDisponible = _habitacion.Estado == EstadoOcupacion.Disponible;

            lblHuespedTitulo.Visible = esOcupada;
            lblHuespedValor.Visible = esOcupada;
            lblIngresoTitulo.Visible = esOcupada;
            lblIngresoValor.Visible = esOcupada;
            lblTemporizador.Visible = esOcupada;

            lblNombreHuesped.Visible = false;
            txtNombreHuesped.Visible = false;

            lblMensaje.Visible = !esOcupada;
            btnAccionSecundaria.Visible = esDisponible;

            if (esOcupada)
            {
                lblHuespedValor.Text = _habitacion.Huesped;

                if (_habitacion.HoraIngreso.HasValue)
                {
                    lblIngresoValor.Text = _habitacion.HoraIngreso.Value.ToString("dd/MM/yyyy HH:mm");
                    lblTemporizador.Text = (DateTime.Now - _habitacion.HoraIngreso.Value).ToString(@"hh\:mm\:ss");
                }
            }
            else if (esDisponible)
            {
                lblMensaje.Text = "Esta habitación está disponible.";
            }
            else if (_habitacion.Estado == EstadoOcupacion.Limpieza)
            {
                lblMensaje.Text = "Habitación en limpieza.";
            }
            else if (_habitacion.Estado == EstadoOcupacion.Mantenimiento)
            {
                lblMensaje.Text = "Habitación en mantenimiento.";
            }

            btnAccionPrincipal.Text = _habitacion.Estado switch
            {
                EstadoOcupacion.Disponible => "Registrar Check-In",
                EstadoOcupacion.Ocupada => "Registrar Check-Out",
                EstadoOcupacion.Limpieza => "Marcar como Disponible",
                EstadoOcupacion.Mantenimiento => "Finalizar Mantenimiento",
                _ => "Confirmar"
            };
        }

        private void btnAccionPrincipal_Click(object sender, EventArgs e)
        {
            switch (_habitacion.Estado)
            {
                case EstadoOcupacion.Disponible:
                    RegistrarCheckIn();
                    break;

                case EstadoOcupacion.Ocupada:
                    RegistrarCheckOut();
                    break;

                case EstadoOcupacion.Limpieza:
                    MarcarComoDisponibleDesdeLimpieza();
                    break;

                case EstadoOcupacion.Mantenimiento:
                    FinalizarMantenimiento();
                    break;
            }
        }

        private void btnAccionSecundaria_Click(object sender, EventArgs e)
        {
            EnviarAMantenimiento();
        }

        private bool ValidarUsuarioYNumero(out int nroHabitacion)
        {
            nroHabitacion = 0;

            if (_usuario == null)
            {
                MessageBox.Show("No se pudo identificar al usuario de la sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(_habitacion.NroHabitacion, out nroHabitacion))
            {
                MessageBox.Show($"El número de habitación \"{_habitacion.NroHabitacion}\" no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void RegistrarCheckIn()
        {
            if (!ValidarUsuarioYNumero(out _))
            {
                return;
            }

            using var fCheckIn = new FCheckIn(_habitacion.NroHabitacion, _usuario!.IdUsuario);
            if (fCheckIn.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            _habitacion.Huesped = fCheckIn.NombreCompleto;
            _habitacion.HoraIngreso = fCheckIn.HoraIngreso;
            _habitacion.Estado = EstadoOcupacion.Ocupada;

            CerrarConCambios();
        }

        private void RegistrarCheckOut()
        {
            if (!ValidarUsuarioYNumero(out int nroHabitacion))
            {
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Confirma el check-out de la habitación {_habitacion.NroHabitacion}?",
                "Confirmar check-out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _gestionHospedajes.RegistrarCheckOut(nroHabitacion);

                _habitacion.Huesped = null;
                _habitacion.HoraIngreso = null;
                _habitacion.Estado = EstadoOcupacion.Limpieza;

                CerrarConCambios();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo registrar el check-out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar el check-out.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MarcarComoDisponibleDesdeLimpieza()
        {
            if (!ValidarUsuarioYNumero(out int nroHabitacion))
            {
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Confirma que la habitación {_habitacion.NroHabitacion} fue limpiada y está lista para volver a Disponible?",
                "Confirmar limpieza",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _gestionHabitaciones.MarcarComoDisponible(nroHabitacion, _usuario!.IdUsuario);
                _habitacion.Estado = EstadoOcupacion.Disponible;
                CerrarConCambios();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar la habitación.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviarAMantenimiento()
        {
            if (!ValidarUsuarioYNumero(out int nroHabitacion))
            {
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Confirma enviar la habitación {_habitacion.NroHabitacion} a Mantenimiento?",
                "Confirmar mantenimiento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _gestionHabitaciones.EnviarAMantenimiento(nroHabitacion);
                _habitacion.Estado = EstadoOcupacion.Mantenimiento;
                CerrarConCambios();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar la habitación.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FinalizarMantenimiento()
        {
            if (!ValidarUsuarioYNumero(out int nroHabitacion))
            {
                return;
            }

            try
            {
                _gestionHabitaciones.FinalizarMantenimiento(nroHabitacion);
                _habitacion.Estado = EstadoOcupacion.Disponible;
                CerrarConCambios();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar la habitación.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CerrarConCambios()
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
