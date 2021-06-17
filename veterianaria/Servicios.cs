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
    public partial class Servicios : Form
    {
        Conexion_PostgreSQL conectandose = new Conexion_PostgreSQL();
        public Servicios()
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
            dtgv_SERVICIOS.DataSource = conectandose.Consultar("servicios");
            conectandose.Desconectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_consulta_codigo.Text != "")
            {
                conectandose.Conectar();
                dtgv_SERVICIOS.DataSource = conectandose.Consultar_Codigo("servicios", tbx_consulta_codigo.Text);
                conectandose.Desconectar();
                return;
            }
            else if (tbx_consulta_nombre.Text != "")
            {
                conectandose.Conectar();
                dtgv_SERVICIOS.DataSource = conectandose.Consultar_Nombre("servicios", tbx_consulta_nombre.Text);
                conectandose.Desconectar();
                return;
            }
            else
            {
                conectandose.Conectar();
                dtgv_SERVICIOS.DataSource = conectandose.Consultar("servicios");
                conectandose.Desconectar();
            }
        }

        private void btn_AGREGAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if (tbx_nombre.Text == "")
            {
                MessageBox.Show("Necesitas al menos un tip de servicio.", "¡ERROR!");
                return;
            }

            // Mandamos información de las cajas
            conectandose.Insertar_SERVICIOS(
                Convert.ToInt32(tbx_codigo_empleado.Text),
                Convert.ToInt32(tbx_precio.Text),
                tbx_nombre.Text
                );

            // Actualización del DataGridView (OPCIONAL)
            dtgv_SERVICIOS.DataSource = conectandose.Consultar("servicios");

            // Limpieza de TextBox
            tbx_codigo_empleado.Text = "0";
            tbx_precio.Text = "0";
            tbx_nombre.Text = "";

            conectandose.Desconectar(); // Desconectamos de la DB
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dtgv_SERVICIOS.DataSource = conectandose.Consultar("servicios");
            conectandose.Desconectar();

            // inicializando boxes
            tbx_consulta_nombre.Enabled = true;
            tbx_consulta_codigo.Enabled = true;

            tbx_nombre.Enabled = false;
            tbx_codigo_empleado.Enabled = false;
            tbx_precio.Enabled = false;
        }

        private void rbtn_CONSULTAR_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_CONSULTAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = true;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = false;
                tbx_codigo_empleado.Enabled = false;
                tbx_precio.Enabled = false;
            }
        }

        private void rbtn_Eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Eliminar.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = false;
                tbx_codigo_empleado.Enabled = false;
                tbx_precio.Enabled = false;
            }
        }

        private void rbtn_AGREGAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_AGREGAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = false;

                tbx_nombre.Enabled = true;
                tbx_codigo_empleado.Enabled = true;
                tbx_precio.Enabled = true;
            }
        }

        private void rbtn_MODIFICAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_MODIFICAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = true;
                tbx_codigo_empleado.Enabled = true;
                tbx_precio.Enabled = true;
            }
        }

        private void btn_ELIMINAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Mandamos información de las cajas
            conectandose.Eliminar("servicios", Convert.ToInt32(tbx_consulta_codigo.Text));

            // Actualización del DataGridView (OPCIONAL)
            dtgv_SERVICIOS.DataSource = conectandose.Consultar("servicios");

            // Limpieza de TextBox
            tbx_consulta_codigo.Text = "0";


            conectandose.Desconectar(); // Desconectamos de la DB
        }

        private void btn_MODIFICAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if (tbx_nombre.Text == "")
            {
                MessageBox.Show("Necesitas al menos un tip de servicio.", "¡ERROR!");
                return;
            }
            else if (tbx_consulta_codigo.Text == "0" || tbx_consulta_codigo.Text == "")
            {
                MessageBox.Show("Para modificar datos del SERVICIO necesitas el codigo del mismo.", "¡ERROR!");
                return;
            }

            // Mandamos información de las cajas
            conectandose.Update_SERVICIOS(
                Convert.ToInt32(tbx_consulta_codigo.Text),
                Convert.ToInt32(tbx_codigo_empleado.Text),
                Convert.ToInt32(tbx_precio.Text),
                tbx_nombre.Text
                );

            // Actualización del DataGridView (OPCIONAL)
            dtgv_SERVICIOS.DataSource = conectandose.Consultar("servicios");

            // Limpieza de TextBox
            tbx_consulta_codigo.Text = "0";
            tbx_codigo_empleado.Text = "0";
            tbx_precio.Text = "0";
            tbx_nombre.Text = "";

            conectandose.Desconectar(); // Desconectamos de la DB
        }
    }
}
