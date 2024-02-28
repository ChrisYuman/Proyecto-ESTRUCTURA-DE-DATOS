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
    public partial class Compra : Form
    {
        private GestorProductos gestorProductos;

        public Compra(GestorProductos gestorProductos)
        {
            InitializeComponent();
            this.gestorProductos = gestorProductos;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            int cantidad;

            // Verificar si la cantidad ingresada es un número válido
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el producto está registrado
            if (gestorProductos.ProductosRegistrados.ContainsKey(nombreProducto.ToLower()))
            {
                // Actualizar la cantidad disponible del producto
                Producto producto = gestorProductos.ProductosRegistrados[nombreProducto.ToLower()];
                producto.Cantidad_Disponible += cantidad;

                // Mostrar mensaje de éxito
                MessageBox.Show($"Se han comprado {cantidad} unidades de {nombreProducto} correctamente.", "Compra Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El producto no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagina_principal principal = new Pagina_principal();
            principal.Show();
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            int cantidad;

            // Verificar si la cantidad ingresada es un número válido
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el producto está registrado
            if (gestorProductos.ProductosRegistrados.ContainsKey(nombreProducto.ToLower()))
            {
                // Verificar si hay suficiente cantidad disponible
                Producto producto = gestorProductos.ProductosRegistrados[nombreProducto.ToLower()];
                if (producto.Cantidad_Disponible < cantidad)
                {
                    MessageBox.Show($"No hay suficientes unidades de {nombreProducto} en inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Actualizar la cantidad disponible del producto
                producto.Cantidad_Disponible -= cantidad;

                // Mostrar mensaje de éxito
                MessageBox.Show($"Se han vendido {cantidad} unidades de {nombreProducto} correctamente.", "Venta Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El producto no está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
