
namespace veterianaria
{
    partial class Clientes
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
            this.rbtn_CONSULTAR = new System.Windows.Forms.RadioButton();
            this.rbtn_AGREGAR = new System.Windows.Forms.RadioButton();
            this.lbl_CONSULTA_NOMBRE = new System.Windows.Forms.Label();
            this.lbl_CONSULTA_CODIGO = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tbx_consultar_nombre = new System.Windows.Forms.TextBox();
            this.tbx_consultar_codigo = new System.Windows.Forms.TextBox();
            this.tbx_telefono = new System.Windows.Forms.TextBox();
            this.tbx_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AGREGAR = new System.Windows.Forms.Button();
            this.CONSULTAR = new System.Windows.Forms.Button();
            this.btn_CONSULTAR_TODO = new System.Windows.Forms.Button();
            this.dtgv_CLIENTES = new System.Windows.Forms.DataGridView();
            this.rbtn_Eliminar = new System.Windows.Forms.RadioButton();
            this.rbtn_MODIFICAR = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CLIENTES)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(825, 581);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(164, 48);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "SALIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F);
            this.lbl_titulo.Location = new System.Drawing.Point(365, 25);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(221, 50);
            this.lbl_titulo.TabIndex = 2;
            this.lbl_titulo.Text = "CLIENTES";
            // 
            // rbtn_CONSULTAR
            // 
            this.rbtn_CONSULTAR.AutoSize = true;
            this.rbtn_CONSULTAR.Location = new System.Drawing.Point(49, 103);
            this.rbtn_CONSULTAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_CONSULTAR.Name = "rbtn_CONSULTAR";
            this.rbtn_CONSULTAR.Size = new System.Drawing.Size(89, 21);
            this.rbtn_CONSULTAR.TabIndex = 3;
            this.rbtn_CONSULTAR.TabStop = true;
            this.rbtn_CONSULTAR.Text = "Consultar";
            this.rbtn_CONSULTAR.UseVisualStyleBackColor = true;
            // 
            // rbtn_AGREGAR
            // 
            this.rbtn_AGREGAR.AutoSize = true;
            this.rbtn_AGREGAR.Location = new System.Drawing.Point(373, 101);
            this.rbtn_AGREGAR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_AGREGAR.Name = "rbtn_AGREGAR";
            this.rbtn_AGREGAR.Size = new System.Drawing.Size(80, 21);
            this.rbtn_AGREGAR.TabIndex = 4;
            this.rbtn_AGREGAR.TabStop = true;
            this.rbtn_AGREGAR.Text = "Agregar";
            this.rbtn_AGREGAR.UseVisualStyleBackColor = true;
            // 
            // lbl_CONSULTA_NOMBRE
            // 
            this.lbl_CONSULTA_NOMBRE.AutoSize = true;
            this.lbl_CONSULTA_NOMBRE.Location = new System.Drawing.Point(35, 162);
            this.lbl_CONSULTA_NOMBRE.Name = "lbl_CONSULTA_NOMBRE";
            this.lbl_CONSULTA_NOMBRE.Size = new System.Drawing.Size(58, 17);
            this.lbl_CONSULTA_NOMBRE.TabIndex = 5;
            this.lbl_CONSULTA_NOMBRE.Text = "Nombre";
            // 
            // lbl_CONSULTA_CODIGO
            // 
            this.lbl_CONSULTA_CODIGO.AutoSize = true;
            this.lbl_CONSULTA_CODIGO.Location = new System.Drawing.Point(35, 210);
            this.lbl_CONSULTA_CODIGO.Name = "lbl_CONSULTA_CODIGO";
            this.lbl_CONSULTA_CODIGO.Size = new System.Drawing.Size(52, 17);
            this.lbl_CONSULTA_CODIGO.TabIndex = 6;
            this.lbl_CONSULTA_CODIGO.Text = "Codigo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tbx_consultar_nombre
            // 
            this.tbx_consultar_nombre.Location = new System.Drawing.Point(147, 158);
            this.tbx_consultar_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consultar_nombre.Name = "tbx_consultar_nombre";
            this.tbx_consultar_nombre.Size = new System.Drawing.Size(100, 22);
            this.tbx_consultar_nombre.TabIndex = 8;
            // 
            // tbx_consultar_codigo
            // 
            this.tbx_consultar_codigo.Location = new System.Drawing.Point(147, 206);
            this.tbx_consultar_codigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_consultar_codigo.Name = "tbx_consultar_codigo";
            this.tbx_consultar_codigo.Size = new System.Drawing.Size(100, 22);
            this.tbx_consultar_codigo.TabIndex = 9;
            this.tbx_consultar_codigo.Text = "0";
            this.tbx_consultar_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbx_telefono
            // 
            this.tbx_telefono.Location = new System.Drawing.Point(483, 206);
            this.tbx_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_telefono.Name = "tbx_telefono";
            this.tbx_telefono.Size = new System.Drawing.Size(201, 22);
            this.tbx_telefono.TabIndex = 13;
            // 
            // tbx_nombre
            // 
            this.tbx_nombre.Location = new System.Drawing.Point(483, 160);
            this.tbx_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_nombre.Name = "tbx_nombre";
            this.tbx_nombre.Size = new System.Drawing.Size(201, 22);
            this.tbx_nombre.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // tbx_email
            // 
            this.tbx_email.Location = new System.Drawing.Point(795, 210);
            this.tbx_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(193, 22);
            this.tbx_email.TabIndex = 17;
            this.tbx_email.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbx_apellido
            // 
            this.tbx_apellido.Location = new System.Drawing.Point(795, 162);
            this.tbx_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_apellido.Name = "tbx_apellido";
            this.tbx_apellido.Size = new System.Drawing.Size(193, 22);
            this.tbx_apellido.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(705, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(705, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Apellido";
            // 
            // tbx_direccion
            // 
            this.tbx_direccion.Location = new System.Drawing.Point(483, 249);
            this.tbx_direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbx_direccion.Name = "tbx_direccion";
            this.tbx_direccion.Size = new System.Drawing.Size(201, 22);
            this.tbx_direccion.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dirección";
            // 
            // btn_AGREGAR
            // 
            this.btn_AGREGAR.Location = new System.Drawing.Point(825, 249);
            this.btn_AGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AGREGAR.Name = "btn_AGREGAR";
            this.btn_AGREGAR.Size = new System.Drawing.Size(164, 48);
            this.btn_AGREGAR.TabIndex = 22;
            this.btn_AGREGAR.Text = "Agregar";
            this.btn_AGREGAR.UseVisualStyleBackColor = true;
            this.btn_AGREGAR.Click += new System.EventHandler(this.btn_AGREGAR_Click);
            // 
            // CONSULTAR
            // 
            this.CONSULTAR.Location = new System.Drawing.Point(38, 249);
            this.CONSULTAR.Margin = new System.Windows.Forms.Padding(4);
            this.CONSULTAR.Name = "CONSULTAR";
            this.CONSULTAR.Size = new System.Drawing.Size(164, 48);
            this.CONSULTAR.TabIndex = 23;
            this.CONSULTAR.Text = "Consultar";
            this.CONSULTAR.UseVisualStyleBackColor = true;
            this.CONSULTAR.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_CONSULTAR_TODO
            // 
            this.btn_CONSULTAR_TODO.Location = new System.Drawing.Point(38, 581);
            this.btn_CONSULTAR_TODO.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CONSULTAR_TODO.Name = "btn_CONSULTAR_TODO";
            this.btn_CONSULTAR_TODO.Size = new System.Drawing.Size(164, 48);
            this.btn_CONSULTAR_TODO.TabIndex = 24;
            this.btn_CONSULTAR_TODO.Text = "CONSULTAR TODO";
            this.btn_CONSULTAR_TODO.UseVisualStyleBackColor = true;
            this.btn_CONSULTAR_TODO.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtgv_CLIENTES
            // 
            this.dtgv_CLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_CLIENTES.Location = new System.Drawing.Point(39, 322);
            this.dtgv_CLIENTES.Name = "dtgv_CLIENTES";
            this.dtgv_CLIENTES.RowHeadersWidth = 51;
            this.dtgv_CLIENTES.RowTemplate.Height = 24;
            this.dtgv_CLIENTES.Size = new System.Drawing.Size(950, 236);
            this.dtgv_CLIENTES.TabIndex = 25;
            // 
            // rbtn_Eliminar
            // 
            this.rbtn_Eliminar.AutoSize = true;
            this.rbtn_Eliminar.Location = new System.Drawing.Point(158, 103);
            this.rbtn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtn_Eliminar.Name = "rbtn_Eliminar";
            this.rbtn_Eliminar.Size = new System.Drawing.Size(79, 21);
            this.rbtn_Eliminar.TabIndex = 26;
            this.rbtn_Eliminar.TabStop = true;
            this.rbtn_Eliminar.Text = "Eliminar";
            this.rbtn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // rbtn_MODIFICAR
            // 
            this.rbtn_MODIFICAR.AutoSize = true;
            this.rbtn_MODIFICAR.Location = new System.Drawing.Point(846, 103);
            this.rbtn_MODIFICAR.Name = "rbtn_MODIFICAR";
            this.rbtn_MODIFICAR.Size = new System.Drawing.Size(143, 21);
            this.rbtn_MODIFICAR.TabIndex = 59;
            this.rbtn_MODIFICAR.TabStop = true;
            this.rbtn_MODIFICAR.Text = "Modificar Registro";
            this.rbtn_MODIFICAR.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 654);
            this.Controls.Add(this.rbtn_MODIFICAR);
            this.Controls.Add(this.rbtn_Eliminar);
            this.Controls.Add(this.dtgv_CLIENTES);
            this.Controls.Add(this.btn_CONSULTAR_TODO);
            this.Controls.Add(this.CONSULTAR);
            this.Controls.Add(this.btn_AGREGAR);
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
            this.Controls.Add(this.tbx_consultar_codigo);
            this.Controls.Add(this.tbx_consultar_nombre);
            this.Controls.Add(this.lbl_CONSULTA_CODIGO);
            this.Controls.Add(this.lbl_CONSULTA_NOMBRE);
            this.Controls.Add(this.rbtn_AGREGAR);
            this.Controls.Add(this.rbtn_CONSULTAR);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clientes";
            this.RightToLeftLayout = true;
            this.Text = "Clientes  -  CHUCHOLANDIA®";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_CLIENTES)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.RadioButton rbtn_CONSULTAR;
        private System.Windows.Forms.RadioButton rbtn_AGREGAR;
        private System.Windows.Forms.Label lbl_CONSULTA_NOMBRE;
        private System.Windows.Forms.Label lbl_CONSULTA_CODIGO;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox tbx_consultar_nombre;
        private System.Windows.Forms.TextBox tbx_consultar_codigo;
        private System.Windows.Forms.TextBox tbx_telefono;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_apellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AGREGAR;
        private System.Windows.Forms.Button CONSULTAR;
        private System.Windows.Forms.Button btn_CONSULTAR_TODO;
        private System.Windows.Forms.DataGridView dtgv_CLIENTES;
        private System.Windows.Forms.RadioButton rbtn_Eliminar;
        private System.Windows.Forms.RadioButton rbtn_MODIFICAR;
    }
}