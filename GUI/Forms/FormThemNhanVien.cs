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
namespace GUI.Forms
{
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }
        public string sPathImg = "";




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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //string sPathImg = getPathFile();

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
            
            object[] objects = new object[] {hoten,chucvu,gioiTinh,ngaySinh,ngayVaoLam,diachi,sdt,tenNganHang,soNganHang,luong,email,hinh};

            if (BUS.B_NhanVien.Instance.adminAddNhanVien(objects))
            {
                MessageBox.Show("Thêm Nhân viên Thành Công", "Thật Tuyệt Vời");
            }
            else
            {
                MessageBox.Show("Ô Nô !!!");
            }
            
        }



        private string getPathFile()
        {
            OpenFileDialog file = new OpenFileDialog();
            string sPathImg = "";
            file.Filter = "Image Files (*.bmp;*.png;*.jpg)|*.bmp;*.png;*.jpg";
            file.FilterIndex = 1;
            file.Multiselect = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                sPathImg = file.FileName;
                //MessageBox.Show(sPathImg);
            }
            return sPathImg;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            sPathImg = getPathFile();
            Image img = Image.FromFile(sPathImg);
            ptbShowImage.Image = img;
            //img.Dispose();
        }
    }
}
