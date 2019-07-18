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
            txtDevuelta.Text = "RD" + this.pagoEstudiante.Devuelta.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("es-DO"));
        }

        private void nudDineroRecivido_ValueChanged(object sender, EventArgs e)
        {
            this.pagoEstudiante.MontoRecibido = nudDineroRecivido.Value;
            this.pagoEstudiante.Devuelta = this.pagoEstudiante.MontoRecibido - this.pagoEstudiante.MontoAPagar;
            if (this.nudDineroRecivido.Value <= this.pagoEstudiante.MontoAPagar)
            {
                this.pagoEstudiante.Devuelta = 0;
            }
            this.Refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pagoEstudiante.MontoRecibido = nudDineroRecivido.Value;
            if (this.pagoEstudiante.MontoRecibido >= this.pagoEstudiante.MontoAPagar)
            {
                if (this.pagoEstudiante.MontoAPagar == 0)
                {
                    MessageBox.Show("Este estudiante no tiene deuda acumulada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (this.pagoEstudiante.Registrar())
                    {
                        MessageBox.Show("Pago realizado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.pagoEstudiante = new PagoEstudiante();
                        txtEstudiante.Text = string.Empty;
                        nudDineroRecivido.Value = 0;
                        this.Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar el pago pare este estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("El dinero recibido debe ser igual o mayor al monto a pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
