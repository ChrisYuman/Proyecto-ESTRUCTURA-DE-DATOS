using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    public partial class RegistrarProductos : Form
    {

        public GestorProductos products = new GestorProductos();
        public RegistrarProductos()
        {

            InitializeComponent();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string nombre = txtNombreProducto.Text;
            string descripcion = txtDescripcion.Text;
            double precio = Convert.ToDouble(txtPrecio.Text); // Asegúrate de manejar errores de conversión
            int cantidad = Convert.ToInt32(txtCantidadDisponible.Text); // Asegúrate de manejar errores de conversión

            // Validar los datos ingresados (puedes agregar más validaciones según sea necesario)
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion) || precio <= 0 || cantidad <= 0)
            {
                MessageBox.Show("Por favor, complete todos los campos y asegúrese de que los valores sean válidos.");
                return;
            }

            // Registrar el producto utilizando el GestorProductos
            products.RegistrarProducto(nombre, descripcion, precio, cantidad);

            // Limpiar los cuadros de texto después del registro exitoso
            LimpiarCampos();

            // Mostrar mensaje de éxito
            MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Actualizar la lista de productos registrados
            CargarProductosRegistrados();
        }

        private void CargarProductosRegistrados()
        {
            // Limpiar el DataGridView
            dataGridViewProductos.Rows.Clear();
            dataGridViewProductos.Columns.Clear(); // Limpiar las columnas también

            // Agregar las columnas al DataGridView si aún no se han agregado
            if (dataGridViewProductos.ColumnCount == 0)
            {
                dataGridViewProductos.Columns.Add("Nombre", "Nombre");
                dataGridViewProductos.Columns.Add("Descripción", "Descripción");

                // Agregar la columna de Precio y configurar su formato
                var precioColumn = new DataGridViewTextBoxColumn();
                precioColumn.Name = "Precio";
                precioColumn.HeaderText = "Precio";
                precioColumn.DefaultCellStyle.Format = "F2";  // Formato de moneda
                dataGridViewProductos.Columns.Add(precioColumn);

                dataGridViewProductos.Columns.Add("Cantidad", "Cantidad");
            }

            // Obtener todos los productos del diccionario dentro de GestorProductos
            foreach (var productoEntry in gestorProductos.ProductosRegistrados)
            {
                Producto producto = productoEntry.Value;
                dataGridViewProductos.Rows.Add(producto.Nombre, producto.Descripcion, producto.Precio, producto.Cantidad_Disponible);
            }
        }

        private void LimpiarCampos()
        {
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidadDisponible.Text = "";
        }


        private void CargarProductosDesdeArchivo(string rutaArchivo)
        {
            try
            {
                // Leer todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaArchivo);

                // Procesar cada línea y agregar los productos
                foreach (string linea in lineas)
                {
                    // Dividir la línea en campos utilizando la coma como separador
                    string[] campos = linea.Split(',');

                    // Verificar si hay suficientes campos para crear un producto
                    if (campos.Length >= 4)
                    {
                        // Obtener los valores de los campos
                        string nombre = campos[0];
                        string descripcion = campos[1];
                        double precio = Convert.ToDouble(campos[2]);
                        int cantidad = Convert.ToInt32(campos[3]);

                        // Registrar el producto utilizando el GestorProductos
                        productos.RegistrarProducto(nombre, descripcion, precio, cantidad);
                    }
                }

                MessageBox.Show("Productos cargados correctamente desde el archivo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarArchivo_Click_1(object sender, EventArgs e)
        {
            // Mostrar el diálogo para seleccionar archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Texto|*.txt";
            openFileDialog.Title = "Seleccionar Archivo de Productos";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar los productos desde el archivo
                CargarProductosDesdeArchivo(openFileDialog.FileName);

                // Actualizar la lista de productos registrados
                CargarProductosRegistrados();
            }
        }
    }
}