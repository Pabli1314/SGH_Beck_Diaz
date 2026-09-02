namespace Presentacion.Recepcionista
{
    partial class FReservas
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
            this.label1 = new System.Windows.Forms.Label();
            this.bCrearReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "reservas";
            // 
            // bCrearReserva
            // 
            this.bCrearReserva.Location = new System.Drawing.Point(966, 101);
            this.bCrearReserva.Name = "bCrearReserva";
            this.bCrearReserva.Size = new System.Drawing.Size(184, 44);
            this.bCrearReserva.TabIndex = 1;
            this.bCrearReserva.Text = "Crear Nueva Reserva";
            this.bCrearReserva.UseVisualStyleBackColor = true;
            this.bCrearReserva.Click += new System.EventHandler(this.bCrearReserva_Click);
            // 
            // FReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 724);
            this.Controls.Add(this.bCrearReserva);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FReservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.FReservas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCrearReserva;
    }
}