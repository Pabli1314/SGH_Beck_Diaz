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
            this.Pimagen = new System.Windows.Forms.Panel();
            this.Lsgh = new System.Windows.Forms.Label();
            this.Lusuario = new System.Windows.Forms.Label();
            this.Lpass = new System.Windows.Forms.Label();
            this.BIniciarSesion = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Pimagen
            // 
            this.Pimagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Pimagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pimagen.BackgroundImage")));
            this.Pimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pimagen.Location = new System.Drawing.Point(12, 12);
            this.Pimagen.Name = "Pimagen";
            this.Pimagen.Size = new System.Drawing.Size(281, 426);
            this.Pimagen.TabIndex = 0;
            // 
            // Lsgh
            // 
            this.Lsgh.AutoSize = true;
            this.Lsgh.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsgh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Lsgh.Location = new System.Drawing.Point(309, 31);
            this.Lsgh.Name = "Lsgh";
            this.Lsgh.Size = new System.Drawing.Size(529, 36);
            this.Lsgh.TabIndex = 1;
            this.Lsgh.Text = "SISTEMA DE GESTIÓN HOTELERA";
            // 
            // Lusuario
            // 
            this.Lusuario.AutoSize = true;
            this.Lusuario.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Lusuario.Location = new System.Drawing.Point(309, 99);
            this.Lusuario.Name = "Lusuario";
            this.Lusuario.Size = new System.Drawing.Size(137, 34);
            this.Lusuario.TabIndex = 2;
            this.Lusuario.Text = "Usuario:";
            // 
            // Lpass
            // 
            this.Lpass.AutoSize = true;
            this.Lpass.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.Lpass.Location = new System.Drawing.Point(309, 227);
            this.Lpass.Name = "Lpass";
            this.Lpass.Size = new System.Drawing.Size(190, 34);
            this.Lpass.TabIndex = 3;
            this.Lpass.Text = "Contraseña:";
            // 
            // BIniciarSesion
            // 
            this.BIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.BIniciarSesion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BIniciarSesion.Location = new System.Drawing.Point(465, 349);
            this.BIniciarSesion.Name = "BIniciarSesion";
            this.BIniciarSesion.Size = new System.Drawing.Size(192, 44);
            this.BIniciarSesion.TabIndex = 6;
            this.BIniciarSesion.Text = "INICIAR SESIÓN";
            this.BIniciarSesion.UseVisualStyleBackColor = false;
            this.BIniciarSesion.Click += new System.EventHandler(this.BIniciarSesion_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(315, 151);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(520, 45);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(315, 282);
            this.txtPass.MaxLength = 16;
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(520, 45);
            this.txtPass.TabIndex = 8;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged_1);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.BIniciarSesion);
            this.Controls.Add(this.Lpass);
            this.Controls.Add(this.Lusuario);
            this.Controls.Add(this.Lsgh);
            this.Controls.Add(this.Pimagen);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión Hotelera";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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

