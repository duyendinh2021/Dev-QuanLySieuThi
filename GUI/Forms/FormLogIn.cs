using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GUI.Forms.NhanVien;
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

            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtMatKhau.Focus();
                }
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnDangNhap.Focus();
                }
            }
        }

        private void chkBoxHienMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkBoxHienMK.Checked = true;
            }
        }

        [Obsolete]
        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            // thực hiện đăng nhập
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Tab)
            {
                lblLinkQuanMK.Focus();
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Email_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
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
            MessageBox.Show("Vui liên hệ quản trị viên dể biết giải quyết SDT:XXXXXXXXXXXXX", "Thông Báo");
        }

        [Obsolete]
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string accUesrLogIn = txtTaiKhoan.Text;
            string passUesrLogIn = txtMatKhau.Text;
            string message = "";
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Chưa Nhập :((", "Err");
                txtTaiKhoan.Focus();
            }
            else
            {
                if (B_TaiKhoan.Instance.UserLogIn(accUesrLogIn, passUesrLogIn, ref message))
                {

                    if (B_TaiKhoan.Instance.pass == "123")
                    {
                        MessageBox.Show("Vui long doi mat khau", "Thong Bao");
                        FormChangePassWord formChangePassWord = new FormChangePassWord(B_TaiKhoan.Instance.id);
                        formChangePassWord.ShowDialog();
                    }

                    FormMainApp formMainApp = new FormMainApp();
                    formMainApp.Show();
                    B_TaiKhoan.Instance.updateStatusLogin(B_TaiKhoan.Instance.id);
                    this.Hide();
                    formMainApp.LogOut += FormMainApp_LogOut;
                }
                else
                {
                    MessageBox.Show(message);

                }
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
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            B_TaiKhoan.Instance.updateStatusLogin(B_TaiKhoan.Instance.id);
        }
    }
}
