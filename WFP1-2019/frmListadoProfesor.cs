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
    public partial class frmListadoProfesor : Form
    {
        Mantenimiento mant;
        DataTable dt;
        public frmListadoProfesor()
        {
            InitializeComponent();
            mant = new Mantenimiento();
        }


        private void frmListadoProfesor_Load(object sender, EventArgs e)
        {

        }

      
    }
}
