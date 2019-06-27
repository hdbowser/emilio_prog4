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
    public partial class MainForm : Form
    {
        public static MainForm menuobj;
        public MainForm()
        {
            InitializeComponent();

        }

        public MainForm(Usuario usr)
        {
            this.usuarioActual = usr;
            InitializeComponent();
        }
        Usuario usuarioActual;

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del sistema?",
                "Advertencia",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoEstudiantes frm = new frmListadoEstudiantes();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
        }

        private void ventanasDeDiálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDialogos frm = new frmDialogos();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor frm = new frmEditor();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            this.notifyIcon1.Visible = false;
        }
        public static void showMensajeAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ActualizarPermisos(sistemaToolStripMenuItem);
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                this.ActualizarPermisos(item);
            }
        }

        private void pruevaLogingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Loging log = new Loging();
            log.StartPosition = FormStartPosition.CenterScreen;
            log.MdiParent = this;
            log.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoEstudiantes est = new frmListadoEstudiantes();
            est.StartPosition = FormStartPosition.CenterScreen;
            est.MdiParent = this;
            est.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoProfesores pro = new frmListadoProfesores();
            pro.StartPosition = FormStartPosition.CenterScreen;
            pro.MdiParent = this;
            pro.Show();

        }

        private void estudianteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //frmEstudiante frm = new frmEstudiante(0);
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.ShowDialog();

            frmListadoEstudiantes est = new frmListadoEstudiantes();
            est.StartPosition = FormStartPosition.CenterScreen;
            est.MdiParent = this;
            est.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoProfesores p = new frmListadoProfesores();
            p.StartPosition = FormStartPosition.CenterScreen;
            p.MdiParent = this;
            p.Show();
        }

        private void actualizarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActualizaPerfil frm = new frmActualizaPerfil();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignatura frm = new frmAsignatura();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCentro frm = new frmCentro();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();

        }

        private void asignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asignaturas frm = new Asignaturas();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
        }

        private void realizarBackUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackUp frm = new WFP1_2019.frmBackUp();
            frm.MdiParent = this;
            frm.Show();
        }




        //METODOS ===========================================================================================================================

        private void ActualizarPermisos(ToolStripMenuItem menu)
        {
            foreach (var item in menu.DropDownItems)
            {
                if (item.GetType() == typeof(ToolStripMenuItem))
                {
                    if (item.GetType() == typeof(ToolStripMenuItem))
                    {
                        string tag = "";
                        if (((ToolStripMenuItem)item).Tag != null)
                        {
                            tag = ((ToolStripMenuItem)item).Tag.ToString();
                            if (!CompararPermisos(usuarioActual.Permisos, tag))
                            {
                                ((ToolStripMenuItem)item).Enabled = false;
                            }
                        }
                        else
                        {
                            ((ToolStripMenuItem)item).Enabled = false;
                        }
                    }
                }
            }
        }

        private bool CompararPermisos(string permisosUsuario, string permiso)
        {
            string[] permisos = permisosUsuario.Split(';');
            foreach (string item in permisos)
            {
                if (item == permiso)
                    return true;
            }
            return false;
        }
    }
}
