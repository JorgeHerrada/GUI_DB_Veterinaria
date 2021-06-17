
namespace veterianaria
{
    partial class Servicios
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.tbx_precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_codigo_empleado = new System.Windows.Forms.TextBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_consulta_codigo = new System.Windows.Forms.TextBox();
            this.tbx_consulta_nombre = new System.Windows.Forms.TextBox();
            this.lbl_CONSULTA_CODIGO = new System.Windows.Forms.Label();
            this.rbtn_AGREGAR = new System.Windows.Forms.RadioButton();
            this.rbtn_CONSULTAR = new System.Windows.Forms.RadioButton();
            this.lbl_CONSULTA_NOMBRE = new System.Windows.Forms.Label();
            this.btn_AGREGAR = new System.Windows.Forms.Button();
            this.btn_CONSULTAR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgv_SERVICIOS = new System.Windows.Forms.DataGridView();
            this.rbtn_Eliminar = new System.Windows.Forms.RadioButton();
            this.rbtn_MODIFICAR = new System.Windows.Forms.RadioButton();
            this.btn_ELIMINAR = new System.Windows.Forms.Button();
            this.btn_MODIFICAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SERVICIOS)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.lbl_titulo.Location = new System.Drawing.Point(425, 28);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(251, 50);
            this.lbl_titulo.TabIndex = 3;
            this.lbl_titulo.Text = "Servicios";
            // 
            // btn_exit
            // 
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_exit.Location = new System.Drawing.Point(893, 684);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(155, 48);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // tbx_precio
            // 
            this.tbx_precio.Location = new System.Drawing.Point(853, 177);
            this.tbx_precio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_precio.Name = "tbx_precio";
            this.tbx_precio.Size = new System.Drawing.Size(193, 22);
            this.tbx_precio.TabIndex = 53;
            this.tbx_precio.Text = "0";
            this.tbx_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Precio";
            // 
            // tbx_codigo_empleado
            // 
            this.tbx_codigo_empleado.Location = new System.Drawing.Point(540, 219);
            this.tbx_codigo_empleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_codigo_empleado.Name = "tbx_codigo_empleado";
            this.tbx_codigo_empleado.Size = new System.Drawing.Size(201, 22);
            this.tbx_codigo_empleado.TabIndex = 50;
            this.tbx_codigo_empleado.Text = "0";
            this.tbx_codigo_empleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(540, 175);
            this.tbx_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(201, 22);
            this.tbx_nombre.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Codigo Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tipo de Servicio";
            // 
            // tbx_consulta_codigo
            // 
            this.tbx_consulta_codigo.Location = new System.Drawing.Point(196, 219);
            this.tbx_consulta_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consulta_codigo.Name = "tbx_consulta_codigo";
            this.tbx_consulta_codigo.Size = new System.Drawing.Size(100, 22);
            this.tbx_consulta_codigo.TabIndex = 46;
            this.tbx_consulta_codigo.Text = "0";
            this.tbx_consulta_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_consulta_nombre
            // 
            this.tbx_consulta_nombre.Location = new System.Drawing.Point(196, 172);
            this.tbx_consulta_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consulta_nombre.Name = "tbx_consulta_nombre";
            this.tbx_consulta_nombre.Size = new System.Drawing.Size(100, 22);
            this.tbx_consulta_nombre.TabIndex = 45;
            // 
            // lbl_CONSULTA_CODIGO
            // 
            this.lbl_CONSULTA_CODIGO.AutoSize = true;
            this.lbl_CONSULTA_CODIGO.Location = new System.Drawing.Point(79, 225);
            this.lbl_CONSULTA_CODIGO.Name = "lbl_CONSULTA_CODIGO";
            this.lbl_CONSULTA_CODIGO.Size = new System.Drawing.Size(52, 17);
            this.lbl_CONSULTA_CODIGO.TabIndex = 44;
            this.lbl_CONSULTA_CODIGO.Text = "Codigo";
            // 
            // rbtn_AGREGAR
            // 
            this.rbtn_AGREGAR.AutoSize = true;
            this.rbtn_AGREGAR.Location = new System.Drawing.Point(629, 117);
            this.rbtn_AGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_AGREGAR.Name = "rbtn_AGREGAR";
            this.rbtn_AGREGAR.Size = new System.Drawing.Size(80, 21);
            this.rbtn_AGREGAR.TabIndex = 42;
            this.rbtn_AGREGAR.Text = "Agregar";
            this.rbtn_AGREGAR.UseVisualStyleBackColor = true;
            this.rbtn_AGREGAR.CheckedChanged += new System.EventHandler(this.rbtn_AGREGAR_CheckedChanged);
            // 
            // rbtn_CONSULTAR
            // 
            this.rbtn_CONSULTAR.AutoSize = true;
            this.rbtn_CONSULTAR.Checked = true;
            this.rbtn_CONSULTAR.Location = new System.Drawing.Point(82, 117);
            this.rbtn_CONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_CONSULTAR.Name = "rbtn_CONSULTAR";
            this.rbtn_CONSULTAR.Size = new System.Drawing.Size(89, 21);
            this.rbtn_CONSULTAR.TabIndex = 41;
            this.rbtn_CONSULTAR.TabStop = true;
            this.rbtn_CONSULTAR.Text = "Consultar";
            this.rbtn_CONSULTAR.UseVisualStyleBackColor = true;
            this.rbtn_CONSULTAR.CheckedChanged += new System.EventHandler(this.rbtn_CONSULTAR_CheckedChanged);
            // 
            // lbl_CONSULTA_NOMBRE
            // 
            this.lbl_CONSULTA_NOMBRE.AutoSize = true;
            this.lbl_CONSULTA_NOMBRE.Location = new System.Drawing.Point(79, 176);
            this.lbl_CONSULTA_NOMBRE.Name = "lbl_CONSULTA_NOMBRE";
            this.lbl_CONSULTA_NOMBRE.Size = new System.Drawing.Size(110, 17);
            this.lbl_CONSULTA_NOMBRE.TabIndex = 43;
            this.lbl_CONSULTA_NOMBRE.Text = "Tipo de Servicio";
            // 
            // btn_AGREGAR
            // 
            this.btn_AGREGAR.Location = new System.Drawing.Point(629, 272);
            this.btn_AGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AGREGAR.Name = "btn_AGREGAR";
            this.btn_AGREGAR.Size = new System.Drawing.Size(164, 48);
            this.btn_AGREGAR.TabIndex = 54;
            this.btn_AGREGAR.Text = "Agregar";
            this.btn_AGREGAR.UseVisualStyleBackColor = true;
            this.btn_AGREGAR.Click += new System.EventHandler(this.btn_AGREGAR_Click);
            // 
            // btn_CONSULTAR
            // 
            this.btn_CONSULTAR.Location = new System.Drawing.Point(83, 272);
            this.btn_CONSULTAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CONSULTAR.Name = "btn_CONSULTAR";
            this.btn_CONSULTAR.Size = new System.Drawing.Size(164, 48);
            this.btn_CONSULTAR.TabIndex = 55;
            this.btn_CONSULTAR.Text = "Consultar";
            this.btn_CONSULTAR.UseVisualStyleBackColor = true;
            this.btn_CONSULTAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 685);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 48);
            this.button3.TabIndex = 56;
            this.button3.Text = "CONSULTAR TODO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgv_SERVICIOS
            // 
            this.dtgv_SERVICIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_SERVICIOS.Location = new System.Drawing.Point(82, 349);
            this.dtgv_SERVICIOS.Name = "dtgv_SERVICIOS";
            this.dtgv_SERVICIOS.RowHeadersWidth = 51;
            this.dtgv_SERVICIOS.RowTemplate.Height = 24;
            this.dtgv_SERVICIOS.Size = new System.Drawing.Size(964, 304);
            this.dtgv_SERVICIOS.TabIndex = 57;
            // 
            // rbtn_Eliminar
            // 
            this.rbtn_Eliminar.AutoSize = true;
            this.rbtn_Eliminar.Location = new System.Drawing.Point(361, 117);
            this.rbtn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Eliminar.Name = "rbtn_Eliminar";
            this.rbtn_Eliminar.Size = new System.Drawing.Size(79, 21);
            this.rbtn_Eliminar.TabIndex = 58;
            this.rbtn_Eliminar.Text = "Eliminar";
            this.rbtn_Eliminar.UseVisualStyleBackColor = true;
            this.rbtn_Eliminar.CheckedChanged += new System.EventHandler(this.rbtn_Eliminar_CheckedChanged);
            // 
            // rbtn_MODIFICAR
            // 
            this.rbtn_MODIFICAR.AutoSize = true;
            this.rbtn_MODIFICAR.Location = new System.Drawing.Point(893, 117);
            this.rbtn_MODIFICAR.Name = "rbtn_MODIFICAR";
            this.rbtn_MODIFICAR.Size = new System.Drawing.Size(143, 21);
            this.rbtn_MODIFICAR.TabIndex = 59;
            this.rbtn_MODIFICAR.Text = "Modificar Registro";
            this.rbtn_MODIFICAR.UseVisualStyleBackColor = true;
            this.rbtn_MODIFICAR.CheckedChanged += new System.EventHandler(this.rbtn_MODIFICAR_CheckedChanged);
            // 
            // btn_ELIMINAR
            // 
            this.btn_ELIMINAR.Location = new System.Drawing.Point(361, 272);
            this.btn_ELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ELIMINAR.Name = "btn_ELIMINAR";
            this.btn_ELIMINAR.Size = new System.Drawing.Size(164, 48);
            this.btn_ELIMINAR.TabIndex = 60;
            this.btn_ELIMINAR.Text = "Eliminar";
            this.btn_ELIMINAR.UseVisualStyleBackColor = true;
            this.btn_ELIMINAR.Click += new System.EventHandler(this.btn_ELIMINAR_Click);
            // 
            // btn_MODIFICAR
            // 
            this.btn_MODIFICAR.Location = new System.Drawing.Point(884, 272);
            this.btn_MODIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MODIFICAR.Name = "btn_MODIFICAR";
            this.btn_MODIFICAR.Size = new System.Drawing.Size(164, 48);
            this.btn_MODIFICAR.TabIndex = 61;
            this.btn_MODIFICAR.Text = "Modificar";
            this.btn_MODIFICAR.UseVisualStyleBackColor = true;
            this.btn_MODIFICAR.Click += new System.EventHandler(this.btn_MODIFICAR_Click);
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 759);
            this.Controls.Add(this.btn_MODIFICAR);
            this.Controls.Add(this.btn_ELIMINAR);
            this.Controls.Add(this.rbtn_MODIFICAR);
            this.Controls.Add(this.rbtn_Eliminar);
            this.Controls.Add(this.dtgv_SERVICIOS);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_CONSULTAR);
            this.Controls.Add(this.btn_AGREGAR);
            this.Controls.Add(this.tbx_precio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_codigo_empleado);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_consulta_codigo);
            this.Controls.Add(this.tbx_consulta_nombre);
            this.Controls.Add(this.lbl_CONSULTA_CODIGO);
            this.Controls.Add(this.lbl_CONSULTA_NOMBRE);
            this.Controls.Add(this.rbtn_AGREGAR);
            this.Controls.Add(this.rbtn_CONSULTAR);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_titulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Servicios";
            this.Text = "Servicio  -  CHUCHOLANDIA®";
            this.Load += new System.EventHandler(this.Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_SERVICIOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox tbx_precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_codigo_empleado;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_consulta_codigo;
        private System.Windows.Forms.TextBox tbx_consulta_nombre;
        private System.Windows.Forms.Label lbl_CONSULTA_CODIGO;
        private System.Windows.Forms.RadioButton rbtn_AGREGAR;
        private System.Windows.Forms.RadioButton rbtn_CONSULTAR;
        private System.Windows.Forms.Label lbl_CONSULTA_NOMBRE;
        private System.Windows.Forms.Button btn_AGREGAR;
        private System.Windows.Forms.Button btn_CONSULTAR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgv_SERVICIOS;
        private System.Windows.Forms.RadioButton rbtn_Eliminar;
        private System.Windows.Forms.RadioButton rbtn_MODIFICAR;
        private System.Windows.Forms.Button btn_ELIMINAR;
        private System.Windows.Forms.Button btn_MODIFICAR;
    }
}