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
    public partial class Actualizar : Form
    {
        private GestorProductos productos_registrados;
        public Actualizar()
        {
            InitializeComponent();
            this.productos_registrados = GestorProductos.Instancia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            Producto producto_a_buscar = productos_registrados.BuscarPorNombre(nombre);
            if (producto_a_buscar != null)
            {
                txtCategoria.Text = producto_a_buscar.Categoria.Trim();
                txtDescripcion.Text = producto_a_buscar.Descripcion;
                txtPrecio.Text = producto_a_buscar.Precio.ToString();
                txtCantidad.Text = producto_a_buscar.Cantidad_Disponible.ToString();
            }
            else
            {
                MessageBox.Show("No existe el producto a buscar");
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            productos_registrados.ActualizarProducts(txtNombre.Text, txtCategoria.Text, txtDescripcion.Text, Double.Parse(txtPrecio.Text), Int32.Parse(txtCantidad.Text));
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Pagina_principal principal = new Pagina_principal();
            principal.Show();
            this.Close();
        }
    }
}
