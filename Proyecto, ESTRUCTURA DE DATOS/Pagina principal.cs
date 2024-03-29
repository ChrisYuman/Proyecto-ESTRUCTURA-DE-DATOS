﻿using System;
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
    public partial class Pagina_principal : Form
    {
        private GestorProductos gestorProductos;

        public Pagina_principal()
        {
            InitializeComponent();
            gestorProductos = GestorProductos.Instancia;

            Notificador.Notificacion += ManejarNotificacion;

        }
        private void ManejarNotificacion(string mensaje)
        {
            MessageBox.Show(mensaje, "Notificación de inventario crítico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // Otra lógica para manejar la notificación, como escribir en un archivo de registro, enviar un correo electrónico, etc.
        }
        private void Pagina_principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mostrar el formulario de registro
                RegistrarProductos RegistrarProductos = new RegistrarProductos();
            RegistrarProductos.Show();
            //ocultar la pagina principal
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProductos buscar = new BuscarProductos();
            buscar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compra Compra = new Compra(gestorProductos);
            Compra.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actualizar Actualizar = new Actualizar();
            Actualizar.Show();
            this.Hide();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Actualizar_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
