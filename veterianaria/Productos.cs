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
    }
}