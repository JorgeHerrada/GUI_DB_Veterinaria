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
    public partial class Proveedores : Form
    {
        Conexion_PostgreSQL conectandose = new Conexion_PostgreSQL();
        public Proveedores()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dtgv_PROVEEDORES.DataSource = conectandose.Consultar("proveedores");
            conectandose.Desconectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_consulta_codigo.Text != "")
            {
                conectandose.Conectar();
                dtgv_PROVEEDORES.DataSource = conectandose.Consultar_Codigo("proveedores", tbx_consulta_codigo.Text);
                conectandose.Desconectar();
                return;
            }
            else if (tbx_consulta_nombre.Text != "")
            {
                conectandose.Conectar();
                dtgv_PROVEEDORES.DataSource = conectandose.Consultar_Nombre("proveedores", tbx_consulta_nombre.Text);
                conectandose.Desconectar();
                return;
            }
            else
            {
                conectandose.Conectar();
                dtgv_PROVEEDORES.DataSource = conectandose.Consultar("proveedores");
                conectandose.Desconectar();
            }
        }

        private void tbx_AGREGAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if (tbx_telefono.Text == "" || tbx_nombre.Text == "")
            {
                MessageBox.Show("Necesitas al menos un nombre y un telefono.", "¡ERROR!");
                conectandose.Desconectar();
                return;
            }

            // Mandamos información de las cajas
            conectandose.Insertar_PROVEEDORES(
                tbx_nombre.Text,
                tbx_direccion.Text,
                tbx_telefono.Text,
                tbx_email.Text
                );

            // Actualización del DataGridView (OPCIONAL)
            dtgv_PROVEEDORES.DataSource = conectandose.Consultar("proveedores");

            // Limpieza de TextBox
            tbx_nombre.Text = "";
            tbx_telefono.Text = "";
            tbx_direccion.Text = "";
            tbx_email.Text = "";

            conectandose.Desconectar(); // Desconectamos de la DB
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            // inicializando DataGridView
            conectandose.Conectar();
            dtgv_PROVEEDORES.DataSource = conectandose.Consultar("proveedores");
            conectandose.Desconectar();

            // inicializando boxes
            tbx_consulta_nombre.Enabled = true;
            tbx_consulta_codigo.Enabled = true;

            tbx_nombre.Enabled = false;
            tbx_telefono.Enabled = false;
            tbx_direccion.Enabled = false;
            tbx_email.Enabled = false;
        }

        private void rbtn_CONSULTAR_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_CONSULTAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = true;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = false;
                tbx_telefono.Enabled = false;
                tbx_direccion.Enabled = false;
                tbx_email.Enabled = false;
            }
        }

        private void rbtn_Eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Eliminar.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = false;
                tbx_telefono.Enabled = false;
                tbx_direccion.Enabled = false;
                tbx_email.Enabled = false;
            }
        }

        private void rbtn_AGREGAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_AGREGAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = false;

                tbx_nombre.Enabled = true;
                tbx_telefono.Enabled = true;
                tbx_direccion.Enabled = true;
                tbx_email.Enabled = true;
            }
        }

        private void rbtn_MODIFICAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_AGREGAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = true;
                tbx_telefono.Enabled = true;
                tbx_direccion.Enabled = true;
                tbx_email.Enabled = true;
            }
        }

        private void btn_ELIMINAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Mandamos información de las cajas
            conectandose.Eliminar("proveedores", Convert.ToInt32(tbx_consulta_codigo.Text));

            // Actualización del DataGridView (OPCIONAL)
            dtgv_PROVEEDORES.DataSource = conectandose.Consultar("proveedores");

            // Limpieza de TextBox
            tbx_consulta_codigo.Text = "0";


            conectandose.Desconectar(); // Desconectamos de la DB
        }

        private void btn_MODIFICAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if (tbx_telefono.Text == "" || tbx_nombre.Text == "")
            {
                MessageBox.Show("Necesitas al menos un nombre y un telefono.", "¡ERROR!");
                conectandose.Desconectar();
                return;
            }
            else if (tbx_consulta_codigo.Text == "0" || tbx_consulta_codigo.Text == "")
            {
                MessageBox.Show("Para modificar datos del PROVEEDOR necesitas el codigo del mismo.", "¡ERROR!");
                conectandose.Desconectar();
                return;
            }

            // Mandamos información de las cajas
            conectandose.Update_PROVEEDORES(
                Convert.ToInt32(tbx_consulta_codigo.Text),
                tbx_nombre.Text,
                tbx_direccion.Text,
                tbx_telefono.Text,
                tbx_email.Text
                );

            // Actualización del DataGridView (OPCIONAL)
            dtgv_PROVEEDORES.DataSource = conectandose.Consultar("proveedores");

            // Limpieza de TextBox
            tbx_consulta_codigo.Text = "0";
            tbx_nombre.Text = "";
            tbx_telefono.Text = "";
            tbx_direccion.Text = "";
            tbx_email.Text = "";

            conectandose.Desconectar(); // Desconectamos de la DB
        }
    }
}
