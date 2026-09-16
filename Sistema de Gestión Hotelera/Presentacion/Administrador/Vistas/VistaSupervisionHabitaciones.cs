using Entidades;
using Logica;
using Presentacion.Administrador.UI;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion.Administrador.Vistas
{
    internal class VistaSupervisionHabitaciones : UserControl, IVistaAdministrador
    {
        private readonly Usuario _usuario;
        private readonly GestionHabitaciones _gestionHabitaciones = new();
        private readonly GestionConfiguracion _gestionConfiguracion = new();
        private readonly FlowLayoutPanel _panelHabitaciones;

        public VistaSupervisionHabitaciones(Usuario usuario)
        {
            _usuario = usuario;
            Dock = DockStyle.Fill;
            BackColor = Paleta.FondoApp;
            AutoScroll = true;

            var lblTitulo = new Label { Text = "Todas las habitaciones", Font = Paleta.FuenteSeccion, ForeColor = Paleta.TextoPrimario, AutoSize = true, Location = new Point(0, 0) };

            _panelHabitaciones = new FlowLayoutPanel
            {
                Location = new Point(0, 36),
                Size = new Size(1400, 900),
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                AutoSize = true
            };

            Controls.Add(lblTitulo);
            Controls.Add(_panelHabitaciones);
        }

        public void Refrescar()
        {
            int minutosTolerancia = _gestionConfiguracion.Obtener().MinutosTolerancia;
            var habitaciones = _gestionHabitaciones.ObtenerResumenHabitaciones().OrderBy(h => h.NroHabitacion).ToList();

            _panelHabitaciones.Controls.Clear();
            foreach (HabitacionResumen resumen in habitaciones)
            {
                var tarjeta = new TarjetaHabitacionAdmin { Margin = new Padding(0, 0, 16, 16) };
                tarjeta.ConfigurarDesdeResumen(resumen, minutosTolerancia, mostrarAccionLimpieza: true);
                tarjeta.AccionClick += (s, e) => MarcarComoLimpia(resumen.NroHabitacion);
                _panelHabitaciones.Controls.Add(tarjeta);
            }
        }

        private void MarcarComoLimpia(int nroHabitacion)
        {
            DialogResult confirmacion = MessageBox.Show(
                $"¿Confirma que la habitación {nroHabitacion} fue limpiada y está lista para volver a Disponible?",
                "Confirmar limpieza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                _gestionHabitaciones.MarcarComoDisponible(nroHabitacion, _usuario.IdUsuario);
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
