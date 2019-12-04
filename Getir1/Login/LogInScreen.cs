using Getir1.Data;
using Getir1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Getir1
{
    public partial class LogInScreen : Form
    {
        SqlData sqlData;
        public LogInScreen()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            sqlData = new SqlData();
            if(sqlData.Login(txtEmail.Text, txtPassword.Text))
            {
                LoadingScreen f = new LoadingScreen(txtEmail.Text);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adi yada sifre hatali");
            }

        }


        private void lblBtnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            ForgetPasswordScreen f = new ForgetPasswordScreen();
            f.Show();
            this.Hide();
        }
        private void lblBtnHesabımYok_Click(object sender, EventArgs e)
        {
            NewRegistrationScreen f = new NewRegistrationScreen();
            f.Show();
            this.Hide();
        }
        private void btnSee_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                btnSee.BackgroundImage = Resources.closed_eye;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnSee.BackgroundImage = Resources.eye;
            }
        }


    }
}
