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
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
            this.inscripcion = new Inscripcion();
        }
        private Inscripcion inscripcion;
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmListadoEstudiantes frm = new frmListadoEstudiantes();
            frm.ModoBusqueda();
            frm.ShowDialog();
            Estudiante est = new Estudiante();
            est = frm.EstudianteSeleccionado;

            this.inscripcion = est.VerificarInscripcionExistente();

            if (inscripcion.InscripcionID == 0)
            {
                this.inscripcion.EstudianteID = est.EstudianteID;
                this.inscripcion.NombareEstudiante = est.Nombre + " " + est.Apellido;
            }

            this.Refrescar();
        }

        private void btnAgregarSeccion_Click(object sender, EventArgs e)
        {
            frmSecciones frm = new frmSecciones();
            frm.ModoBusqueda();
            frm.ShowDialog();
            Seccion sec = frm.SeccionSeleccionada;

            if (this.inscripcion.VerificarAsignatura(sec.AsignaturaID) > 0)
            {
                MessageBox.Show("Ya hay una seccion con esta asignatura en la lista");
            }
            else
            {
                DataTable dtt = this.inscripcion.VerificarConflictosHorario(sec.SeccionID);
                if (dtt.Rows.Count > 0)
                {
                    frmConflictoSecciones frmConflitos = new frmConflictoSecciones(dtt, "La asignatura que intenta agregar tiene conlicto de horarios con las siguientes secciones: ");
                    frmConflitos.ShowDialog();
                }
                else
                {
                    if (this.inscripcion.AgregarSeccion(sec.SeccionID))
                    {
                        this.Refrescar();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido realizar la operación!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.inscripcion.EstudianteID > 0)
            {
                if (this.inscripcion.InscripcionID == 0)
                {
                    this.Registrar();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un estudiante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void Registrar()
        {
            this.inscripcion.InscripcionID = inscripcion.Registrar();
            if (this.inscripcion.InscripcionID > 0) { }
            {
                MessageBox.Show("Registro creado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.inscripcion = this.inscripcion.Deatlle();
                this.Refrescar();
            }
        }

        public void Refrescar()
        {
            this.txtEstudiante.Text = this.inscripcion.NombareEstudiante;
            if (this.inscripcion.InscripcionID > 0)
            {
                dataGridView1.Enabled = true;
                btnAgregarSeccion.Enabled = true;
                btnDetalleSeccion.Enabled = true;
                btnEliminarSeccion.Enabled = true;
                txtFecha.Text = this.inscripcion.Fecha.ToShortDateString();
                dataGridView1.DataSource = inscripcion.ListadoSecciones();
                btnGuardar.Enabled = false;
            }
            else
            {
                dataGridView1.Enabled = false;
                btnAgregarSeccion.Enabled = false;
                btnDetalleSeccion.Enabled = false;
                btnEliminarSeccion.Enabled = false;
                txtFecha.Text = "";
                dataGridView1.DataSource = new DataTable();
            }

        }

        private void btnDetalleSeccion_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Seccion sec = new Seccion();
                sec.SeccionID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString());
                sec = sec.Detalle();
                frmEditorSeccion frm = new frmEditorSeccion(sec);
                frm.ModoDetalle();
                frm.Show();
            }
        }

        private void btnEliminarSeccion_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if(MessageBox.Show("¿Segura que desea eliminar este elemento?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {

                int seccionID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString());
                    inscripcion.EliminarSeccion(seccionID);
                    this.Refrescar();
                }
            }
        }
    }
}
