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
using INF518Core.Inscripcion;
using System.Data.SqlClient;

namespace WFP1_2019
{
    public partial class frmProfesor : Form
    {
        Profesor profesor;
        public frmProfesor()
        {
            InitializeComponent();
            profesor = new Profesor();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            profesor = new Profesor();
            profesor.Cedula = mtxtCedula.Text;
            profesor.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            profesor.Nombre = txtNombre.Text;
            profesor.Apellido = txtApellido.Text;
            profesor.TelefonoCasa = txtTelefonoCasa.Text;
            profesor.TelefonoMovil = txtTelefonoPersonal.Text;
            profesor.Email = txtEmail.Text;
            profesor.Observaciones = txtObservaciones.Text;
            if (rbtM.Checked)
            {
                profesor.Sexo = 'M';

            }
            else
            {
                profesor.Sexo = 'F';
            }
            if (profesor.GuardaProfesor())
            {
                MessageBox.Show("Se Registro Correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("se Produjo un Error al Registrar el Estudiante ");
            }
        }
        void actualizaProfesor()
        {
            profesor.Nombre = this.txtNombre.Text;
            profesor.Apellido = this.txtApellido.Text;
            profesor.Cedula = mtxtCedula.Text;
            profesor.FechaNacimiento = dtpFechaNacimiento.Value;

            profesor.TelefonoCasa = txtTelefonoCasa.Text;
            profesor.TelefonoMovil = txtTelefonoPersonal.Text;
            profesor.Email = txtEmail.Text;
            profesor.Observaciones = txtObservaciones.Text;
        }
        void actualizarFormulario()
        {
            txtNombre.Text = profesor.Nombre;
            txtApellido.Text = profesor.Apellido;
            dtpFechaNacimiento.Value = profesor.FechaNacimiento.Date;
            mtxtCedula.Text = profesor.Cedula;
    
            txtTelefonoCasa.Text = profesor.TelefonoCasa;
            txtTelefonoPersonal.Text = profesor.TelefonoMovil;
            txtEmail.Text = profesor.Email;
            txtObservaciones.Text = profesor.Observaciones;
        }

        bool estaValidado()
        {
            if (mtxtCedula.Text.Equals("   -       -"))
            {
                MainForm.showMensajeAdvertencia("La cédula no puede estar en blanco.");
                mtxtCedula.Focus();
                return false;
            }

            if (this.txtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre no puede estar en blanco", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            if (this.txtApellido.Text.Trim().Length == 0)
            {
                MessageBox.Show("El apellido no puede estar en blanco", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }
            return true;
        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
