using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion.Supervisor
{
    public partial class FSupervisor : Form
    {
        private const string ESTADO_DISPONIBLE = "Disponible";
        private const string ESTADO_OCUPADA = "Ocupada";
        private const string ESTADO_LIMPIEZA = "Limpieza";
        private const string ESTADO_MANTENIMIENTO = "Mantenimiento";

        private readonly Usuario? _usuario;
        private readonly GestionHabitaciones _gestionHabitaciones = new GestionHabitaciones();

        public FSupervisor() : this(null)
        {
        }

        public FSupervisor(Usuario? usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            ConfigurarGrilla();
        }

        private void FSupervisor_Load(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        private void ConfigurarGrilla()
        {
            dgvHabitaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "NroHabitacion", HeaderText = "Habitación", Width = 120 });
            dgvHabitaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "CantCamas", HeaderText = "Camas", Width = 80 });
            dgvHabitaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "TarifaBase", HeaderText = "Tarifa", Width = 120 });
            dgvHabitaciones.Columns.Add(new DataGridViewTextBoxColumn { Name = "NomEstado", HeaderText = "Estado", Width = 160 });
        }

        private void CargarHabitaciones()
        {
            try
            {
                var habitaciones = _gestionHabitaciones.ObtenerHabitaciones();
                var nombresEstado = _gestionHabitaciones.ObtenerEstados()
                    .ToDictionary(e => e.IdEstado, e => e.NomEstadoHabitacion);

                dgvHabitaciones.Rows.Clear();

                foreach (var habitacion in habitaciones.OrderBy(h => h.NroHabitacion))
                {
                    string nomEstado = nombresEstado.TryGetValue(habitacion.IdEstado, out var nombre) ? nombre : "Desconocido";

                    int filaIndex = dgvHabitaciones.Rows.Add(
                        habitacion.NroHabitacion,
                        habitacion.CantCamas,
                        habitacion.TarifaBase.ToString("C"),
                        nomEstado);

                    var fila = dgvHabitaciones.Rows[filaIndex];
                    fila.Tag = habitacion;
                    fila.DefaultCellStyle.BackColor = ColorPorEstado(nomEstado);
                }

                btnMarcarDisponible.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudieron cargar las habitaciones.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Color ColorPorEstado(string nomEstado)
        {
            return nomEstado switch
            {
                ESTADO_DISPONIBLE => Color.LightGreen,
                ESTADO_OCUPADA => Color.LightCoral,
                ESTADO_LIMPIEZA => Color.Khaki,
                ESTADO_MANTENIMIENTO => Color.LightSkyBlue,
                _ => Color.White
            };
        }

        private void dgvHabitaciones_SelectionChanged(object sender, EventArgs e)
        {
            btnMarcarDisponible.Enabled = HabitacionSeleccionadaEnLimpieza();
        }

        private bool HabitacionSeleccionadaEnLimpieza()
        {
            if (dgvHabitaciones.SelectedRows.Count == 0)
            {
                return false;
            }

            string? nomEstado = dgvHabitaciones.SelectedRows[0].Cells["NomEstado"].Value?.ToString();
            return string.Equals(nomEstado, ESTADO_LIMPIEZA, StringComparison.OrdinalIgnoreCase);
        }

        private void btnMarcarDisponible_Click(object sender, EventArgs e)
        {
            if (dgvHabitaciones.SelectedRows.Count == 0 || dgvHabitaciones.SelectedRows[0].Tag is not Habitacion habitacion)
            {
                return;
            }

            if (_usuario == null)
            {
                MessageBox.Show("No se pudo identificar al usuario de la sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Confirma que la habitación {habitacion.NroHabitacion} fue limpiada y está lista para volver a Disponible?",
                "Confirmar limpieza",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _gestionHabitaciones.MarcarComoDisponible(habitacion.NroHabitacion, _usuario.IdUsuario);
                MessageBox.Show($"Habitación {habitacion.NroHabitacion} marcada como Disponible.", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHabitaciones();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarHabitaciones();
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
