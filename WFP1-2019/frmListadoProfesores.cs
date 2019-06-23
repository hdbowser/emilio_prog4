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

namespace WFP1_2019
{
    public partial class frmListadoProfesores : Form
    {
        Mantenimiento mant;
        DataTable dt;
        public frmListadoProfesores()
        {
            InitializeComponent();
            mant = new Mantenimiento();
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProfesor frm = new frmProfesor(0);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.btnGuardarCambios.Dispose();
            frm.btnEliminar.Dispose();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.txtCedula.Text = frm.mtxtCedula.Text;
                this.txtNombre.Text = string.Empty;
                btnBuscar_Click(sender, e);
            }
            frm.Dispose();
        }

        string buildFiltro()
        {
            StringBuilder qry = new StringBuilder();
            qry.Append(" ID>0 ");
            if (txtCedula.Text.Trim().Length > 0)
                qry.AppendFormat(" AND Cedula LIKE '%{0}%'", txtCedula.Text);
            if (txtNombre.Text.Trim().Length > 0)
            {
                qry.AppendFormat(" AND Nombre+' '+Apellido LIKE '%{0}%'", txtNombre.Text);
                //qry.AppendFormat(" OR Apellido LIKE '%{0}%'", txtNombre.Text);
            }



            return qry.ToString();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            dt = mant.getListadoProfesor(buildFiltro());
            dataGridView1.AutoGenerateColumns = true; //no llena las columnas automaticamente
            lblCantidad.Text = "0";
            this.btnModificar.Enabled = false;
            if (dt != null || dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt; //asigna el datatable al datagridview
                this.lblCantidad.Text = dt.Rows.Count.ToString("#,###"); //muestra la cantidad de registros
                this.btnModificar.Enabled = true;
            }
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            filtrarDatagridView();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            filtrarDatagridView();
        }
        void filtrarDatagridView()
        {

            if (dt != null && dt.Rows.Count > 0)
            {
                this.dt.DefaultView.RowFilter = buildFiltro();
                this.lblCantidad.Text = dt.DefaultView.Count.ToString("#,###");
                if (dt.DefaultView.Count > 0)
                    this.btnModificar.Enabled = true;
                else
                    this.btnModificar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.txtCedula.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.dataGridView1.DataSource = null; //limpia el datagridview
            dt = null; //limpia el datatable con lo datos
            this.lblCantidad.Text = string.Empty;
            this.btnModificar.Enabled = false;
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int id = 0;
                int.TryParse(dataGridView1.CurrentRow.Cells["colID"].Value.ToString(), out id);
                frmProfesor frm = new frmProfesor(id);
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.btnAceptar.Dispose();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    this.txtCedula.Text = frm.mtxtCedula.Text;
                    this.txtNombre.Text = string.Empty;
                    btnBuscar_Click(sender, e);
                }
                frm.Dispose();
            }

        }
    }
}