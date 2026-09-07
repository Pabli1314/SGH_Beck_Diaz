using Entidades;
using Presentacion;
using Presentacion.Administrador;
using Presentacion.Supervisor;
using System;
using System.Windows.Forms;

namespace Sistema_de_Gestión_Hotelera
{
    public partial class FSeleccionUsuario : Form
    {
        private readonly Usuario? _usuario;

        public FSeleccionUsuario() : this(null)
        {
        }

        public FSeleccionUsuario(Usuario? usuario)
        {
            InitializeComponent();

            // Por el momento el login (FLogin) no forma parte del flujo de arranque, así que
            // no llega un Usuario real. Se usa uno de prueba para poder ejercitar funciones
            // que necesitan id_usuario (p. ej. registrar limpiezas desde FSupervisor).
            _usuario = usuario ?? new Usuario { IdUsuario = 1, NomUsuario = "dev", IdRol = 0, Estado = true };
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            AbrirModulo(new FAdministrador(_usuario));
        }

        private void btnSupervisor_Click(object sender, EventArgs e)
        {
            AbrirModulo(new FSupervisor(_usuario));
        }

        private void btnRecepcionista_Click(object sender, EventArgs e)
        {
            AbrirModulo(new FRecepcionista(_usuario));
        }

        private void AbrirModulo(Form modulo)
        {
            modulo.Show();
            Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
            Hide();
        }
    }
}
