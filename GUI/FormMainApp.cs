using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMainApp : Form
    {
        public FormMainApp()
        {
            InitializeComponent();
        }
        public bool isThoat = true;
        private static Form formChild = null;


        public event EventHandler LogOut;


        [Obsolete]
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOut(this, new EventArgs());
            BUS.B_TaiKhoan.Instance.updateStatusLogin(BUS.B_TaiKhoan.Instance.id);


        }

        [Obsolete]
        private void FormMainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isThoat)
            {
                BUS.B_TaiKhoan.Instance.updateStatusLogin(BUS.B_TaiKhoan.Instance.id);
                Application.Exit();
            }
        }
    }
}
