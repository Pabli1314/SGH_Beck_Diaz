namespace Presentacion.Administrador
{
    partial class FAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdministrador));
            PMenu = new System.Windows.Forms.Panel();
            BHuesped = new System.Windows.Forms.Button();
            PLogo = new System.Windows.Forms.Panel();
            Breportes = new System.Windows.Forms.Button();
            BUsuarios = new System.Windows.Forms.Button();
            BInicio = new System.Windows.Forms.Button();
            PMenu.SuspendLayout();
            SuspendLayout();
            // 
            // PMenu
            // 
            PMenu.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            PMenu.Controls.Add(BInicio);
            PMenu.Controls.Add(BHuesped);
            PMenu.Controls.Add(PLogo);
            PMenu.Controls.Add(Breportes);
            PMenu.Controls.Add(BUsuarios);
            PMenu.Dock = System.Windows.Forms.DockStyle.Left;
            PMenu.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            PMenu.Location = new System.Drawing.Point(0, 0);
            PMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PMenu.Name = "PMenu";
            PMenu.Size = new System.Drawing.Size(372, 800);
            PMenu.TabIndex = 2;
            // 
            // BHuesped
            // 
            BHuesped.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BHuesped.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            BHuesped.Location = new System.Drawing.Point(12, 696);
            BHuesped.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BHuesped.Name = "BHuesped";
            BHuesped.Size = new System.Drawing.Size(339, 91);
            BHuesped.TabIndex = 4;
            BHuesped.Text = "Huespedes";
            BHuesped.UseVisualStyleBackColor = true;
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
            // Breportes
            // 
            Breportes.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Breportes.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            Breportes.Location = new System.Drawing.Point(12, 573);
            Breportes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Breportes.Name = "Breportes";
            Breportes.Size = new System.Drawing.Size(339, 91);
            Breportes.TabIndex = 3;
            Breportes.Text = "Reportes";
            Breportes.UseVisualStyleBackColor = true;
            // 
            // BUsuarios
            // 
            BUsuarios.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BUsuarios.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            BUsuarios.Location = new System.Drawing.Point(12, 449);
            BUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BUsuarios.Name = "BUsuarios";
            BUsuarios.Size = new System.Drawing.Size(339, 92);
            BUsuarios.TabIndex = 2;
            BUsuarios.Text = "Usuarios";
            BUsuarios.UseVisualStyleBackColor = true;
            BUsuarios.Click += BUsuarios_Click;
            // 
            // BInicio
            // 
            BInicio.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BInicio.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            BInicio.Location = new System.Drawing.Point(12, 327);
            BInicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BInicio.Name = "BInicio";
            BInicio.Size = new System.Drawing.Size(339, 92);
            BInicio.TabIndex = 5;
            BInicio.Text = "Inicio";
            BInicio.UseVisualStyleBackColor = true;
            BInicio.Click += BInicio_Click;
            // 
            // FAdministrador
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1280, 800);
            Controls.Add(PMenu);
            IsMdiContainer = true;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FAdministrador";
            Text = "Administración";
            Load += FAdministrador_Load;
            PMenu.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.Button Breportes;
        private System.Windows.Forms.Button BUsuarios;
        private System.Windows.Forms.Button BHuesped;
        private System.Windows.Forms.Button BInicio;
    }
}