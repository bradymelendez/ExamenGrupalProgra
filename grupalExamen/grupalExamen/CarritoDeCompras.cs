using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupalExamen
{
    class CarritoDeCompras
    {
        private List<Producto> productosEnCarrito = new List<Producto>();
        public void AgregarProducto(Producto producto)
        {
            productosEnCarrito.Add(producto);
        }
        public void MostrarContenido()
        {
            Console.WriteLine("Contenido del carrito:");
            foreach (var producto in productosEnCarrito)
            {
                Console.WriteLine($"- {producto.Nombre}: {producto.ObtenerPrecio()}");
            }
            Console.WriteLine($"Precio Total: {CalcularPrecioTotal()}");
        }
        public float CalcularPrecioTotal()
        {
            float total = 0;
            foreach (var producto in productosEnCarrito)
            {
                total += producto.ObtenerPrecio();
            }
            return total;
        }
        public void VaciarCarrito()
        {
            productosEnCarrito.Clear();
        }
    }
}
