using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    public class GestorProductos
    {
        private Dictionary<string, Producto> productos_registrados;

        public GestorProductos(Dictionary<string, Producto> productos_registrados)
        {
            this.productos_registrados = productos_registrados;
        }


    }
}
