using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grupalExamen
{
    class ProductoArcilla : Producto
    {
        public float Peso { get; set; }
        public string Tamaño { get; set; }
        public string Color { get; set; }
        public ProductoArcilla(string nombre, float precio, int stock, float peso, string tamaño, string color)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Peso = peso;
            Tamaño = tamaño;
            Color = color;
        }
        public override string ObtenerCaracteristicas()
        {
            return $"Nombre: {Nombre}, Peso: {Peso} gramos, Tamaño: {Tamaño}, Color: {Color}";
        }
    }
}
