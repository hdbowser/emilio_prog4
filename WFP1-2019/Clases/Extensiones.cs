using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFP1_2019.Clases
{
    public static class Extensiones
    {
        public static int Entero(this decimal valor)
        {
            int r = 0;
            int.TryParse(valor.ToString(), out r);
            return r;
        }
    }

    //progressBar1.Value = numericUpDown1.Value.Entero();
    //trackBar1.Value = numericUpDown1.Value.Entero();
}
