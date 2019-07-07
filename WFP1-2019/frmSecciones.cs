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
    public partial class frmSecciones : Form
    {
        public frmSecciones()
        {
            InitializeComponent();
            Asignatura a = new Asignatura();
            cbbAsignatura.DataSource = a.Buscar("");
            cbbAsignatura.DisplayMember = "Descripcion";
            cbbAsignatura.ValueMember = "AsignaturaID";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditorSeccion frm = new frmEditorSeccion();
            frm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (new Seccion() { AsignaturaID = Convert.ToInt32(cbbAsignatura.SelectedValue.ToString()) }).Buscar();
            lblCantidad.Text = dataGridView1.RowCount.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Seccion s = new Seccion();
            s.SeccionID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString());
            s = s.Detalle();
            frmEditorSeccion frm = new frmEditorSeccion(s);
            frm.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                btnModificar.Enabled = true;
            }
        }
    }
}
