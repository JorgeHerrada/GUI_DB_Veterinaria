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
    public partial class Personal : Form
    {
        Conexion_PostgreSQL conectandose = new Conexion_PostgreSQL();
        public Personal()
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
            dtgv_PERSONAL.DataSource = conectandose.Consultar("personal");
            conectandose.Desconectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_consulta_codigo.Text != "")
            {
                conectandose.Conectar();
                dtgv_PERSONAL.DataSource = conectandose.Consultar_Codigo("personal", tbx_consulta_codigo.Text);
                conectandose.Desconectar();
                return;
            }
            else if (tbx_consulta_nombre.Text != "")
            {
                conectandose.Conectar();
                dtgv_PERSONAL.DataSource = conectandose.Consultar_Nombre("personal", tbx_consulta_nombre.Text);
                conectandose.Desconectar();
                return;
            }
            else
            {
                conectandose.Conectar();
                dtgv_PERSONAL.DataSource = conectandose.Consultar("personal");
                conectandose.Desconectar();
            }
        }

        private void btn_AGREGAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if (tbx_apellido.Text == "" || tbx_nombre.Text == "" )
            {
                MessageBox.Show("Necesitas al menos un nombre.", "¡ERROR!");
                return;
            }

            // Mandamos información de las cajas
            conectandose.Insertar_PERSONAL(tbx_nombre.Text,
                tbx_apellido.Text, tbx_telefono.Text,
                tbx_direccion.Text, tbx_email.Text,
                tbx_puesto.Text, tbx_estudios.Text,
                Convert.ToInt32(tbx_antiguedad.Text),
                tbx_horario.Text, 
                Convert.ToDouble(tbx_salario.Text)
                );

            // Actualización del DataGridView (OPCIONAL)
            dtgv_PERSONAL.DataSource = conectandose.Consultar("personal");

            // Limpieza de TextBox
            tbx_nombre.Text = "";
            tbx_apellido.Text = "";
            tbx_telefono.Text = "";
            tbx_direccion.Text = "";
            tbx_email.Text = "";
            tbx_puesto.Text = "";
            tbx_estudios.Text = "";
            tbx_antiguedad.Text = "0";
            tbx_horario.Text = "";
            tbx_salario.Text = "0";

            conectandose.Desconectar(); // Desconectamos de la DB
        }

        private void Personal_Load(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dtgv_PERSONAL.DataSource = conectandose.Consultar("personal");
            conectandose.Desconectar();
        }
    }
}
