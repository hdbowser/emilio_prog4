using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using INF518Core.Clases;

namespace WFP1_2019
{
    public partial class Loging : Form
    {
        public INF518Core.Clases.Usuario UsuarioActual { get; set; }
        public Loging()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            INF518Core.Clases.Usuario usr = new INF518Core.Clases.Usuario();
            usr.NombreUsuario = this.txtUsuario.Text;
            usr.Password = this.txtPassword.Text;
            usr = usr.ValidarLogin();
            UsuarioActual = usr;

            if (usr.UsuarioID != 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña no coinciden","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void Loging_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
