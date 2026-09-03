using Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Sistema_de_Gestión_Hotelera
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            this.MaximizeBox = false;

            this.TopMost = true;
           
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FRecepcionista fRecepcionista = new FRecepcionista();
                fRecepcionista.Show();
                this.Hide(); 
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void txtPass_TextChanged_1(object sender, EventArgs e)
        {

        }*/

        private void Pimagen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lsgh_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
