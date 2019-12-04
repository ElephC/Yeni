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
    public partial class Form2 : Form
    {
        SqlData sqlData;
        string email;
        User user;
        public Form2(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            welcomeMessage();
            populateItem();
        }
        private void welcomeMessage()
        {
            sqlData = new SqlData();
            user = sqlData.GetUser(email);
            //lblName.Text = "HOŞGELDİN "+user.name.ToUpper();
            lblName.Text = "HOŞGELDİN " + email;
        }
        private void populateItem()
        {
            string a = "domates";
            string b = "salatalik";
            UrunItem[] urunItem = new UrunItem[3];
            
            for (int i = 0; i < urunItem.Length; i++)
            {
                urunItem[i] = new UrunItem();
                urunItem[i].itemName = "domates";
                urunItem[i].picture = Resources.domates;
                
                if (flpst.Controls.Count < 0)
                {
                    flpst.Controls.Clear();
                }
                else
                    
                flpst.Controls.Add(urunItem[i]);
            }
        }

        private void SepetBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
