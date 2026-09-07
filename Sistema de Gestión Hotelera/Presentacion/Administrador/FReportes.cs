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
    public partial class FReportes : Form
    {
        public FReportes()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.ConfigurarEstiloFormulario();
        }

        private void ConfigurarEstiloFormulario()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = "Reportes y Analítica Operativa";
        }

        private void FReportes_Load(object sender, EventArgs e)
        {
            // 1. Cargar filtros estáticos
            CargarFiltrosEstaticos();

            // 2. Cargar tarjetas KPI estáticas
            CargarTarjetasKPI();

            // 3. Configurar y cargar grilla con datos de muestra
            ConfigurarGrillaDetalle();
            CargarDatosEstaticosGrilla();
        }

        private void CargarFiltrosEstaticos()
        {
            dtpDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpHasta.Value = DateTime.Now;

            cmbTipoReporte.Items.Clear();
            cmbTipoReporte.Items.Add("Ingresos por Medio de Pago");
            cmbTipoReporte.Items.Add("Ocupación y Rendimiento por Categoría");
            cmbTipoReporte.Items.Add("Historial de Arqueos y Cierres de Caja");
            cmbTipoReporte.SelectedIndex = 0;
        }

        private void CargarTarjetasKPI()
        {
            lblTotalIngresosValor.Text = "$ 1.450.000,00";
            lblOcupacionValor.Text = "78.5 %";
            // 'lblRevParValor' es donde asignas dinámicamente o estáticamente la cifra
            lblRevParValor.Text = "$ 18.500,00";
        }

        private void ConfigurarGrillaDetalle()
        {
            dgvReporteDetalle.AutoGenerateColumns = false;
            dgvReporteDetalle.Columns.Clear();

            dgvReporteDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Fecha",
                HeaderText = "Fecha / Período",
                Width = 120
            });

            dgvReporteDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Concepto",
                HeaderText = "Concepto / Servicio",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvReporteDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MedioPago",
                HeaderText = "Medio de Pago",
                Width = 150
            });

            dgvReporteDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Monto",
                HeaderText = "Monto Total",
                Width = 130,
                DefaultCellStyle = { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvReporteDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Estado",
                HeaderText = "Estado Caja",
                Width = 110
            });
        }

        private void CargarDatosEstaticosGrilla()
        {
            // Datos simulados para la entrega visual
            var listaEstatica = new List<object>
            {
                new { Fecha = "01/09/2026", Concepto = "Hospedaje (2 Noches) - Hab. 102", MedioPago = "Efectivo", Monto = "$ 90.000,00", Estado = "Cerrado" },
                new { Fecha = "01/09/2026", Concepto = "Hospedaje (1 Noche) - Hab. 205", MedioPago = "Transferencia", Monto = "$ 32.000,00", Estado = "Cerrado" },
                new { Fecha = "02/09/2026", Concepto = "Hospedaje (3 Noches) - Hab. 301", MedioPago = "Tarjeta Débito", Monto = "$ 66.000,00", Estado = "Cerrado" },
                new { Fecha = "04/09/2026", Concepto = "Hospedaje (1 Noche) - Hab. 104", MedioPago = "Tarjeta Crédito", Monto = "$ 38.000,00", Estado = "Abierto" }
            };

            dgvReporteDetalle.Rows.Clear();
            foreach (dynamic item in listaEstatica)
            {
                dgvReporteDetalle.Rows.Add(item.Fecha, item.Concepto, item.MedioPago, item.Monto, item.Estado);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Simulación de interacción visual
            MessageBox.Show("Reporte actualizado estáticamente para el rango seleccionado.", "Modo Presentación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de exportación PDF (Vista previa lista para la siguiente entrega).", "Exportar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de exportación Excel (Vista previa lista para la siguiente entrega).", "Exportar Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dgvReporteDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
