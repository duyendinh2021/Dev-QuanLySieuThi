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
    public partial class Wiget : UserControl
    {
        private int id;
        private int id_loai;

        public event EventHandler OnSelect = null;
        public Wiget()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
        public string Title { get => lblName.Text; set => lblName.Text = value; }
        public string Cost { get => lblCost.Text; set => lblCost.Text = value; }

        public Image Image { get => ptbImage.Image; set => ptbImage.Image = value; }
        public int Id { get => id; set => id = value; }
        public int Id_loai { get => id_loai; set => id_loai = value; }
    }
}
