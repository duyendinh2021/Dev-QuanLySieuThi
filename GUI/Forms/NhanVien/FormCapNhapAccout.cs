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

namespace GUI.Forms
{
    public partial class FormCapNhapAccout : Form
    {
        public FormCapNhapAccout()
        {
            InitializeComponent();

        }

        int trangthai;
        int id;
        string uesrname;
        string chucvu;
        string pass;
        public FormCapNhapAccout(int id, string tk, string mk, int trangthai, string chucvu)
        {
            InitializeComponent();
            txtTaiKhoan.Text = tk;
            txtMk.Text = mk;

            uesrname = tk;
            pass = mk;
            this.id = id;
            this.trangthai = trangthai;
            this.chucvu = chucvu;
        }

        private void setBtn(Boolean status)
        {
            txtMk.ReadOnly = !status;


            cmbTrangThai.Enabled = status;
        }

        private void FormViewAccout_Load(object sender, EventArgs e)
        {
            setBtn(false);
            if (trangthai == 1)
            {
                cmbTrangThai.SelectedIndex = 0;
            }
            else if (trangthai == 0)
            {
                cmbTrangThai.SelectedIndex = 1;
            }
            txtTaiKhoan.ReadOnly = true;
            if (chucvu == "Admin")
            {
                txtMk.UseSystemPasswordChar = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            if (chucvu == "Admin")
            {
                MessageBox.Show("Không Thể Chỉnh Sửa Tài Khoản Admin");
            }
            else
            {
                setBtn(true);
            }
        }



        //btn cập nhật click
        [Obsolete]
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string tkupdate = txtTaiKhoan.Text;
            string passupdate = txtMk.Text;
            int trangthaiupdate = -1;
            if (txtMk.Text == "" || txtTaiKhoan.Text == "" || cmbTrangThai.SelectedIndex == -1)
            {
                MessageBox.Show("Thông tin chưa đủ, vui lòng kiểm tra lại. Tks!!!");
            }
            else
            {
                DialogResult result = MessageBox.Show("Hãy xác nhân thông tin bạn nhập là chính xác !!!", "Thông báo quan trọng", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    switch (cmbTrangThai.SelectedIndex)
                    {
                        case 0:
                            trangthaiupdate = 1;
                            break;
                        case 1:
                            trangthaiupdate = 0;
                            break;
                        default:
                            break;
                    }
                    object[] objects = new object[] { id, tkupdate, passupdate, chucvu, trangthaiupdate };
                    if (BUS.B_TaiKhoan.Instance.updateTaikhoan(objects))
                    {
                        MessageBox.Show("Cập nhật thành công", "Thật tuyệt vời");
                    }
                    else
                    {
                        MessageBox.Show("Ô Nô !!!", "Có gì đó sai sai");
                    }
                }
            }

        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Email_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không thể nhập ký tự này");
                e.Handled = true;
            }
        }

        private void txtMk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Password_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không thể nhập ký tự này");
                e.Handled = true;
            }
        }
    }
}
