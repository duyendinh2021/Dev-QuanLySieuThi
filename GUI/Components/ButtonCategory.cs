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

namespace UI.Components
{
    public partial class ButtonCategory : UserControl
    {
        public ButtonCategory()
        {
            InitializeComponent();
        }
        public event EventHandler OnSelect = null;

        private IconButton btn;
        private int ID_loai;
        public IconButton Button { get => btnAll; set { btn = value; btnAll.IconChar = btn.IconChar; btnAll.Text = btn.Text; } }
        public int ID_Loai { get => ID_loai; set => ID_loai = value; }

        private void btnAll_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
