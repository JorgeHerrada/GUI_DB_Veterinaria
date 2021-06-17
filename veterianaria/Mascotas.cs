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
    public partial class Mascotas : Form
    {
        Conexion_PostgreSQL conectandose = new Conexion_PostgreSQL();
        public Mascotas()
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
            dtgv_MASCOTAS.DataSource = conectandose.Consultar("mascotas");
            conectandose.Desconectar();
        }

        private void CONSULTAR_Click(object sender, EventArgs e)
        {
            if (tbx_consultar_codigo.Text != "")
            {
                conectandose.Conectar();
                dtgv_MASCOTAS.DataSource = conectandose.Consultar_Codigo("mascotas", tbx_consultar_codigo.Text);
                conectandose.Desconectar();
                return;
            }
            else if (tbx_consultar_nombre.Text != "")
            {
                conectandose.Conectar();
                dtgv_MASCOTAS.DataSource = conectandose.Consultar_Nombre("mascotas", tbx_consultar_nombre.Text);
                conectandose.Desconectar();
                return;
            }
            else
            {
                conectandose.Conectar();
                dtgv_MASCOTAS.DataSource = conectandose.Consultar("mascotas");
                conectandose.Desconectar();
            }
        }

        private void btn_AGREGAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if (tbx_nombre.Text == "" || tbx_codigo_cliente.Text == "")
            {
                MessageBox.Show("Necesitas al menos un nombre y dueño.", "¡ERROR!");
                return;
            }

            // Mandamos información de las cajas
            conectandose.Insertar_MASCOTAS(
                Convert.ToInt32(tbx_codigo_cliente.Text),
                tbx_nombre.Text,tbx_raza.Text,
                tbx_especie.Text, 
                Convert.ToInt32(tbx_edad.Text),
                Convert.ToDouble(tbx_peso.Text)
                );

            // Actualización del DataGridView (OPCIONAL)
            dtgv_MASCOTAS.DataSource = conectandose.Consultar("mascotas");

            // Limpieza de TextBox
            tbx_nombre.Text = "";
            tbx_codigo_cliente.Text = "";
            tbx_raza.Text = "";
            tbx_especie.Text = "";
            tbx_edad.Text = "0";
            tbx_peso.Text = "0";

            conectandose.Desconectar(); // Desconectamos de la DB
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //NO CODE
        }

        private void Mascotas_Load(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dtgv_MASCOTAS.DataSource = conectandose.Consultar("mascotas");
            conectandose.Desconectar();

            // inicializando textboxes
            tbx_consultar_nombre.Enabled = true;
            tbx_consultar_codigo.Enabled = true;

            tbx_nombre.Enabled = false;
            tbx_especie.Enabled = false;
            tbx_codigo_cliente.Enabled = false;
            tbx_raza.Enabled = false;
            tbx_peso.Enabled = false;
            tbx_edad.Enabled = false;

        }

        private void rbtn_CONSULTAR_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_CONSULTAR.Checked == true)
            {
                tbx_consultar_nombre.Enabled = true;
                tbx_consultar_codigo.Enabled = true;

                tbx_nombre.Enabled = false;
                tbx_especie.Enabled = false;
                tbx_codigo_cliente.Enabled = false;
                tbx_raza.Enabled = false;
                tbx_peso.Enabled = false;
                tbx_edad.Enabled = false;
            }
        }

        private void rbtn_Eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Eliminar.Checked == true)
            {
                tbx_consultar_nombre.Enabled = false;
                tbx_consultar_codigo.Enabled = true;

                tbx_nombre.Enabled = false;
                tbx_especie.Enabled = false;
                tbx_codigo_cliente.Enabled = false;
                tbx_raza.Enabled = false;
                tbx_peso.Enabled = false;
                tbx_edad.Enabled = false;
            }
        }

        private void rbtn_AGREGAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_AGREGAR.Checked == true)
            {
                tbx_consultar_nombre.Enabled = false;
                tbx_consultar_codigo.Enabled = false;

                tbx_nombre.Enabled = true;
                tbx_especie.Enabled = true;
                tbx_codigo_cliente.Enabled = true;
                tbx_raza.Enabled = true;
                tbx_peso.Enabled = true;
                tbx_edad.Enabled = true;
            }
        }

        private void rbtn_MODIFICAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_MODIFICAR.Checked == true)
            {
                tbx_consultar_nombre.Enabled = false;
                tbx_consultar_codigo.Enabled = true;

                tbx_nombre.Enabled = true;
                tbx_especie.Enabled = true;
                tbx_codigo_cliente.Enabled = true;
                tbx_raza.Enabled = true;
                tbx_peso.Enabled = true;
                tbx_edad.Enabled = true;
            }
        }
    }
}
