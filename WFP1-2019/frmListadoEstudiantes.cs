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


        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmListadoEstudiantes_Load(object sender, EventArgs e)
        {
            this.Buscar();
            lblTotal.Text = dataGridView1.RowCount.ToString();
        }

       private void Buscar()
        {
            dataGridView1.DataSource = (new Estudiante()).Buscar(txtBusqueda.Text);
            
        }
    }
}
