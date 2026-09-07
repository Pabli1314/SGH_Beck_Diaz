namespace Sistema_de_Gestión_Hotelera
{
    partial class FSeleccionUsuario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnSupervisor = new System.Windows.Forms.Button();
            this.btnRecepcionista = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Sans Serif Collection", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(125, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(520, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "¿Con qué módulo deseas continuar?";
            //
            // lblNota
            //
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.lblNota.Location = new System.Drawing.Point(129, 90);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(430, 15);
            this.lblNota.TabIndex = 1;
            this.lblNota.Text = "Selección manual del módulo (no restringe según el rol real del usuario).";
            //
            // btnAdministrador
            //
            this.btnAdministrador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(66)))), ((int)(((byte)(193)))));
            this.btnAdministrador.FlatAppearance.BorderSize = 0;
            this.btnAdministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministrador.Font = new System.Drawing.Font("Sans Serif Collection", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrador.ForeColor = System.Drawing.Color.White;
            this.btnAdministrador.Location = new System.Drawing.Point(40, 150);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(220, 150);
            this.btnAdministrador.TabIndex = 2;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdministrador_Click);
            //
            // btnSupervisor
            //
            this.btnSupervisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnSupervisor.FlatAppearance.BorderSize = 0;
            this.btnSupervisor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupervisor.Font = new System.Drawing.Font("Sans Serif Collection", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupervisor.ForeColor = System.Drawing.Color.White;
            this.btnSupervisor.Location = new System.Drawing.Point(280, 150);
            this.btnSupervisor.Name = "btnSupervisor";
            this.btnSupervisor.Size = new System.Drawing.Size(220, 150);
            this.btnSupervisor.TabIndex = 3;
            this.btnSupervisor.Text = "Supervisor";
            this.btnSupervisor.UseVisualStyleBackColor = false;
            this.btnSupervisor.Click += new System.EventHandler(this.btnSupervisor_Click);
            //
            // btnRecepcionista
            //
            this.btnRecepcionista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnRecepcionista.FlatAppearance.BorderSize = 0;
            this.btnRecepcionista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepcionista.Font = new System.Drawing.Font("Sans Serif Collection", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepcionista.ForeColor = System.Drawing.Color.White;
            this.btnRecepcionista.Location = new System.Drawing.Point(520, 150);
            this.btnRecepcionista.Name = "btnRecepcionista";
            this.btnRecepcionista.Size = new System.Drawing.Size(220, 150);
            this.btnRecepcionista.TabIndex = 4;
            this.btnRecepcionista.Text = "Recepcionista";
            this.btnRecepcionista.UseVisualStyleBackColor = false;
            this.btnRecepcionista.Click += new System.EventHandler(this.btnRecepcionista_Click);
            //
            // btnVolver
            //
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Sans Serif Collection", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(40, 340);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 44);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // FSeleccionUsuario
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(780, 420);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRecepcionista);
            this.Controls.Add(this.btnSupervisor);
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSeleccionUsuario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión Hotelera - Selección de módulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnSupervisor;
        private System.Windows.Forms.Button btnRecepcionista;
        private System.Windows.Forms.Button btnVolver;
    }
}
