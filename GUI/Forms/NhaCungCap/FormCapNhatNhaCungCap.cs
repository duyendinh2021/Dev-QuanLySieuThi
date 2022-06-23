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
using BUS;

namespace GUI.Forms.NhaCungCap
{
    public partial class FormCapNhatNhaCungCap : Form
    {
        [Obsolete]
        public FormCapNhatNhaCungCap()
        {
            InitializeComponent();
        }

        int id_ncc;
        string ten_ct;
        string diachi;
        string sdt;
        string songanhang;
        string tennganhang;


        [Obsolete]
        public FormCapNhatNhaCungCap(int id_ncc, string ten_ct, string diach, string sdt, string soNganhang, string tenNganHang)
        {
            InitializeComponent();
            this.id_ncc = id_ncc;
            this.ten_ct = ten_ct;
            this.diachi = diach;
            this.sdt = sdt;
            this.songanhang = soNganhang;
            this.tennganhang = tenNganHang;
            txtTenCongTy.Text = this.ten_ct;
            txtDiaChi.Text = this.diachi;
            txtSDT.Text = this.sdt;
            txtSoNganHang.Text = this.songanhang;
            txtTenNganHang.Text = this.tennganhang;
        }


        [Obsolete]
        private void FormCapNhatNhaCungCap_Load(object sender, EventArgs e)
        {
            B_NhaCungCap.Instance.LoadComBoBoxNhaCungCapByID(id_ncc, ref cmbTrangThai);
            cmbTrangThai.SelectedIndex = 0;
        }

        private void btnEditTRangThaiNCC_Click(object sender, EventArgs e)
        {
            List<int> trangthai = new List<int>();
            trangthai.Add(1);
            trangthai.Add(0);
            cmbTrangThai.DataSource = trangthai;
        }



        [Obsolete]
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác Nhận Cập Nhật Nhà Cung Cấp Với Thông Tin Như Trên", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (result == DialogResult.Yes)
            {
                if (txtTenCongTy.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtSoNganHang.Text == "" || txtTenNganHang.Text == "" || cmbTrangThai.SelectedIndex == -1)
                {
                    MessageBox.Show("Thông Tin Chưa Đủ, Vui Lòng Kiểm Tra Lại");
                }
                else
                {
                    if (Rule_Regex.Instance.IsPhoneNbr(txtSDT.Text))
                    {
                        this.ten_ct = txtTenCongTy.Text;
                        this.sdt = txtSDT.Text;
                        this.tennganhang = txtTenNganHang.Text;
                        this.songanhang = txtSoNganHang.Text;
                        this.diachi = txtDiaChi.Text;
                        int trangthai = int.Parse(cmbTrangThai.SelectedValue.ToString());
                        object[] NhaCungCap = new object[] { id_ncc, ten_ct, diachi, sdt, songanhang, tennganhang, trangthai };
                        if (B_NhaCungCap.Instance.StokerUpdateNhaCungCap(NhaCungCap))
                        {
                            MessageBox.Show("Cập Nhật Nhà Cung Cấp Thành Công", "Thông Báo");
                        }
                        else
                        {
                            MessageBox.Show("Ô NÔ !!!", "Có Gì Đó Không Ổn");
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này");
                e.Handled = true;
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Address_Regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này");
                e.Handled = true;
            }
        }

        private void txtSoNganHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này");
                e.Handled = true;
            }
        }

        private void txtTenNganHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này");
                e.Handled = true;
            }
        }

        private void txtTenCongTy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này");
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenCongTy.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTenNganHang.Clear();
            txtSoNganHang.Clear();
            cmbTrangThai.SelectedIndex = -1;
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
                    cmbTrangThai.Focus();
                }
            }
        }

        private void cmbTrangThai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConfirm.Focus();
            }
        }
    }
}
