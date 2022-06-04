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
        [Obsolete]
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
            if (e.KeyCode == Keys.Enter)
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

            if (B_TaiKhoan.Instance.UserLogIn(accUesrLogIn, passUesrLogIn))
            {
                FormMainApp formMainApp = new FormMainApp();
                formMainApp.Show();
                this.Hide();
                formMainApp.LogOut += FormMainApp_LogOut;
            }
            else
            {
                MessageBox.Show("that bai");

            }
        }

        private void FormMainApp_LogOut(object sender, EventArgs e)
        {
            (sender as FormMainApp).isThoat = false;
            (sender as FormMainApp).Close();
            this.Show();
        }

        [Obsolete]
        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắt muốn thoát chứ ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
                BUS.B_TaiKhoan.Instance.updateStatusLogin(BUS.B_TaiKhoan.Instance.id);
            }
        }
    }
}
