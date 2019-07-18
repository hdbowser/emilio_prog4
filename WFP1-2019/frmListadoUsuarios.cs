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
    public partial class frmListadoUsuarios : Form
    {
        public frmListadoUsuarios()
        {
            InitializeComponent();
            this.Buscar();
        }

        public void Buscar()
        {
            Usuario u = new Usuario();
            DataTable dtt = new DataTable();
            dtt = u.Buscar(txtBusqueda.Text);
            dataGridView1.DataSource = dtt;
            lblTotal.Text = dataGridView1.RowCount.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Usuario u = new Usuario();
                u.UsuarioID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString());
                u = u.Detalle();
                frmUsuario frm = new frmUsuario(u);
                frm.ShowDialog();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.ShowDialog();
        }
    }
}
