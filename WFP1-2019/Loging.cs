using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WFP1_2019.Clases;
using INF518Core.Modelos;

namespace WFP1_2019
{
    public partial class Loging : Form
    {
        public string usuario,datos;
        public Usuario UsuarioActual ; 
        public Loging()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=INF518;User ID=sa; Password=12345;");
        public void Logear(string usuario, string contraseña)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Tipo_Usuario FROM Usuarios WHERE Usuario = @usuario AND Password = @pas", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    // this.UsuarioActual = new Usuario();

                    // this.UsuarioActual.ID_Usuario = Convert.ToInt32(dt.Rows[0]["ID_Usuario"].ToString());
                    // this.UsuarioActual.Nombre = dt.Rows[0]["Nombre"].ToString();
                    //this.UsuarioActual.ID_Usuario = Convert.ToInt32(dt.Rows[0]["IdTipoUsuario"].ToString());
                    //Cursor.Current = Cursors.WaitCursor;
                    //for (int i = 1; i <= 100; i++)
                    //{
                    //    progressBar1.Value = i;
                    //    for (int x = 0; x < 10000000; x++) ; //HACE UN DELAY...

                    //}
                    //Cursor.Current = Cursors.Default;
                    //this.DialogResult = DialogResult.OK;
                    // this.Close();

                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                        {
                            datos = (dt.Rows[0][0].ToString());
                    ////   //new MainForm(dt.Rows[0][0].ToString()).Show();
                           MainForm.menuobj.cambiarContraseñaToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.LogingToolStripMenuItem.Dispose();
                            MainForm.menuobj.sistemaToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.actualizarPerfilToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.cambiarDeUsuarioToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.MantenimientoToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.consultasToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.reportesToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.utilitriosToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.ayudaToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.cambiarDeUsuarioToolStripMenuItem.Enabled = true;
                     }
                     else if (dt.Rows[0][1].ToString() == "Registro")
                     {
                    //   // new MainForm(dt.Rows[0][0].ToString()).Show();
                            MainForm.menuobj.cambiarContraseñaToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.LogingToolStripMenuItem.Dispose();
                            MainForm.menuobj.sistemaToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.actualizarPerfilToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.cambiarDeUsuarioToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.MantenimientoToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.consultasToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.reportesToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.utilitriosToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.ayudaToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.pagosToolStripMenuItem.Enabled = false;
                      }
                        else if (dt.Rows[0][1].ToString() == "cajero")
                        {
                            MainForm.menuobj.cambiarContraseñaToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.LogingToolStripMenuItem.Dispose();
                            MainForm.menuobj.sistemaToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.cambiarDeUsuarioToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.MantenimientoToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.estudianteToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.profesorToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.semestreToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.asignaturaToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.centroToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.aulaToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.carreraToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.inscripciónToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.conceptosToolStripMenuItem.Enabled = false;
                            MainForm.menuobj.consultasToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.ayudaToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.cambiarDeUsuarioToolStripMenuItem.Enabled = true;
                            MainForm.menuobj.consultasToolStripMenuItem.Enabled = false;
                    }

                }
                else {
                    MessageBox.Show("Usuaruio y/o Contraseña Incorecta");
                }
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }finally
            {
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Logear(this.textBox1.Text, this.textBox2.Text);
            frmCambiar_Contraseña us = new frmCambiar_Contraseña();
            us.lblUsuario.Text = textBox1.Text;
        }

    }
}
