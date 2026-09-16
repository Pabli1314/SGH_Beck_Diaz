using Entidades;
using Logica;
using Presentacion.Administrador.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Administrador.Modales
{
    internal class FModalUsuario : FormModalBase
    {
        private readonly GestionUsuarios _gestionUsuarios = new();
        private readonly Usuario? _usuarioOriginal;

        private readonly TextBox _txtNombre;
        private readonly TextBox _txtApellido;
        private readonly TextBox _txtUsuario;
        private readonly TextBox _txtPassword;
        private readonly TextBox _txtConfirmar;
        private readonly ComboBox _cmbRol;
        private readonly ToggleSwitch _switchEstado;
        private readonly Label _lblErrorGeneral;

        public FModalUsuario(Usuario? usuario)
        {
            _usuarioOriginal = usuario;
            Size = new Size(480, usuario == null ? 610 : 610);
            EstablecerTitulo(usuario == null ? "Nuevo usuario" : "Editar usuario");

            int y = 0;
            const int alto = 62;
            const int ancho = 400;

            Contenido.Controls.Add(CamposFormulario.Etiqueta("Nombre", new Point(0, y)));
            _txtNombre = CamposFormulario.Texto(new Point(0, y + 22), ancho);
            Contenido.Controls.Add(_txtNombre);
            y += alto;

            Contenido.Controls.Add(CamposFormulario.Etiqueta("Apellido", new Point(0, y)));
            _txtApellido = CamposFormulario.Texto(new Point(0, y + 22), ancho);
            Contenido.Controls.Add(_txtApellido);
            y += alto;

            Contenido.Controls.Add(CamposFormulario.Etiqueta("Nombre de usuario", new Point(0, y)));
            _txtUsuario = CamposFormulario.Texto(new Point(0, y + 22), ancho);
            Contenido.Controls.Add(_txtUsuario);
            y += alto;

            string etiquetaPassword = usuario == null ? "Contraseña" : "Nueva contraseña (dejar vacío para no cambiarla)";
            Contenido.Controls.Add(CamposFormulario.Etiqueta(etiquetaPassword, new Point(0, y)));
            _txtPassword = CamposFormulario.Texto(new Point(0, y + 22), ancho, esPassword: true);
            Contenido.Controls.Add(_txtPassword);
            y += alto;

            Contenido.Controls.Add(CamposFormulario.Etiqueta("Confirmar contraseña", new Point(0, y)));
            _txtConfirmar = CamposFormulario.Texto(new Point(0, y + 22), ancho, esPassword: true);
            Contenido.Controls.Add(_txtConfirmar);
            y += alto;

            Contenido.Controls.Add(CamposFormulario.Etiqueta("Rol", new Point(0, y)));
            _cmbRol = CamposFormulario.Combo(new Point(0, y + 22), ancho);
            foreach (Rol rol in _gestionUsuarios.ObtenerRoles())
            {
                _cmbRol.Items.Add(rol);
            }
            _cmbRol.DisplayMember = nameof(Rol.NomRol);
            Contenido.Controls.Add(_cmbRol);
            y += alto;

            Contenido.Controls.Add(CamposFormulario.Etiqueta("Estado", new Point(0, y)));
            _switchEstado = new ToggleSwitch { Location = new Point(0, y + 24), Checked = true };
            Contenido.Controls.Add(_switchEstado);
            y += 56;

            _lblErrorGeneral = new Label { Location = new Point(0, y), Size = new Size(ancho, 20), ForeColor = Paleta.Peligro, Font = Paleta.FuenteChica, Visible = false };
            Contenido.Controls.Add(_lblErrorGeneral);
            y += 30;

            var btnCancelar = EstiloBoton.Secundario(new Button { Text = "Cancelar", Size = new Size(120, 38), Location = new Point(ancho - 120 - 130, y) });
            btnCancelar.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };

            var btnGuardar = EstiloBoton.Primario(new Button { Text = "Guardar", Size = new Size(120, 38), Location = new Point(ancho - 120, y) });
            btnGuardar.Click += (s, e) => Guardar();

            Contenido.Controls.Add(btnCancelar);
            Contenido.Controls.Add(btnGuardar);

            CargarDatosIniciales();
        }

        private void CargarDatosIniciales()
        {
            if (_usuarioOriginal == null)
            {
                if (_cmbRol.Items.Count > 0) _cmbRol.SelectedIndex = 0;
                return;
            }

            _txtNombre.Text = _usuarioOriginal.Nombre;
            _txtApellido.Text = _usuarioOriginal.Apellido;
            _txtUsuario.Text = _usuarioOriginal.NomUsuario;
            _switchEstado.Checked = _usuarioOriginal.Estado;

            foreach (var item in _cmbRol.Items)
            {
                if (item is Rol rol && rol.IdRol == _usuarioOriginal.IdRol)
                {
                    _cmbRol.SelectedItem = rol;
                    break;
                }
            }
        }

        private void Guardar()
        {
            var usuario = new Usuario
            {
                IdUsuario = _usuarioOriginal?.IdUsuario ?? 0,
                Nombre = _txtNombre.Text.Trim(),
                Apellido = _txtApellido.Text.Trim(),
                NomUsuario = _txtUsuario.Text.Trim(),
                IdRol = (_cmbRol.SelectedItem as Rol)?.IdRol ?? 0,
                Estado = _switchEstado.Checked
            };

            try
            {
                if (_usuarioOriginal == null)
                {
                    _gestionUsuarios.CrearUsuario(usuario, _txtPassword.Text, _txtConfirmar.Text);
                }
                else
                {
                    _gestionUsuarios.EditarUsuario(usuario, _txtPassword.Text, _txtConfirmar.Text);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                _lblErrorGeneral.Text = ex.Message;
                _lblErrorGeneral.Visible = true;
            }
            catch (Exception ex)
            {
                _lblErrorGeneral.Text = $"Error al guardar: {ex.Message}";
                _lblErrorGeneral.Visible = true;
            }
        }
    }
}
