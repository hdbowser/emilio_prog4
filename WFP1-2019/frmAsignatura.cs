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
    public partial class frmAsignatura : Form
    {
        public frmAsignatura()
        {
            InitializeComponent();
            this.asignatura = new Asignatura();
            this.Inicializar();
        }

        public frmAsignatura( Asignatura a)
        {
            InitializeComponent();
            this.asignatura = a;
            this.Inicializar();
            this.CargarDatos();
        }

        Asignatura asignatura;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarFormulario())
            {
                if (this.asignatura.AsignaturaID > 0)
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

        private void Actualizar()
        {
            MessageBox.Show("Actualizar");
        }

        private void Registrar()
        {
            AsignarValores();
            if (this.asignatura.Registrar())
            {
                MessageBox.Show("Se ha registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

        public void AsignarValores()
        {
            this.asignatura.Descripcion = txtDescripcion.Text;
            this.asignatura.Creditos = (int)nudCreditos.Value;
            this.asignatura.Observaciones = txtObservaciones.Text;
            this.asignatura.CarreraID = Convert.ToInt32(cbbCarrera.SelectedValue.ToString());
            this.asignatura.Codigo = txtCodigo.Text;
        }

        private void Inicializar()
        {
            cbbCarrera.DataSource = (new Carrera()).Buscar("");
            cbbCarrera.DisplayMember = "Descripcion";
            cbbCarrera.ValueMember = "CarreraID";
        }

        public void CargarDatos()
        {
            txtDescripcion.Text = this.asignatura.Descripcion;
            txtCodigo.Text = this.asignatura.Codigo;
            nudCreditos.Value = Convert.ToDecimal(this.asignatura.Creditos);
            cbbCarrera.SelectedValue = this.asignatura.CarreraID;
            txtObservaciones.Text = this.asignatura.Observaciones;
        }

        private void frmAsignatura_Load(object sender, EventArgs e)
        {
            
        }
    }
}
