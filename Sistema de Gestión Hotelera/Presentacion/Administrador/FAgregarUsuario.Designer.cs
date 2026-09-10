namespace Presentacion.Administrador
{
    partial class FAgregarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAgregarUsuario));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtNomUsuario = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            rAdministrador = new System.Windows.Forms.RadioButton();
            rSupervisor = new System.Windows.Forms.RadioButton();
            rRecepcionista = new System.Windows.Forms.RadioButton();
            bGuardar = new System.Windows.Forms.Button();
            bLimpiar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // txtNomUsuario
            // 
            resources.ApplyResources(txtNomUsuario, "txtNomUsuario");
            txtNomUsuario.Name = "txtNomUsuario";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // rAdministrador
            // 
            resources.ApplyResources(rAdministrador, "rAdministrador");
            rAdministrador.Name = "rAdministrador";
            rAdministrador.TabStop = true;
            rAdministrador.UseVisualStyleBackColor = true;
            // 
            // rSupervisor
            // 
            resources.ApplyResources(rSupervisor, "rSupervisor");
            rSupervisor.Name = "rSupervisor";
            rSupervisor.TabStop = true;
            rSupervisor.UseVisualStyleBackColor = true;
            // 
            // rRecepcionista
            // 
            resources.ApplyResources(rRecepcionista, "rRecepcionista");
            rRecepcionista.Name = "rRecepcionista";
            rRecepcionista.TabStop = true;
            rRecepcionista.UseVisualStyleBackColor = true;
            // 
            // bGuardar
            // 
            bGuardar.BackColor = System.Drawing.Color.FromArgb(25, 135, 84);
            resources.ApplyResources(bGuardar, "bGuardar");
            bGuardar.Name = "bGuardar";
            bGuardar.UseVisualStyleBackColor = false;
            bGuardar.Click += bGuardar_Click;
            // 
            // bLimpiar
            // 
            bLimpiar.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            resources.ApplyResources(bLimpiar, "bLimpiar");
            bLimpiar.Name = "bLimpiar";
            bLimpiar.UseVisualStyleBackColor = false;
            bLimpiar.Click += bLimpiar_Click;
            // 
            // FAgregarUsuario
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(33, 37, 41);
            Controls.Add(bLimpiar);
            Controls.Add(bGuardar);
            Controls.Add(rRecepcionista);
            Controls.Add(rSupervisor);
            Controls.Add(rAdministrador);
            Controls.Add(label3);
            Controls.Add(txtNomUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = System.Drawing.Color.White;
            MaximizeBox = false;
            Name = "FAgregarUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += FAgregarUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rAdministrador;
        private System.Windows.Forms.RadioButton rSupervisor;
        private System.Windows.Forms.RadioButton rRecepcionista;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bLimpiar;
    }
}