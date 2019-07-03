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
    public partial class frmEditorSeccion : Form
    {
        public frmEditorSeccion()
        {
            InitializeComponent();
            this.seccion = new Seccion();
            this.Inicializar();
        }
        private Seccion seccion;

        private void Inicializar()
        {
            Centro c = new Centro();
            this.cbbCentro.DataSource = c.Buscar("");
            this.cbbCentro.ValueMember = "CentroID";
            this.cbbCentro.DisplayMember = "nombre";

            this.CargarAulas();
            DataTable dtt = this.seccion.ListadoDias();
            cbbDia1.DataSource = dtt;
            cbbDia1.ValueMember = "DiaID";
            cbbDia1.DisplayMember = "Nombre";

            cbbDia2.DataSource = dtt;
            cbbDia2.ValueMember = "DiaID";
            cbbDia2.DisplayMember = "Nombre";


            Profesor p = new Profesor();
            cbbProfesor.DataSource = p.BuscarProfesores("");
            cbbProfesor.DisplayMember = "Nombre";
            cbbProfesor.ValueMember = "ProfesorID";

            Asignatura asig = new Asignatura();
            cbbAsignatura.DataSource = asig.Buscar("");
            cbbAsignatura.ValueMember = "AsignaturaID";
            cbbAsignatura.DisplayMember = "Descripcion";
        }

        private void CargarAulas()
        {
            Aula a = new Aula();
            cbbAula.DataSource = a.Buscar(Convert.ToInt32(cbbCentro.SelectedValue.ToString()));
            cbbAula.ValueMember = "AulaID";
            cbbAula.DisplayMember = "Descripcion";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.seccion.CentroID = Convert.ToInt32(cbbCentro.SelectedValue.ToString());
            this.seccion.ProfesorID = Convert.ToInt32(cbbProfesor.SelectedValue.ToString());
            this.seccion.AsignaturaID = Convert.ToInt32(cbbAsignatura.SelectedValue.ToString());
            this.seccion.AulaID = Convert.ToInt32(cbbAula.SelectedValue.ToString());
            this.seccion.Dia1ID = Convert.ToInt32(cbbDia1.SelectedValue.ToString());
        }
    }
}
