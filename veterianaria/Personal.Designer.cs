
namespace veterianaria
{
    partial class Personal
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
            this.tbx_consulta_nombre = new System.Windows.Forms.TextBox();
            this.lbl_CONSULTA_CODIGO = new System.Windows.Forms.Label();
            this.lbl_CONSULTA_NOMBRE = new System.Windows.Forms.Label();
            this.rbtn_AGREGAR = new System.Windows.Forms.RadioButton();
            this.rbtn_CONSULTAR = new System.Windows.Forms.RadioButton();
            this.tbx_direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_telefono = new System.Windows.Forms.TextBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_horario = new System.Windows.Forms.TextBox();
            this.tbx_antiguedad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_salario = new System.Windows.Forms.TextBox();
            this.tbx_estudios = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_puesto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_AGREGAR = new System.Windows.Forms.Button();
            this.btn_CONSULTAR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgv_PERSONAL = new System.Windows.Forms.DataGridView();
            this.rbtn_Eliminar = new System.Windows.Forms.RadioButton();
            this.rbtn_MODIFICAR = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PERSONAL)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(900, 639);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(132, 39);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.lbl_titulo.Location = new System.Drawing.Point(407, 30);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(221, 79);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "Personal";
            // 
            // tbx_consulta_codigo
            // 
            this.tbx_consulta_codigo.Location = new System.Drawing.Point(188, 229);
            this.tbx_consulta_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consulta_codigo.Name = "tbx_consulta_codigo";
            this.tbx_consulta_codigo.Size = new System.Drawing.Size(100, 22);
            this.tbx_consulta_codigo.TabIndex = 43;
            this.tbx_consulta_codigo.Text = "0";
            this.tbx_consulta_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_consulta_nombre
            // 
            this.tbx_consulta_nombre.Location = new System.Drawing.Point(188, 180);
            this.tbx_consulta_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consulta_nombre.Name = "tbx_consulta_nombre";
            this.tbx_consulta_nombre.Size = new System.Drawing.Size(100, 22);
            this.tbx_consulta_nombre.TabIndex = 42;
            // 
            // lbl_CONSULTA_CODIGO
            // 
            this.lbl_CONSULTA_CODIGO.AutoSize = true;
            this.lbl_CONSULTA_CODIGO.Location = new System.Drawing.Point(76, 234);
            this.lbl_CONSULTA_CODIGO.Name = "lbl_CONSULTA_CODIGO";
            this.lbl_CONSULTA_CODIGO.Size = new System.Drawing.Size(52, 17);
            this.lbl_CONSULTA_CODIGO.TabIndex = 41;
            this.lbl_CONSULTA_CODIGO.Text = "Codigo";
            // 
            // lbl_CONSULTA_NOMBRE
            // 
            this.lbl_CONSULTA_NOMBRE.AutoSize = true;
            this.lbl_CONSULTA_NOMBRE.Location = new System.Drawing.Point(76, 185);
            this.lbl_CONSULTA_NOMBRE.Name = "lbl_CONSULTA_NOMBRE";
            this.lbl_CONSULTA_NOMBRE.Size = new System.Drawing.Size(58, 17);
            this.lbl_CONSULTA_NOMBRE.TabIndex = 40;
            this.lbl_CONSULTA_NOMBRE.Text = "Nombre";
            // 
            // rbtn_AGREGAR
            // 
            this.rbtn_AGREGAR.AutoSize = true;
            this.rbtn_AGREGAR.Location = new System.Drawing.Point(415, 124);
            this.rbtn_AGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_AGREGAR.Name = "rbtn_AGREGAR";
            this.rbtn_AGREGAR.Size = new System.Drawing.Size(80, 21);
            this.rbtn_AGREGAR.TabIndex = 39;
            this.rbtn_AGREGAR.Text = "Agregar";
            this.rbtn_AGREGAR.UseVisualStyleBackColor = true;
            this.rbtn_AGREGAR.CheckedChanged += new System.EventHandler(this.rbtn_AGREGAR_CheckedChanged);
            // 
            // rbtn_CONSULTAR
            // 
            this.rbtn_CONSULTAR.AutoSize = true;
            this.rbtn_CONSULTAR.Checked = true;
            this.rbtn_CONSULTAR.Location = new System.Drawing.Point(79, 126);
            this.rbtn_CONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_CONSULTAR.Name = "rbtn_CONSULTAR";
            this.rbtn_CONSULTAR.Size = new System.Drawing.Size(89, 21);
            this.rbtn_CONSULTAR.TabIndex = 38;
            this.rbtn_CONSULTAR.TabStop = true;
            this.rbtn_CONSULTAR.Text = "Consultar";
            this.rbtn_CONSULTAR.UseVisualStyleBackColor = true;
            this.rbtn_CONSULTAR.CheckedChanged += new System.EventHandler(this.rbtn_CONSULTAR_CheckedChanged);
            // 
            // tbx_direccion
            // 
            this.tbx_direccion.Location = new System.Drawing.Point(524, 271);
            this.tbx_direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_direccion.Name = "tbx_direccion";
            this.tbx_direccion.Size = new System.Drawing.Size(201, 22);
            this.tbx_direccion.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Dirección";
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(837, 233);
            this.tbx_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(193, 22);
            this.tbx_email.TabIndex = 51;
            // 
            // tbx_apellido
            // 
            this.tbx_apellido.Location = new System.Drawing.Point(837, 185);
            this.tbx_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_apellido.Name = "tbx_apellido";
            this.tbx_apellido.Size = new System.Drawing.Size(193, 22);
            this.tbx_apellido.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(747, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(747, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Apellidos";
            // 
            // tbx_telefono
            // 
            this.tbx_telefono.Location = new System.Drawing.Point(524, 228);
            this.tbx_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_telefono.Name = "tbx_telefono";
            this.tbx_telefono.Size = new System.Drawing.Size(201, 22);
            this.tbx_telefono.TabIndex = 47;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(524, 182);
            this.tbx_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(201, 22);
            this.tbx_nombre.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre";
            // 
            // tbx_horario
            // 
            this.tbx_horario.Location = new System.Drawing.Point(837, 359);
            this.tbx_horario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_horario.Name = "tbx_horario";
            this.tbx_horario.Size = new System.Drawing.Size(193, 22);
            this.tbx_horario.TabIndex = 61;
            // 
            // tbx_antiguedad
            // 
            this.tbx_antiguedad.Location = new System.Drawing.Point(837, 313);
            this.tbx_antiguedad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_antiguedad.Name = "tbx_antiguedad";
            this.tbx_antiguedad.Size = new System.Drawing.Size(193, 22);
            this.tbx_antiguedad.TabIndex = 60;
            this.tbx_antiguedad.Text = "0";
            this.tbx_antiguedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(747, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "Horario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(747, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Antiguedad";
            // 
            // tbx_salario
            // 
            this.tbx_salario.Location = new System.Drawing.Point(524, 354);
            this.tbx_salario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_salario.Name = "tbx_salario";
            this.tbx_salario.Size = new System.Drawing.Size(201, 22);
            this.tbx_salario.TabIndex = 57;
            this.tbx_salario.Text = "0";
            this.tbx_salario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_estudios
            // 
            this.tbx_estudios.Location = new System.Drawing.Point(524, 309);
            this.tbx_estudios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_estudios.Name = "tbx_estudios";
            this.tbx_estudios.Size = new System.Drawing.Size(201, 22);
            this.tbx_estudios.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Salario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 54;
            this.label10.Text = "Grado Estudios";
            // 
            // tbx_puesto
            // 
            this.tbx_puesto.Location = new System.Drawing.Point(837, 271);
            this.tbx_puesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_puesto.Name = "tbx_puesto";
            this.tbx_puesto.Size = new System.Drawing.Size(193, 22);
            this.tbx_puesto.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(747, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 64;
            this.label11.Text = "Puesto";
            // 
            // btn_AGREGAR
            // 
            this.btn_AGREGAR.Location = new System.Drawing.Point(868, 398);
            this.btn_AGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AGREGAR.Name = "btn_AGREGAR";
            this.btn_AGREGAR.Size = new System.Drawing.Size(164, 48);
            this.btn_AGREGAR.TabIndex = 67;
            this.btn_AGREGAR.Text = "Agregar";
            this.btn_AGREGAR.UseVisualStyleBackColor = true;
            this.btn_AGREGAR.Click += new System.EventHandler(this.btn_AGREGAR_Click);
            // 
            // btn_CONSULTAR
            // 
            this.btn_CONSULTAR.Location = new System.Drawing.Point(79, 282);
            this.btn_CONSULTAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CONSULTAR.Name = "btn_CONSULTAR";
            this.btn_CONSULTAR.Size = new System.Drawing.Size(164, 48);
            this.btn_CONSULTAR.TabIndex = 68;
            this.btn_CONSULTAR.Text = "Consultar";
            this.btn_CONSULTAR.UseVisualStyleBackColor = true;
            this.btn_CONSULTAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(80, 635);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 48);
            this.button3.TabIndex = 69;
            this.button3.Text = "CONSULTAR TODO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgv_PERSONAL
            // 
            this.dtgv_PERSONAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_PERSONAL.Location = new System.Drawing.Point(80, 453);
            this.dtgv_PERSONAL.Name = "dtgv_PERSONAL";
            this.dtgv_PERSONAL.RowHeadersWidth = 51;
            this.dtgv_PERSONAL.RowTemplate.Height = 24;
            this.dtgv_PERSONAL.Size = new System.Drawing.Size(952, 175);
            this.dtgv_PERSONAL.TabIndex = 70;
            // 
            // rbtn_Eliminar
            // 
            this.rbtn_Eliminar.AutoSize = true;
            this.rbtn_Eliminar.Location = new System.Drawing.Point(209, 126);
            this.rbtn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Eliminar.Name = "rbtn_Eliminar";
            this.rbtn_Eliminar.Size = new System.Drawing.Size(79, 21);
            this.rbtn_Eliminar.TabIndex = 71;
            this.rbtn_Eliminar.Text = "Eliminar";
            this.rbtn_Eliminar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.rbtn_Eliminar.UseVisualStyleBackColor = true;
            this.rbtn_Eliminar.CheckedChanged += new System.EventHandler(this.rbtn_Eliminar_CheckedChanged);
            // 
            // rbtn_MODIFICAR
            // 
            this.rbtn_MODIFICAR.AutoSize = true;
            this.rbtn_MODIFICAR.Location = new System.Drawing.Point(887, 126);
            this.rbtn_MODIFICAR.Name = "rbtn_MODIFICAR";
            this.rbtn_MODIFICAR.Size = new System.Drawing.Size(143, 21);
            this.rbtn_MODIFICAR.TabIndex = 72;
            this.rbtn_MODIFICAR.Text = "Modificar Registro";
            this.rbtn_MODIFICAR.UseVisualStyleBackColor = true;
            this.rbtn_MODIFICAR.CheckedChanged += new System.EventHandler(this.rbtn_MODIFICAR_CheckedChanged);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 706);
            this.Controls.Add(this.rbtn_MODIFICAR);
            this.Controls.Add(this.rbtn_Eliminar);
            this.Controls.Add(this.dtgv_PERSONAL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_CONSULTAR);
            this.Controls.Add(this.btn_AGREGAR);
            this.Controls.Add(this.tbx_puesto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbx_horario);
            this.Controls.Add(this.tbx_antiguedad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_salario);
            this.Controls.Add(this.tbx_estudios);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbx_direccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_email);
            this.Controls.Add(this.tbx_apellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_telefono);
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
            this.Controls.Add(this.btn_exit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Personal";
            this.Text = "Personal  -  CHUCHOLANDIA®";
            this.Load += new System.EventHandler(this.Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_PERSONAL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox tbx_consulta_codigo;
        private System.Windows.Forms.TextBox tbx_consulta_nombre;
        private System.Windows.Forms.Label lbl_CONSULTA_CODIGO;
        private System.Windows.Forms.Label lbl_CONSULTA_NOMBRE;
        private System.Windows.Forms.RadioButton rbtn_AGREGAR;
        private System.Windows.Forms.RadioButton rbtn_CONSULTAR;
        private System.Windows.Forms.TextBox tbx_direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_telefono;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_horario;
        private System.Windows.Forms.TextBox tbx_antiguedad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_salario;
        private System.Windows.Forms.TextBox tbx_estudios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_puesto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_AGREGAR;
        private System.Windows.Forms.Button btn_CONSULTAR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dtgv_PERSONAL;
        private System.Windows.Forms.RadioButton rbtn_Eliminar;
        private System.Windows.Forms.RadioButton rbtn_MODIFICAR;
    }
}