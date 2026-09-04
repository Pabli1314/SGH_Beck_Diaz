namespace Presentacion.Administrador
{
    partial class FUsuarios
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
            dgUusario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgUusario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sans Serif Collection", 16.1999989F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(295, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(276, 91);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Usuario";
            // 
            // dgUusario
            // 
            dgUusario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUusario.Location = new System.Drawing.Point(261, 158);
            dgUusario.Name = "dgUusario";
            dgUusario.RowHeadersWidth = 51;
            dgUusario.Size = new System.Drawing.Size(300, 188);
            dgUusario.TabIndex = 1;
            // 
            // FUsuarios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dgUusario);
            Controls.Add(label1);
            Name = "FUsuarios";
            Text = "FUsuarios";
            Load += FUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgUusario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgUusario;
    }
}