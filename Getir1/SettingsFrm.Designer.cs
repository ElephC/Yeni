namespace Getir1
{
    partial class SettingsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsFrm));
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailChangeBtn = new System.Windows.Forms.Button();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.SeeBtn = new System.Windows.Forms.Button();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(35, 55);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(246, 20);
            this.emailTxt.TabIndex = 0;
            // 
            // emailChangeBtn
            // 
            this.emailChangeBtn.Location = new System.Drawing.Point(206, 81);
            this.emailChangeBtn.Name = "emailChangeBtn";
            this.emailChangeBtn.Size = new System.Drawing.Size(75, 23);
            this.emailChangeBtn.TabIndex = 1;
            this.emailChangeBtn.Text = "Değiştir";
            this.emailChangeBtn.UseVisualStyleBackColor = true;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(35, 36);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(32, 13);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "Email";
            // 
            // SeeBtn
            // 
            this.SeeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SeeBtn.BackgroundImage")));
            this.SeeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SeeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SeeBtn.Location = new System.Drawing.Point(287, 120);
            this.SeeBtn.Name = "SeeBtn";
            this.SeeBtn.Size = new System.Drawing.Size(25, 20);
            this.SeeBtn.TabIndex = 3;
            this.SeeBtn.UseVisualStyleBackColor = true;
            this.SeeBtn.Click += new System.EventHandler(this.SeeBtn_Click);
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(35, 101);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(28, 13);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Şifre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Değiştir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(35, 120);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(246, 20);
            this.passwordTxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ödeme Yöntemi";
            // 
            // SettingsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.SeeBtn);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.emailChangeBtn);
            this.Controls.Add(this.emailTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Button emailChangeBtn;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Button SeeBtn;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label1;
    }
}