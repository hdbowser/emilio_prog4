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
    public partial class frmEditorSeccion : Form
    {
        public frmEditorSeccion()
        {
            InitializeComponent();
            this.Inicializar();
        }

        private void Inicializar()
        {
            Centro c = new Centro();
            this.cbbCentro.DataSource = c.Buscar("");
            this.cbbCentro.ValueMember = "CentroID";
            this.cbbCentro.DisplayMember = "nombre";

            this.CargarAulas();
        }

        private void CargarAulas()
        {
            Aula a = new Aula();
            cbbAula.DataSource = a.Buscar(Convert.ToInt32(cbbCentro.SelectedValue.ToString()));
            cbbAula.ValueMember = "AulaID";
            cbbAula.DisplayMember = "Descripcion";
        }
    }
}
