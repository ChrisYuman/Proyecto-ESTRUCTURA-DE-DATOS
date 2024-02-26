using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__ESTRUCTURA_DE_DATOS
{
    public class GestorUsuario
    {
        private Dictionary<string, Usuario> usuarios_registrados;

        public GestorUsuario()
        {
            this.usuarios_registrados = new Dictionary<string, Usuario>();
        }   

        public void RegistrarUsuario(string nombre, string usuario, string password)
        {
            if (usuarios_registrados.ContainsKey(usuario))
            {
                MessageBox.Show("El usuario ya existe. Intente con otro nombre de usuario");
                return;
            }

            Usuario nuevo_user = new Usuario(nombre, usuario, password);
            usuarios_registrados.Add(usuario, nuevo_user);
            MessageBox.Show("Usuario Registrado Exitosamente");
        }
        public bool VerificarCredenciales(string usuario, string password)
        {
            if(usuarios_registrados.TryGetValue(usuario, out Usuario user))
            {
                return user.Password == password;
            }
            return false;
        }
    }
}
