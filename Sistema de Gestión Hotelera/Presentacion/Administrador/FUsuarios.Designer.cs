namespace Presentacion.Administrador
{
    partial class FUsuarios
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
            label1 = new System.Windows.Forms.Label();
            bAgregarUsuario = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            combRol = new System.Windows.Forms.ComboBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            txtBuscar = new System.Windows.Forms.TextBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            dgUusario = new System.Windows.Forms.DataGridView();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgUusario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sans Serif Collection", 16.1999989F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(505, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(332, 91);
            label1.TabIndex = 0;
            label1.Text = "GESTIÓN DE USUARIOS";
            label1.Click += label1_Click;
            // 
            // bAgregarUsuario
            // 
            bAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(13, 202, 240);
            bAgregarUsuario.Location = new System.Drawing.Point(936, 193);
            bAgregarUsuario.Name = "bAgregarUsuario";
            bAgregarUsuario.Size = new System.Drawing.Size(218, 70);
            bAgregarUsuario.TabIndex = 2;
            bAgregarUsuario.Text = "Agregar nuevo usuario";
            bAgregarUsuario.UseVisualStyleBackColor = false;
            bAgregarUsuario.Click += bAgregarUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(12, 193);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(142, 78);
            label2.TabIndex = 3;
            label2.Text = "Filtrar por:";
            // 
            // combRol
            // 
            combRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            combRol.Font = new System.Drawing.Font("Sans Serif Collection", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            combRol.FormattingEnabled = true;
            combRol.Items.AddRange(new object[] { "Administrador", "Supervisor", "Recepcionista" });
            combRol.Location = new System.Drawing.Point(176, 193);
            combRol.Name = "combRol";
            combRol.Size = new System.Drawing.Size(200, 70);
            combRol.TabIndex = 4;
            combRol.SelectedIndexChanged += combRol_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new System.Drawing.Font("Sans Serif Collection", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            comboBox1.Items.AddRange(new object[] { "Activo", "No activo" });
            comboBox1.Location = new System.Drawing.Point(438, 193);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(200, 70);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Estado";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new System.Drawing.Font("Sans Serif Collection", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtBuscar.Location = new System.Drawing.Point(697, 193);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(188, 70);
            txtBuscar.TabIndex = 6;
            txtBuscar.Text = "Buscar";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dgUusario);
            flowLayoutPanel1.Location = new System.Drawing.Point(1, 274);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1324, 501);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // dgUusario
            // 
            dgUusario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUusario.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgUusario.Location = new System.Drawing.Point(3, 3);
            dgUusario.Name = "dgUusario";
            dgUusario.RowHeadersWidth = 51;
            dgUusario.Size = new System.Drawing.Size(1313, 506);
            dgUusario.TabIndex = 3;
            // 
            // FUsuarios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1337, 787);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(txtBuscar);
            Controls.Add(comboBox1);
            Controls.Add(combRol);
            Controls.Add(label2);
            Controls.Add(bAgregarUsuario);
            Controls.Add(label1);
            Name = "FUsuarios";
            Text = "FUsuarios";
            Load += FUsuarios_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgUusario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAgregarUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combRol;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dgUusario;
    }
}