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
    public partial class RegistroForm : Form
    {
        public string NuevoUsuario { get; private set; }
        public string NuevaContraseña { get; private set; }
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            NuevoUsuario = txtNuevoUsuario.Text;
            NuevaContraseña = txtNuevaContraseña.Text;

            if (string.IsNullOrWhiteSpace(NuevoUsuario) || string.IsNullOrWhiteSpace(NuevaContraseña))
            {
                MessageBox.Show("Por favor, introduce un nombre de usuario y una contraseña válidos.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
