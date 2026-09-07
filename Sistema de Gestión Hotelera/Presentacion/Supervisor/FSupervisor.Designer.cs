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
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.btnMarcarDisponible = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.PMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
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
            this.PMenu.Size = new System.Drawing.Size(372, 699);
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
            this.bSalir.Click += new System.EventHandler(this.bSalir_Click);
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
            this.label1.Location = new System.Drawing.Point(400, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 91);
            this.label1.TabIndex = 4;
            this.label1.Text = "GESTION DE HABITACIONES";
            //
            // dgvHabitaciones
            //
            this.dgvHabitaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.AutoGenerateColumns = false;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(400, 120);
            this.dgvHabitaciones.MultiSelect = false;
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.ReadOnly = true;
            this.dgvHabitaciones.RowHeadersVisible = false;
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(960, 480);
            this.dgvHabitaciones.TabIndex = 6;
            this.dgvHabitaciones.SelectionChanged += new System.EventHandler(this.dgvHabitaciones_SelectionChanged);
            //
            // btnMarcarDisponible
            //
            this.btnMarcarDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMarcarDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnMarcarDisponible.Enabled = false;
            this.btnMarcarDisponible.FlatAppearance.BorderSize = 0;
            this.btnMarcarDisponible.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcarDisponible.Font = new System.Drawing.Font("Sans Serif Collection", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarDisponible.ForeColor = System.Drawing.Color.White;
            this.btnMarcarDisponible.Location = new System.Drawing.Point(400, 614);
            this.btnMarcarDisponible.Name = "btnMarcarDisponible";
            this.btnMarcarDisponible.Size = new System.Drawing.Size(260, 60);
            this.btnMarcarDisponible.TabIndex = 7;
            this.btnMarcarDisponible.Text = "Marcar como Disponible";
            this.btnMarcarDisponible.UseVisualStyleBackColor = false;
            this.btnMarcarDisponible.Click += new System.EventHandler(this.btnMarcarDisponible_Click);
            //
            // btnActualizar
            //
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Sans Serif Collection", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(680, 614);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 60);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            //
            // FSupervisor
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 699);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnMarcarDisponible);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PMenu);
            this.Name = "FSupervisor";
            this.Text = "Panel de supervisión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FSupervisor_Load);
            this.PMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PMenu;
        private System.Windows.Forms.Button bSalir;
        private System.Windows.Forms.Panel PLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Button btnMarcarDisponible;
        private System.Windows.Forms.Button btnActualizar;
    }
}
