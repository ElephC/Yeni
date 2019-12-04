using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Getir1
{
    public partial class LoadingScreen : Form
    {
        string email;
        public LoadingScreen(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 5;
            if(panel2.Width >= 700)
            {
                timer1.Stop();
                Form2 f = new Form2(email);
                f.Show();
                this.Hide();
            }
        }
    }
}
