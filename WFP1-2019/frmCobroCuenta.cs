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
    public partial class frmCobroCuenta : Form
    {
        public frmCobroCuenta()
        {
            InitializeComponent();
            this.pagoEstudiante = new PagoEstudiante();
        }

        PagoEstudiante pagoEstudiante;

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmListadoEstudiantes frm = new frmListadoEstudiantes();
            frm.ModoBusqueda();
            frm.ShowDialog();
            Estudiante est = new Estudiante();
            est = frm.EstudianteSeleccionado;

            this.pagoEstudiante.EstudianteID = est.EstudianteID;
            txtEstudiante.Text = est.Nombre + " " + est.Apellido;
            this.pagoEstudiante.MontoAPagar = Convert.ToDecimal(est.Balance);
            this.Refrescar();
        }

        private void Refrescar()
        {
            txtMontoAPagar.Text = "RD" + this.pagoEstudiante.MontoAPagar.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-DO"));
            txtDevuelta.Text = this.pagoEstudiante.Devuelta.ToString();
        }

        private void nudDineroRecivido_ValueChanged(object sender, EventArgs e)
        {
            this.pagoEstudiante.MontoRecibido = nudDineroRecivido.Value;
            this.pagoEstudiante.Devuelta = this.pagoEstudiante.MontoRecibido - this.pagoEstudiante.MontoAPagar;
            this.Refrescar();
        }
    }
}
