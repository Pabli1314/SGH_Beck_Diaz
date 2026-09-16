namespace Presentacion.Recepcionista
{
    partial class FCheckIn
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
            lblTitulo = new System.Windows.Forms.Label();
            lblDni = new System.Windows.Forms.Label();
            txtDni = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblApellido = new System.Windows.Forms.Label();
            txtApellido = new System.Windows.Forms.TextBox();
            lblTelefono = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            lblDireccion = new System.Windows.Forms.Label();
            txtDireccion = new System.Windows.Forms.TextBox();
            lblMetodoPago = new System.Windows.Forms.Label();
            cmbMetodoPago = new System.Windows.Forms.ComboBox();
            lblFechaSalida = new System.Windows.Forms.Label();
            dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            lblHoraSalida = new System.Windows.Forms.Label();
            dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            btnConfirmar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitulo.ForeColor = System.Drawing.Color.White;
            lblTitulo.Location = new System.Drawing.Point(38, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new System.Drawing.Size(193, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Check-In — 101";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblDni.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblDni.Location = new System.Drawing.Point(38, 68);
            lblDni.Name = "lblDni";
            lblDni.Size = new System.Drawing.Size(35, 20);
            lblDni.TabIndex = 1;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtDni.Location = new System.Drawing.Point(38, 88);
            txtDni.Name = "txtDni";
            txtDni.Size = new System.Drawing.Size(160, 30);
            txtDni.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblNombre.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblNombre.Location = new System.Drawing.Point(214, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(64, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtNombre.Location = new System.Drawing.Point(214, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(180, 30);
            txtNombre.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblApellido.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblApellido.Location = new System.Drawing.Point(38, 126);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(66, 20);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtApellido.Location = new System.Drawing.Point(38, 146);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(160, 30);
            txtApellido.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTelefono.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblTelefono.Location = new System.Drawing.Point(214, 126);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new System.Drawing.Size(67, 20);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtTelefono.Location = new System.Drawing.Point(214, 146);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(180, 30);
            txtTelefono.TabIndex = 8;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblDireccion.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblDireccion.Location = new System.Drawing.Point(38, 184);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new System.Drawing.Size(72, 20);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtDireccion.Location = new System.Drawing.Point(38, 204);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(356, 30);
            txtDireccion.TabIndex = 10;
            // 
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblMetodoPago.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblMetodoPago.Location = new System.Drawing.Point(38, 242);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new System.Drawing.Size(122, 20);
            lblMetodoPago.TabIndex = 11;
            lblMetodoPago.Text = "Método de pago";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMetodoPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Location = new System.Drawing.Point(38, 262);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new System.Drawing.Size(160, 31);
            cmbMetodoPago.TabIndex = 12;
            // 
            // lblFechaSalida
            // 
            lblFechaSalida.AutoSize = true;
            lblFechaSalida.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblFechaSalida.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblFechaSalida.Location = new System.Drawing.Point(214, 242);
            lblFechaSalida.Name = "lblFechaSalida";
            lblFechaSalida.Size = new System.Drawing.Size(111, 20);
            lblFechaSalida.TabIndex = 13;
            lblFechaSalida.Text = "Fecha de salida";
            // 
            // dtpFechaSalida
            // 
            dtpFechaSalida.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFechaSalida.Location = new System.Drawing.Point(214, 262);
            dtpFechaSalida.Name = "dtpFechaSalida";
            dtpFechaSalida.Size = new System.Drawing.Size(111, 30);
            dtpFechaSalida.TabIndex = 14;
            // 
            // lblHoraSalida
            // 
            lblHoraSalida.AutoSize = true;
            lblHoraSalida.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblHoraSalida.ForeColor = System.Drawing.Color.FromArgb(140, 156, 174);
            lblHoraSalida.Location = new System.Drawing.Point(341, 243);
            lblHoraSalida.Name = "lblHoraSalida";
            lblHoraSalida.Size = new System.Drawing.Size(106, 20);
            lblHoraSalida.TabIndex = 15;
            lblHoraSalida.Text = "Hora de salida";
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.Font = new System.Drawing.Font("Segoe UI", 10F);
            dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHoraSalida.Location = new System.Drawing.Point(341, 263);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Size = new System.Drawing.Size(106, 30);
            dtpHoraSalida.TabIndex = 16;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnConfirmar.ForeColor = System.Drawing.Color.White;
            btnConfirmar.Location = new System.Drawing.Point(37, 341);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(180, 44);
            btnConfirmar.TabIndex = 17;
            btnConfirmar.Text = "Confirmar Check-In";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 181, 189);
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.Location = new System.Drawing.Point(223, 341);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(150, 44);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FCheckIn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 28, 36);
            ClientSize = new System.Drawing.Size(489, 441);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(dtpHoraSalida);
            Controls.Add(lblHoraSalida);
            Controls.Add(dtpFechaSalida);
            Controls.Add(lblFechaSalida);
            Controls.Add(cmbMetodoPago);
            Controls.Add(lblMetodoPago);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(lblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FCheckIn";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Check-In";
            Load += FCheckIn_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
