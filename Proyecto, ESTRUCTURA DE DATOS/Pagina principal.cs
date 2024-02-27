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
    public partial class Pagina_principal : Form
    {
        public Pagina_principal()
        {
            InitializeComponent();
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
    }
}
