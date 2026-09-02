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
            this.PMenu = new System.Windows.Forms.Panel();
            this.bSalir = new System.Windows.Forms.Button();
            this.PLogo = new System.Windows.Forms.Panel();
            this.BVentas = new System.Windows.Forms.Button();
            this.BPagos = new System.Windows.Forms.Button();
            this.Bhuesped = new System.Windows.Forms.Button();
            this.PMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMenu
            // 
            this.PMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.PMenu.Controls.Add(this.bSalir);
            this.PMenu.Controls.Add(this.PLogo);
            this.PMenu.Controls.Add(this.BVentas);
            this.PMenu.Controls.Add(this.BPagos);
            this.PMenu.Controls.Add(this.Bhuesped);
            this.PMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PMenu.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.PMenu.Location = new System.Drawing.Point(0, 0);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(372, 699);
            this.PMenu.TabIndex = 1;
            // 
            // bSalir
            // 
            this.bSalir.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.bSalir.Location = new System.Drawing.Point(12, 614);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(339, 73);
            this.bSalir.TabIndex = 5;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
            // 
            // PLogo
            // 
            this.PLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PLogo.BackgroundImage")));
            this.PLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PLogo.Location = new System.Drawing.Point(12, 12);
            this.PLogo.Name = "PLogo";
            this.PLogo.Size = new System.Drawing.Size(339, 218);
            this.PLogo.TabIndex = 2;
            // 
            // BVentas
            // 
            this.BVentas.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.BVentas.Location = new System.Drawing.Point(12, 502);
            this.BVentas.Name = "BVentas";
            this.BVentas.Size = new System.Drawing.Size(339, 73);
            this.BVentas.TabIndex = 4;
            this.BVentas.Text = "Ventas Adicionales";
            this.BVentas.UseVisualStyleBackColor = true;
            // 
            // BPagos
            // 
            this.BPagos.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPagos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.BPagos.Location = new System.Drawing.Point(12, 391);
            this.BPagos.Name = "BPagos";
            this.BPagos.Size = new System.Drawing.Size(339, 73);
            this.BPagos.TabIndex = 3;
            this.BPagos.Text = "Pagos";
            this.BPagos.UseVisualStyleBackColor = true;
            // 
            // Bhuesped
            // 
            this.Bhuesped.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bhuesped.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Bhuesped.Location = new System.Drawing.Point(12, 271);
            this.Bhuesped.Name = "Bhuesped";
            this.Bhuesped.Size = new System.Drawing.Size(339, 74);
            this.Bhuesped.TabIndex = 2;
            this.Bhuesped.Text = "Huespedes";
            this.Bhuesped.UseVisualStyleBackColor = true;
            // 
            // FRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 699);
            this.Controls.Add(this.PMenu);
            this.IsMdiContainer = true;
            this.Name = "FRecepcionista";
            this.Text = "Panel de recepción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRecepcionista_Load);
            this.PMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.Button Bhuesped;
        private System.Windows.Forms.Button BPagos;
        private System.Windows.Forms.Button BVentas;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.Button bSalir;
    }
}