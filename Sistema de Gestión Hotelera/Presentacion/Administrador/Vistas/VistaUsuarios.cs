using Entidades;
using Logica;
using Presentacion.Administrador.Modales;
using Presentacion.Administrador.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Presentacion.Administrador.Vistas
{
    internal class VistaUsuarios : UserControl, IVistaAdministrador
    {
        private const string ColEditar = "colEditar";
        private const string ColEstado = "colEstadoAccion";
        private const string ColEliminar = "colEliminar";

        private readonly GestionUsuarios _gestionUsuarios = new();
        private readonly DataGridView _dgv;
        private List<Usuario> _usuarios = new();

        public VistaUsuarios()
        {
            Dock = DockStyle.Fill;
            BackColor = Paleta.FondoApp;

            var barraSuperior = new Panel { Dock = DockStyle.Top, Height = 48 };
            var btnNuevo = EstiloBoton.Primario(new Button { Text = "+  Nuevo usuario", Size = new Size(170, 38), Dock = DockStyle.Right });
            btnNuevo.Click += (s, e) => AbrirModal(null);
            barraSuperior.Controls.Add(btnNuevo);

            _dgv = new DataGridView { Dock = DockStyle.Fill, AutoGenerateColumns = false };
            EstiloGrid.Aplicar(_dgv);
            ConfigurarColumnas();
            _dgv.CellContentClick += Dgv_CellContentClick;

            var panelGrid = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 16, 0, 0) };
            panelGrid.Controls.Add(_dgv);

            Controls.Add(panelGrid);
            Controls.Add(barraSuperior);
        }

        public void Refrescar() => CargarDatos();

        private void ConfigurarColumnas()
        {
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ID", HeaderText = "ID", Width = 55 });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre", Width = 140 });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Apellido", HeaderText = "Apellido", Width = 140 });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Usuario", HeaderText = "Usuario", Width = 130 });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Rol", HeaderText = "Rol", Width = 130 });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "Estado", HeaderText = "Estado", Width = 90 });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "UltimoAcceso", HeaderText = "Último acceso", Width = 150, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            _dgv.Columns.Add(new DataGridViewButtonColumn { Name = ColEditar, HeaderText = "", Text = "Editar", UseColumnTextForButtonValue = true, Width = 80, FlatStyle = FlatStyle.Flat });
            _dgv.Columns.Add(new DataGridViewButtonColumn { Name = ColEstado, HeaderText = "", UseColumnTextForButtonValue = false, Width = 100, FlatStyle = FlatStyle.Flat });
            _dgv.Columns.Add(new DataGridViewButtonColumn { Name = ColEliminar, HeaderText = "", Text = "Eliminar", UseColumnTextForButtonValue = true, Width = 80, FlatStyle = FlatStyle.Flat });
        }

        private void CargarDatos()
        {
            try
            {
                _usuarios = _gestionUsuarios.ObtenerUsuarios();
                _dgv.Rows.Clear();

                foreach (Usuario usuario in _usuarios)
                {
                    int fila = _dgv.Rows.Add(
                        usuario.IdUsuario,
                        usuario.Nombre,
                        usuario.Apellido,
                        usuario.NomUsuario,
                        usuario.Rol.NomRol,
                        usuario.Estado ? "Activo" : "Inactivo",
                        usuario.UltimoAcceso.HasValue ? usuario.UltimoAcceso.Value.ToString("dd/MM/yyyy HH:mm") : "Nunca");

                    _dgv.Rows[fila].Cells[ColEstado].Value = usuario.Estado ? "Desactivar" : "Activar";
                    _dgv.Rows[fila].Cells["Estado"].Style.ForeColor = usuario.Estado ? Paleta.Exito : Paleta.Peligro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo cargar la lista de usuarios.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dgv_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _usuarios.Count) return;

            Usuario usuario = _usuarios[e.RowIndex];
            string columna = _dgv.Columns[e.ColumnIndex].Name;

            if (columna == ColEditar)
            {
                AbrirModal(usuario);
            }
            else if (columna == ColEstado)
            {
                CambiarEstado(usuario);
            }
            else if (columna == ColEliminar)
            {
                Eliminar(usuario);
            }
        }

        private void AbrirModal(Usuario? usuario)
        {
            using var modal = new FModalUsuario(usuario);
            if (modal.ShowDialog(this) == DialogResult.OK)
            {
                CargarDatos();
            }
        }

        private void CambiarEstado(Usuario usuario)
        {
            string accion = usuario.Estado ? "desactivar" : "activar";
            DialogResult confirmacion = MessageBox.Show(
                $"¿Confirma que desea {accion} al usuario \"{usuario.NomUsuario}\"?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                _gestionUsuarios.CambiarEstado(usuario.IdUsuario, !usuario.Estado);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo actualizar el estado.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar(Usuario usuario)
        {
            DialogResult confirmacion = MessageBox.Show(
                $"¿Confirma que desea eliminar definitivamente al usuario \"{usuario.NomUsuario}\"?\nEsta acción no se puede deshacer.",
                "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes) return;

            try
            {
                _gestionUsuarios.EliminarUsuario(usuario.IdUsuario);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"No se pudo eliminar el usuario (puede tener movimientos asociados). Considere desactivarlo en su lugar.\n{ex.Message}",
                    "No se pudo eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
