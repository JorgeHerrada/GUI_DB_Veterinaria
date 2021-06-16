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
    }
}
