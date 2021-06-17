
namespace veterianaria
{
    partial class Mascotas
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
            this.tbx_codigo_cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_raza = new System.Windows.Forms.TextBox();
            this.tbx_edad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_especie = new System.Windows.Forms.TextBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_consultar_codigo = new System.Windows.Forms.TextBox();
            this.tbx_consultar_nombre = new System.Windows.Forms.TextBox();
            this.lbl_CONSULTA_CODIGO = new System.Windows.Forms.Label();
            this.lbl_CONSULTA_NOMBRE = new System.Windows.Forms.Label();
            this.rbtn_AGREGAR = new System.Windows.Forms.RadioButton();
            this.rbtn_CONSULTAR = new System.Windows.Forms.RadioButton();
            this.tbx_peso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_AGREGAR = new System.Windows.Forms.Button();
            this.CONSULTAR = new System.Windows.Forms.Button();
            this.CONSULTAR_TODO = new System.Windows.Forms.Button();
            this.dtgv_MASCOTAS = new System.Windows.Forms.DataGridView();
            this.rbtn_Eliminar = new System.Windows.Forms.RadioButton();
            this.rbtn_MODIFICAR = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MASCOTAS)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(859, 639);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(162, 48);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.lbl_titulo.Location = new System.Drawing.Point(398, 33);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(221, 79);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Mascotas";
            // 
            // tbx_codigo_cliente
            // 
            this.tbx_codigo_cliente.Location = new System.Drawing.Point(515, 272);
            this.tbx_codigo_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_codigo_cliente.Name = "tbx_codigo_cliente";
            this.tbx_codigo_cliente.Size = new System.Drawing.Size(201, 22);
            this.tbx_codigo_cliente.TabIndex = 37;
            this.tbx_codigo_cliente.Text = "0";
            this.tbx_codigo_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Código Cliente";
            // 
            // tbx_raza
            // 
            this.tbx_raza.Location = new System.Drawing.Point(828, 229);
            this.tbx_raza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_raza.Name = "tbx_raza";
            this.tbx_raza.Size = new System.Drawing.Size(193, 22);
            this.tbx_raza.TabIndex = 35;
            // 
            // tbx_edad
            // 
            this.tbx_edad.Location = new System.Drawing.Point(828, 186);
            this.tbx_edad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_edad.Name = "tbx_edad";
            this.tbx_edad.Size = new System.Drawing.Size(193, 22);
            this.tbx_edad.TabIndex = 34;
            this.tbx_edad.Text = "0";
            this.tbx_edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(738, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Raza";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(739, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Edad";
            // 
            // tbx_especie
            // 
            this.tbx_especie.Location = new System.Drawing.Point(515, 229);
            this.tbx_especie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_especie.Name = "tbx_especie";
            this.tbx_especie.Size = new System.Drawing.Size(201, 22);
            this.tbx_especie.TabIndex = 31;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(515, 183);
            this.tbx_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(201, 22);
            this.tbx_nombre.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Especie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre";
            // 
            // tbx_consultar_codigo
            // 
            this.tbx_consultar_codigo.Location = new System.Drawing.Point(179, 229);
            this.tbx_consultar_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consultar_codigo.Name = "tbx_consultar_codigo";
            this.tbx_consultar_codigo.Size = new System.Drawing.Size(100, 22);
            this.tbx_consultar_codigo.TabIndex = 27;
            this.tbx_consultar_codigo.Text = "0";
            this.tbx_consultar_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_consultar_nombre
            // 
            this.tbx_consultar_nombre.Location = new System.Drawing.Point(179, 180);
            this.tbx_consultar_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consultar_nombre.Name = "tbx_consultar_nombre";
            this.tbx_consultar_nombre.Size = new System.Drawing.Size(100, 22);
            this.tbx_consultar_nombre.TabIndex = 26;
            // 
            // lbl_CONSULTA_CODIGO
            // 
            this.lbl_CONSULTA_CODIGO.AutoSize = true;
            this.lbl_CONSULTA_CODIGO.Location = new System.Drawing.Point(67, 234);
            this.lbl_CONSULTA_CODIGO.Name = "lbl_CONSULTA_CODIGO";
            this.lbl_CONSULTA_CODIGO.Size = new System.Drawing.Size(52, 17);
            this.lbl_CONSULTA_CODIGO.TabIndex = 25;
            this.lbl_CONSULTA_CODIGO.Text = "Codigo";
            // 
            // lbl_CONSULTA_NOMBRE
            // 
            this.lbl_CONSULTA_NOMBRE.AutoSize = true;
            this.lbl_CONSULTA_NOMBRE.Location = new System.Drawing.Point(67, 185);
            this.lbl_CONSULTA_NOMBRE.Name = "lbl_CONSULTA_NOMBRE";
            this.lbl_CONSULTA_NOMBRE.Size = new System.Drawing.Size(58, 17);
            this.lbl_CONSULTA_NOMBRE.TabIndex = 24;
            this.lbl_CONSULTA_NOMBRE.Text = "Nombre";
            // 
            // rbtn_AGREGAR
            // 
            this.rbtn_AGREGAR.AutoSize = true;
            this.rbtn_AGREGAR.Location = new System.Drawing.Point(405, 124);
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
            this.rbtn_CONSULTAR.Location = new System.Drawing.Point(83, 126);
            this.rbtn_CONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_CONSULTAR.Name = "rbtn_CONSULTAR";
            this.rbtn_CONSULTAR.Size = new System.Drawing.Size(89, 21);
            this.rbtn_CONSULTAR.TabIndex = 22;
            this.rbtn_CONSULTAR.TabStop = true;
            this.rbtn_CONSULTAR.Text = "Consultar";
            this.rbtn_CONSULTAR.UseVisualStyleBackColor = true;
            // 
            // tbx_peso
            // 
            this.tbx_peso.Location = new System.Drawing.Point(828, 272);
            this.tbx_peso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_peso.Name = "tbx_peso";
            this.tbx_peso.Size = new System.Drawing.Size(193, 22);
            this.tbx_peso.TabIndex = 48;
            this.tbx_peso.Text = "0";
            this.tbx_peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(739, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Peso";
            // 
            // btn_AGREGAR
            // 
            this.btn_AGREGAR.Location = new System.Drawing.Point(859, 315);
            this.btn_AGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AGREGAR.Name = "btn_AGREGAR";
            this.btn_AGREGAR.Size = new System.Drawing.Size(164, 48);
            this.btn_AGREGAR.TabIndex = 49;
            this.btn_AGREGAR.Text = "Agregar";
            this.btn_AGREGAR.UseVisualStyleBackColor = true;
            this.btn_AGREGAR.Click += new System.EventHandler(this.btn_AGREGAR_Click);
            // 
            // CONSULTAR
            // 
            this.CONSULTAR.Location = new System.Drawing.Point(70, 315);
            this.CONSULTAR.Margin = new System.Windows.Forms.Padding(4);
            this.CONSULTAR.Name = "CONSULTAR";
            this.CONSULTAR.Size = new System.Drawing.Size(164, 48);
            this.CONSULTAR.TabIndex = 50;
            this.CONSULTAR.Text = "Consultar";
            this.CONSULTAR.UseVisualStyleBackColor = true;
            this.CONSULTAR.Click += new System.EventHandler(this.CONSULTAR_Click);
            // 
            // CONSULTAR_TODO
            // 
            this.CONSULTAR_TODO.Location = new System.Drawing.Point(71, 639);
            this.CONSULTAR_TODO.Margin = new System.Windows.Forms.Padding(4);
            this.CONSULTAR_TODO.Name = "CONSULTAR_TODO";
            this.CONSULTAR_TODO.Size = new System.Drawing.Size(164, 48);
            this.CONSULTAR_TODO.TabIndex = 51;
            this.CONSULTAR_TODO.Text = "CONSULTAR TODO";
            this.CONSULTAR_TODO.UseVisualStyleBackColor = true;
            this.CONSULTAR_TODO.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgv_MASCOTAS
            // 
            this.dtgv_MASCOTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_MASCOTAS.Location = new System.Drawing.Point(71, 396);
            this.dtgv_MASCOTAS.Name = "dtgv_MASCOTAS";
            this.dtgv_MASCOTAS.RowHeadersWidth = 51;
            this.dtgv_MASCOTAS.RowTemplate.Height = 24;
            this.dtgv_MASCOTAS.Size = new System.Drawing.Size(950, 215);
            this.dtgv_MASCOTAS.TabIndex = 52;
            // 
            // rbtn_Eliminar
            // 
            this.rbtn_Eliminar.AutoSize = true;
            this.rbtn_Eliminar.Location = new System.Drawing.Point(200, 126);
            this.rbtn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Eliminar.Name = "rbtn_Eliminar";
            this.rbtn_Eliminar.Size = new System.Drawing.Size(79, 21);
            this.rbtn_Eliminar.TabIndex = 53;
            this.rbtn_Eliminar.TabStop = true;
            this.rbtn_Eliminar.Text = "Eliminar";
            this.rbtn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // rbtn_MODIFICAR
            // 
            this.rbtn_MODIFICAR.AutoSize = true;
            this.rbtn_MODIFICAR.Location = new System.Drawing.Point(878, 124);
            this.rbtn_MODIFICAR.Name = "rbtn_MODIFICAR";
            this.rbtn_MODIFICAR.Size = new System.Drawing.Size(143, 21);
            this.rbtn_MODIFICAR.TabIndex = 59;
            this.rbtn_MODIFICAR.TabStop = true;
            this.rbtn_MODIFICAR.Text = "Modificar Registro";
            this.rbtn_MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // Mascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 721);
            this.Controls.Add(this.rbtn_MODIFICAR);
            this.Controls.Add(this.rbtn_Eliminar);
            this.Controls.Add(this.dtgv_MASCOTAS);
            this.Controls.Add(this.CONSULTAR_TODO);
            this.Controls.Add(this.CONSULTAR);
            this.Controls.Add(this.btn_AGREGAR);
            this.Controls.Add(this.tbx_peso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_codigo_cliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_raza);
            this.Controls.Add(this.tbx_edad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_especie);
            this.Controls.Add(this.tbx_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_consultar_codigo);
            this.Controls.Add(this.tbx_consultar_nombre);
            this.Controls.Add(this.lbl_CONSULTA_CODIGO);
            this.Controls.Add(this.lbl_CONSULTA_NOMBRE);
            this.Controls.Add(this.rbtn_AGREGAR);
            this.Controls.Add(this.rbtn_CONSULTAR);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_exit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mascotas";
            this.Text = "Mascotas  -  CHUCHOLANDIA®";
            this.Load += new System.EventHandler(this.Mascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_MASCOTAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox tbx_codigo_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_raza;
        private System.Windows.Forms.TextBox tbx_edad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_especie;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_consultar_codigo;
        private System.Windows.Forms.TextBox tbx_consultar_nombre;
        private System.Windows.Forms.Label lbl_CONSULTA_CODIGO;
        private System.Windows.Forms.Label lbl_CONSULTA_NOMBRE;
        private System.Windows.Forms.RadioButton rbtn_AGREGAR;
        private System.Windows.Forms.RadioButton rbtn_CONSULTAR;
        private System.Windows.Forms.TextBox tbx_peso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_AGREGAR;
        private System.Windows.Forms.Button CONSULTAR;
        private System.Windows.Forms.Button CONSULTAR_TODO;
        private System.Windows.Forms.DataGridView dtgv_MASCOTAS;
        private System.Windows.Forms.RadioButton rbtn_Eliminar;
        private System.Windows.Forms.RadioButton rbtn_MODIFICAR;
    }
}