namespace Presentacion.Administrador
{
    partial class FMainAdministrador
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
            panel1 = new System.Windows.Forms.Panel();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            LPLibres = new System.Windows.Forms.Label();
            LPOcupadas = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(39, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(226, 102);
            label1.TabIndex = 0;
            label1.Text = "Habitaciones";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(LPLibres);
            panel1.Controls.Add(LPOcupadas);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1229, 751);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.FromArgb(255, 193, 7);
            label9.Location = new System.Drawing.Point(99, 510);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(65, 78);
            label9.TabIndex = 14;
            label9.Text = "5%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(39, 432);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(309, 78);
            label8.TabIndex = 13;
            label8.Text = "Habitaciones en Limpieza:";
            // 
            // LPLibres
            // 
            LPLibres.AutoSize = true;
            LPLibres.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            LPLibres.ForeColor = System.Drawing.Color.FromArgb(25, 135, 84);
            LPLibres.Location = new System.Drawing.Point(99, 322);
            LPLibres.Name = "LPLibres";
            LPLibres.Size = new System.Drawing.Size(78, 78);
            LPLibres.TabIndex = 12;
            LPLibres.Text = "15%";
            // 
            // LPOcupadas
            // 
            LPOcupadas.AutoSize = true;
            LPOcupadas.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            LPOcupadas.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69);
            LPOcupadas.Location = new System.Drawing.Point(99, 175);
            LPOcupadas.Name = "LPOcupadas";
            LPOcupadas.Size = new System.Drawing.Size(78, 78);
            LPOcupadas.TabIndex = 11;
            LPOcupadas.Text = "80%";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(497, 385);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(112, 78);
            label7.TabIndex = 10;
            label7.Text = "Tarjeta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(497, 244);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(185, 78);
            label6.TabIndex = 9;
            label6.Text = "Transferencia:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(497, 117);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(124, 78);
            label5.TabIndex = 8;
            label5.Text = "Efectivo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(497, 33);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(223, 102);
            label3.TabIndex = 7;
            label3.Text = "Recaudacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(39, 244);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(247, 78);
            label2.TabIndex = 6;
            label2.Text = "Habitaciones Libres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Sans Serif Collection", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(39, 117);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(290, 78);
            label4.TabIndex = 5;
            label4.Text = "Habitaciones Ocupadas:";
            // 
            // FMainAdministrador
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1229, 751);
            Controls.Add(panel1);
            Name = "FMainAdministrador";
            Text = "FMainAdministrador";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LPLibres;
        private System.Windows.Forms.Label LPOcupadas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}