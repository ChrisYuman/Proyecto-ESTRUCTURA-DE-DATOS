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
        private const int UmbralCritico = 10;

        private static GestorProductos instancia;

        private Dictionary<string, Producto> productos_registrados;

        private GestorProductos()
        {
            productos_registrados =  new Dictionary<string, Producto>();
        }
        public static GestorProductos Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new GestorProductos();
                }
                return instancia;
            }
        }
        public Dictionary<string, Producto> ProductosRegistrados
        {
            get { return productos_registrados; }
        }
        public void RegistrarProducto(string nombre, string categoria, string descripcion, double precio, int cantidad_disponible)
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
                Producto nuevoProducto = new Producto(nombre, categoria, descripcion, precio, cantidad_disponible);
                productos_registrados.Add(nombreNormalizado, nuevoProducto);

                if (cantidad_disponible <= UmbralCritico)
                {
                    // Enviar notificación
                    Notificador.InformarNivelCritico(nombre, cantidad_disponible);
                }
            }

            // Mostrar un mensaje o notificación de éxito
            MessageBox.Show("Producto registrado exitosamente.");
        }
        public Producto BuscarPorNombre(string nombre)
        {
            foreach(var producto in productos_registrados.Values)
            {
                if(producto.Nombre == nombre)
                {
                    return producto;
                }
            }
            return null;
        }

        public List<Producto> BuscarPorCategoria(string categoria)
        {
            List<Producto> productos_filtrados = new List<Producto>();
            foreach (var producto in productos_registrados.Values)
            {
                if (producto.Categoria == categoria)
                {
                    productos_filtrados.Add(producto);
                }
            }
            return productos_filtrados;
        }

        public void ActualizarProducts(string nombre, string categoria, string descripcion, double precio, int cantidad)
        {
            Producto producto_existente = BuscarPorNombre(nombre);
            if (producto_existente != null)
            {
                producto_existente.Categoria = categoria;
                producto_existente.Descripcion = descripcion;
                producto_existente.Precio = precio;
                producto_existente.Cantidad_Disponible = cantidad;

                if (cantidad < UmbralCritico)
                {
                    Notificador.InformarNivelCritico(nombre, cantidad);
                }

                MessageBox.Show("Producto Actualizado Correctamente");
            }
            else
            {
                MessageBox.Show("No existe el producto");
            }
        }
    }
}