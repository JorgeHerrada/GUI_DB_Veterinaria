using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veterianaria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Cerrar sesión y salir.", "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(r == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_CLIENTES_Click(object sender, EventArgs e)
        {
            Clientes clientes_form = new Clientes();
            clientes_form.Show();
        }

        private void btn_MASCOTAS_Click(object sender, EventArgs e)
        {
            Mascotas mascotas_form = new Mascotas();
            mascotas_form.Show();
        }

        private void btn_PERSONAL_Click(object sender, EventArgs e)
        {
            Personal personal_form = new Personal();
            personal_form.Show();
        }

        private void btn_VISITAS_Click(object sender, EventArgs e)
        {
            Visitas visitas_form = new Visitas();
            visitas_form.Show();
        }

        private void btn_ARTICULOS_Click(object sender, EventArgs e)
        {
            Articulos articulos_form = new Articulos();
            articulos_form.Show();
        }

        private void btn_PROVEEDORES_Click(object sender, EventArgs e)
        {
            Proveedores proveedores_form = new Proveedores();
            proveedores_form.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_SERVICIOS_Click(object sender, EventArgs e)
        {
            Servicios servicios_form = new Servicios();
            servicios_form.Show();
        }
    }
}
