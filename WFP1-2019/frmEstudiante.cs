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
    public partial class frmEstudiante : Form
    {


        public frmEstudiante()
        {
            InitializeComponent();
            Inicializar();
            this.estudiante = new Estudiante();
        }

        public frmEstudiante(Estudiante est)
        {
            InitializeComponent();
            Inicializar();
            this.estudiante = est;
            this.CargarValores();
        }

        Estudiante estudiante;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarFormulario())
            {
                if (this.estudiante.EstudianteID > 0)
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

        void CargarValores()
        {
            txtNombre.Text = estudiante.Nombre;
            txtApellido.Text = estudiante.Apellido;
            dtpFechaNacimiento.Value = estudiante.FechaNacimiento;
            mtxtCedula.Text = estudiante.Cedula;
            txtMatricula.Text = estudiante.Matricula;
            cbbTipoEstudiante.SelectedValue = estudiante.TipodeEstudianteID;
            cbbEstadoCivil.SelectedValue = estudiante.EstadoCivil;
            cbbCarrera.SelectedValue = estudiante.CarreraID;
            txtTelefonoCasa.Text = estudiante.TelefonoCasa;
            txtTelefonoPersonal.Text = estudiante.TelefonoMovil;
            txtEmail.Text = estudiante.Email;
            txtObservaciones.Text = estudiante.Observaciones;
            cbbCarrera.SelectedValue = estudiante.CarreraID;
            txtBalance.Text = estudiante.Balance.ToString();

            if (this.estudiante.Sexo == 'M')
                rbtM.Checked = true;
            else
                rbtF.Checked = true;
        }

        private void frmEstudiante_Load(object sender, EventArgs e)
        {

        }


        private void Inicializar()
        {
            cbbTipoEstudiante.DataSource = (new TipoEstudiante()).Listado();
            cbbTipoEstudiante.DisplayMember = "Descripcion";
            cbbTipoEstudiante.ValueMember = "TipoEstudianteID";


            cbbCarrera.DataSource = (new Carrera()).Buscar("");
            cbbCarrera.DisplayMember = "Descripcion";
            cbbCarrera.ValueMember = "CarreraID";

            Dictionary<char, string> dic = new Dictionary<char, string>();
            dic.Add('S', "Soltero");
            dic.Add('C', "Casado");
            dic.Add('D', "Divorciado");

            cbbEstadoCivil.DataSource = new BindingSource(dic, null);
            cbbEstadoCivil.DisplayMember = "Value";
            cbbEstadoCivil.ValueMember = "Key";
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

        public void AsignarValores()
        {
            estudiante.Cedula = mtxtCedula.Text;
            estudiante.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            estudiante.Nombre = txtNombre.Text;
            estudiante.Apellido = txtApellido.Text;
            estudiante.TipodeEstudianteID = Convert.ToInt32(cbbTipoEstudiante.SelectedValue.ToString());
            estudiante.CarreraID = Convert.ToInt32(cbbCarrera.SelectedValue.ToString());
            estudiante.EstadoCivil = Convert.ToChar(cbbEstadoCivil.SelectedValue);
            estudiante.TelefonoCasa = txtTelefonoCasa.Text;
            estudiante.TelefonoMovil = txtTelefonoPersonal.Text;
            estudiante.Email = txtEmail.Text;
            estudiante.Observaciones = txtObservaciones.Text;
            estudiante.Sexo = (rbtM.Checked) ? 'M' : 'F';
        }

        private void Registrar()
        {
            AsignarValores();
            if (this.estudiante.Matricular())
            {
                MessageBox.Show("Se ha registrado el elemento correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Actualizar()
        {
            this.AsignarValores();
            if (this.estudiante.Actualizar())
            {
                MessageBox.Show("Se ha actualizado el elemento correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo completar la operación", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
