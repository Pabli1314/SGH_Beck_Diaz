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
            PLogo = new System.Windows.Forms.Panel();
            BVentas = new System.Windows.Forms.Button();
            BPagos = new System.Windows.Forms.Button();
            Bhuesped = new System.Windows.Forms.Button();
            PMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PMenu
            // 
            PMenu.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            PMenu.Controls.Add(PLogo);
            PMenu.Controls.Add(BVentas);
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
            // BVentas
            // 
            BVentas.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BVentas.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            BVentas.Location = new System.Drawing.Point(12, 628);
            BVentas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BVentas.Name = "BVentas";
            BVentas.Size = new System.Drawing.Size(339, 91);
            BVentas.TabIndex = 4;
            BVentas.Text = "Ventas Adicionales";
            BVentas.UseVisualStyleBackColor = true;
            // 
            // BPagos
            // 
            BPagos.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BPagos.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            BPagos.Location = new System.Drawing.Point(12, 489);
            BPagos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BPagos.Name = "BPagos";
            BPagos.Size = new System.Drawing.Size(339, 91);
            BPagos.TabIndex = 3;
            BPagos.Text = "Pagos";
            BPagos.UseVisualStyleBackColor = true;
            // 
            // Bhuesped
            // 
            Bhuesped.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Bhuesped.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            Bhuesped.Location = new System.Drawing.Point(12, 339);
            Bhuesped.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Bhuesped.Name = "Bhuesped";
            Bhuesped.Size = new System.Drawing.Size(339, 92);
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
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.Button Bhuesped;
        private System.Windows.Forms.Button BPagos;
        private System.Windows.Forms.Button BVentas;
        private System.Windows.Forms.Panel PLogo;
    }
}