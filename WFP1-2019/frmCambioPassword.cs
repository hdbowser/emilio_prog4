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
    public partial class frmCambioPassword : Form
    {
        public frmCambioPassword(Usuario usr)
        {
            InitializeComponent();
            this.usuario = usr;
        }
        Usuario usuario;

        private bool Validar()
        {
            Usuario u = new Usuario();
            u.NombreUsuario = this.usuario.NombreUsuario;
            u.Password = txtPasswordActual.Text;
            this.usuario.Password = txtPasswordNuevo.Text;
            if (u.ValidarLogin().UsuarioID > 0)
            {
                if (txtPasswordNuevo.Text == txtPasswordNuevo2.Text)
                {
                    if (this.usuario.CambiarPassword())
                    {
                        MessageBox.Show("La contraseña ha sido cambiada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error hubo un error al intentar cambiar la contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña nueva y la de confirmación deben ser iguales", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("La contraseña actual introducida es erronea", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return false;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            this.Validar();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
