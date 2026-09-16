using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;

namespace Presentacion.Recepcionista
{
    public partial class FReservas : Form
    {
        private readonly Usuario? _usuario;
        private readonly GestionHabitaciones _gestionHabitaciones = new GestionHabitaciones();
        private List<HabitacionInfo> _habitaciones;

        public FReservas() : this(null)
        {
        }

        public FReservas(Usuario? usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }



        private void FReservas_Load(object sender, EventArgs e)
        {
            CargarHabitacionesDesdeBaseDeDatos();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        /// <summary>Trae las habitaciones reales (número, tipo y estado) desde la base de datos.</summary>
        private void CargarHabitacionesDesdeBaseDeDatos()
        {
            try
            {
                List<Habitacion> habitaciones = _gestionHabitaciones.ObtenerHabitaciones();
                Dictionary<int, string> tipos = _gestionHabitaciones.ObtenerTiposHabitacion()
                    .ToDictionary(t => t.IdTipoHabitacion, t => t.Descripcion);
                Dictionary<int, string> estados = _gestionHabitaciones.ObtenerEstados()
                    .ToDictionary(e => e.IdEstado, e => e.NomEstadoHabitacion);

                _habitaciones = habitaciones
                    .Select(h => new HabitacionInfo
                    {
                        NroHabitacion = h.NroHabitacion.ToString(),
                        Tipo = tipos.TryGetValue(h.IdTipoHabitacion, out string? tipo) ? tipo : "Sin tipo",
                        Estado = DibujoUtil.EstadoDesdeTexto(estados.TryGetValue(h.IdEstado, out string? nomEstado) ? nomEstado : string.Empty)
                    })
                    .OrderBy(h => h.NroHabitacion)
                    .ToList();
            }
            catch (Exception ex)
            {
                _habitaciones = new List<HabitacionInfo>();
                MessageBox.Show($"No se pudieron cargar las habitaciones desde la base de datos.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefrescarTablero();
        }

        private void RefrescarTablero()
        {
            CargarResumen(_habitaciones);
            CargarHabitaciones(_habitaciones);
        }

        /// <summary>
        /// pnlColumnaCentral ocupa todo el espacio disponible (Dock = Fill); al redimensionar
        /// hay que volver a acomodar la grilla de habitaciones porque las filas se arman con
        /// un ancho fijo calculado en base al ancho disponible en ese momento.
        /// </summary>
        private void FReservas_Resize(object sender, EventArgs e)
        {
            if (_habitaciones != null) CargarHabitaciones(_habitaciones);
        }

        // ---------- Paso 4: Indicadores superiores (tarjetas de resumen) ----------

        private void CargarResumen(List<HabitacionInfo> habitaciones)
        {
            pnlResumen.Controls.Clear();

            int disponibles = habitaciones.Count(h => h.Estado == EstadoOcupacion.Disponible);
            int ocupadas = habitaciones.Count(h => h.Estado == EstadoOcupacion.Ocupada);
            int limpieza = habitaciones.Count(h => h.Estado == EstadoOcupacion.Limpieza);
            int mantenimiento = habitaciones.Count(h => h.Estado == EstadoOcupacion.Mantenimiento);

            pnlResumen.Controls.Add(CrearTarjetaResumen("Disponibles", disponibles, DibujoUtil.ColorPorEstado(EstadoOcupacion.Disponible)));
            pnlResumen.Controls.Add(CrearTarjetaResumen("Ocupadas", ocupadas, DibujoUtil.ColorPorEstado(EstadoOcupacion.Ocupada)));
            pnlResumen.Controls.Add(CrearTarjetaResumen("Limpieza", limpieza, DibujoUtil.ColorPorEstado(EstadoOcupacion.Limpieza)));
            pnlResumen.Controls.Add(CrearTarjetaResumen("Mantenimiento", mantenimiento, DibujoUtil.ColorPorEstado(EstadoOcupacion.Mantenimiento)));
        }

        /// <summary>Renderiza una tarjeta de resumen: punto de color + título + número total.</summary>
        private Panel CrearTarjetaResumen(string titulo, int cantidad, Color colorEstado)
        {
            var tarjeta = new Panel
            {
                Size = new Size(230, 150),
                BackColor = Color.White,
                Margin = new Padding(0, 0, 20, 0)
            };

            var indicador = new IndicadorColor
            {
                ColorEstado = colorEstado,
                BackColor = tarjeta.BackColor,
                Location = new Point(18, 20)
            };

            var lblTitulo = new Label
            {
                Text = titulo,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.FromArgb(108, 117, 125),
                AutoSize = true,
                BackColor = Color.Transparent,
                Location = new Point(40, 16)
            };

            var lblCantidad = new Label
            {
                Text = cantidad.ToString(),
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 37, 41),
                AutoSize = true,
                BackColor = Color.Transparent,
                Location = new Point(18, 44)
            };

            tarjeta.Controls.Add(indicador);
            tarjeta.Controls.Add(lblTitulo);
            tarjeta.Controls.Add(lblCantidad);

            return tarjeta;
        }

        // ---------- Paso 5: Matriz dinámica de habitaciones ----------

        private const int AnchoTarjetaHabitacion = 180;
        private const int AltoTarjetaHabitacion = 130;
        private const int SeparacionTarjetas = 20;

        /// <summary>Cuántas tarjetas entran por fila según el ancho disponible dentro de pnlColumnaCentral (mínimo 1).</summary>
        private int CalcularTarjetasPorFila(int anchoDisponible)
        {
            int porFila = anchoDisponible / (AnchoTarjetaHabitacion + SeparacionTarjetas);
            return Math.Max(1, porFila);
        }

        private void CargarHabitaciones(List<HabitacionInfo> habitaciones)
        {
            List<Panel> filasAnteriores = pnlColumnaCentral.Controls.OfType<Panel>()
                .Where(p => p != pnlResumen)
                .ToList();
            foreach (Panel filaAnterior in filasAnteriores)
            {
                pnlColumnaCentral.Controls.Remove(filaAnterior);
                filaAnterior.Dispose();
            }

            int anchoDisponible = Math.Max(AnchoTarjetaHabitacion,
                pnlColumnaCentral.ClientSize.Width - pnlColumnaCentral.Padding.Horizontal);
            int tarjetasPorFila = CalcularTarjetasPorFila(anchoDisponible);
            int left = pnlColumnaCentral.Padding.Left;
            int top = pnlResumen.Bottom + SeparacionTarjetas;

            for (int inicio = 0; inicio < habitaciones.Count; inicio += tarjetasPorFila)
            {
                List<HabitacionInfo> fila = habitaciones.Skip(inicio).Take(tarjetasPorFila).ToList();
                Panel filaPanel = CrearFilaHabitaciones(fila, anchoDisponible);
                filaPanel.Location = new Point(left, top);
                pnlColumnaCentral.Controls.Add(filaPanel);
                top += filaPanel.Height + SeparacionTarjetas;
            }
        }

        /// <summary>Arma una fila de tarjetas de habitación centrada dentro del ancho disponible (para que la última fila, aunque no esté completa, no quede pegada a la izquierda).</summary>
        private Panel CrearFilaHabitaciones(List<HabitacionInfo> fila, int anchoDisponible)
        {
            var contenedorFila = new Panel
            {
                Size = new Size(anchoDisponible, AltoTarjetaHabitacion)
            };

            int anchoContenido = fila.Count * AnchoTarjetaHabitacion + (fila.Count - 1) * SeparacionTarjetas;
            int x = Math.Max(0, (contenedorFila.Width - anchoContenido) / 2);

            foreach (HabitacionInfo habitacion in fila)
            {
                var tarjeta = new UC_Habitacion { Location = new Point(x, 0) };

                tarjeta.ConfigurarTarjeta(habitacion.NroHabitacion, habitacion.Tipo, habitacion.Estado, habitacion.Huesped, habitacion.HoraIngreso);
                tarjeta.Click += (s, e) => GestionarHabitacion(habitacion);

                contenedorFila.Controls.Add(tarjeta);
                x += AnchoTarjetaHabitacion + SeparacionTarjetas;
            }

            return contenedorFila;
        }

        /// <summary>
        /// Abre la pantalla real de gestión de la habitación. FGestionHabitacion muta el mismo
        /// objeto HabitacionInfo (hoy en memoria); cuando haya persistencia, esa mutación se
        /// reemplaza por una consulta/actualización real y este método sigue funcionando igual.
        /// </summary>
        private void GestionarHabitacion(HabitacionInfo habitacion)
        {
            using (var fGestion = new FGestionHabitacion(habitacion, _usuario))
            {
                fGestion.ShowDialog(this);
            }

            RefrescarTablero();
        }

        private void pnlColumnaCentral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
