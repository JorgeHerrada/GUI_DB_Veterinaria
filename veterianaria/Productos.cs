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
    public partial class Productos : Form
    {
        Conexion_PostgreSQL conectandose = new Conexion_PostgreSQL();
        public Productos()
        {
            InitializeComponent();
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dtgv_PRODUCTOS.DataSource = conectandose.Consultar("productos");
            conectandose.Desconectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbx_consulta_codigo.Text != "")
            {
                conectandose.Conectar();
                dtgv_PRODUCTOS.DataSource = conectandose.Consultar_Codigo("productos", tbx_consulta_codigo.Text);
                conectandose.Desconectar();
                return;
            }
            else if (tbx_consulta_nombre.Text != "")
            {
                conectandose.Conectar();
                dtgv_PRODUCTOS.DataSource = conectandose.Consultar_Nombre("productos", tbx_consulta_nombre.Text);
                conectandose.Desconectar();
                return;
            }
            else
            {
                conectandose.Conectar();
                dtgv_PRODUCTOS.DataSource = conectandose.Consultar("productos");
                conectandose.Desconectar();
            }

            // LIMPIANDO DATABOXES
            tbx_consulta_nombre.Text = "";
            tbx_consulta_codigo.Text = "0";
        }

        private void btn_AGREGAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if (tbx_precio_venta.Text == "" || tbx_nombre.Text == "")
            {
                MessageBox.Show("Necesitas al menos el nombre y precio de venta.", "¡ERROR!");
                conectandose.Desconectar();
                return;
            }

            // Mandamos información de las cajas
            conectandose.Insertar_PRODUCTOS(
                Convert.ToInt32(tbx_proveedor.Text),
                Convert.ToInt32(tbx_servicio.Text),
                tbx_nombre.Text,
                Convert.ToInt32(tbx_precio_venta.Text),
                Convert.ToInt32(tbx_precio_compra.Text),
                Convert.ToInt32(tbx_existencias.Text)
                );

            // Actualización del DataGridView (OPCIONAL)
            dtgv_PRODUCTOS.DataSource = conectandose.Consultar("productos");

            // Limpieza de TextBoxes
            tbx_proveedor.Text = "0";
            tbx_servicio.Text = "0";
            tbx_nombre.Text = "";
            tbx_precio_venta.Text = "0";
            tbx_precio_compra.Text = "0";
            tbx_existencias.Text = "0";

            conectandose.Desconectar(); // Desconectamos de la DB
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            conectandose.Conectar();
            dtgv_PRODUCTOS.DataSource = conectandose.Consultar("productos");
            conectandose.Desconectar();

            // inicializando boxes
            tbx_consulta_nombre.Enabled = true;
            tbx_consulta_codigo.Enabled = true;

            tbx_nombre.Enabled = false;
            tbx_proveedor.Enabled = false;
            tbx_servicio.Enabled = false;
            tbx_precio_venta.Enabled = false;
            tbx_precio_compra.Enabled = false;
            tbx_existencias.Enabled = false;
        }

        private void rbtn_CONSULTAR_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_CONSULTAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = true;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = false;
                tbx_proveedor.Enabled = false;
                tbx_servicio.Enabled = false;
                tbx_precio_venta.Enabled = false;
                tbx_precio_compra.Enabled = false;
                tbx_existencias.Enabled = false;
            }
        }

        private void rbtn_Eliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Eliminar.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = false;
                tbx_proveedor.Enabled = false;
                tbx_servicio.Enabled = false;
                tbx_precio_venta.Enabled = false;
                tbx_precio_compra.Enabled = false;
                tbx_existencias.Enabled = false;
            }
        }

        private void rbtn_AGREGAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_AGREGAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = false;

                tbx_nombre.Enabled = true;
                tbx_proveedor.Enabled = true;
                tbx_servicio.Enabled = true;
                tbx_precio_venta.Enabled = true;
                tbx_precio_compra.Enabled = true;
                tbx_existencias.Enabled = true;
            }
        }

        private void rbtn_MODIFICAR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_MODIFICAR.Checked == true)
            {
                tbx_consulta_nombre.Enabled = false;
                tbx_consulta_codigo.Enabled = true;

                tbx_nombre.Enabled = true;
                tbx_proveedor.Enabled = true;
                tbx_servicio.Enabled = true;
                tbx_precio_venta.Enabled = true;
                tbx_precio_compra.Enabled = true;
                tbx_existencias.Enabled = true;
            }
        }

        private void btn_ELIMINAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Mandamos información de las cajas
            conectandose.Eliminar("productos", Convert.ToInt32(tbx_consulta_codigo.Text));

            // Actualización del DataGridView (OPCIONAL)
            dtgv_PRODUCTOS.DataSource = conectandose.Consultar("productos");

            // Limpieza de TextBox
            tbx_consulta_codigo.Text = "0";


            conectandose.Desconectar(); // Desconectamos de la DB
        }

        private void btn_MODIFICAR_Click(object sender, EventArgs e)
        {
            conectandose.Conectar(); // Connectamos a la DB

            // Verificamos que la menos tengamos nombre y apellido
            if (tbx_precio_venta.Text == "" || tbx_nombre.Text == "")
            {
                MessageBox.Show("Necesitas al menos el nombre y precio de venta.", "¡ERROR!");
                conectandose.Desconectar();
                return;
            }
            else if(tbx_consulta_codigo.Text == "0" || tbx_consulta_codigo.Text == "")
            {
                MessageBox.Show("Para modificar datos del PRODUCTO necesitas el codigo del mismo.", "¡ERROR!");
                conectandose.Desconectar();
                return;
            }

            // Mandamos información de las cajas
            conectandose.Update_PRODUCTOS(
                Convert.ToInt32(tbx_consulta_codigo.Text),
                Convert.ToInt32(tbx_proveedor.Text),
                Convert.ToInt32(tbx_servicio.Text),
                tbx_nombre.Text,
                Convert.ToInt32(tbx_precio_venta.Text),
                Convert.ToInt32(tbx_precio_compra.Text),
                Convert.ToInt32(tbx_existencias.Text)
                );

            // Actualización del DataGridView (OPCIONAL)
            dtgv_PRODUCTOS.DataSource = conectandose.Consultar("productos");

            // Limpieza de TextBoxes
            tbx_consulta_codigo.Text = "0";
            tbx_proveedor.Text = "0";
            tbx_servicio.Text = "0";
            tbx_nombre.Text = "";
            tbx_precio_venta.Text = "0";
            tbx_precio_compra.Text = "0";
            tbx_existencias.Text = "0";

            conectandose.Desconectar(); // Desconectamos de la DB
        }
    }
}
