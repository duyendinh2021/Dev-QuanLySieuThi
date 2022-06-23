using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.ClassSupport;

namespace GUI.Forms
{
    public partial class FormThemNhaCungCap : Form
    {
        public FormThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenCongTy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này !!!", "Thông Báo");
                e.Handled = true;
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Address_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này !!!", "Thông Báo");
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này !!!", "Thông Báo");
                e.Handled = true;
            }
        }

        private void txtSoNganHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này !!!", "Thông Báo");
                e.Handled = true;
            }
        }

        private void txtTenNganHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này !!!", "Thông Báo");
                e.Handled = true;
            }
        }

        private void txtTenCongTy_KeyDown(object sender, KeyEventArgs e)
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
                    txtDiaChi.Focus();
                }
            }
        }

        private void txtDiaChi_KeyDown(object sender, KeyEventArgs e)
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
                    txtSDT.Focus();
                }
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
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
                    txtSoNganHang.Focus();
                }
            }
        }

        private void txtSoNganHang_KeyDown(object sender, KeyEventArgs e)
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
                    txtTenNganHang.Focus();
                }
            }
        }

        private void txtTenNganHang_KeyDown(object sender, KeyEventArgs e)
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
                    btnConfirm.Focus();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenCongTy.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtSoNganHang.Clear();
            txtTenNganHang.Clear();
        }


        [Obsolete]
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtTenCongTy.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtSoNganHang.Text == "" || txtTenNganHang.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Dủ Thông Tin Vui Lòng Xem Lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (Rule_Regex.Instance.IsPhoneNbr(txtSDT.Text))
                {
                    string tenCongTy = txtTenCongTy.Text;
                    string diaChi = txtDiaChi.Text;
                    string soNganHang = txtSoNganHang.Text;
                    string tenNganHang = txtTenNganHang.Text;
                    string sdt = txtSDT.Text;

                    object[] objects = new object[] { tenCongTy, diaChi, sdt, soNganHang, tenNganHang };
                    if (BUS.B_NhaCungCap.Instance.stokerAddNhaCungCap(objects))
                    {
                        MessageBox.Show("Thêm Nhà Cung Cấp Thành Công", "Thật Tuyệt Vời");
                    }
                    else
                    {
                        MessageBox.Show("Ô Nô !!!", "Có Gì Đó lỗi Ở Đây");
                    }
                }
                else
                {
                    MessageBox.Show("Không phải sô điện thoại, vui lòng nhập lại", "Thông Báo");
                    txtSDT.Focus();
                }
  
            }
        }
    }
}
