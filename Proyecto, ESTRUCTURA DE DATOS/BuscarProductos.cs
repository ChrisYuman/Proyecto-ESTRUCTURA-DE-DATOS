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
        private GestorProductos productos_registrados;
        public BuscarProductos()
        {
            this.productos_registrados = GestorProductos.Instancia;
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Pagina_principal principal = new Pagina_principal();
            principal.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Producto> productos_filtrados = productos_registrados.BuscarPorCategoria(txtCategoria.Text);
            MostrarProductosPorCategoria(productos_filtrados);
        }

        private void MostrarProductosPorCategoria(List<Producto> productos)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if(dataGridView1.ColumnCount == 0)
            {
                dataGridView1.Columns.Add("Nombre", "Nombre");
                dataGridView1.Columns.Add("Categoria", "Categoria");
                dataGridView1.Columns.Add("Descripcion", "Descripcion");
                var precioColumn = new DataGridViewTextBoxColumn();
                precioColumn.Name = "Precio";
                precioColumn.HeaderText = "Precio";
                precioColumn.DefaultCellStyle.Format = "F2";
                dataGridView1.Columns.Add(precioColumn);
                dataGridView1.Columns.Add("Cantidad", "Cantidad");
            }
            foreach(var producto in productos)
            {
                dataGridView1.Rows.Add(producto.Nombre, producto.Categoria, producto.Descripcion, producto.Precio, producto.Cantidad_Disponible);
            }
        }
    }
}
