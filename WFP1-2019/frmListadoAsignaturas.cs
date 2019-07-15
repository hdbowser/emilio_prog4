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
    public partial class frmListadoAsignaturas : Form
    {
        public frmListadoAsignaturas()
        {
            InitializeComponent();
        }

        private void fromListadoAsignaturas_Load(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void Buscar()
        {
            this.dataGridView1.DataSource = (new Asignatura()).Buscar(this.txtBusqueda.Text);
            lblCantidad.Text = dataGridView1.RowCount.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAsignatura frm = new frmAsignatura();
            frm.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Asignatura a = new Asignatura();
                a.AsignaturaID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString());
                a = a.Detalle();

                frmAsignatura frm = new frmAsignatura(a);
                frm.ShowDialog();
            }
        }
    }
}
