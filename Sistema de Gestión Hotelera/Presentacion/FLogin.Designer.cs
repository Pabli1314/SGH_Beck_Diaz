namespace Sistema_de_Gestión_Hotelera
{
    partial class FLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            Pimagen = new System.Windows.Forms.Panel();
            Lsgh = new System.Windows.Forms.Label();
            Lusuario = new System.Windows.Forms.Label();
            Lpass = new System.Windows.Forms.Label();
            BIniciarSesion = new System.Windows.Forms.Button();
            txtUsuario = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // Pimagen
            // 
            Pimagen.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            Pimagen.BackgroundImage = (System.Drawing.Image)resources.GetObject("Pimagen.BackgroundImage");
            Pimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Pimagen.Location = new System.Drawing.Point(12, 12);
            Pimagen.Name = "Pimagen";
            Pimagen.Size = new System.Drawing.Size(291, 426);
            Pimagen.TabIndex = 0;
            Pimagen.Paint += Pimagen_Paint;
            // 
            // Lsgh
            // 
            Lsgh.AutoSize = true;
            Lsgh.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Lsgh.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            Lsgh.Location = new System.Drawing.Point(327, 12);
            Lsgh.Name = "Lsgh";
            Lsgh.Size = new System.Drawing.Size(493, 102);
            Lsgh.TabIndex = 1;
            Lsgh.Text = "SISTEMA DE GESTIÓN HOTELERA";
            Lsgh.Click += Lsgh_Click;
            // 
            // Lusuario
            // 
            Lusuario.AutoSize = true;
            Lusuario.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Lusuario.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            Lusuario.Location = new System.Drawing.Point(309, 124);
            Lusuario.Name = "Lusuario";
            Lusuario.Size = new System.Drawing.Size(137, 34);
            Lusuario.TabIndex = 2;
            Lusuario.Text = "Usuario:";
            // 
            // Lpass
            // 
            Lpass.AutoSize = true;
            Lpass.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Lpass.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            Lpass.Location = new System.Drawing.Point(309, 252);
            Lpass.Name = "Lpass";
            Lpass.Size = new System.Drawing.Size(190, 34);
            Lpass.TabIndex = 3;
            Lpass.Text = "Contraseña:";
            // 
            // BIniciarSesion
            // 
            BIniciarSesion.BackColor = System.Drawing.Color.FromArgb(13, 110, 253);
            BIniciarSesion.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            BIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(248, 249, 250);
            BIniciarSesion.Location = new System.Drawing.Point(465, 374);
            BIniciarSesion.Name = "BIniciarSesion";
            BIniciarSesion.Size = new System.Drawing.Size(192, 50);
            BIniciarSesion.TabIndex = 6;
            BIniciarSesion.Text = "INICIAR SESIÓN";
            BIniciarSesion.UseVisualStyleBackColor = false;
            BIniciarSesion.Click += BIniciarSesion_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtUsuario.Location = new System.Drawing.Point(309, 161);
            txtUsuario.MaxLength = 20;
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new System.Drawing.Size(520, 72);
            txtUsuario.TabIndex = 7;
            txtUsuario.Text = " ";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtPass
            // 
            txtPass.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtPass.Location = new System.Drawing.Point(315, 304);
            txtPass.MaxLength = 16;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new System.Drawing.Size(520, 40);
            txtPass.TabIndex = 8;
            txtPass.UseSystemPasswordChar = true;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            ClientSize = new System.Drawing.Size(847, 450);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(BIniciarSesion);
            Controls.Add(Lpass);
            Controls.Add(Lusuario);
            Controls.Add(Lsgh);
            Controls.Add(Pimagen);
            Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FLogin";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión Hotelera";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pimagen;
        private System.Windows.Forms.Label Lsgh;
        private System.Windows.Forms.Label Lusuario;
        private System.Windows.Forms.Label Lpass;
        private System.Windows.Forms.Button BIniciarSesion;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
    }
}

