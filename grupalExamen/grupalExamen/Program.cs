using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupalExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Producto> productos = new List<Producto>
        {
            new ProductoTela("Polo", 12f, 100, "M", "Algodón", "Azul"),
            new ProductoTela("Vestido", 25f, 50, "S", "Seda", "Rojo"),
            new ProductoTela("Pantalones", 15f, 75, "L", "Algodon", "Negro"),
            new ProductoArcilla("Maceta", 20f, 60, 500, "Pequeña", "Gris"),
            new ProductoArcilla("Taza", 25f, 90, 250, "Mediana", "Blanco"),
            new ProductoArcilla("Jarrón", 50f, 30, 750, "Grande", "Verde")
        };
            CarritoDeCompras carrito = new CarritoDeCompras();
            while (true)
            {
                Console.WriteLine("¿Qué quieres hacer?");
                Console.WriteLine("1. Agregar producto al carrito");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar la compra");
                Console.WriteLine("4. Salir");
                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            MostrarListaProductos(productos);
                            Console.WriteLine("Seleccione un producto por número:");
                            if (int.TryParse(Console.ReadLine(), out int seleccion))
                            {
                                if (seleccion >= 1 && seleccion <= productos.Count)
                                {
                                    Producto productoSeleccionado = productos[seleccion - 1];
                                    Console.WriteLine($"Características del producto: {productoSeleccionado.ObtenerCaracteristicas()}");
                                    Console.WriteLine($"Precio: {productoSeleccionado.ObtenerPrecio()}");

                                    Console.WriteLine("¿Desea añadirlo al carrito? (Si/No)");
                                    string respuesta = Console.ReadLine().Trim().ToLower();
                                    if (respuesta == "si")
                                    {
                                        carrito.AgregarProducto(productoSeleccionado);
                                        Console.WriteLine("Producto añadido al carrito.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Selección no válida.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida.");
                            }
                            break;

                        case 2:
                            carrito.MostrarContenido();
                            break;

                        case 3:
                            carrito.MostrarContenido();
                            Console.WriteLine("¡Gracias por su compra!");
                            carrito.VaciarCarrito();
                            break;

                        case 4:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida.");
                }
            }
        }
        static void MostrarListaProductos(List<Producto> productos)
        {
            Console.WriteLine("Lista de productos:");
            for (int i = 0; i < productos.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {productos[i].Nombre}");
            }
        }
    }
}
