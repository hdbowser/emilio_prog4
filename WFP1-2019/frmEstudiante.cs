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

        Estudiante estudiante;
        Mantenimiento mant;
        public frmEstudiante(int ID)
        {
            InitializeComponent();
            estudiante = new Estudiante();
            mant = new Mantenimiento();
            if(ID>0)
            {
                estudiante = mant.GetEstudianteInfo(ID);
                estudiante.ID = ID;
                actualizarFormulario();
            }
        }
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            estudiante =  new Estudiante();

            estudiante.Cedula = mtxtCedula.Text;
            estudiante.FechaNacimiento = dtpFechaNacimiento.Value.Date;
            estudiante.Nombre = txtNombre.Text;
            estudiante.Apellido = txtApellido.Text;
            estudiante.IDTipodeEstudiante = Convert.ToInt32(cbbTipoEstudiante.SelectedValue.ToString());
            estudiante.IDCarrera = Convert.ToInt32(cbbCarrera.SelectedValue.ToString());
            estudiante.Matricula = txtMatricula.Text;
            estudiante.EstadoCivil = txtEstadoCivil.Text;
            estudiante.TelefonoCasa = txtTelefonoCasa.Text;
            estudiante.TelefonoMovil = txtTelefonoPersonal.Text;
            estudiante.Email = txtEmail.Text;
            estudiante.Observaciones = txtObservaciones.Text;
            if (rbtM.Checked)
            {
                estudiante.sexo = 'M';

            }
            else
            {
                estudiante.sexo = 'F';
            }
            if (estudiante.Matricular())
            {
                MessageBox.Show("Se Registro Correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("se Produjo un Error al Registrar el Estudiante ");
            }
        }

        void actualizaEstudiante()
        {
            estudiante.Nombre = this.txtNombre.Text;
            estudiante.Apellido = this.txtApellido.Text;
            estudiante.Cedula = mtxtCedula.Text;
            estudiante.FechaNacimiento = dtpFechaNacimiento.Value;
            estudiante.Matricula = txtMatricula.Text;
            estudiante.IDTipodeEstudiante =  Convert.ToInt16( this.cbbTipoEstudiante.SelectedValue);
            estudiante.EstadoCivil = txtEstadoCivil.Text;
            estudiante.TelefonoCasa = txtTelefonoCasa.Text;
            estudiante.TelefonoMovil = txtTelefonoPersonal.Text;
            estudiante.Email = txtEmail.Text;
            estudiante.Observaciones = txtObservaciones.Text;
           // estudiante.IDCarrera = Convert.ToInt16(this.cbbCarrera.SelectedText);
        }
        void actualizarFormulario()
        {
            txtNombre.Text = estudiante.Nombre;
            txtApellido.Text = estudiante.Apellido;
            dtpFechaNacimiento.Value = estudiante.FechaNacimiento.Date;
            mtxtCedula.Text = estudiante.Cedula;
            txtMatricula.Text = estudiante.Matricula;
            cbbTipoEstudiante.SelectedValue = estudiante.IDTipodeEstudiante;
            txtEstadoCivil.Text = estudiante.EstadoCivil;
            txtTelefonoCasa.Text = estudiante.TelefonoCasa;
            txtTelefonoPersonal.Text = estudiante.TelefonoMovil;
            txtEmail.Text = estudiante.Email;
            txtObservaciones.Text = estudiante.Observaciones;
            //cbbCarrera.SelectedText = estudiante.IDCarrera.ToString();
        }

        
        /// <summary>
        /// Valida los campos del formulario
        /// </summary>
        /// <returns></returns>
        bool estaValidado()
        { 
            if(mtxtCedula.Text.Equals("   -       -"))
            {
                MainForm.showMensajeAdvertencia("La cédula no puede estar en blanco.");
                mtxtCedula.Focus();
                return false;
            }
           
            if(this.txtNombre.Text.Trim().Length==0)
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

        private void frmEstudiante_Load(object sender, EventArgs e)
        {
            TipoEstudiante te = new TipoEstudiante();
            cbbTipoEstudiante.DataSource = te.Listado();
            cbbTipoEstudiante.DisplayMember = "Descripcion";
            cbbTipoEstudiante.ValueMember = "ID";

            Carrera c = new Carrera();
            cbbCarrera.DataSource = c.Listado();
            cbbCarrera.DisplayMember = "Descripcion";
            cbbCarrera.ValueMember = "ID";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Descargado de
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListadoEstudiantes frm = new frmListadoEstudiantes();
            frm.StartPosition = FormStartPosition.CenterScreen;
            //if (frm.ShowDialog() == DialogResult.OK)
               // txtNombre.Text = frm.txtFiltro.Text;

            //MessageBox.Show(frm.txtFiltro.Text);
            frm.Dispose();
        }
         SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=INF518;User ID=sa; Password=12345;");
        
        public void btnGuardarCambios_Click(object sender, EventArgs e)
        {
           
            //string querty = "UPDATE tblEstudiantes set Nombre = @Nombre WHERE ID = {0}";
            //con.Open();
            //SqlCommand comamdo = new SqlCommand(querty, con);
            //comamdo.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            //comamdo.ExecuteNonQuery(); 
            //con.Close();
            MessageBox.Show("Actualizado");
            Close();
        }
    }
}
