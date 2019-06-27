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
    public partial class frmListadoProfesores : Form
    {
        public frmListadoProfesores()
        {
            InitializeComponent();
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProfesor frm = new frmProfesor();
            frm.ShowDialog();
        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.Buscar();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            this.btnNuevo_Click(sender, e);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.btnBuscar_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString());

        }
        public void Buscar()
        {
            Profesor p = new Profesor();
            DataTable dtt = new DataTable();
            dtt = p.BuscarProfesores(txtBusqueda.Text);
            dataGridView1.DataSource = dtt;

        }

        private void frmListadoProfesores_Load(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}