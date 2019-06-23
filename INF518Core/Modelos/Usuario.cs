using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Modelos
{
    public class Usuario : MantenimientoBase
    {
        public int ID_Usuario  { get; set; }
        public string  Nombre { get; set; }
        public string  usuario { get; set; }
        public string Password  { get; set; }
        public string  Tipo_Usuario { get; set; }
        public int  IdTipoUsuario { get; set; }
        public string  Permisos { get; set; }
        public string Observaciones { get; set; }
        public bool Inactivo { get; set; }
        
    }
}
