using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFP1_2019
{
    public partial class frmSecciones : Form
    {
        public frmSecciones()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEditorSeccion frm = new frmEditorSeccion();
            frm.ShowDialog();
        }
    }
}
