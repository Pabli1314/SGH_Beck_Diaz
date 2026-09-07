namespace Presentacion.Recepcionista
{
    partial class FCrearReserva
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
            components = new System.ComponentModel.Container();
            LTitulo = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnConfirmarReserva = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            txtDomicilio = new System.Windows.Forms.TextBox();
            lblDomicilio = new System.Windows.Forms.Label();
            dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            lblFechaNacimiento = new System.Windows.Forms.Label();
            txtDocumento = new System.Windows.Forms.TextBox();
            lblDocumento = new System.Windows.Forms.Label();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            LTitulo.ForeColor = System.Drawing.Color.White;
            LTitulo.Location = new System.Drawing.Point(594, -3);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new System.Drawing.Size(311, 95);
            LTitulo.TabIndex = 0;
            LTitulo.Text = "DATOS DEL HUESPED";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnConfirmarReserva);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(txtDomicilio);
            panel1.Controls.Add(lblDomicilio);
            panel1.Controls.Add(dtpFechaNacimiento);
            panel1.Controls.Add(lblFechaNacimiento);
            panel1.Controls.Add(txtDocumento);
            panel1.Controls.Add(lblDocumento);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(113, 72);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1296, 832);
            panel1.TabIndex = 1;
            // 
            // btnConfirmarReserva
            // 
            btnConfirmarReserva.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnConfirmarReserva.FlatAppearance.BorderSize = 0;
            btnConfirmarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConfirmarReserva.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnConfirmarReserva.ForeColor = System.Drawing.Color.White;
            btnConfirmarReserva.Location = new System.Drawing.Point(638, 649);
            btnConfirmarReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnConfirmarReserva.Name = "btnConfirmarReserva";
            btnConfirmarReserva.Size = new System.Drawing.Size(175, 58);
            btnConfirmarReserva.TabIndex = 41;
            btnConfirmarReserva.Text = "Confirmar Reserva";
            btnConfirmarReserva.UseVisualStyleBackColor = false;
            btnConfirmarReserva.Click += btnConfirmarReserva_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 181, 189);
            btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelar.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = System.Drawing.Color.White;
            btnCancelar.Location = new System.Drawing.Point(448, 649);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(150, 58);
            btnCancelar.TabIndex = 42;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Font = new System.Drawing.Font("Sans Serif Collection", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtDomicilio.Location = new System.Drawing.Point(798, 465);
            txtDomicilio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new System.Drawing.Size(235, 56);
            txtDomicilio.TabIndex = 19;
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDomicilio.ForeColor = System.Drawing.Color.White;
            lblDomicilio.Location = new System.Drawing.Point(798, 404);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new System.Drawing.Size(122, 68);
            lblDomicilio.TabIndex = 18;
            lblDomicilio.Text = "Domicilio:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtpFechaNacimiento.Font = new System.Drawing.Font("Sans Serif Collection", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpFechaNacimiento.Location = new System.Drawing.Point(798, 296);
            dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new System.Drawing.Size(235, 56);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            lblFechaNacimiento.Location = new System.Drawing.Point(798, 242);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new System.Drawing.Size(221, 68);
            lblFechaNacimiento.TabIndex = 8;
            lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new System.Drawing.Font("Sans Serif Collection", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtDocumento.Location = new System.Drawing.Point(241, 280);
            txtDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(235, 56);
            txtDocumento.TabIndex = 7;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblDocumento.ForeColor = System.Drawing.Color.White;
            lblDocumento.Location = new System.Drawing.Point(241, 230);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new System.Drawing.Size(71, 68);
            lblDocumento.TabIndex = 6;
            lblDocumento.Text = "DNI:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new System.Drawing.Font("Sans Serif Collection", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtTelefono.Location = new System.Drawing.Point(241, 467);
            txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(235, 56);
            txtTelefono.TabIndex = 18;
            // 
            // txtApellido
            // 
            txtApellido.Font = new System.Drawing.Font("Sans Serif Collection", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtApellido.Location = new System.Drawing.Point(798, 129);
            txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(235, 56);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new System.Drawing.Font("Sans Serif Collection", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            txtNombre.Location = new System.Drawing.Point(241, 131);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(235, 56);
            txtNombre.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(798, 82);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(109, 68);
            label4.TabIndex = 5;
            label4.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(241, 395);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(114, 68);
            label3.TabIndex = 4;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(241, 84);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 68);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // FCrearReserva
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            ClientSize = new System.Drawing.Size(1685, 1000);
            Controls.Add(panel1);
            Controls.Add(LTitulo);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FCrearReserva";
            Text = "FCrearReserva";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Button btnConfirmarReserva;
        private System.Windows.Forms.Button btnCancelar;
    }
}
