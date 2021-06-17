
namespace veterianaria
{
    partial class Visitas
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.tbx_consulta_codigo = new System.Windows.Forms.TextBox();
            this.tbx_consulta_nombre_mascota = new System.Windows.Forms.TextBox();
            this.lbl_CONSULTA_CODIGO = new System.Windows.Forms.Label();
            this.lbl_CONSULTA_NOMBRE = new System.Windows.Forms.Label();
            this.rbtn_AGREGAR = new System.Windows.Forms.RadioButton();
            this.rbtn_CONSULTAR = new System.Windows.Forms.RadioButton();
            this.tbx_codigo_servicio = new System.Windows.Forms.TextBox();
            this.tbx_codigo_mascota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_codigo_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AGREGAR = new System.Windows.Forms.Button();
            this.tbn_CONSULTAR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgv_VISITAS = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.rbtn_Eliminar = new System.Windows.Forms.RadioButton();
            this.rbtn_MODIFICAR = new System.Windows.Forms.RadioButton();
            this.btn_MODIFICAR = new System.Windows.Forms.Button();
            this.btn_ELIMINAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_VISITAS)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(972, 702);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(109, 44);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.lbl_titulo.Location = new System.Drawing.Point(405, 26);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(221, 79);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Visitas";
            // 
            // tbx_consulta_codigo
            // 
            this.tbx_consulta_codigo.Location = new System.Drawing.Point(208, 235);
            this.tbx_consulta_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consulta_codigo.Name = "tbx_consulta_codigo";
            this.tbx_consulta_codigo.Size = new System.Drawing.Size(100, 22);
            this.tbx_consulta_codigo.TabIndex = 27;
            this.tbx_consulta_codigo.Text = "0";
            this.tbx_consulta_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_consulta_nombre_mascota
            // 
            this.tbx_consulta_nombre_mascota.Location = new System.Drawing.Point(208, 187);
            this.tbx_consulta_nombre_mascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consulta_nombre_mascota.Name = "tbx_consulta_nombre_mascota";
            this.tbx_consulta_nombre_mascota.Size = new System.Drawing.Size(100, 22);
            this.tbx_consulta_nombre_mascota.TabIndex = 26;
            // 
            // lbl_CONSULTA_CODIGO
            // 
            this.lbl_CONSULTA_CODIGO.AutoSize = true;
            this.lbl_CONSULTA_CODIGO.Location = new System.Drawing.Point(69, 238);
            this.lbl_CONSULTA_CODIGO.Name = "lbl_CONSULTA_CODIGO";
            this.lbl_CONSULTA_CODIGO.Size = new System.Drawing.Size(52, 17);
            this.lbl_CONSULTA_CODIGO.TabIndex = 25;
            this.lbl_CONSULTA_CODIGO.Text = "Codigo";
            // 
            // lbl_CONSULTA_NOMBRE
            // 
            this.lbl_CONSULTA_NOMBRE.AutoSize = true;
            this.lbl_CONSULTA_NOMBRE.Location = new System.Drawing.Point(69, 190);
            this.lbl_CONSULTA_NOMBRE.Name = "lbl_CONSULTA_NOMBRE";
            this.lbl_CONSULTA_NOMBRE.Size = new System.Drawing.Size(115, 17);
            this.lbl_CONSULTA_NOMBRE.TabIndex = 24;
            this.lbl_CONSULTA_NOMBRE.Text = "Nombre Mascota";
            // 
            // rbtn_AGREGAR
            // 
            this.rbtn_AGREGAR.AutoSize = true;
            this.rbtn_AGREGAR.Location = new System.Drawing.Point(649, 128);
            this.rbtn_AGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_AGREGAR.Name = "rbtn_AGREGAR";
            this.rbtn_AGREGAR.Size = new System.Drawing.Size(80, 21);
            this.rbtn_AGREGAR.TabIndex = 23;
            this.rbtn_AGREGAR.Text = "Agregar";
            this.rbtn_AGREGAR.UseVisualStyleBackColor = true;
            this.rbtn_AGREGAR.CheckedChanged += new System.EventHandler(this.rbtn_AGREGAR_CheckedChanged);
            // 
            // rbtn_CONSULTAR
            // 
            this.rbtn_CONSULTAR.AutoSize = true;
            this.rbtn_CONSULTAR.Checked = true;
            this.rbtn_CONSULTAR.Location = new System.Drawing.Point(73, 128);
            this.rbtn_CONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_CONSULTAR.Name = "rbtn_CONSULTAR";
            this.rbtn_CONSULTAR.Size = new System.Drawing.Size(89, 21);
            this.rbtn_CONSULTAR.TabIndex = 22;
            this.rbtn_CONSULTAR.TabStop = true;
            this.rbtn_CONSULTAR.Text = "Consultar";
            this.rbtn_CONSULTAR.UseVisualStyleBackColor = true;
            this.rbtn_CONSULTAR.CheckedChanged += new System.EventHandler(this.rbtn_CONSULTAR_CheckedChanged);
            // 
            // tbx_codigo_servicio
            // 
            this.tbx_codigo_servicio.Location = new System.Drawing.Point(523, 231);
            this.tbx_codigo_servicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_codigo_servicio.Name = "tbx_codigo_servicio";
            this.tbx_codigo_servicio.Size = new System.Drawing.Size(100, 22);
            this.tbx_codigo_servicio.TabIndex = 42;
            this.tbx_codigo_servicio.Text = "0";
            this.tbx_codigo_servicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_codigo_mascota
            // 
            this.tbx_codigo_mascota.Location = new System.Drawing.Point(523, 182);
            this.tbx_codigo_mascota.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_codigo_mascota.Name = "tbx_codigo_mascota";
            this.tbx_codigo_mascota.Size = new System.Drawing.Size(100, 22);
            this.tbx_codigo_mascota.TabIndex = 41;
            this.tbx_codigo_mascota.Text = "0";
            this.tbx_codigo_mascota.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Código Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Código Mascota";
            // 
            // tbx_codigo_cliente
            // 
            this.tbx_codigo_cliente.Location = new System.Drawing.Point(523, 276);
            this.tbx_codigo_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_codigo_cliente.Name = "tbx_codigo_cliente";
            this.tbx_codigo_cliente.Size = new System.Drawing.Size(100, 22);
            this.tbx_codigo_cliente.TabIndex = 45;
            this.tbx_codigo_cliente.Text = "0";
            this.tbx_codigo_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 44;
            this.label3.Text = "Hora Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Código Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(674, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Hora Entrada";
            // 
            // btn_AGREGAR
            // 
            this.btn_AGREGAR.Location = new System.Drawing.Point(649, 326);
            this.btn_AGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AGREGAR.Name = "btn_AGREGAR";
            this.btn_AGREGAR.Size = new System.Drawing.Size(164, 48);
            this.btn_AGREGAR.TabIndex = 51;
            this.btn_AGREGAR.Text = "Agregar";
            this.btn_AGREGAR.UseVisualStyleBackColor = true;
            this.btn_AGREGAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbn_CONSULTAR
            // 
            this.tbn_CONSULTAR.Location = new System.Drawing.Point(73, 326);
            this.tbn_CONSULTAR.Margin = new System.Windows.Forms.Padding(4);
            this.tbn_CONSULTAR.Name = "tbn_CONSULTAR";
            this.tbn_CONSULTAR.Size = new System.Drawing.Size(164, 48);
            this.tbn_CONSULTAR.TabIndex = 52;
            this.tbn_CONSULTAR.Text = "Consultar";
            this.tbn_CONSULTAR.UseVisualStyleBackColor = true;
            this.tbn_CONSULTAR.Click += new System.EventHandler(this.tbn_CONSULTAR_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 697);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 48);
            this.button3.TabIndex = 53;
            this.button3.Text = "CONSULTAR TODO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgv_VISITAS
            // 
            this.dtgv_VISITAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_VISITAS.Location = new System.Drawing.Point(73, 403);
            this.dtgv_VISITAS.Name = "dtgv_VISITAS";
            this.dtgv_VISITAS.RowHeadersWidth = 51;
            this.dtgv_VISITAS.RowTemplate.Height = 24;
            this.dtgv_VISITAS.Size = new System.Drawing.Size(1008, 272);
            this.dtgv_VISITAS.TabIndex = 54;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(794, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 22);
            this.dateTimePicker1.TabIndex = 55;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(794, 229);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(287, 22);
            this.dateTimePicker2.TabIndex = 56;
            // 
            // rbtn_Eliminar
            // 
            this.rbtn_Eliminar.AutoSize = true;
            this.rbtn_Eliminar.Location = new System.Drawing.Point(346, 128);
            this.rbtn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Eliminar.Name = "rbtn_Eliminar";
            this.rbtn_Eliminar.Size = new System.Drawing.Size(79, 21);
            this.rbtn_Eliminar.TabIndex = 57;
            this.rbtn_Eliminar.Text = "Eliminar";
            this.rbtn_Eliminar.UseVisualStyleBackColor = true;
            this.rbtn_Eliminar.CheckedChanged += new System.EventHandler(this.rbtn_Eliminar_CheckedChanged);
            // 
            // rbtn_MODIFICAR
            // 
            this.rbtn_MODIFICAR.AutoSize = true;
            this.rbtn_MODIFICAR.Location = new System.Drawing.Point(917, 128);
            this.rbtn_MODIFICAR.Name = "rbtn_MODIFICAR";
            this.rbtn_MODIFICAR.Size = new System.Drawing.Size(143, 21);
            this.rbtn_MODIFICAR.TabIndex = 58;
            this.rbtn_MODIFICAR.Text = "Modificar Registro";
            this.rbtn_MODIFICAR.UseVisualStyleBackColor = true;
            this.rbtn_MODIFICAR.CheckedChanged += new System.EventHandler(this.rbtn_MODIFICAR_CheckedChanged);
            // 
            // btn_MODIFICAR
            // 
            this.btn_MODIFICAR.Location = new System.Drawing.Point(917, 326);
            this.btn_MODIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MODIFICAR.Name = "btn_MODIFICAR";
            this.btn_MODIFICAR.Size = new System.Drawing.Size(164, 48);
            this.btn_MODIFICAR.TabIndex = 63;
            this.btn_MODIFICAR.Text = "Modificar";
            this.btn_MODIFICAR.UseVisualStyleBackColor = true;
            this.btn_MODIFICAR.Click += new System.EventHandler(this.btn_MODIFICAR_Click);
            // 
            // btn_ELIMINAR
            // 
            this.btn_ELIMINAR.Location = new System.Drawing.Point(346, 326);
            this.btn_ELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ELIMINAR.Name = "btn_ELIMINAR";
            this.btn_ELIMINAR.Size = new System.Drawing.Size(164, 48);
            this.btn_ELIMINAR.TabIndex = 62;
            this.btn_ELIMINAR.Text = "Eliminar";
            this.btn_ELIMINAR.UseVisualStyleBackColor = true;
            this.btn_ELIMINAR.Click += new System.EventHandler(this.btn_ELIMINAR_Click);
            // 
            // Visitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 755);
            this.Controls.Add(this.btn_MODIFICAR);
            this.Controls.Add(this.btn_ELIMINAR);
            this.Controls.Add(this.rbtn_MODIFICAR);
            this.Controls.Add(this.rbtn_Eliminar);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dtgv_VISITAS);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbn_CONSULTAR);
            this.Controls.Add(this.btn_AGREGAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_codigo_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_codigo_servicio);
            this.Controls.Add(this.tbx_codigo_mascota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_consulta_codigo);
            this.Controls.Add(this.tbx_consulta_nombre_mascota);
            this.Controls.Add(this.lbl_CONSULTA_CODIGO);
            this.Controls.Add(this.lbl_CONSULTA_NOMBRE);
            this.Controls.Add(this.rbtn_AGREGAR);
            this.Controls.Add(this.rbtn_CONSULTAR);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_exit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Visitas";
            this.Text = "Visitas  -  CHUCHOLANDIA®";
            this.Load += new System.EventHandler(this.Visitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_VISITAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox tbx_consulta_codigo;
        private System.Windows.Forms.TextBox tbx_consulta_nombre_mascota;
        private System.Windows.Forms.Label lbl_CONSULTA_CODIGO;
        private System.Windows.Forms.Label lbl_CONSULTA_NOMBRE;
        private System.Windows.Forms.RadioButton rbtn_AGREGAR;
        private System.Windows.Forms.RadioButton rbtn_CONSULTAR;
        private System.Windows.Forms.TextBox tbx_codigo_servicio;
        private System.Windows.Forms.TextBox tbx_codigo_mascota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_codigo_cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AGREGAR;
        private System.Windows.Forms.Button tbn_CONSULTAR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgv_VISITAS;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.RadioButton rbtn_Eliminar;
        private System.Windows.Forms.RadioButton rbtn_MODIFICAR;
        private System.Windows.Forms.Button btn_MODIFICAR;
        private System.Windows.Forms.Button btn_ELIMINAR;
    }
}