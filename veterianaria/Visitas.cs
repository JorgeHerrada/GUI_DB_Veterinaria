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
    public partial class Visitas : Form
    {
        Conexion_PostgreSQL conectandose = new Conexion_PostgreSQL();
        public Visitas()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // NO CODE
        }

        private void Visitas_Load(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dtgv_VISITAS.DataSource = conectandose.Consultar("visitas");
            conectandose.Desconectar();

            // Ajuste de los TimePickers
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/mm/yyyy HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/mm/yyyy HH:mm";

            // Inicializando TextBoxes
                tbx_consulta_codigo.Enabled = true;
                tbx_consulta_nombre_mascota.Enabled = true;
                tbx_codigo_cliente.Enabled = false;
                tbx_codigo_servicio.Enabled = false;
                tbx_codigo_mascota.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dtgv_VISITAS.DataSource = conectandose.Consultar("visitas");
            conectandose.Desconectar();
        }

        private void tbn_CONSULTAR_Click(object sender, EventArgs e)
        {
            if (tbx_consulta_codigo.Text != "")
            {
                conectandose.Conectar();
                dtgv_VISITAS.DataSource = conectandose.Consultar_Codigo("mascotas", tbx_consulta_codigo.Text);
                conectandose.Desconectar();
                return;
            }
            else if (tbx_consulta_nombre_mascota.Text != "")
            {
                conectandose.Conectar();
                dtgv_VISITAS.DataSource = conectandose.Consultar_Nombre_Mascota(tbx_consulta_nombre_mascota.Text);
                conectandose.Desconectar();
                return;
            }
            else
            {
                conectandose.Conectar();
                dtgv_VISITAS.DataSource = conectandose.Consultar("mascotas");
                conectandose.Desconectar();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if (tbx_codigo_mascota.Text == "" || tbx_codigo_mascota.Text == "0")
            {
                MessageBox.Show("Necesitas al menos el codigo de la mascota.", "¡ERROR!");
                return;
            }

            // Mandamos información de las cajas
            conectandose.Insertar_VISITAS(
                Convert.ToInt32(tbx_codigo_servicio.Text),
                Convert.ToInt32(tbx_codigo_mascota.Text),
                Convert.ToInt32(tbx_codigo_cliente.Text),
                dateTimePicker1.Text,
                dateTimePicker2.Text
                );

            // Actualización del DataGridView (OPCIONAL)
            dtgv_VISITAS.DataSource = conectandose.Consultar("visitas");

            // Limpieza de TextBox
            tbx_codigo_servicio.Text = "0";
            tbx_codigo_mascota.Text = "0";
            tbx_codigo_cliente.Text = "0";

            conectandose.Desconectar(); // Desconectamos de la DB
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // NO CODE
        }

        private void rbtn_CONSULTAR_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_CONSULTAR.Checked == true)
            {
                tbx_consulta_codigo.Enabled = true;
                tbx_consulta_nombre_mascota.Enabled = true;

                tbx_codigo_cliente.Enabled = false;
                tbx_codigo_servicio.Enabled = false;
                tbx_codigo_mascota.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void rbtn_Eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Eliminar.Checked == true)
            {
                tbx_consulta_codigo.Enabled = true;
                tbx_consulta_nombre_mascota.Enabled = false;

                tbx_codigo_cliente.Enabled = false;
                tbx_codigo_servicio.Enabled = false;
                tbx_codigo_mascota.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void rbtn_AGREGAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_AGREGAR.Checked == true)
            {
                tbx_consulta_codigo.Enabled = false;
                tbx_consulta_nombre_mascota.Enabled = false;

                tbx_codigo_cliente.Enabled = true;
                tbx_codigo_servicio.Enabled = true;
                tbx_codigo_mascota.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
        }

        private void rbtn_MODIFICAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_MODIFICAR.Checked == true)
            {
                tbx_consulta_codigo.Enabled = true;
                tbx_consulta_nombre_mascota.Enabled = false;

                tbx_codigo_cliente.Enabled = true;
                tbx_codigo_servicio.Enabled = true;
                tbx_codigo_mascota.Enabled = true;
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
        }
    }
}
