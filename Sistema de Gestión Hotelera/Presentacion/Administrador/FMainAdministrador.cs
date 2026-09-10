using System;
using System.Drawing;
using System.Windows.Forms;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;

namespace Presentacion.Administrador
{
    public partial class FMainAdministrador : Form
    {
        // En LiveCharts2 el control para barras/columnas es CartesianChart
        private CartesianChart chartHabitaciones;

        public FMainAdministrador()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

        }



        private void label1_Click(object sender, EventArgs e)
        {
            // Evento vacio
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Evento vacio
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}