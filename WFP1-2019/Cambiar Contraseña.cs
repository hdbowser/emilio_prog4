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
namespace WFP1_2019
{
    public partial class frmCambiar_Contraseña : Form
    {
        
        public frmCambiar_Contraseña()
        {
            InitializeComponent();
            
        }

        SqlConnection con = new SqlConnection(@"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=INF518;User ID=sa; Password=12345;");
        public void ActualizaContrasena(string usuario, string contraseña)
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
                    
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {


                    }

                }
                else
                {
                    MessageBox.Show("Usuaruio y/o Contraseña Incorecta");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void frmCambiar_Contraseña_Load(object sender, EventArgs e)
        {
            
        }
    }
}
