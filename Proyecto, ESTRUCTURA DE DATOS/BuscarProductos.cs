using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    public partial class BuscarProductos : Form
    {
        private GestorProductos productos_registrados = new GestorProductos();
        public BuscarProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            Producto producto_a_buscar = productos_registrados.BuscarPorNombre(nombre);
            if (producto_a_buscar != null)
            {
                txtCategoria.Text = producto_a_buscar.Descripcion;
                txtPrecio.Text = producto_a_buscar.Precio.ToString();
                txtCantidad.Text = producto_a_buscar.Cantidad_Disponible.ToString();
            }
            else
            {
                MessageBox.Show("No existe el producto a buscar");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pagina_principal principal = new Pagina_principal();
            principal.Show();
            this.Close();
        }
    }
}
