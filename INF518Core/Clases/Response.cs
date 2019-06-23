using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF518Core.Clases
{
    public class Response
    {
        public int ID { get; set; }
        public string Mensaje { get; set; }
        public Response()
        {
            ID = 0;
            Mensaje = string.Empty;
        }
    }
}