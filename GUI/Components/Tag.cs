using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Components
{
    public partial class Tag : UserControl
    {
        public Tag()
        {
            InitializeComponent();
        }
        private IconPictureBox icon;
        public string Title { get => label1.Text; set => label1.Text = value; }
        public string Cost { get => label2.Text; set => label2.Text = value; }
        public IconPictureBox Image { get => iconPictureBox1; set { icon = value; iconPictureBox1.IconChar = icon.IconChar; } }
    }
}
