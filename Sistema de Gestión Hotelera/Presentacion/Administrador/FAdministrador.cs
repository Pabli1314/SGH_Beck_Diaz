using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion.Administrador
{
    public partial class FAdministrador : Form
    {
        private readonly Usuario? _usuario;

        public FAdministrador() : this(null)
        {
        }

        public FAdministrador(Usuario? usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }
    }
}
