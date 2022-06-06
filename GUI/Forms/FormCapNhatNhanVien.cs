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
        [Obsolete]
        public FormCapNhatNhanVien()
        {
            InitializeComponent();
        }
        public int idNhanVien;
        public string sPathImg = "";
        public Image img = null;
        public byte[] dataImg = null;

        public FormCapNhatNhanVien(int id, string hoTen, string email, string sdt, DateTime ngaysinh, Decimal luong, string tennganhang, string soNganhang, DateTime ngayvaolam, string diachi, Image img, string quyen, string gioitinh, byte[] dataImg)
        {
            InitializeComponent();


            idNhanVien = id;
            txtHoTen.Text = hoTen;
            txtEmail.Text = email;
            txtSDT.Text = sdt;
            dtpNgaySinh.Value = ngaysinh;
            dtpNgayVaoLam.Value = ngayvaolam;
            txtLuong.Text = luong.ToString();
            txtTenNganHang.Text = tennganhang;
            txtSoNganHang.Text = soNganhang;
            //dtpNgayVaoLam.Value
            txtDiachi.Text = diachi;
            this.img = img;
            this.dataImg = dataImg;
            switch (quyen)
            {
                case "Admin":
                    cmbChucvu.SelectedIndex = 0;
                    break;
                case "Cashier":
                    cmbChucvu.SelectedIndex = 1;
                    break;
                case "Stoker":
                    cmbChucvu.SelectedIndex = 2;
                    break;
                default:
                    break;
            }

            switch (gioitinh)
            {
                case "Nữ":
                    cmbGioiTinh.SelectedIndex = 1;
                    break;
                case "Nam":
                    cmbGioiTinh.SelectedIndex = 0;
                    break;
                default:
                    break;
            }

            this.dataImg = dataImg;
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
            if (sPathImg != "")
            {
                img = Image.FromFile(sPathImg);
            }
            ptbShowImage.Image = img;
        }
        [Obsolete]
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" || txtEmail.Text == "" || txtSDT.Text == "" || txtLuong.Text == "" || txtTenNganHang.Text == "" || txtSoNganHang.Text == "" || txtDiachi.Text == "" || img == null)
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
                byte[] hinh = null;
                if (sPathImg == "")
                {
                    hinh = dataImg;
                }
                else
                {
                    hinh = System.IO.File.ReadAllBytes(sPathImg);
                }


                object[] objects = new object[] { idNhanVien, hoten, chucvu, gioiTinh, ngaySinh, ngayVaoLam, diachi, sdt, tenNganHang, soNganHang, luong, email, hinh };

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

        private void FormCapNhatNhanVien_Load(object sender, EventArgs e)
        {
            ptbShowImage.Image = img;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
