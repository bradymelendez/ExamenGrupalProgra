using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupalExamen
{
    class Producto
    {
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Stock { get; set; }
        public virtual string ObtenerCaracteristicas()
        {
            return "";
        }
        public float ObtenerPrecio()
        {
            return Precio;
        }
    }
}