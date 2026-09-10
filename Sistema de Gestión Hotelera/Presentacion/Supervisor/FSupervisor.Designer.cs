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
            PMenu = new System.Windows.Forms.Panel();
            bSalir = new System.Windows.Forms.Button();
            PLogo = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            dgvHabitaciones = new System.Windows.Forms.DataGridView();
            btnMarcarDisponible = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            PFormSupervisor = new System.Windows.Forms.Panel();
            LHabitacion = new System.Windows.Forms.Label();
            LCama = new System.Windows.Forms.Label();
            txtHabitacion = new System.Windows.Forms.TextBox();
            txtCama = new System.Windows.Forms.TextBox();
            LEstado = new System.Windows.Forms.Label();
            rDisponible = new System.Windows.Forms.RadioButton();
            rOcupada = new System.Windows.Forms.RadioButton();
            rLimpieza = new System.Windows.Forms.RadioButton();
            bAgregar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            PMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).BeginInit();
            PFormSupervisor.SuspendLayout();
            SuspendLayout();
            // 
            // PMenu
            // 
            PMenu.BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            PMenu.Controls.Add(PFormSupervisor);
            PMenu.Controls.Add(PLogo);
            PMenu.Dock = System.Windows.Forms.DockStyle.Left;
            PMenu.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            PMenu.Location = new System.Drawing.Point(0, 0);
            PMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            PMenu.Name = "PMenu";
            PMenu.Size = new System.Drawing.Size(372, 874);
            PMenu.TabIndex = 2;
            // 
            // bSalir
            // 
            bSalir.Font = new System.Drawing.Font("Sans Serif Collection", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            bSalir.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            bSalir.Location = new System.Drawing.Point(187, 428);
            bSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bSalir.Name = "bSalir";
            bSalir.Size = new System.Drawing.Size(133, 64);
            bSalir.TabIndex = 5;
            bSalir.Text = "Salir";
            bSalir.UseVisualStyleBackColor = true;
            bSalir.Click += bSalir_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(400, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(401, 95);
            label1.TabIndex = 4;
            label1.Text = "GESTION DE HABITACIONES";
            // 
            // dgvHabitaciones
            // 
            dgvHabitaciones.AllowUserToAddRows = false;
            dgvHabitaciones.AllowUserToDeleteRows = false;
            dgvHabitaciones.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHabitaciones.Location = new System.Drawing.Point(400, 150);
            dgvHabitaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvHabitaciones.MultiSelect = false;
            dgvHabitaciones.Name = "dgvHabitaciones";
            dgvHabitaciones.ReadOnly = true;
            dgvHabitaciones.RowHeadersVisible = false;
            dgvHabitaciones.RowHeadersWidth = 51;
            dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvHabitaciones.Size = new System.Drawing.Size(960, 600);
            dgvHabitaciones.TabIndex = 6;
            dgvHabitaciones.SelectionChanged += dgvHabitaciones_SelectionChanged;
            // 
            // btnMarcarDisponible
            // 
            btnMarcarDisponible.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnMarcarDisponible.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            btnMarcarDisponible.Enabled = false;
            btnMarcarDisponible.FlatAppearance.BorderSize = 0;
            btnMarcarDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnMarcarDisponible.Font = new System.Drawing.Font("Sans Serif Collection", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            btnMarcarDisponible.ForeColor = System.Drawing.Color.White;
            btnMarcarDisponible.Location = new System.Drawing.Point(400, 768);
            btnMarcarDisponible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnMarcarDisponible.Name = "btnMarcarDisponible";
            btnMarcarDisponible.Size = new System.Drawing.Size(260, 75);
            btnMarcarDisponible.TabIndex = 7;
            btnMarcarDisponible.Text = "Marcar como Disponible";
            btnMarcarDisponible.UseVisualStyleBackColor = false;
            btnMarcarDisponible.Click += btnMarcarDisponible_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnActualizar.Font = new System.Drawing.Font("Sans Serif Collection", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnActualizar.Location = new System.Drawing.Point(680, 768);
            btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(150, 75);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // PFormSupervisor
            // 
            PFormSupervisor.Controls.Add(bAgregar);
            PFormSupervisor.Controls.Add(rLimpieza);
            PFormSupervisor.Controls.Add(rOcupada);
            PFormSupervisor.Controls.Add(rDisponible);
            PFormSupervisor.Controls.Add(LEstado);
            PFormSupervisor.Controls.Add(txtCama);
            PFormSupervisor.Controls.Add(txtHabitacion);
            PFormSupervisor.Controls.Add(LCama);
            PFormSupervisor.Controls.Add(LHabitacion);
            PFormSupervisor.Controls.Add(bSalir);
            PFormSupervisor.Location = new System.Drawing.Point(12, 315);
            PFormSupervisor.Name = "PFormSupervisor";
            PFormSupervisor.Size = new System.Drawing.Size(339, 528);
            PFormSupervisor.TabIndex = 6;
            // 
            // LHabitacion
            // 
            LHabitacion.AutoSize = true;
            LHabitacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            LHabitacion.Location = new System.Drawing.Point(15, 87);
            LHabitacion.Name = "LHabitacion";
            LHabitacion.Size = new System.Drawing.Size(103, 25);
            LHabitacion.TabIndex = 7;
            LHabitacion.Text = "Habitacion";
            // 
            // LCama
            // 
            LCama.AutoSize = true;
            LCama.Font = new System.Drawing.Font("Segoe UI", 11F);
            LCama.Location = new System.Drawing.Point(26, 156);
            LCama.Name = "LCama";
            LCama.Size = new System.Drawing.Size(60, 25);
            LCama.TabIndex = 8;
            LCama.Text = "Cama";
            // 
            // txtHabitacion
            // 
            txtHabitacion.Location = new System.Drawing.Point(124, 85);
            txtHabitacion.Name = "txtHabitacion";
            txtHabitacion.Size = new System.Drawing.Size(177, 27);
            txtHabitacion.TabIndex = 10;
            // 
            // txtCama
            // 
            txtCama.Location = new System.Drawing.Point(124, 156);
            txtCama.Name = "txtCama";
            txtCama.Size = new System.Drawing.Size(177, 27);
            txtCama.TabIndex = 12;
            // 
            // LEstado
            // 
            LEstado.AutoSize = true;
            LEstado.Font = new System.Drawing.Font("Segoe UI", 11F);
            LEstado.Location = new System.Drawing.Point(26, 216);
            LEstado.Name = "LEstado";
            LEstado.Size = new System.Drawing.Size(68, 25);
            LEstado.TabIndex = 14;
            LEstado.Text = "Estado";
            LEstado.Click += label5_Click;
            // 
            // rDisponible
            // 
            rDisponible.AutoSize = true;
            rDisponible.Location = new System.Drawing.Point(136, 218);
            rDisponible.Name = "rDisponible";
            rDisponible.Size = new System.Drawing.Size(102, 24);
            rDisponible.TabIndex = 15;
            rDisponible.TabStop = true;
            rDisponible.Text = "Disponible";
            rDisponible.UseVisualStyleBackColor = true;
            // 
            // rOcupada
            // 
            rOcupada.AutoSize = true;
            rOcupada.Location = new System.Drawing.Point(136, 248);
            rOcupada.Name = "rOcupada";
            rOcupada.Size = new System.Drawing.Size(90, 24);
            rOcupada.TabIndex = 16;
            rOcupada.TabStop = true;
            rOcupada.Text = "Ocupada";
            rOcupada.UseVisualStyleBackColor = true;
            // 
            // rLimpieza
            // 
            rLimpieza.AutoSize = true;
            rLimpieza.Location = new System.Drawing.Point(136, 278);
            rLimpieza.Name = "rLimpieza";
            rLimpieza.Size = new System.Drawing.Size(90, 24);
            rLimpieza.TabIndex = 17;
            rLimpieza.TabStop = true;
            rLimpieza.Text = "Limpieza";
            rLimpieza.UseVisualStyleBackColor = true;
            // 
            // bAgregar
            // 
            bAgregar.Font = new System.Drawing.Font("Sans Serif Collection", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            bAgregar.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            bAgregar.Location = new System.Drawing.Point(15, 428);
            bAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new System.Drawing.Size(133, 64);
            bAgregar.TabIndex = 18;
            bAgregar.Text = "Agregar";
            bAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            btnBuscar.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = System.Drawing.Color.White;
            btnBuscar.Location = new System.Drawing.Point(1257, 37);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(94, 48);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(807, 37);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por DNI. Apellido/Nombre, núm de habitacion";
            txtBuscar.Size = new System.Drawing.Size(399, 48);
            txtBuscar.TabIndex = 9;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // FSupervisor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1396, 874);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnActualizar);
            Controls.Add(btnMarcarDisponible);
            Controls.Add(dgvHabitaciones);
            Controls.Add(label1);
            Controls.Add(PMenu);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FSupervisor";
            Text = "Panel de supervisión";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FSupervisor_Load;
            PMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHabitaciones).EndInit();
            PFormSupervisor.ResumeLayout(false);
            PFormSupervisor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnMarcarDisponible;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel PFormSupervisor;
        private System.Windows.Forms.TextBox txtCama;
        private System.Windows.Forms.TextBox txtHabitacion;
        private System.Windows.Forms.Label LCama;
        private System.Windows.Forms.Label LHabitacion;
        private System.Windows.Forms.Label LEstado;
        private System.Windows.Forms.RadioButton rDisponible;
        private System.Windows.Forms.RadioButton rLimpieza;
        private System.Windows.Forms.RadioButton rOcupada;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}
