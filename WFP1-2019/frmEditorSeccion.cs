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
            this.seccion = new Seccion();
            this.Inicializar();
        }
        private Seccion seccion;

        private void Inicializar()
        {
            Centro c = new Centro();
            this.cbbCentro.DataSource = c.Buscar("");
            this.cbbCentro.ValueMember = "CentroID";
            this.cbbCentro.DisplayMember = "nombre";

            this.CargarAulas();
            cbbDia1.DataSource = this.seccion.ListadoDias(); ;
            cbbDia1.ValueMember = "DiaID";
            cbbDia1.DisplayMember = "Nombre";

            cbbDia2.DataSource = this.seccion.ListadoDias(); ;
            cbbDia2.ValueMember = "DiaID";
            cbbDia2.DisplayMember = "Nombre";


            Profesor p = new Profesor();
            cbbProfesor.DataSource = p.BuscarProfesores("");
            cbbProfesor.DisplayMember = "Nombre";
            cbbProfesor.ValueMember = "ProfesorID";

            Asignatura asig = new Asignatura();
            cbbAsignatura.DataSource = asig.Buscar("");
            cbbAsignatura.ValueMember = "AsignaturaID";
            cbbAsignatura.DisplayMember = "Descripcion";
        }

        private void CargarAulas()
        {
            Aula a = new Aula();
            cbbAula.DataSource = a.Buscar(Convert.ToInt32(cbbCentro.SelectedValue.ToString()));
            cbbAula.ValueMember = "AulaID";
            cbbAula.DisplayMember = "Descripcion";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.seccion.CentroID = Convert.ToInt32(cbbCentro.SelectedValue.ToString());
            this.seccion.ProfesorID = Convert.ToInt32(cbbProfesor.SelectedValue.ToString());
            this.seccion.AsignaturaID = Convert.ToInt32(cbbAsignatura.SelectedValue.ToString());
            this.seccion.AulaID = Convert.ToInt32(cbbAula.SelectedValue.ToString());
            this.seccion.Dia1ID = Convert.ToInt32(cbbDia1.SelectedValue.ToString());
            this.seccion.HoraInicioDia1 = dttpHoraInicioDia1.Value;
            this.seccion.HoraFinDia1 = dttpHoraFinDia1.Value;
            this.seccion.Dia2ID = Convert.ToInt32(cbbDia2.SelectedValue.ToString());
            this.seccion.HoraInicioDia2 = dttpHoraInicioDia2.Value;
            this.seccion.HoraFinDia2 = dttpHoraFinDia2.Value;
            this.seccion.Observaciones = txtObservaciones.Text;
            this.seccion.Capacidad = Convert.ToInt32(nudCapacidad.Value);

            if (this.ValidarHoras())
            {

                DataTable dtt = this.seccion.VerificarConflictosAula();
                if (dtt.Rows.Count > 0)
                {
                    frmConflictoSecciones frm = new frmConflictoSecciones(dtt, "El aula seleccionada no está disponible para el horario que intenta registrar,conlicto con las siguientes secciones ");
                    frm.ShowDialog();
                }
                else
                {
                    dtt = this.seccion.VerificarConflictosProfesor();
                    if (dtt.Rows.Count > 0)
                    {
                        frmConflictoSecciones frm = new frmConflictoSecciones(dtt, "El profesor selecionado no está disponible en el horario que intenta registrar, conlicto con las siguientes secciones:");
                        frm.ShowDialog();
                    }
                    else
                    {
                        if (this.seccion.Registrar())
                         {
                             MessageBox.Show("Registro creado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         }
                         else
                         {
                             MessageBox.Show("Error al crear registro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         }
                    }
                }
            }

        }

        private bool ValidarHoras()
        {
            string mensaje = "Existe un conflito en la selección de horas con el mismo día";
            if (this.seccion.Dia1ID == this.seccion.Dia2ID)
            {
                if (LimpiarTicks(this.seccion.HoraInicioDia1).CompareTo(LimpiarTicks(this.seccion.HoraInicioDia2)) == 0 || LimpiarTicks(this.seccion.HoraInicioDia1).CompareTo(LimpiarTicks(this.seccion.HoraFinDia2)) == 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (LimpiarTicks(seccion.HoraInicioDia1).CompareTo(LimpiarTicks(seccion.HoraInicioDia2)) > 0 && LimpiarTicks(seccion.HoraInicioDia1).CompareTo(LimpiarTicks(seccion.HoraFinDia2)) < 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (LimpiarTicks(this.seccion.HoraFinDia1).CompareTo(LimpiarTicks(this.seccion.HoraInicioDia2)) == 0 || LimpiarTicks(this.seccion.HoraFinDia1).CompareTo(LimpiarTicks(this.seccion.HoraFinDia2)) == 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (LimpiarTicks(seccion.HoraFinDia1).CompareTo(LimpiarTicks(seccion.HoraInicioDia2)) > 0 && LimpiarTicks(seccion.HoraFinDia1).CompareTo(LimpiarTicks(seccion.HoraFinDia2)) < 0)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (LimpiarTicks(seccion.HoraInicioDia1).CompareTo(LimpiarTicks(seccion.HoraFinDia1)) == 0)
                {
                    MessageBox.Show("La hora de inicio y la hora de fin no pueden ser iguales", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (LimpiarTicks(seccion.HoraInicioDia2).CompareTo(LimpiarTicks(seccion.HoraFinDia2)) == 0)
                {
                    MessageBox.Show("La hora de inicio y la hora de fin no pueden ser iguales", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private DateTime LimpiarTicks(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
        }

    }
}
