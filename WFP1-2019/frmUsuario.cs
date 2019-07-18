using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INF518Core.Clases;

namespace WFP1_2019
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
            this.usuario = new Usuario();
            this.Inicializar();
        }
        public frmUsuario(Usuario usr)
        {
            InitializeComponent();
            this.usuario = usr;
            this.Inicializar();
            this.CargarDatos();
        }

        private Usuario usuario;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicializar()
        {
            DataTable dtt = (new TipoUsuario()).Listado();
            cbbTipoUsuario.DataSource = dtt;
            cbbTipoUsuario.DisplayMember = "Nombre";
            cbbTipoUsuario.ValueMember = "TipoUsuarioID";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarFormulario())
            {
                if (this.usuario.UsuarioID > 0)
                {
                    Actualizar();
                }
                else
                {
                    Registrar();
                }
            }
            else
            {
                MessageBox.Show("Los campos con (*) son obligatorios");
            }
        }

        public void AsignarValores()
        {
            this.usuario.Nombre = txtNombre.Text;
            this.usuario.Password = txtPassword.Text;
            this.usuario.NombreUsuario = txtUsuario.Text;
            this.usuario.TipoUsuarioID = Convert.ToInt32(cbbTipoUsuario.SelectedValue.ToString());
            this.usuario.Observaciones = txtObservaciones.Text;
        }

        public bool ValidarFormulario()
        {
            foreach (var item in groupBox1.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    if (((TextBox)item).Tag.ToString() == "*" && ((TextBox)item).Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public void Actualizar()
        {
            AsignarValores();
            if (this.usuario.Actualizar())
            {
                MessageBox.Show("Se ha actualizado el elemento correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo completar la operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void Registrar()
        {
            AsignarValores();
            if (this.usuario.Registrar())
            {
                MessageBox.Show("Se ha registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void CargarDatos()
        {
            txtNombre.Text = this.usuario.Nombre;
            txtUsuario.Text = this.usuario.NombreUsuario;
            cbbTipoUsuario.SelectedValue = this.usuario.TipoUsuarioID;
            txtPassword.Text = "sdfsdfsdfsd";
            txtPassword.Enabled = false;
            txtObservaciones.Text = this.usuario.Observaciones;
        }
    }
}
