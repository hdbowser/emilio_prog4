using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INF518Core.Inscripcion;
using System.Data.SqlClient;
using INF518Core.Clases;

namespace WFP1_2019
{

    public partial class frmListadoEstudiantes : Form
    {
        public frmListadoEstudiantes()
        {
            InitializeComponent();
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            (new frmEstudiante()).ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public Estudiante EstudianteSeleccionado { get; set; }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Estudiante est = new Estudiante();
                est.EstudianteID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString());
                est = est.Detalle();

                frmEstudiante frm = new frmEstudiante(est);
                frm.ShowDialog();

            }
        }

        private void frmListadoEstudiantes_Load(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void Buscar()
        {
            dataGridView1.DataSource = (new Estudiante()).Buscar(txtBusqueda.Text);
            lblTotal.Text = dataGridView1.RowCount.ToString();
        }

        public void ModoBusqueda()
        {
            btnEnlazar.Visible = true;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            this.EstudianteSeleccionado = new Estudiante();
        }

        private void btnEnlazar_Click(object sender, EventArgs e)
        {
            this.EstudianteSeleccionado = new Estudiante();
            if (dataGridView1.SelectedRows.Count == 1)
            {
                this.EstudianteSeleccionado.EstudianteID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString());
                this.EstudianteSeleccionado = EstudianteSeleccionado.Detalle();
            }
            this.Close();
        }
    }
}
