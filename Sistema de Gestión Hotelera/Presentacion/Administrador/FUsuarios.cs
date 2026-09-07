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

namespace Presentacion.Administrador
{
    public partial class FUsuarios : Form
    {
        private LAdministrador lAdministrador = new LAdministrador();
        public FUsuarios()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.cargarGrid();
        }

        private void FUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                dgUusario.DataSource = lAdministrador.ObtenerUsuariosParaGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de conexion a la BBDD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void cargarGrid()
        {
            try
            {
                // 1. Desactivamos la generación automática para controlar el orden y los botones
                dgUusario.AutoGenerateColumns = false;
                dgUusario.Columns.Clear();

                // 2. Definimos las columnas de datos
                dgUusario.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "ID",
                    HeaderText = "ID",
                    Width = 50
                });

                dgUusario.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Usuario",
                    HeaderText = "Usuario",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                });

                dgUusario.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "pass",
                    HeaderText = "Contraseña",
                    Width = 120
                });

                dgUusario.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Rol",
                    HeaderText = "Rol",
                    Width = 150
                });

                dgUusario.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Estado",
                    HeaderText = "Estado",
                    Width = 100
                });

                // 3. Columna de Botón (sin acción asignada aún)
                DataGridViewButtonColumn btnDeshabilitar = new DataGridViewButtonColumn
                {
                    Name = "btnAccion",
                    HeaderText = "Acciones",
                    Text = "Deshabilitar",
                    UseColumnTextForButtonValue = true, // Fuerza a que todas las filas digan "Deshabilitar"
                    Width = 110
                };
                dgUusario.Columns.Add(btnDeshabilitar);

                // 4. Asignamos el DataSource desde la lógica
                dgUusario.DataSource = lAdministrador.ObtenerUsuariosParaGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bAgregarUsuario_Click(object sender, EventArgs e)
        {
            FAgregarUsuario fAgregarUsuario = new FAgregarUsuario();
            fAgregarUsuario.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
