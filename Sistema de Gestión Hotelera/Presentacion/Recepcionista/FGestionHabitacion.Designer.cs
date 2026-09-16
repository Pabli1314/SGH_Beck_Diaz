namespace Presentacion.Recepcionista
{
    partial class FGestionHabitacion
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
            lblNumero = new System.Windows.Forms.Label();
            lblTipo = new System.Windows.Forms.Label();
            badgeEstado = new BadgeEstado();
            pnlSeparador = new System.Windows.Forms.Panel();
            lblHuespedTitulo = new System.Windows.Forms.Label();
            lblHuespedValor = new System.Windows.Forms.Label();
            lblIngresoTitulo = new System.Windows.Forms.Label();
            lblIngresoValor = new System.Windows.Forms.Label();
            lblTemporizador = new System.Windows.Forms.Label();
            lblMensaje = new System.Windows.Forms.Label();
            lblNombreHuesped = new System.Windows.Forms.Label();
            txtNombreHuesped = new System.Windows.Forms.TextBox();
            btnAccionPrincipal = new System.Windows.Forms.Button();
            btnCerrar = new System.Windows.Forms.Button();
            btnAccionSecundaria = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblNumero.ForeColor = System.Drawing.Color.White;
            lblNumero.Location = new System.Drawing.Point(32, 28);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new System.Drawing.Size(80, 46);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "101";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblTipo.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblTipo.Location = new System.Drawing.Point(34, 74);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new System.Drawing.Size(76, 23);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Estándar";
            // 
            // badgeEstado
            // 
            badgeEstado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            badgeEstado.ForeColor = System.Drawing.Color.White;
            badgeEstado.Location = new System.Drawing.Point(300, 32);
            badgeEstado.Name = "badgeEstado";
            badgeEstado.Size = new System.Drawing.Size(96, 24);
            badgeEstado.TabIndex = 2;
            badgeEstado.Text = "Disponible";
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = System.Drawing.Color.FromArgb(45, 52, 64);
            pnlSeparador.Location = new System.Drawing.Point(32, 112);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new System.Drawing.Size(388, 1);
            pnlSeparador.TabIndex = 3;
            // 
            // lblHuespedTitulo
            // 
            lblHuespedTitulo.AutoSize = true;
            lblHuespedTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblHuespedTitulo.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblHuespedTitulo.Location = new System.Drawing.Point(32, 134);
            lblHuespedTitulo.Name = "lblHuespedTitulo";
            lblHuespedTitulo.Size = new System.Drawing.Size(68, 20);
            lblHuespedTitulo.TabIndex = 4;
            lblHuespedTitulo.Text = "Huésped";
            // 
            // lblHuespedValor
            // 
            lblHuespedValor.AutoSize = true;
            lblHuespedValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblHuespedValor.ForeColor = System.Drawing.Color.White;
            lblHuespedValor.Location = new System.Drawing.Point(34, 169);
            lblHuespedValor.Name = "lblHuespedValor";
            lblHuespedValor.Size = new System.Drawing.Size(151, 28);
            lblHuespedValor.TabIndex = 5;
            lblHuespedValor.Text = "Carlos Méndez";
            // 
            // lblIngresoTitulo
            // 
            lblIngresoTitulo.AutoSize = true;
            lblIngresoTitulo.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblIngresoTitulo.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblIngresoTitulo.Location = new System.Drawing.Point(34, 300);
            lblIngresoTitulo.Name = "lblIngresoTitulo";
            lblIngresoTitulo.Size = new System.Drawing.Size(116, 20);
            lblIngresoTitulo.TabIndex = 6;
            lblIngresoTitulo.Text = "Hora de ingreso";
            // 
            // lblIngresoValor
            // 
            lblIngresoValor.AutoSize = true;
            lblIngresoValor.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblIngresoValor.ForeColor = System.Drawing.Color.FromArgb(222, 226, 230);
            lblIngresoValor.Location = new System.Drawing.Point(34, 331);
            lblIngresoValor.Name = "lblIngresoValor";
            lblIngresoValor.Size = new System.Drawing.Size(141, 23);
            lblIngresoValor.TabIndex = 7;
            lblIngresoValor.Text = "11/09/2026 14:05";
            // 
            // lblTemporizador
            // 
            lblTemporizador.AutoSize = true;
            lblTemporizador.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTemporizador.ForeColor = System.Drawing.Color.FromArgb(234, 84, 85);
            lblTemporizador.Location = new System.Drawing.Point(351, 169);
            lblTemporizador.Name = "lblTemporizador";
            lblTemporizador.Size = new System.Drawing.Size(136, 41);
            lblTemporizador.TabIndex = 8;
            lblTemporizador.Text = "00:08:52";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new System.Drawing.Font("Segoe UI", 10F);
            lblMensaje.ForeColor = System.Drawing.Color.FromArgb(222, 226, 230);
            lblMensaje.Location = new System.Drawing.Point(32, 131);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new System.Drawing.Size(249, 23);
            lblMensaje.TabIndex = 9;
            lblMensaje.Text = "Esta habitación está disponible.";
            // 
            // lblNombreHuesped
            // 
            lblNombreHuesped.AutoSize = true;
            lblNombreHuesped.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblNombreHuesped.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblNombreHuesped.Location = new System.Drawing.Point(32, 211);
            lblNombreHuesped.Name = "lblNombreHuesped";
            lblNombreHuesped.Size = new System.Drawing.Size(152, 20);
            lblNombreHuesped.TabIndex = 10;
            lblNombreHuesped.Text = "Nombre del huésped:";
            // 
            // txtNombreHuesped
            // 
            txtNombreHuesped.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNombreHuesped.Location = new System.Drawing.Point(32, 246);
            txtNombreHuesped.Name = "txtNombreHuesped";
            txtNombreHuesped.Size = new System.Drawing.Size(300, 30);
            txtNombreHuesped.TabIndex = 11;
            // 
            // btnAccionPrincipal
            // 
            btnAccionPrincipal.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnAccionPrincipal.FlatAppearance.BorderSize = 0;
            btnAccionPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccionPrincipal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAccionPrincipal.ForeColor = System.Drawing.Color.White;
            btnAccionPrincipal.Location = new System.Drawing.Point(32, 380);
            btnAccionPrincipal.Name = "btnAccionPrincipal";
            btnAccionPrincipal.Size = new System.Drawing.Size(220, 44);
            btnAccionPrincipal.TabIndex = 12;
            btnAccionPrincipal.Text = "Registrar Check-In";
            btnAccionPrincipal.UseVisualStyleBackColor = false;
            btnAccionPrincipal.Click += btnAccionPrincipal_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 181, 189);
            btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnCerrar.ForeColor = System.Drawing.Color.White;
            btnCerrar.Location = new System.Drawing.Point(268, 380);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new System.Drawing.Size(150, 44);
            btnCerrar.TabIndex = 13;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAccionSecundaria
            // 
            btnAccionSecundaria.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            btnAccionSecundaria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(79, 134, 247);
            btnAccionSecundaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAccionSecundaria.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            btnAccionSecundaria.ForeColor = System.Drawing.Color.FromArgb(79, 134, 247);
            btnAccionSecundaria.Location = new System.Drawing.Point(32, 436);
            btnAccionSecundaria.Name = "btnAccionSecundaria";
            btnAccionSecundaria.Size = new System.Drawing.Size(220, 38);
            btnAccionSecundaria.TabIndex = 14;
            btnAccionSecundaria.Text = "Enviar a Mantenimiento";
            btnAccionSecundaria.UseVisualStyleBackColor = false;
            btnAccionSecundaria.Click += btnAccionSecundaria_Click;
            // 
            // FGestionHabitacion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 28, 36);
            ClientSize = new System.Drawing.Size(535, 501);
            Controls.Add(btnAccionSecundaria);
            Controls.Add(btnCerrar);
            Controls.Add(btnAccionPrincipal);
            Controls.Add(txtNombreHuesped);
            Controls.Add(lblNombreHuesped);
            Controls.Add(lblMensaje);
            Controls.Add(lblTemporizador);
            Controls.Add(lblIngresoValor);
            Controls.Add(lblIngresoTitulo);
            Controls.Add(lblHuespedValor);
            Controls.Add(lblHuespedTitulo);
            Controls.Add(pnlSeparador);
            Controls.Add(badgeEstado);
            Controls.Add(lblTipo);
            Controls.Add(lblNumero);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "FGestionHabitacion";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Gestión de Habitación";
            Load += FGestionHabitacion_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTipo;
        private Presentacion.Recepcionista.BadgeEstado badgeEstado;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.Label lblHuespedTitulo;
        private System.Windows.Forms.Label lblHuespedValor;
        private System.Windows.Forms.Label lblIngresoTitulo;
        private System.Windows.Forms.Label lblIngresoValor;
        private System.Windows.Forms.Label lblTemporizador;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblNombreHuesped;
        private System.Windows.Forms.TextBox txtNombreHuesped;
        private System.Windows.Forms.Button btnAccionPrincipal;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAccionSecundaria;
    }
}
