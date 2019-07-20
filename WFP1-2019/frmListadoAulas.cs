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
    public partial class frmListadoAulas : Form
    {
        public frmListadoAulas()
        {
            InitializeComponent();
            this.Buscar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAula frm = new frmAula();
            frm.ShowDialog();
        }

        private void Buscar()
        {
            Aula c = new Aula();
            dataGridView1.DataSource = c.Buscar(txtBusqueda.Text);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}
