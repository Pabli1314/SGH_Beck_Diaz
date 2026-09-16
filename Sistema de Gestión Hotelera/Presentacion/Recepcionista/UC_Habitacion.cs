using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Presentacion.Recepcionista
{
    public partial class UC_Habitacion : UserControl
    {
        private const int Radio = 14;

        private DateTime? _horaIngreso;

        public string NumeroHabitacion { get; private set; }
        public EstadoOcupacion Estado { get; private set; }

        public UC_Habitacion()
        {
            InitializeComponent();

            MinimumSize = MaximumSize = Size;
            Cursor = Cursors.Hand;
            badgeEstado.BackColor = BackColor;

            Region = new Region(DibujoUtil.RutaRedondeada(new RectangleF(0, 0, Width, Height), Radio));

            PropagarClick(this);
        }

        /// <summary>Configura el contenido y el estado visual de la tarjeta de habitación.</summary>
        public void ConfigurarTarjeta(string numero, string tipo, EstadoOcupacion estado, string huesped = null, DateTime? horaIngreso = null)
        {
            NumeroHabitacion = numero;
            Estado = estado;
            _horaIngreso = horaIngreso;

            lblNumero.Text = numero;
            lblTipo.Text = tipo;

            Color colorEstado = DibujoUtil.ColorPorEstado(estado);
            badgeEstado.FijarEstado(DibujoUtil.TextoPorEstado(estado), colorEstado);
            badgeEstado.Location = new Point(Width - badgeEstado.Width - 10, 10);

            bool esOcupada = estado == EstadoOcupacion.Ocupada;

            lblHuesped.Text = huesped ?? string.Empty;
            lblHuesped.Visible = esOcupada && !string.IsNullOrWhiteSpace(huesped);

            lblTemporizador.ForeColor = colorEstado;
            lblTemporizador.Visible = esOcupada && horaIngreso.HasValue;

            if (esOcupada && horaIngreso.HasValue)
            {
                ActualizarTemporizador();
                temporizador.Start();
            }
            else
            {
                temporizador.Stop();
                lblTemporizador.Text = "00:00:00";
            }
        }

        private void temporizador_Tick(object sender, EventArgs e) => ActualizarTemporizador();

        private void ActualizarTemporizador()
        {
            if (!_horaIngreso.HasValue) return;

            TimeSpan transcurrido = DateTime.Now - _horaIngreso.Value;
            lblTemporizador.Text = transcurrido.ToString(@"hh\:mm\:ss");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var ruta = DibujoUtil.RutaRedondeada(new RectangleF(0.5F, 0.5F, Width - 1, Height - 1), Radio - 1);
            using var lapiz = new Pen(Color.FromArgb(33, 37, 41));
            e.Graphics.DrawPath(lapiz, ruta);
        }

        /// <summary>Permite hacer click en cualquier parte de la tarjeta, no solo en el fondo.</summary>
        private void PropagarClick(Control contenedor)
        {
            foreach (Control hijo in contenedor.Controls)
            {
                hijo.Cursor = Cursors.Hand;
                hijo.Click += (s, e) => OnClick(EventArgs.Empty);

                if (hijo.HasChildren) PropagarClick(hijo);
            }
        }
    }
}
