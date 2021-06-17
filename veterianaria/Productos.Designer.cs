
namespace veterianaria
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_EXIT = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tbx_precio_venta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_existencias = new System.Windows.Forms.TextBox();
            this.tbx_proveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_precio_compra = new System.Windows.Forms.TextBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_consulta_codigo = new System.Windows.Forms.TextBox();
            this.tbx_consulta_nombre = new System.Windows.Forms.TextBox();
            this.lbl_CONSULTA_CODIGO = new System.Windows.Forms.Label();
            this.lbl_CONSULTA_NOMBRE = new System.Windows.Forms.Label();
            this.rbtn_AGREGAR = new System.Windows.Forms.RadioButton();
            this.rbtn_CONSULTAR = new System.Windows.Forms.RadioButton();
            this.tbx_servicio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AGREGAR = new System.Windows.Forms.Button();
            this.btn_CONSULTAR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgv_PRODUCTOS = new System.Windows.Forms.DataGridView();
            this.rbtn_Eliminar = new System.Windows.Forms.RadioButton();
            this.rbtn_MODIFICAR = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PRODUCTOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.Location = new System.Drawing.Point(854, 689);
            this.btn_EXIT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(164, 48);
            this.btn_EXIT.TabIndex = 0;
            this.btn_EXIT.Text = "SALIR";
            this.btn_EXIT.UseVisualStyleBackColor = true;
            this.btn_EXIT.Click += new System.EventHandler(this.btn_EXIT_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.lbl_titulo.Location = new System.Drawing.Point(411, 44);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(221, 79);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Productos";
            // 
            // tbx_precio_venta
            // 
            this.tbx_precio_venta.Location = new System.Drawing.Point(527, 286);
            this.tbx_precio_venta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_precio_venta.Name = "tbx_precio_venta";
            this.tbx_precio_venta.Size = new System.Drawing.Size(187, 22);
            this.tbx_precio_venta.TabIndex = 37;
            this.tbx_precio_venta.Text = "0";
            this.tbx_precio_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Precio de Venta";
            // 
            // tbx_existencias
            // 
            this.tbx_existencias.Location = new System.Drawing.Point(825, 242);
            this.tbx_existencias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_existencias.Name = "tbx_existencias";
            this.tbx_existencias.Size = new System.Drawing.Size(193, 22);
            this.tbx_existencias.TabIndex = 35;
            this.tbx_existencias.Text = "0";
            this.tbx_existencias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_proveedor
            // 
            this.tbx_proveedor.Location = new System.Drawing.Point(825, 199);
            this.tbx_proveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_proveedor.Name = "tbx_proveedor";
            this.tbx_proveedor.Size = new System.Drawing.Size(193, 22);
            this.tbx_proveedor.TabIndex = 34;
            this.tbx_proveedor.Text = "0";
            this.tbx_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(735, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Existencias";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(735, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Proveedor";
            // 
            // tbx_precio_compra
            // 
            this.tbx_precio_compra.Location = new System.Drawing.Point(527, 242);
            this.tbx_precio_compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_precio_compra.Name = "tbx_precio_compra";
            this.tbx_precio_compra.Size = new System.Drawing.Size(187, 22);
            this.tbx_precio_compra.TabIndex = 31;
            this.tbx_precio_compra.Text = "0";
            this.tbx_precio_compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(527, 196);
            this.tbx_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(187, 22);
            this.tbx_nombre.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Precio de Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre";
            // 
            // tbx_consulta_codigo
            // 
            this.tbx_consulta_codigo.Location = new System.Drawing.Point(176, 242);
            this.tbx_consulta_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consulta_codigo.Name = "tbx_consulta_codigo";
            this.tbx_consulta_codigo.Size = new System.Drawing.Size(100, 22);
            this.tbx_consulta_codigo.TabIndex = 27;
            this.tbx_consulta_codigo.Text = "0";
            this.tbx_consulta_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_consulta_nombre
            // 
            this.tbx_consulta_nombre.Location = new System.Drawing.Point(176, 193);
            this.tbx_consulta_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consulta_nombre.Name = "tbx_consulta_nombre";
            this.tbx_consulta_nombre.Size = new System.Drawing.Size(100, 22);
            this.tbx_consulta_nombre.TabIndex = 26;
            // 
            // lbl_CONSULTA_CODIGO
            // 
            this.lbl_CONSULTA_CODIGO.AutoSize = true;
            this.lbl_CONSULTA_CODIGO.Location = new System.Drawing.Point(64, 247);
            this.lbl_CONSULTA_CODIGO.Name = "lbl_CONSULTA_CODIGO";
            this.lbl_CONSULTA_CODIGO.Size = new System.Drawing.Size(52, 17);
            this.lbl_CONSULTA_CODIGO.TabIndex = 25;
            this.lbl_CONSULTA_CODIGO.Text = "Codigo";
            // 
            // lbl_CONSULTA_NOMBRE
            // 
            this.lbl_CONSULTA_NOMBRE.AutoSize = true;
            this.lbl_CONSULTA_NOMBRE.Location = new System.Drawing.Point(64, 198);
            this.lbl_CONSULTA_NOMBRE.Name = "lbl_CONSULTA_NOMBRE";
            this.lbl_CONSULTA_NOMBRE.Size = new System.Drawing.Size(58, 17);
            this.lbl_CONSULTA_NOMBRE.TabIndex = 24;
            this.lbl_CONSULTA_NOMBRE.Text = "Nombre";
            // 
            // rbtn_AGREGAR
            // 
            this.rbtn_AGREGAR.AutoSize = true;
            this.rbtn_AGREGAR.Location = new System.Drawing.Point(403, 137);
            this.rbtn_AGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_AGREGAR.Name = "rbtn_AGREGAR";
            this.rbtn_AGREGAR.Size = new System.Drawing.Size(80, 21);
            this.rbtn_AGREGAR.TabIndex = 23;
            this.rbtn_AGREGAR.TabStop = true;
            this.rbtn_AGREGAR.Text = "Agregar";
            this.rbtn_AGREGAR.UseVisualStyleBackColor = true;
            // 
            // rbtn_CONSULTAR
            // 
            this.rbtn_CONSULTAR.AutoSize = true;
            this.rbtn_CONSULTAR.Location = new System.Drawing.Point(68, 139);
            this.rbtn_CONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_CONSULTAR.Name = "rbtn_CONSULTAR";
            this.rbtn_CONSULTAR.Size = new System.Drawing.Size(89, 21);
            this.rbtn_CONSULTAR.TabIndex = 22;
            this.rbtn_CONSULTAR.TabStop = true;
            this.rbtn_CONSULTAR.Text = "Consultar";
            this.rbtn_CONSULTAR.UseVisualStyleBackColor = true;
            // 
            // tbx_servicio
            // 
            this.tbx_servicio.Location = new System.Drawing.Point(825, 286);
            this.tbx_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_servicio.Name = "tbx_servicio";
            this.tbx_servicio.Size = new System.Drawing.Size(193, 22);
            this.tbx_servicio.TabIndex = 40;
            this.tbx_servicio.Text = "0";
            this.tbx_servicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(735, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Servicio";
            // 
            // btn_AGREGAR
            // 
            this.btn_AGREGAR.Location = new System.Drawing.Point(854, 324);
            this.btn_AGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AGREGAR.Name = "btn_AGREGAR";
            this.btn_AGREGAR.Size = new System.Drawing.Size(164, 48);
            this.btn_AGREGAR.TabIndex = 43;
            this.btn_AGREGAR.Text = "Agregar";
            this.btn_AGREGAR.UseVisualStyleBackColor = true;
            this.btn_AGREGAR.Click += new System.EventHandler(this.btn_AGREGAR_Click);
            // 
            // btn_CONSULTAR
            // 
            this.btn_CONSULTAR.Location = new System.Drawing.Point(67, 324);
            this.btn_CONSULTAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CONSULTAR.Name = "btn_CONSULTAR";
            this.btn_CONSULTAR.Size = new System.Drawing.Size(164, 48);
            this.btn_CONSULTAR.TabIndex = 44;
            this.btn_CONSULTAR.Text = "Consultar";
            this.btn_CONSULTAR.UseVisualStyleBackColor = true;
            this.btn_CONSULTAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 689);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 48);
            this.button3.TabIndex = 45;
            this.button3.Text = "CONSULTAR TODO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgv_PRODUCTOS
            // 
            this.dtgv_PRODUCTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_PRODUCTOS.Location = new System.Drawing.Point(68, 410);
            this.dtgv_PRODUCTOS.Name = "dtgv_PRODUCTOS";
            this.dtgv_PRODUCTOS.RowHeadersWidth = 51;
            this.dtgv_PRODUCTOS.RowTemplate.Height = 24;
            this.dtgv_PRODUCTOS.Size = new System.Drawing.Size(950, 238);
            this.dtgv_PRODUCTOS.TabIndex = 46;
            // 
            // rbtn_Eliminar
            // 
            this.rbtn_Eliminar.AutoSize = true;
            this.rbtn_Eliminar.Location = new System.Drawing.Point(197, 139);
            this.rbtn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Eliminar.Name = "rbtn_Eliminar";
            this.rbtn_Eliminar.Size = new System.Drawing.Size(79, 21);
            this.rbtn_Eliminar.TabIndex = 47;
            this.rbtn_Eliminar.TabStop = true;
            this.rbtn_Eliminar.Text = "Eliminar";
            this.rbtn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // rbtn_MODIFICAR
            // 
            this.rbtn_MODIFICAR.AutoSize = true;
            this.rbtn_MODIFICAR.Location = new System.Drawing.Point(875, 137);
            this.rbtn_MODIFICAR.Name = "rbtn_MODIFICAR";
            this.rbtn_MODIFICAR.Size = new System.Drawing.Size(143, 21);
            this.rbtn_MODIFICAR.TabIndex = 59;
            this.rbtn_MODIFICAR.TabStop = true;
            this.rbtn_MODIFICAR.Text = "Modificar Registro";
            this.rbtn_MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 752);
            this.Controls.Add(this.rbtn_MODIFICAR);
            this.Controls.Add(this.rbtn_Eliminar);
            this.Controls.Add(this.dtgv_PRODUCTOS);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_CONSULTAR);
            this.Controls.Add(this.btn_AGREGAR);
            this.Controls.Add(this.tbx_servicio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_precio_venta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_existencias);
            this.Controls.Add(this.tbx_proveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_precio_compra);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_consulta_codigo);
            this.Controls.Add(this.tbx_consulta_nombre);
            this.Controls.Add(this.lbl_CONSULTA_CODIGO);
            this.Controls.Add(this.lbl_CONSULTA_NOMBRE);
            this.Controls.Add(this.rbtn_AGREGAR);
            this.Controls.Add(this.rbtn_CONSULTAR);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_EXIT);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Productos";
            this.Text = "Articulos  -  CHUCHOLANDIA®";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PRODUCTOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_EXIT;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox tbx_precio_venta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_existencias;
        private System.Windows.Forms.TextBox tbx_proveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_precio_compra;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_consulta_codigo;
        private System.Windows.Forms.TextBox tbx_consulta_nombre;
        private System.Windows.Forms.Label lbl_CONSULTA_CODIGO;
        private System.Windows.Forms.Label lbl_CONSULTA_NOMBRE;
        private System.Windows.Forms.RadioButton rbtn_AGREGAR;
        private System.Windows.Forms.RadioButton rbtn_CONSULTAR;
        private System.Windows.Forms.TextBox tbx_servicio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_AGREGAR;
        private System.Windows.Forms.Button btn_CONSULTAR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgv_PRODUCTOS;
        private System.Windows.Forms.RadioButton rbtn_Eliminar;
        private System.Windows.Forms.RadioButton rbtn_MODIFICAR;
    }
}