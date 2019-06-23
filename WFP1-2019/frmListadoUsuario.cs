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
    public partial class frmListadoUsuario : Form
    {
        Mantenimiento mant;
        DataTable dt;

        public frmListadoUsuario(string nombre)
        {
           
            InitializeComponent();
            mant = new Mantenimiento();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
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


        private void btnBuscar_Click(object sender, EventArgs e)
        {

            dt = mant.getListadoPersonas(buildFiltro());
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


    }
}
