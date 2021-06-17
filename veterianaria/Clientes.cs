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
    public partial class Clientes : Form
    {
        Conexion_PostgreSQL conectandose = new Conexion_PostgreSQL();
        public Clientes()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dtgv_CLIENTES.DataSource = conectandose.Consultar("clientes");
            conectandose.Desconectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbx_consultar_codigo.Text != "")
            {
                conectandose.Conectar();
                dtgv_CLIENTES.DataSource = conectandose.Consultar_Codigo("clientes",tbx_consultar_codigo.Text);
                conectandose.Desconectar();
                return;
            }
            else if(tbx_consultar_nombre.Text != "")
            {
                conectandose.Conectar();
                dtgv_CLIENTES.DataSource = conectandose.Consultar_Nombre("clientes",tbx_consultar_nombre.Text);
                conectandose.Desconectar();
                return;
            }
            else
            {
                conectandose.Conectar();
                dtgv_CLIENTES.DataSource = conectandose.Consultar("clientes");
                conectandose.Desconectar();
            }
        }

        private void btn_AGREGAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if(tbx_apellido.Text == "" || tbx_nombre.Text == "" )
            {
                MessageBox.Show("Necesitas al menos un nombre y un apellido.", "¡ERROR!");
                return;
            }

            // Mandamos información de las cajas
            conectandose.Insertar_CLIENTES(tbx_nombre.Text, 
                tbx_apellido.Text, tbx_telefono.Text, 
                tbx_email.Text, tbx_direccion.Text);

            // Actualización del DataGridView (OPCIONAL)
            dtgv_CLIENTES.DataSource = conectandose.Consultar("clientes");

            // Limpieza de TextBox
            tbx_nombre.Text = "";
            tbx_apellido.Text = "";
            tbx_telefono.Text = "";
            tbx_email.Text = "";
            tbx_direccion.Text = "";

            conectandose.Desconectar(); // Desconectamos de la DB
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dtgv_CLIENTES.DataSource = conectandose.Consultar("clientes");
            conectandose.Desconectar();
        }
    }
}
