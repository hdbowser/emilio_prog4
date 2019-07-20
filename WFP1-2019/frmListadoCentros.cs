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
    public partial class frmListadoCentros : Form
    {
        public frmListadoCentros()
        {
            InitializeComponent();
            this.Buscar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCentro frm = new frmCentro();
            frm.ShowDialog();
        }
        private void Buscar()
        {
            Centro c = new Centro();
            dataGridView1.DataSource = c.Buscar(txtBusqueda.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}
