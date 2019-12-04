namespace Getir1
{
    partial class UrunItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunItem));
            this.label1 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SepetBtn = new System.Windows.Forms.Button();
            this.pBItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "kg";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.Maroon;
            this.lblItemName.Location = new System.Drawing.Point(20, 45);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(27, 16);
            this.lblItemName.TabIndex = 4;
            this.lblItemName.Text = "title";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(4, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(47, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // SepetBtn
            // 
            this.SepetBtn.BackColor = System.Drawing.Color.Transparent;
            this.SepetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SepetBtn.BackgroundImage")));
            this.SepetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SepetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SepetBtn.FlatAppearance.BorderSize = 0;
            this.SepetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.SepetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.SepetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SepetBtn.Location = new System.Drawing.Point(72, 67);
            this.SepetBtn.Name = "SepetBtn";
            this.SepetBtn.Size = new System.Drawing.Size(16, 16);
            this.SepetBtn.TabIndex = 1;
            this.SepetBtn.UseVisualStyleBackColor = false;
            // 
            // pBItem
            // 
            this.pBItem.Location = new System.Drawing.Point(13, 3);
            this.pBItem.Name = "pBItem";
            this.pBItem.Size = new System.Drawing.Size(66, 41);
            this.pBItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBItem.TabIndex = 0;
            this.pBItem.TabStop = false;
            // 
            // UrunItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SepetBtn);
            this.Controls.Add(this.pBItem);
            this.MaximumSize = new System.Drawing.Size(95, 91);
            this.Name = "UrunItem";
            this.Size = new System.Drawing.Size(95, 91);
            ((System.ComponentModel.ISupportInitialize)(this.pBItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBItem;
        private System.Windows.Forms.Button SepetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
