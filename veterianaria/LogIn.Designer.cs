
namespace veterianaria
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_USER = new System.Windows.Forms.Label();
            this.lbl_PASSWORD = new System.Windows.Forms.Label();
            this.btn_ENTRAR = new System.Windows.Forms.Button();
            this.txb_PASSWORD = new System.Windows.Forms.TextBox();
            this.txb_USER = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_USER
            // 
            this.lbl_USER.AutoSize = true;
            this.lbl_USER.Location = new System.Drawing.Point(208, 198);
            this.lbl_USER.Name = "lbl_USER";
            this.lbl_USER.Size = new System.Drawing.Size(70, 17);
            this.lbl_USER.TabIndex = 0;
            this.lbl_USER.Text = "USUARIO";
            // 
            // lbl_PASSWORD
            // 
            this.lbl_PASSWORD.AutoSize = true;
            this.lbl_PASSWORD.Location = new System.Drawing.Point(208, 246);
            this.lbl_PASSWORD.Name = "lbl_PASSWORD";
            this.lbl_PASSWORD.Size = new System.Drawing.Size(103, 17);
            this.lbl_PASSWORD.TabIndex = 1;
            this.lbl_PASSWORD.Text = "CONTRASEÑA";
            // 
            // btn_ENTRAR
            // 
            this.btn_ENTRAR.Location = new System.Drawing.Point(261, 295);
            this.btn_ENTRAR.Name = "btn_ENTRAR";
            this.btn_ENTRAR.Size = new System.Drawing.Size(142, 41);
            this.btn_ENTRAR.TabIndex = 2;
            this.btn_ENTRAR.Text = "ENTRAR";
            this.btn_ENTRAR.UseVisualStyleBackColor = true;
            this.btn_ENTRAR.Click += new System.EventHandler(this.btn_ENTRAR_Click);
            // 
            // txb_PASSWORD
            // 
            this.txb_PASSWORD.Location = new System.Drawing.Point(346, 241);
            this.txb_PASSWORD.Name = "txb_PASSWORD";
            this.txb_PASSWORD.PasswordChar = '*';
            this.txb_PASSWORD.Size = new System.Drawing.Size(100, 22);
            this.txb_PASSWORD.TabIndex = 3;
            // 
            // txb_USER
            // 
            this.txb_USER.Location = new System.Drawing.Point(346, 198);
            this.txb_USER.Name = "txb_USER";
            this.txb_USER.Size = new System.Drawing.Size(100, 22);
            this.txb_USER.TabIndex = 4;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 589);
            this.Controls.Add(this.txb_USER);
            this.Controls.Add(this.txb_PASSWORD);
            this.Controls.Add(this.btn_ENTRAR);
            this.Controls.Add(this.lbl_PASSWORD);
            this.Controls.Add(this.lbl_USER);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inicio de Sesión  -  CHUCHOLANDIA®";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_USER;
        private System.Windows.Forms.Label lbl_PASSWORD;
        private System.Windows.Forms.Button btn_ENTRAR;
        private System.Windows.Forms.TextBox txb_PASSWORD;
        private System.Windows.Forms.TextBox txb_USER;
    }
}

