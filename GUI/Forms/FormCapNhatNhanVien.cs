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
    public partial class FormCapNhatNhanVien : Form
    {
        public FormCapNhatNhanVien()
        {
            InitializeComponent();
        }
        public int idNhanVien;
        public string sPathImg = "";
        public Image img = null;
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
            if (Rule_Regex.Instance.UserNam_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
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

        private void btnImage_Click(object sender, EventArgs e)
        {
            sPathImg = SupportLogic.Instance.getPathFile();
            img = Image.FromFile(sPathImg);
            ptbShowImage.Image = img;
        }
        [Obsolete]
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtEmail.Text == "" || txtSDT.Text == "" || txtLuong.Text == "" || txtTenNganHang.Text == "" || txtSoNganHang.Text == "" || txtDiachi.Text == "" || sPathImg == "" || img == null)
            {
                MessageBox.Show("Bạn chưa điền thông tinh, vui lòng điền đủ");
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


                object[] objects = new object[] {idNhanVien,hoten,chucvu,gioiTinh,ngaySinh,ngayVaoLam,diachi,sdt,tenNganHang,soNganHang,luong,email,hinh};

                if (BUS.B_NhanVien.Instance.adminUpdateNhanVien(objects))
                {
                    MessageBox.Show("Cập Nhật Thành Công", "Thật Tuyệt Vời");
                }
                else
                {
                    MessageBox.Show("Ô nô !!!");
                }
            }
        }
        [Obsolete]
        private void FormCapNhatNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
             //BUS.B_NhanVien.Instance.getAllNhanVien(ref FormQuanLyNhanVien.dtGVDanhSachNV);
        }
    }
}
