using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Getir1
{
    public partial class UrunItem : UserControl
    {
        public UrunItem()
        {
            InitializeComponent();
        }

        private string _itemName;
        private Image _picture;

        public string itemName
        {
            get { return _itemName; }
            set { _itemName = value; lblItemName.Text = value; }
        }
        public Image picture
        {
            get { return _picture; }
            set { _picture = value; pBItem.Image = value; }
        }

    }
}
