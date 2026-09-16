namespace Presentacion
{
    partial class FRecepcionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRecepcionista));
            PMenu = new System.Windows.Forms.Panel();
            pDisponible = new System.Windows.Forms.Panel();
            lDisponible = new System.Windows.Forms.Label();
            pOcupada = new System.Windows.Forms.Panel();
            lOcupada = new System.Windows.Forms.Label();
            pLimpieza = new System.Windows.Forms.Panel();
            lLimpieza = new System.Windows.Forms.Label();
            pMantenimiento = new System.Windows.Forms.Panel();
            lMantenimiento = new System.Windows.Forms.Label();
            LLeyenda = new System.Windows.Forms.Label();
            PLogo = new System.Windows.Forms.Panel();
            BbloquearSesion = new System.Windows.Forms.Button();
            BPagos = new System.Windows.Forms.Button();
            Bhuesped = new System.Windows.Forms.Button();
            PMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PMenu
            // 
            PMenu.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            PMenu.Controls.Add(pDisponible);
            PMenu.Controls.Add(lDisponible);
            PMenu.Controls.Add(pOcupada);
            PMenu.Controls.Add(lOcupada);
            PMenu.Controls.Add(pLimpieza);
            PMenu.Controls.Add(lLimpieza);
            PMenu.Controls.Add(pMantenimiento);
            PMenu.Controls.Add(lMantenimiento);
            PMenu.Controls.Add(LLeyenda);
            PMenu.Controls.Add(PLogo);
            PMenu.Controls.Add(BbloquearSesion);
            PMenu.Controls.Add(BPagos);
            PMenu.Controls.Add(Bhuesped);
            PMenu.Dock = System.Windows.Forms.DockStyle.Left;
            PMenu.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            PMenu.Location = new System.Drawing.Point(0, 0);
            PMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PMenu.Name = "PMenu";
            PMenu.Size = new System.Drawing.Size(372, 874);
            PMenu.TabIndex = 1;
            PMenu.Paint += PMenu_Paint;
            // 
            // pDisponible
            // 
            pDisponible.BackColor = System.Drawing.Color.FromArgb(40, 199, 111);
            pDisponible.Location = new System.Drawing.Point(75, 750);
            pDisponible.Name = "pDisponible";
            pDisponible.Size = new System.Drawing.Size(16, 16);
            pDisponible.TabIndex = 14;
            // 
            // lDisponible
            // 
            lDisponible.AutoSize = true;
            lDisponible.ForeColor = System.Drawing.Color.FromArgb(208, 212, 220);
            lDisponible.Location = new System.Drawing.Point(97, 749);
            lDisponible.Name = "lDisponible";
            lDisponible.Size = new System.Drawing.Size(81, 20);
            lDisponible.TabIndex = 15;
            lDisponible.Text = "Disponible";
            // 
            // pOcupada
            // 
            pOcupada.BackColor = System.Drawing.Color.FromArgb(234, 84, 85);
            pOcupada.Location = new System.Drawing.Point(75, 782);
            pOcupada.Name = "pOcupada";
            pOcupada.Size = new System.Drawing.Size(16, 16);
            pOcupada.TabIndex = 16;
            // 
            // lOcupada
            // 
            lOcupada.AutoSize = true;
            lOcupada.ForeColor = System.Drawing.Color.FromArgb(208, 212, 220);
            lOcupada.Location = new System.Drawing.Point(97, 781);
            lOcupada.Name = "lOcupada";
            lOcupada.Size = new System.Drawing.Size(69, 20);
            lOcupada.TabIndex = 17;
            lOcupada.Text = "Ocupada";
            // 
            // pLimpieza
            // 
            pLimpieza.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            pLimpieza.Location = new System.Drawing.Point(75, 814);
            pLimpieza.Name = "pLimpieza";
            pLimpieza.Size = new System.Drawing.Size(16, 16);
            pLimpieza.TabIndex = 18;
            // 
            // lLimpieza
            // 
            lLimpieza.AutoSize = true;
            lLimpieza.ForeColor = System.Drawing.Color.FromArgb(208, 212, 220);
            lLimpieza.Location = new System.Drawing.Point(97, 813);
            lLimpieza.Name = "lLimpieza";
            lLimpieza.Size = new System.Drawing.Size(69, 20);
            lLimpieza.TabIndex = 19;
            lLimpieza.Text = "Limpieza";
            // 
            // pMantenimiento
            // 
            pMantenimiento.BackColor = System.Drawing.Color.FromArgb(79, 134, 247);
            pMantenimiento.Location = new System.Drawing.Point(75, 846);
            pMantenimiento.Name = "pMantenimiento";
            pMantenimiento.Size = new System.Drawing.Size(16, 16);
            pMantenimiento.TabIndex = 20;
            // 
            // lMantenimiento
            // 
            lMantenimiento.AutoSize = true;
            lMantenimiento.ForeColor = System.Drawing.Color.FromArgb(208, 212, 220);
            lMantenimiento.Location = new System.Drawing.Point(97, 845);
            lMantenimiento.Name = "lMantenimiento";
            lMantenimiento.Size = new System.Drawing.Size(110, 20);
            lMantenimiento.TabIndex = 21;
            lMantenimiento.Text = "Mantenimiento";
            // 
            // LLeyenda
            // 
            LLeyenda.AutoSize = true;
            LLeyenda.Location = new System.Drawing.Point(75, 716);
            LLeyenda.Name = "LLeyenda";
            LLeyenda.Size = new System.Drawing.Size(72, 20);
            LLeyenda.TabIndex = 13;
            LLeyenda.Text = "LEYENDA";
            // 
            // PLogo
            // 
            PLogo.BackgroundImage = (System.Drawing.Image)resources.GetObject("PLogo.BackgroundImage");
            PLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            PLogo.Location = new System.Drawing.Point(12, 15);
            PLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PLogo.Name = "PLogo";
            PLogo.Size = new System.Drawing.Size(339, 272);
            PLogo.TabIndex = 2;
            // 
            // BbloquearSesion
            // 
            BbloquearSesion.Font = new System.Drawing.Font("Sans Serif Collection", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BbloquearSesion.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            BbloquearSesion.Location = new System.Drawing.Point(50, 515);
            BbloquearSesion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BbloquearSesion.Name = "BbloquearSesion";
            BbloquearSesion.Size = new System.Drawing.Size(258, 69);
            BbloquearSesion.TabIndex = 4;
            BbloquearSesion.Text = "Bloquear Sesión";
            BbloquearSesion.UseVisualStyleBackColor = true;
            // 
            // BPagos
            // 
            BPagos.Font = new System.Drawing.Font("Sans Serif Collection", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BPagos.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            BPagos.Location = new System.Drawing.Point(50, 422);
            BPagos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BPagos.Name = "BPagos";
            BPagos.Size = new System.Drawing.Size(258, 63);
            BPagos.TabIndex = 3;
            BPagos.Text = "Turno Caja/Pagos";
            BPagos.UseVisualStyleBackColor = true;
            // 
            // Bhuesped
            // 
            Bhuesped.Font = new System.Drawing.Font("Sans Serif Collection", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Bhuesped.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            Bhuesped.Location = new System.Drawing.Point(50, 335);
            Bhuesped.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Bhuesped.Name = "Bhuesped";
            Bhuesped.Size = new System.Drawing.Size(258, 65);
            Bhuesped.TabIndex = 2;
            Bhuesped.Text = "Huespedes";
            Bhuesped.UseVisualStyleBackColor = true;
            // 
            // FRecepcionista
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1396, 874);
            Controls.Add(PMenu);
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FRecepcionista";
            Text = "Panel de recepción";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FRecepcionista_Load;
            PMenu.ResumeLayout(false);
            PMenu.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.Button Bhuesped;
        private System.Windows.Forms.Button BPagos;
        private System.Windows.Forms.Button BbloquearSesion;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.Panel pDisponible;
        private System.Windows.Forms.Label lDisponible;
        private System.Windows.Forms.Panel pOcupada;
        private System.Windows.Forms.Label lOcupada;
        private System.Windows.Forms.Panel pLimpieza;
        private System.Windows.Forms.Label lLimpieza;
        private System.Windows.Forms.Panel pMantenimiento;
        private System.Windows.Forms.Label lMantenimiento;
        private System.Windows.Forms.Label LLeyenda;
    }
}