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
using GUI.ClassSupport;


namespace GUI.Forms
{
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }
        private string sPathImg = "";
        private Image img = null;



        private void grBThongtin_Enter(object sender, EventArgs e)
        {

        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không nhập các kí tự này được !!!");
                e.Handled = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Email_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không nhập các kí tự này được !!!");
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không nhập các kí tự này được !!!");
                e.Handled = true;
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không nhập các kí tự này được !!!");
                e.Handled = true;
            }
        }

        private void txtSoNganHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không nhập các kí tự này được !!!");
                e.Handled = true;
            }
        }

        private void txtTenNganHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không nhập các kí tự này được !!!");
                e.Handled = true;
            }
        }

        private void txtDiachi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Address_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không nhập các kí tự này được !!!");
                e.Handled = true;
            }
        }

        [Obsolete]
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtEmail.Text == "" || txtSDT.Text == "" || txtLuong.Text == "" || txtTenNganHang.Text =="" || txtSoNganHang.Text =="" || txtDiachi.Text == "" || sPathImg == "" || img == null)
            {
                MessageBox.Show("Bạn chư nhập dủ thông tin, vui lòng nhập lại");
            }
            else
            {
                string hoten = txtHoTen.Text;
                string email = txtEmail.Text;
                string sdt = txtSDT.Text;
                decimal luong = decimal.Parse(txtLuong.Text);
                string tenNganHang = txtTenNganHang.Text;
                string soNganHang = txtSoNganHang.Text;
                string diachi = txtDiachi.Text;
                string gioiTinh = cmbGioiTinh.Text;
                string chucvu = cmbChucvu.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                DateTime ngayVaoLam = dtpNgayVaoLam.Value;
                byte[] hinh = System.IO.File.ReadAllBytes(sPathImg);

                object[] objects = new object[] { hoten, chucvu, gioiTinh, ngaySinh, ngayVaoLam, diachi, sdt, tenNganHang, soNganHang, luong, email, hinh };

                if (B_NhanVien.Instance.adminAddNhanVien(objects))
                {
                    MessageBox.Show("Thêm Nhân viên Thành Công", "Thật Tuyệt Vời");
                }
                else
                {
                    MessageBox.Show("Ô Nô !!!");
                }
            }                     
        }

        private void btnImage_Click(object sender, EventArgs e)
        {


            sPathImg = SupportLogic.Instance.getPathFile();
            img = Image.FromFile(sPathImg);
            ptbShowImage.Image = img;
        }

        private void FormThemNhanVien_Load(object sender, EventArgs e)
        {
            cmbChucvu.Text = cmbChucvu.Items[0].ToString();
            cmbGioiTinh.Text = cmbGioiTinh.Items[0].ToString();
            //giới hạn ngày vào làm với giới hạn ngày sinh tuối nhỏ nhất có thể
            dtpNgayVaoLam.MaxDate = DateTime.Now;
            dtpNgaySinh.MinDate = DateTime.Parse("01/01/1980");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtLuong.Clear();
            txtSoNganHang.Clear();
            txtTenNganHang.Clear();
            txtDiachi.Clear();
            sPathImg = "";
            img = null;
            ptbShowImage.Image = null;
            dtpNgaySinh.Value = DateTime.Parse("01/01/1999");
            dtpNgayVaoLam.Value = DateTime.Today;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
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
                    txtEmail.Focus();
                }
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
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
                    txtLuong.Focus();
                }
            }
        }

        private void txtLuong_KeyDown(object sender, KeyEventArgs e)
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
                    dtpNgaySinh.Focus();
                }
            }
        }

        private void dtpNgaySinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpNgayVaoLam.Focus();
            }
        }

        private void dtpNgayVaoLam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSoNganHang.Focus();
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
                    txtDiachi.Focus();
                }
            }
        }

        private void txtDiachi_KeyDown(object sender, KeyEventArgs e)
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
                    cmbChucvu.Focus();
                }
            }
        }

        private void cmbChucvu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbGioiTinh.Focus();
            }
        }

        private void cmbGioiTinh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnImage.Focus();
            }
        }
    }
}
