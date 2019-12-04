using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Getir1.Data;

namespace Getir1
{
    public partial class ForgetPasswordScreen : Form
    {
        SqlData sqlData;
        int newPass;
        public ForgetPasswordScreen()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sqlData = new SqlData();
            if (sqlData.NewPassword(txtEmail.Text, getNewPass()))
            {
                SendEmail();
            }
            else
            {
                MessageBox.Show("Hata");
            }
            
        }
        
        private int getNewPass()
        {
            newPass = 123;
            return newPass;
        }

        private void ForgetPasswordScreen_Load(object sender, EventArgs e)
        {
            lblAutomaticMessage.Visible = false;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            LogInScreen f = new LogInScreen();
            f.Show();
            this.Close();
        }

        private void SendEmail()
        {
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("sanalpazar2020@gmail.com", "Sanalpazar123");

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("sanalpazar2020@gmail.com", "Sanal Pazar");

                mail.To.Add(txtEmail.Text);

                mail.Subject = "Yeni Şifre";
                mail.IsBodyHtml = true;
                mail.Body = "Yeni Şifreniz : " + newPass;

                sc.Send(mail);

                
                lblAutomaticMessage.Text = "Email adresiniz sistemde bulunuyor ise size geçiçi bir parola gönderilecektir.";
            }
            catch(Exception e)
            {
                lblAutomaticMessage.Text = e.Message.ToString();
            }
            finally
            {
                lblAutomaticMessage.Visible = true;
            }
        }
    }
}
