namespace Presentacion.Supervisor
{
    partial class FSupervisor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSupervisor));
            this.PMenu = new System.Windows.Forms.Panel();
            this.bSalir = new System.Windows.Forms.Button();
            this.PLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PMenu
            // 
            this.PMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.PMenu.Controls.Add(this.bSalir);
            this.PMenu.Controls.Add(this.PLogo);
            this.PMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PMenu.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.PMenu.Location = new System.Drawing.Point(0, 0);
            this.PMenu.Name = "PMenu";
            this.PMenu.Size = new System.Drawing.Size(372, 602);
            this.PMenu.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(650, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 91);
            this.label1.TabIndex = 4;
            this.label1.Text = "GESTION DE HABITACIONES";
            // 
            // FSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PMenu);
            this.Name = "FSupervisor";
            this.Text = "FRecepcionista";
            this.PMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.Label label1;
    }
}