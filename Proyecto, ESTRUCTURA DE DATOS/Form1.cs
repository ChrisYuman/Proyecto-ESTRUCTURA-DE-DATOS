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

        private Dictionary<string, string> usuariosRegistrados = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            usuariosRegistrados.Add("admin", "12345");
            usuariosRegistrados.Add("usuario1", "contraseña1");
            usuariosRegistrados.Add("usuario2", "contraseña2");
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (ValidarCredenciales(usuario, contraseña))
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
        private bool ValidarCredenciales(string usuario, string contraseña)
        {
            if (usuariosRegistrados.ContainsKey(usuario))
            {
                return usuariosRegistrados[usuario] == contraseña;
            }
            return false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistroForm registroForm = new RegistroForm();
            if (registroForm.ShowDialog() == DialogResult.OK)
            {
                string nuevoUsuario = registroForm.NuevoUsuario;
                string nuevaContraseña = registroForm.NuevaContraseña;

                if (usuariosRegistrados.ContainsKey(nuevoUsuario))
                {
                    MessageBox.Show("El usuario ya existe. Por favor, elige otro nombre de usuario.");
                    return;
                }

                // Agregar el nuevo usuario y contraseña al diccionario de usuarios registrados
                usuariosRegistrados.Add(nuevoUsuario, nuevaContraseña);
                MessageBox.Show("Usuario registrado exitosamente.");
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
    }
}
}
