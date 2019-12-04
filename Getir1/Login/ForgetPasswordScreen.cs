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

namespace Getir1
{
    public partial class ForgetPasswordScreen : Form
    {
        public ForgetPasswordScreen()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendEmail();
        }

        private void ForgetPasswordScreen_Load(object sender, EventArgs e)
        {
            lblAutomaticMessage.Visible = false;
        }

        private void ForgetPasswordScreen_Deactivate(object sender, EventArgs e)
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
                sc.Credentials = new NetworkCredential("eleph.cnylmz@gmail.com", "can.yilmaz");

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("eleph.cnylmz@gmail.com", "Sanal Pazar");

                mail.To.Add(txtEmail.Text);

                mail.Subject = "Yeni Şifre";
                mail.IsBodyHtml = true;
                mail.Body = "000111222";

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
