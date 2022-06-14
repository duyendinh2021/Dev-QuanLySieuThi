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
        public string Title { get => label1.Text; set => label1.Text = value; }
        public string Cost { get => label2.Text; set => label2.Text = value; }

        public Image Image { get => pictureBox1.Image; set => pictureBox1.Image = value; }
        public int Id { get => id; set => id = value; }
        public int Id_loai { get => id_loai; set => id_loai = value; }
    }
}
