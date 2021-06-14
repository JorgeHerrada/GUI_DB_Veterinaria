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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btn_ENTRAR_Click(object sender, EventArgs e)
        {
            // VALIDATE USER AND PASSWORD
            if (txb_USER.Text == "admin")
            {
                if(txb_PASSWORD.Text == "12345")
                {
                    // CLOSE CURRENT WINDOW AND OPEN MENU

                    Menu menuOpciones = new Menu(); // CREATE INSTANCE
                    

                    this.Hide(); // HIDE THE CURRENT WINDOW

                    // LAMBDA FUNCTION THAT CLOSE THE CURRENT FORM ONLY WHEN THE NEW ONE IS CLOSED
                    menuOpciones.Closed += (s, args) => this.Close(); 
                    menuOpciones.Show(); // DISPLAY INSTANCE
                    // IF "this.Close()" IS USED, IT WILL CLOSE ALL INSTANCES THAT DEPEND ON "this" LIKE: "menuOpciones"
                }
                else
                {
                    MessageBox.Show("El usuario y/o Contraseña no coinciden. Intenta de nuevo.", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // SHOW ERROR WINDOW AND TRY AGAIN
                MessageBox.Show("El usuario y/o Contraseña no coinciden. Intenta de nuevo.","¡ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            txb_USER.Text = "admin";        // JUST FOR DEBUGGING PURPOSES, DELETE LATTER
            txb_PASSWORD.Text = "12345";    // JUST FOR DEBUGGING PURPOSES, DELETE LATTER
        }
    }
}
