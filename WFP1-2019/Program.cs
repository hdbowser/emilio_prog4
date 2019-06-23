using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFP1_2019
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Loging login = new Loging();

            Application.Run(login);

            if(login.DialogResult == DialogResult.OK)
            {
                Application.Run(new MainForm(login.UsuarioActual));
            }

        }
    }
}
