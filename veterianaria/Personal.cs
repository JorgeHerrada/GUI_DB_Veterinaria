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
                conectandose.Desconectar();
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

            // inicializando boxes
            tbx_consulta_nombre.Enabled = true;
            tbx_consulta_codigo.Enabled = true;

            tbx_nombre.Enabled = false;
            tbx_apellido.Enabled = false;
            tbx_telefono.Enabled = false;
            tbx_direccion.Enabled = false;
            tbx_email.Enabled = false;
            tbx_puesto.Enabled = false;
            tbx_estudios.Enabled = false;
            tbx_antiguedad.Enabled = false;
            tbx_puesto.Enabled = false;
            tbx_horario.Enabled = false;
            tbx_salario.Enabled = false;

        }

        private void rbtn_CONSULTAR_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_CONSULTAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = true;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = false;
                tbx_apellido.Enabled = false;
                tbx_telefono.Enabled = false;
                tbx_direccion.Enabled = false;
                tbx_email.Enabled = false;
                tbx_puesto.Enabled = false;
                tbx_estudios.Enabled = false;
                tbx_antiguedad.Enabled = false;
                tbx_puesto.Enabled = false;
                tbx_horario.Enabled = false;
                tbx_salario.Enabled = false;
            }
        }

        private void rbtn_Eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Eliminar.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = false;
                tbx_apellido.Enabled = false;
                tbx_telefono.Enabled = false;
                tbx_direccion.Enabled = false;
                tbx_email.Enabled = false;
                tbx_puesto.Enabled = false;
                tbx_estudios.Enabled = false;
                tbx_antiguedad.Enabled = false;
                tbx_puesto.Enabled = false;
                tbx_horario.Enabled = false;
                tbx_salario.Enabled = false;
            }
        }

        private void rbtn_AGREGAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_AGREGAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = false;

                tbx_nombre.Enabled = true;
                tbx_apellido.Enabled = true;
                tbx_telefono.Enabled = true;
                tbx_direccion.Enabled = true;
                tbx_email.Enabled = true;
                tbx_puesto.Enabled = true;
                tbx_estudios.Enabled = true;
                tbx_antiguedad.Enabled = true;
                tbx_puesto.Enabled = true;
                tbx_horario.Enabled = true;
                tbx_salario.Enabled = true;
            }
        }

        private void rbtn_MODIFICAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_MODIFICAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = true;
                tbx_apellido.Enabled = true;
                tbx_telefono.Enabled = true;
                tbx_direccion.Enabled = true;
                tbx_email.Enabled = true;
                tbx_puesto.Enabled = true;
                tbx_estudios.Enabled = true;
                tbx_antiguedad.Enabled = true;
                tbx_puesto.Enabled = true;
                tbx_horario.Enabled = true;
                tbx_salario.Enabled = true;
            }
        }

        private void btn_ELIMINAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Mandamos información de las cajas
            conectandose.Eliminar("personal", Convert.ToInt32(tbx_consulta_codigo.Text));

            // Actualización del DataGridView (OPCIONAL)
            dtgv_PERSONAL.DataSource = conectandose.Consultar("personal");

            // Limpieza de TextBox
            tbx_consulta_codigo.Text = "0";


            conectandose.Desconectar(); // Desconectamos de la DB
        }

        private void btn_MODIFICAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if (tbx_apellido.Text == "" || tbx_nombre.Text == "")
            {
                MessageBox.Show("Necesitas al menos un nombre.", "¡ERROR!");
                conectandose.Desconectar();
                return;
            }
            else if(tbx_consulta_codigo.Text == "0" || tbx_consulta_codigo.Text == "")
            {
                MessageBox.Show("Para modificar datos de PERSONAL necesitas el codigo del mismp.", "¡ERROR!");
                conectandose.Desconectar();
                return;
            }

            // Mandamos información de las cajas
            conectandose.Update_PERSONAL(
                Convert.ToInt32(tbx_consulta_codigo.Text),
                tbx_nombre.Text,
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
            tbx_consulta_codigo.Text = "0";
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
    }
}
