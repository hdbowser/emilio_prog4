using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INF518Core.Modelos;

namespace WFP1_2019
{
    public partial class MainForm : Form
    {
        public static MainForm menuobj;
        public MainForm()
        {
            InitializeComponent();
            
        }

        public MainForm(Usuario  usr)
        {
            InitializeComponent();
            this.usuaroActual = usr;
        }
        public Usuario usuaroActual { get; set; }
        Usuario usuarioActual = new Usuario();

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

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCambiar_Contraseña frm = new frmCambiar_Contraseña();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.Show();
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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //if (FormWindowState.Minimized == this.WindowState)
            //{
            //    notifyIcon1.Visible = true; //muestra el notifyicon
            //    notifyIcon1.ShowBalloonTip(5000); //dura 5 segundos
            //    this.Hide(); //oculta la ventana principal
            //}
            //else if (FormWindowState.Normal == this.WindowState)
            //{
            //    notifyIcon1.Visible = false;
            //}
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
            // lblNombreUsuario.Text = this.usuaroActual.Nombre;

            actualizarPerfilToolStripMenuItem.Enabled = false;
            cambiarDeUsuarioToolStripMenuItem.Enabled = false;
            cambiarContraseñaToolStripMenuItem.Enabled = false;
            MantenimientoToolStripMenuItem.Enabled = false;
            consultasToolStripMenuItem.Enabled = false;
            reportesToolStripMenuItem.Enabled = false;
            utilitriosToolStripMenuItem.Enabled = false;
            ayudaToolStripMenuItem.Enabled = false;

            Loging log = new Loging();
            log.StartPosition = FormStartPosition.CenterScreen;
            log.MdiParent = this;
            log.Show();
            menuobj = this;
        }

        private void pruevaLogingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

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

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarPerfilToolStripMenuItem.Enabled = false;
            cambiarDeUsuarioToolStripMenuItem.Enabled = false;
            cambiarContraseñaToolStripMenuItem.Enabled = false;
            MantenimientoToolStripMenuItem.Enabled = false;
            consultasToolStripMenuItem.Enabled = false;
            reportesToolStripMenuItem.Enabled = false;
            utilitriosToolStripMenuItem.Enabled = false;
            ayudaToolStripMenuItem.Enabled = false;
            LogingToolStripMenuItem.Enabled = true;

            Loging log = new Loging();
            log.StartPosition = FormStartPosition.CenterScreen;
            log.MdiParent = this;
            log.Show();
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
            p.ShowDialog();
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
    }
}
