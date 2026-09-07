namespace Presentacion.Administrador
{
    partial class FReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvReporteDetalle = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            lblTotalIngresosValor = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            lblOcupacionValor = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblRevParValor = new System.Windows.Forms.Label();
            cmbTipoReporte = new System.Windows.Forms.ComboBox();
            dtpDesde = new System.Windows.Forms.DateTimePicker();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            dtpHasta = new System.Windows.Forms.DateTimePicker();
            btnGeneraar = new System.Windows.Forms.Button();
            btnExportarPDF = new System.Windows.Forms.Button();
            btnExportarExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporteDetalle).BeginInit();
            SuspendLayout();
            // 
            // dgvReporteDetalle
            // 
            dgvReporteDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporteDetalle.Location = new System.Drawing.Point(12, 390);
            dgvReporteDetalle.Name = "dgvReporteDetalle";
            dgvReporteDetalle.RowHeadersWidth = 51;
            dgvReporteDetalle.Size = new System.Drawing.Size(1320, 424);
            dgvReporteDetalle.TabIndex = 0;
            dgvReporteDetalle.CellContentClick += dgvReporteDetalle_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            label1.Location = new System.Drawing.Point(663, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(189, 102);
            label1.TabIndex = 1;
            label1.Text = "REPORTES";
            label1.Click += label1_Click;
            // 
            // lblTotalIngresosValor
            // 
            lblTotalIngresosValor.AutoSize = true;
            lblTotalIngresosValor.Font = new System.Drawing.Font("Sans Serif Collection", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblTotalIngresosValor.Location = new System.Drawing.Point(219, 104);
            lblTotalIngresosValor.Name = "lblTotalIngresosValor";
            lblTotalIngresosValor.Size = new System.Drawing.Size(51, 68);
            lblTotalIngresosValor.TabIndex = 2;
            lblTotalIngresosValor.Text = "$0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sans Serif Collection", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(13, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(191, 68);
            label2.TabIndex = 3;
            label2.Text = "Total de ingresos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sans Serif Collection", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(381, 104);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(376, 68);
            label3.TabIndex = 4;
            label3.Text = "Porcentaje de habitaciones ocupadas: ";
            // 
            // lblOcupacionValor
            // 
            lblOcupacionValor.AutoSize = true;
            lblOcupacionValor.Font = new System.Drawing.Font("Sans Serif Collection", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblOcupacionValor.Location = new System.Drawing.Point(763, 104);
            lblOcupacionValor.Name = "lblOcupacionValor";
            lblOcupacionValor.Size = new System.Drawing.Size(57, 68);
            lblOcupacionValor.TabIndex = 5;
            lblOcupacionValor.Text = "0%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Sans Serif Collection", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(10, 160);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(392, 68);
            label4.TabIndex = 6;
            label4.Text = "Rendimiento por Habitación Disponible:";
            // 
            // lblRevParValor
            // 
            lblRevParValor.AutoSize = true;
            lblRevParValor.Font = new System.Drawing.Font("Sans Serif Collection", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblRevParValor.Location = new System.Drawing.Point(408, 160);
            lblRevParValor.Name = "lblRevParValor";
            lblRevParValor.Size = new System.Drawing.Size(51, 68);
            lblRevParValor.TabIndex = 7;
            lblRevParValor.Text = "$0";
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTipoReporte.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new System.Drawing.Point(15, 234);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new System.Drawing.Size(336, 59);
            cmbTipoReporte.TabIndex = 8;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new System.Drawing.Point(494, 246);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new System.Drawing.Size(303, 27);
            dtpDesde.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Sans Serif Collection", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(357, 234);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(93, 68);
            label5.TabIndex = 10;
            label5.Text = "Desde:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Sans Serif Collection", 11.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(824, 234);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(88, 68);
            label6.TabIndex = 11;
            label6.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new System.Drawing.Point(971, 246);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new System.Drawing.Size(294, 27);
            dtpHasta.TabIndex = 12;
            // 
            // btnGeneraar
            // 
            btnGeneraar.BackColor = System.Drawing.Color.FromArgb(13, 202, 240);
            btnGeneraar.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnGeneraar.Location = new System.Drawing.Point(242, 304);
            btnGeneraar.Name = "btnGeneraar";
            btnGeneraar.Size = new System.Drawing.Size(171, 55);
            btnGeneraar.TabIndex = 13;
            btnGeneraar.Text = "Generar Reporte";
            btnGeneraar.UseVisualStyleBackColor = false;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            btnExportarPDF.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExportarPDF.Location = new System.Drawing.Point(626, 304);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new System.Drawing.Size(171, 55);
            btnExportarPDF.TabIndex = 14;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = false;
            // 
            // btnExportarExcel
            // 
            btnExportarExcel.BackColor = System.Drawing.Color.FromArgb(25, 135, 84);
            btnExportarExcel.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnExportarExcel.Location = new System.Drawing.Point(1023, 304);
            btnExportarExcel.Name = "btnExportarExcel";
            btnExportarExcel.Size = new System.Drawing.Size(171, 55);
            btnExportarExcel.TabIndex = 15;
            btnExportarExcel.Text = "Exportar Excel";
            btnExportarExcel.UseVisualStyleBackColor = false;
            // 
            // FReportes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1409, 761);
            Controls.Add(btnExportarExcel);
            Controls.Add(btnExportarPDF);
            Controls.Add(btnGeneraar);
            Controls.Add(dtpHasta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpDesde);
            Controls.Add(cmbTipoReporte);
            Controls.Add(lblRevParValor);
            Controls.Add(label4);
            Controls.Add(lblOcupacionValor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblTotalIngresosValor);
            Controls.Add(label1);
            Controls.Add(dgvReporteDetalle);
            Name = "FReportes";
            Text = "FReportes";
            Load += FReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporteDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReporteDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalIngresosValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOcupacionValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRevParValor;
        private System.Windows.Forms.ComboBox cmbTipoReporte;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnGeneraar;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Button btnExportarExcel;
    }
}