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
            label1 = new System.Windows.Forms.Label();
            bCrearReserva = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(732, 196);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "reservas";
            // 
            // bCrearReserva
            // 
            bCrearReserva.Location = new System.Drawing.Point(966, 126);
            bCrearReserva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            bCrearReserva.Name = "bCrearReserva";
            bCrearReserva.Size = new System.Drawing.Size(184, 55);
            bCrearReserva.TabIndex = 1;
            bCrearReserva.Text = "Crear Nueva Reserva";
            bCrearReserva.UseVisualStyleBackColor = true;
            bCrearReserva.Click += bCrearReserva_Click;
            // 
            // FReservas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1340, 905);
            Controls.Add(bCrearReserva);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FReservas";
            Text = "Hospedaje";
            Load += FReservas_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bCrearReserva;
    }
}