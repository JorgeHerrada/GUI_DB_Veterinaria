﻿using System;
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
            conectandose.Conectar();
            dtgv_PROVEEDORES.DataSource = conectandose.Consultar("proveedores");
            conectandose.Desconectar();
        }
    }
}
