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
            InicializarValores();
            profesor = new Profesor();
        }

        public frmProfesor(Profesor p)
        {
            InitializeComponent();
            InicializarValores();
            this.profesor = p;
            CargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarFormulario())
            {
                if (this.profesor.ProfesorID > 0)
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

        private void frmProfesor_Load(object sender, EventArgs e)
        {

        }


        //===============METODOS===============================================
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
                else if (item.GetType() == typeof(MaskedTextBox))
                {
                    if (((MaskedTextBox)item).Tag.ToString() == "*" && ((MaskedTextBox)item).Text == "")
                    {
                        return false;
                    }
                }
            }

            if (!rbtF.Checked && !rbtM.Checked) return false;

            return true;
        }

        public void CargarDatos()
        {
            txtNombre.Text = this.profesor.Nombre;
            txtApellido.Text = this.profesor.Apellido;
            mtxtCedula.Text = this.profesor.Cedula;
            dtpFechaNacimiento.Value = this.profesor.FechaNacimiento;
            cbbEstadoCivil.SelectedValue = Convert.ToChar(this.profesor.EstadoCivil);
            txtTelefonoCasa.Text = this.profesor.TelefonoCasa;
            txtTelefonoPersonal.Text = this.profesor.TelefonoMovil;
            txtEmail.Text = this.profesor.Email;
            txtObservaciones.Text = this.profesor.Observaciones;
            if (this.profesor.Sexo == 'M')
                rbtM.Checked = true;
            else
                rbtF.Checked = true;
        }

        private void InicializarValores()
        {
            Dictionary<char, string> dic = new Dictionary<char, string>();
            dic.Add('S', "Soltero");
            dic.Add('C', "Casado");
            dic.Add('D', "Divorciado");

            cbbEstadoCivil.DataSource = new BindingSource(dic, null);
            cbbEstadoCivil.DisplayMember = "Value";
            cbbEstadoCivil.ValueMember = "Key";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.cbbEstadoCivil.SelectedValue = 'C';
        }

        private void Registrar()
        {
            AsignarValores();
            if (this.profesor.Registrar())
            {
                MessageBox.Show("Se ha registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Actualizar()
        {
            AsignarValores();
            if (this.profesor.Actualizar())
            {
                MessageBox.Show("Se ha actualizado el elemento correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo completar la operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        public void AsignarValores()
        {
            this.profesor.Nombre = txtNombre.Text;
            this.profesor.Apellido = txtApellido.Text;
            this.profesor.Cedula = mtxtCedula.Text;
            this.profesor.Sexo = (rbtM.Checked) ? 'M' : 'F';
            this.profesor.FechaNacimiento = dtpFechaNacimiento.Value;
            this.profesor.EstadoCivil = cbbEstadoCivil.SelectedValue.ToString();
            this.profesor.TelefonoCasa = txtTelefonoCasa.Text;
            this.profesor.TelefonoMovil = txtTelefonoPersonal.Text;
            this.profesor.Email = txtEmail.Text;
            this.profesor.Observaciones = txtObservaciones.Text;
        }
    }
}
