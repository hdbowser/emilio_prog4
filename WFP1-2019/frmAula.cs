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
    public partial class frmAula : Form
    {
        public frmAula()
        {
            InitializeComponent();
            this.aula = new Aula();
            this.Inicializar();
        }

        Aula aula;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ValidarFormulario())
            {
                if (this.aula.AulaID > 0)
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

        }
        private void Registrar()
        {
            AsignarValores();
            if (this.aula.Registrar())
            {
                MessageBox.Show("Se ha registrado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo realizar el registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void AsignarValores()
        {
            this.aula.Descripcion = txtDescripcion.Text;
            this.aula.Capacidad = (int)nudCapacidad.Value;
            this.aula.CentroID = Convert.ToInt32(cbbCentro.SelectedValue);
            this.aula.Observaciones = txtObservaciones.Text;
        }

        private void Inicializar()
        {
            Centro c = new Centro();
            this.cbbCentro.DataSource = c.Buscar("");
            this.cbbCentro.ValueMember = "CentroID";
            this.cbbCentro.DisplayMember = "nombre";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
