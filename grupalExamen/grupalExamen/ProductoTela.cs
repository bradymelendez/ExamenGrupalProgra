using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupalExamen
{
    class ProductoTela : Producto
    {
        public string Tamaño { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public ProductoTela(string nombre, float precio, int stock, string tamaño, string material, string color)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Tamaño = tamaño;
            Material = material;
            Color = color;
        }
        public override string ObtenerCaracteristicas()
        {
            return $"Nombre: {Nombre}, Tamaño: {Tamaño}, Material: {Material}, Color: {Color}";
        }
    }
}
