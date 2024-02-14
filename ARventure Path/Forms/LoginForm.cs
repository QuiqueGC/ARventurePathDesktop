using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARventure_Path.Forms
{
    public partial class LoginForm : Form
    {
        private String userName = "ll";
        private String passwd = "ll";
        private MainForm mainForm;

        public LoginForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text.Equals("") || textBoxPwd.Text.Equals(""))
            {
                MessageBox.Show("Debes rellenar los dos campos.", "Error");

            }else if (!textBoxUser.Text.Equals(userName))
            {
                MessageBox.Show("El nombre de usuario no es correcto.", "Error");

            }else if(!textBoxPwd.Text.Equals(passwd)) 
            {
                MessageBox.Show("La contraseña no es correcta.", "Error");
            }
            else 
            { 
                groupBoxLogin.Visible = false;
                mainForm.menuStripMain.Visible = true;
                pictureBoxArventurePath.Size = new System.Drawing.Size(928,590);
                pictureBoxArventurePath.Location = new System.Drawing.Point(20, 0);
            }

                
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e){ Login(e);}

        private void textBoxPwd_KeyDown(object sender, KeyEventArgs e){Login(e);}

        private void Login(KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }
    }
}
