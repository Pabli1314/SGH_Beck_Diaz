using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtPass.UseSystemPasswordChar = true;
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BIniciarSesion_Click(object sender, EventArgs e){
            if (txtUsuario.Text == "" || txtPass.Text == ""){
                MessageBox.Show("Debe completar todo los campor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
