using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    public class GestorProductos
    {
        private Dictionary<string, Producto> productos_registrados;

        public GestorProductos(Dictionary<string, Producto> productos_registrados)
        {
            this.productos_registrados = productos_registrados;
        }
        public Dictionary<string, Producto> ProductosRegistrados
        {
            get { return productos_registrados; }
        }
        public void RegistrarProducto(string nombre, string descripcion, double precio, int cantidad_disponible)
        {
            // Verificar si ya existe un producto con un nombre similar
            string nombreNormalizado = nombre.ToLower(); // Convertir el nombre a minúsculas para una comparación insensible a mayúsculas y minúsculas
            if (productos_registrados.ContainsKey(nombreNormalizado))
            {
                // Si existe, actualizar la cantidad disponible del producto existente
                Producto productoExistente = productos_registrados[nombreNormalizado];
                productoExistente.Cantidad_Disponible += cantidad_disponible;
            }
            else
            {
                // Si no existe, agregar un nuevo producto
                Producto nuevoProducto = new Producto(nombre, descripcion, precio, cantidad_disponible);
                productos_registrados.Add(nombreNormalizado, nuevoProducto);
            }

            // Mostrar un mensaje o notificación de éxito
            MessageBox.Show("Producto registrado exitosamente.");
        }

    }
}