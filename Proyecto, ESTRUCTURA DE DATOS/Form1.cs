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
    public partial class Form1 : Form
    {
        RegistroForm registroForm = new RegistroForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (registroForm.users.VerificarCredenciales(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso");
                // Cambiar a la nueva pantalla o formulario después del inicio de sesión exitoso
                Pagina_principal pagina_Principal = new Pagina_principal();
                pagina_Principal.Show();
                this.Hide(); // Ocultar el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Inténtalo de nuevo.");
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (registroForm.ShowDialog() == DialogResult.OK)
            {
                // Agregar el nuevo usuario y contraseña al diccionario de usuarios registrados
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
