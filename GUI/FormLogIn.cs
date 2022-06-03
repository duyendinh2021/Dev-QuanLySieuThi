using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.Focus();
            }
        }

        private void chkBoxHienMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode  == Keys.Enter)
            {
                chkBoxHienMK.Checked = true;
            }
        }

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            // thực hiện đăng nhập
            if (e.KeyCode == Keys.Enter)
            {

            }
            else if (e.KeyCode == Keys.Tab)
            {
                lblLinkQuanMK.Focus();
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.UserNam_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không thể nhập ký tự này !!!");                   
                e.Handled = true;
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Password_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không thể nhập ký tự này !!!");
                e.Handled = true;
            }
        }

        private void chkBoxHienMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkBoxHienMK.Checked;
        }

        private void lblLinkQuanMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chưa làm chức năng này");
        }

        [Obsolete]
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string accUesrLogIn = txtTaiKhoan.Text;
            string passUesrLogIn = txtMatKhau.Text;

            if (B_TaiKhoan.Instance.UserLogIn(accUesrLogIn,passUesrLogIn))
            {
                MessageBox.Show("thanh cong");
                switch (B_TaiKhoan.Instance.quyen)
                {
                    //Admin, Cashier, Stoker
                    case "Admin":
                        MessageBox.Show("admin");
                        break;
                    case "Cashier":
                        MessageBox.Show("Cashier");
                        break;
                    case "Stoker":
                        MessageBox.Show("Stoker");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("that bai");

            }
        }
    }
}
