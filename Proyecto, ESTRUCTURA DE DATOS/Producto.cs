using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    public class Producto
    {
        public string Nombre {  get; set; }
        public string Descripcion {  get; set; }
        public double Precio { get; set; }
        public int Cantidad_Disponible {  get; set; }
        
        public Producto(string nombre, string descripcion, double precio, int cantidad_disponible)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Precio = precio;
            Cantidad_Disponible = cantidad_disponible;
        }
    }
}
