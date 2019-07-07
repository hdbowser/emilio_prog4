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
    public partial class frmConflictoSecciones : Form
    {
        public frmConflictoSecciones()
        {
            InitializeComponent();
        }
        public frmConflictoSecciones(DataTable dtt, string mensaje)
        {
            InitializeComponent();
            dataGridView1.DataSource = dtt;
            txtMensaje.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
