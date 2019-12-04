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
    public partial class NewRegistrationScreen : Form
    {
        SqlData sqlData;
        public NewRegistrationScreen()
        {
            InitializeComponent();
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                txtPasswordT.PasswordChar = '\0';
                btnSee.BackgroundImage = Resources.closed_eye;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPasswordT.PasswordChar = '*';
                btnSee.BackgroundImage = Resources.eye;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogInScreen f = new LogInScreen();
            f.Show();
            this.Close();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            sqlData = new SqlData();
            if (sqlData.NewUser(txtEmail.Text, txtPassword.Text, txtAd.Text, txtSurname.Text, Convert.ToInt32(txtPhone.Text)))
            {
                MessageBox.Show("Basarili bir sekilde kayit olundu");
                LogInScreen f = new LogInScreen();
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayit sirasinda bir hata meydana geldi.");
            }
        }
    }
}
