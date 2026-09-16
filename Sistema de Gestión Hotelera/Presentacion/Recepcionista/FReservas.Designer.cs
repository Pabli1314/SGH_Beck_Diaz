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
            pnlColumnaCentral = new System.Windows.Forms.Panel();
            pnlResumen = new System.Windows.Forms.FlowLayoutPanel();
            pnlColumnaCentral.SuspendLayout();
            SuspendLayout();
            // 
            // pnlColumnaCentral
            // 
            pnlColumnaCentral.AutoScroll = true;
            pnlColumnaCentral.BackColor = System.Drawing.SystemColors.Control;
            pnlColumnaCentral.Controls.Add(pnlResumen);
            pnlColumnaCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlColumnaCentral.Location = new System.Drawing.Point(0, 0);
            pnlColumnaCentral.Name = "pnlColumnaCentral";
            pnlColumnaCentral.Padding = new System.Windows.Forms.Padding(24);
            pnlColumnaCentral.Size = new System.Drawing.Size(1340, 905);
            pnlColumnaCentral.TabIndex = 1;
            pnlColumnaCentral.Paint += pnlColumnaCentral_Paint;
            // 
            // pnlResumen
            // 
            pnlResumen.AutoSize = true;
            pnlResumen.BackColor = System.Drawing.Color.Transparent;
            pnlResumen.Dock = System.Windows.Forms.DockStyle.Top;
            pnlResumen.Location = new System.Drawing.Point(24, 24);
            pnlResumen.Margin = new System.Windows.Forms.Padding(0, 0, 0, 24);
            pnlResumen.Name = "pnlResumen";
            pnlResumen.Size = new System.Drawing.Size(1292, 0);
            pnlResumen.TabIndex = 0;
            pnlResumen.WrapContents = false;
            // 
            // FReservas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1340, 905);
            Controls.Add(pnlColumnaCentral);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FReservas";
            Text = "Hospedaje";
            Load += FReservas_Load;
            Resize += FReservas_Resize;
            pnlColumnaCentral.ResumeLayout(false);
            pnlColumnaCentral.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlColumnaCentral;
        private System.Windows.Forms.FlowLayoutPanel pnlResumen;
    }
}
