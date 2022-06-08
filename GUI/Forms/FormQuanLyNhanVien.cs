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
using GUI.Forms;
using GUI.ClassSupport;

namespace GUI
{
    //partial
    public partial class FormQuanLyNhanVien : Form
    {
        [Obsolete]
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }
        [Obsolete]
        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);
            dtGVDanhSachNV.Columns["Ngayvaolam"].Visible = false;
            dtGVDanhSachNV.Columns["Tennganhang"].Visible = false;
            dtGVDanhSachNV.Columns["Sotaikhoan"].Visible = false;
            dtGVDanhSachNV.Columns["Luongcoban"].Visible = false;
            dtGVDanhSachNV.Columns["Luongphucap"].Visible = false;
            dtGVDanhSachNV.Columns["Trangthai"].Visible = false;
            dtGVDanhSachNV.Columns["Hinh"].Visible = false;
            cmbChucvu.SelectedIndex = 3;
            cmbTrangThai.SelectedIndex = 0;
        }

        [Obsolete]
        private void edit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                DataGridViewRow row = dtGVDanhSachNV.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["colManv"].Value.ToString());
                string hoten = row.Cells["colTennv"].Value.ToString();
                string email = row.Cells["colTentk"].Value.ToString();
                string sdt = row.Cells["colSDT"].Value.ToString();
                DateTime ngaySinh = DateTime.Parse(row.Cells["colNgaysinh"].Value.ToString());
                DateTime ngayVaoLam = DateTime.Parse(row.Cells["Ngayvaolam"].Value.ToString());
                string diachi = row.Cells["colDiachi"].Value.ToString();
                string gioiTinh = row.Cells["colGioiTinh"].Value.ToString();
                Decimal luong = decimal.Parse(row.Cells["Luongcoban"].Value.ToString());
                string tenNganHang = row.Cells["Tennganhang"].Value.ToString();
                string soNganHang = row.Cells["Sotaikhoan"].Value.ToString();
                string chucvu = row.Cells["colChucVu"].Value.ToString();

                Image tempImg = SupportLogic.Instance.ConvertBinaryToImage((byte[])row.Cells["Hinh"].Value);
                byte[] dataImg = (byte[])row.Cells["Hinh"].Value;
                FormCapNhatNhanVien formCapNhatNhanVien = new FormCapNhatNhanVien(id, hoten, email, sdt, ngaySinh, luong, tenNganHang, soNganHang, ngayVaoLam, diachi, tempImg, chucvu, gioiTinh, dataImg);

                formCapNhatNhanVien.ShowDialog();
                BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);

            }
            else if (e.ColumnIndex == 2)
            {
                DialogResult dialog = MessageBox.Show("Bạn Có Chất Muốn Xóa", "Thông báo đặt biệt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    delete(sender, e);
                }
                BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);

            }
            DataGridViewRow row2 = dtGVDanhSachNV.Rows[e.RowIndex];
            picBoxImg.Image = SupportLogic.Instance.ConvertBinaryToImage((byte[])row2.Cells["Hinh"].Value);

        }
        [Obsolete]
        private void delete(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGVDanhSachNV.Rows[e.RowIndex];
            int id = int.Parse(row.Cells["colManv"].Value.ToString());
            if (BUS.B_NhanVien.Instance.adminDeleteNhanVien(id))
            {
                MessageBox.Show("Xóa Nhân Viên Thành Công", "Thật Tuyệt Vời");
            }
            else
            {
                MessageBox.Show("Ô Nô !!!", "Có Vẽ Sai Sai");

            }

        }

        //private void btnDelete(object sender, EventArgs e)
        //{
        //    int cout = dtGVDanhSachNV.Rows.Cast<DataGridViewRow>().Where(p => Convert.ToBoolean(p.Cells["Checked"].Value) == true).Count();
        //    if (cout > 0)
        //    {
        //        string message = string.Format("Bạn có chất muốn xóa {0} đòng hay không", cout);
        //        if (cout > 1)
        //        {
        //            message = string.Format("Bạn có chất muốn xóa {0} đòng hay không", cout);

        //            DialogResult dialog =  MessageBox.Show(message,"Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        //            if (dialog == DialogResult.Yes)
        //            {
        //                int[] listIdNhanVien = new int[cout];
        //                for (int i = dtGVDanhSachNV.RowCount - 1; i >= 0; i--)
        //                {
        //                    DataGridViewRow row = dtGVDanhSachNV.Rows[i];
        //                    if (Convert.ToBoolean(row.Cells["Checked"].Value) == true)
        //                    {
        //                        listIdNhanVien[i] = int.Parse(row.Cells["colManv"].Value.ToString());
        //                    }

        //                    BUS.B_NhanVien.Instance.adminDeleteNhanVien(listIdNhanVien);
        //                }
        //            }
        //        }
        //    }
        //}


        [Obsolete]
        private void dtGVDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //edit(sender, e);
        }
        [Obsolete]
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemNhanVien formThemNhanVien = new FormThemNhanVien();
            formThemNhanVien.ShowDialog();
            BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);

        }


        [Obsolete]
        private void cmbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chucvu;
            int trangThai;
            // select all nhân viên Admin
            if (cmbChucvu.SelectedIndex == 0)
            {
                chucvu = cmbChucvu.Text;
                // select all nhân viên Admin dang hoạt động
                if (cmbTrangThai.SelectedIndex == 0)
                {
                    trangThai = 1;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);

                }
                // select all nhân viên Admin không hoạt động
                else if (cmbTrangThai.SelectedIndex == 1)
                {
                    trangThai = 0;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all nhân viên Admin (không hoạt động với dang hoạt động)
                else if (cmbTrangThai.SelectedIndex == 2)
                {
                    trangThai = -1;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
            }
            // select all nhân viên Cashier (bán hàng)
            else if (cmbChucvu.SelectedIndex == 1)
            {
                chucvu = cmbChucvu.Text;
                // select all nhân viên Cashier dang hoạt động
                if (cmbTrangThai.SelectedIndex == 0)
                {
                    trangThai = 1;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);

                }
                // select all nhân viên Cashier không hoạt động
                else if (cmbTrangThai.SelectedIndex == 1)
                {
                    trangThai = 0;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all nhân viên Cashier (không hoạt động với dang hoạt động)
                else if (cmbTrangThai.SelectedIndex == 2)
                {
                    trangThai = -1;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
            }
            // select all nhân viên Stoker (kho)
            else if (cmbChucvu.SelectedIndex == 2)
            {
                chucvu = cmbChucvu.Text;
                // select all nhân viên Stoker dang hoạt động
                if (cmbTrangThai.SelectedIndex == 0)
                {
                    trangThai = 1;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);

                }
                // select all nhân viên Stoker không hoạt động
                else if (cmbTrangThai.SelectedIndex == 1)
                {
                    trangThai = 0;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all nhân viên Stoker (không hoạt động với dang hoạt động)
                else if (cmbTrangThai.SelectedIndex == 2)
                {
                    trangThai = -1;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
            }
            // Tất cả loại nhân viên
            else if (cmbChucvu.SelectedIndex == 3)
            {
                chucvu = cmbChucvu.Text;
                // Tất cả loại nhân viên dang hoạt động
                if (cmbTrangThai.SelectedIndex == 0)
                {
                    BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);
                }
                // Tất cả loại nhân viên không hoạt động
                else if (cmbTrangThai.SelectedIndex == 1)
                {
                    trangThai = 0;
                    BUS.B_NhanVien.Instance.getNhanVienByTrangThai(ref dtGVDanhSachNV, trangThai);
                }
                // Tất cả loại nhân viên dang hoạt động với không hoạt động
                else if (cmbTrangThai.SelectedIndex == 2)
                {
                    BUS.B_NhanVien.Instance.getAllNhanVien(ref dtGVDanhSachNV);
                }
            }
        }


        [Obsolete]
        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int trangThai;
            string chucvu;
            // nhân viên còn hoạt động
            if (cmbTrangThai.SelectedIndex == 0)
            {
                trangThai = 1;

                // select all nhân viên admin trang thái dang hoạt động
                if (cmbChucvu.SelectedIndex == 0)
                {
                    chucvu = cmbChucvu.Text;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all nhân viên Cashier (nhân viên bán hàng) trang thái dang hoạt động
                else if (cmbChucvu.SelectedIndex == 1)
                {
                    chucvu = cmbChucvu.Text;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all nhân viên Stoker (nhân viên kho) trang thái dang hoạt động
                else if (cmbChucvu.SelectedIndex == 2)
                {
                    chucvu = cmbChucvu.Text;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all loại nhân viên đang hoạt động
                else if (cmbChucvu.SelectedIndex == 3)
                {                 
                    BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);
                }
            }
            // nhân viên không hoạt động
            else if (cmbTrangThai.SelectedIndex == 1)
            {
                trangThai = 0;
                // select all nhân viên admin trang thái không hoạt động
                if (cmbChucvu.SelectedIndex == 0)
                {
                    chucvu = cmbChucvu.Text;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all nhân viên Cashier (nhân viên bán hàng) trang thái không hoạt động
                else if (cmbChucvu.SelectedIndex == 1)
                {
                    chucvu = cmbChucvu.Text;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all nhân viên Stoker (nhân viên kho) trang thái không hoạt động
                else if (cmbChucvu.SelectedIndex == 2)
                {
                    chucvu = cmbChucvu.Text;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all loại nhân viên không hoạt động
                else if (cmbChucvu.SelectedIndex == 3)
                {
                    BUS.B_NhanVien.Instance.getNhanVienByTrangThai(ref dtGVDanhSachNV, trangThai);
                }
            }
            // tất cả nhân viên bao gồm hoạt động hay không
            else if (cmbTrangThai.SelectedIndex == 2)
            {
                trangThai = -1;
                // select all nhân viên admin
                if (cmbChucvu.SelectedIndex == 0)
                {
                    chucvu = cmbChucvu.Text;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all nhân viên Cashier (nhân viên bán hàng)
                else if (cmbChucvu.SelectedIndex == 1)
                {
                    chucvu = cmbChucvu.Text;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all nhân viên Stoker (nhân viên kho)
                else if (cmbChucvu.SelectedIndex == 2)
                {
                    chucvu = cmbChucvu.Text;
                    BUS.B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                }
                // select all loại nhân viên
                else if (cmbChucvu.SelectedIndex == 3)
                {
                    BUS.B_NhanVien.Instance.getAllNhanVien(ref dtGVDanhSachNV);
                }
            }
        }


        [Obsolete]
        private void txtSeacrch__TextChanged(object sender, EventArgs e)
        {
            int trangthai;
            string chuvu;


            string search = txtSeacrch.Text;


            // Search nhân viên Admin dang hoạt động
            if (cmbChucvu.SelectedIndex == 0 && cmbTrangThai.SelectedIndex == 0)
            {
                trangthai = 1;
                chuvu = cmbChucvu.Text;
                BUS.B_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(ref dtGVDanhSachNV, search, chuvu, trangthai);
            }
            // Search nhân viên Admin không hoạt động
            else if (cmbChucvu.SelectedIndex == 0 && cmbTrangThai.SelectedIndex == 1)
            {
                trangthai = 0;
                chuvu = cmbChucvu.Text;
                BUS.B_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(ref dtGVDanhSachNV, search, chuvu, trangthai);
            }
            // Search nhân viên Admin bao gồm đang hoạt động với không hoạt động
            else if (cmbChucvu.SelectedIndex == 0 && cmbTrangThai.SelectedIndex == 2)
            {
                trangthai = -1;
                chuvu = cmbChucvu.Text;
                BUS.B_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(ref dtGVDanhSachNV, search, chuvu, trangthai);
            }



            // Search nhân viên Cashier dang hoạt động
            if (cmbChucvu.SelectedIndex == 1 && cmbTrangThai.SelectedIndex == 0)
            {
                trangthai = 1;
                chuvu = cmbChucvu.Text;
                BUS.B_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(ref dtGVDanhSachNV, search, chuvu, trangthai);
            }
            // Search nhân viên Cashier không hoạt động
            else if (cmbChucvu.SelectedIndex == 1 && cmbTrangThai.SelectedIndex == 1)
            {
                trangthai = 0;
                chuvu = cmbChucvu.Text;
                BUS.B_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(ref dtGVDanhSachNV, search, chuvu, trangthai);
            }
            // Search nhân viên Cashier bao gồm đang hoạt động với không hoạt động
            else if (cmbChucvu.SelectedIndex == 1 && cmbTrangThai.SelectedIndex == 2)
            {
                trangthai = -1;
                chuvu = cmbChucvu.Text;
                BUS.B_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(ref dtGVDanhSachNV, search, chuvu, trangthai);
            }



            // Search nhân viên Stoker dang hoạt động
            if (cmbChucvu.SelectedIndex == 2 && cmbTrangThai.SelectedIndex == 0)
            {
                trangthai = 1;
                chuvu = cmbChucvu.Text;
                BUS.B_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(ref dtGVDanhSachNV, search, chuvu, trangthai);
            }
            // Search nhân viên Stoker không hoạt động
            else if (cmbChucvu.SelectedIndex == 2 && cmbTrangThai.SelectedIndex == 1)
            {
                trangthai = 0;
                chuvu = cmbChucvu.Text;
                BUS.B_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(ref dtGVDanhSachNV, search, chuvu, trangthai);
            }
            // Search nhân viên Stoker bao gồm đang hoạt động với không hoạt động
            else if (cmbChucvu.SelectedIndex == 2 && cmbTrangThai.SelectedIndex == 2)
            {
                trangthai = -1;
                chuvu = cmbChucvu.Text;
                BUS.B_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(ref dtGVDanhSachNV, search, chuvu, trangthai);
            }



            // Search tất cả loại nhân viên dang hoạt động
            if (cmbChucvu.SelectedIndex == 3 && cmbTrangThai.SelectedIndex == 0)
            {
                trangthai = 1;
                BUS.B_NhanVien.Instance.searchNhanVienByTrangThai(ref dtGVDanhSachNV, search, trangthai);
            }
            // Search tất cả loại nhân viên không hoạt động
            else if (cmbChucvu.SelectedIndex == 3 && cmbTrangThai.SelectedIndex == 1)
            {
                trangthai = 0;
                BUS.B_NhanVien.Instance.searchNhanVienByTrangThai(ref dtGVDanhSachNV, search, trangthai);
            }
            // Search tất cả loại nhân viên bao gồm đang hoạt động với không hoạt động
            else if (cmbChucvu.SelectedIndex == 3 && cmbTrangThai.SelectedIndex == 2)
            {
                trangthai = -1;
                BUS.B_NhanVien.Instance.searchNhanVienByTrangThai(ref dtGVDanhSachNV, search, trangthai);
            }

            //BUS.B_NhanVien.Instance.searchNhanVien(ref dtGVDanhSachNV, search);
        }



        [Obsolete]
        private void dtGVDanhSachNV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                // Click vào btn cập nhật nhân viên
                DataGridViewRow row = dtGVDanhSachNV.Rows[e.RowIndex];
                Image image = SupportLogic.Instance.ConvertBinaryToImage((byte[])row.Cells["Hinh"].Value);
                picBoxImg.Image = image;
                if (e.ColumnIndex == 1)
                {
                    int id = int.Parse(row.Cells["colManv"].Value.ToString());
                    string hoten = row.Cells["colTennv"].Value.ToString();
                    string email = row.Cells["colTentk"].Value.ToString();
                    string sdt = row.Cells["colSDT"].Value.ToString();
                    DateTime ngaySinh = DateTime.Parse(row.Cells["colNgaysinh"].Value.ToString());
                    DateTime ngayVaoLam = DateTime.Parse(row.Cells["Ngayvaolam"].Value.ToString());
                    string diachi = row.Cells["colDiachi"].Value.ToString();
                    string gioiTinh = row.Cells["colGioiTinh"].Value.ToString();
                    Decimal luong = decimal.Parse(row.Cells["Luongcoban"].Value.ToString());
                    string tenNganHang = row.Cells["Tennganhang"].Value.ToString();
                    string soNganHang = row.Cells["Sotaikhoan"].Value.ToString();
                    string chucvu = row.Cells["colChucVu"].Value.ToString();

                    Image tempImg = SupportLogic.Instance.ConvertBinaryToImage((byte[])row.Cells["Hinh"].Value);
                    byte[] dataImg = (byte[])row.Cells["Hinh"].Value;
                    FormCapNhatNhanVien formCapNhatNhanVien = new FormCapNhatNhanVien(id, hoten, email, sdt, ngaySinh, luong, tenNganHang, soNganHang, ngayVaoLam, diachi, tempImg, chucvu, gioiTinh, dataImg);

                    formCapNhatNhanVien.ShowDialog();
                    BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);
                }
                // Click vào btn xóa nhân viên
                if (e.ColumnIndex == 2)
                {
                    DialogResult dialog = MessageBox.Show("Bạn Có Chất Muốn Xóa", "Thông báo đặt biệt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        int id = int.Parse(row.Cells["colManv"].Value.ToString());
                        if (BUS.B_NhanVien.Instance.adminDeleteNhanVien(id))
                        {
                            MessageBox.Show("Xóa Nhân Viên Thành Công", "Thật Tuyệt Vời");
                        }
                        else
                        {
                            MessageBox.Show("Ô Nô !!!", "Có Vẽ Sai Sai");

                        }
                    }
                    BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);
                }
                // Click vào btn xem tài khoản
                if (e.ColumnIndex == 3)
                {
                    int id = int.Parse(row.Cells["colManv"].Value.ToString());
                    string usernam = "";
                    string pass = "";
                    string chucvu = "";

                    int trangthai = -1;
                    BUS.B_NhanVien.Instance.GetTaiKhoanByID(id,ref usernam,ref pass,ref chucvu, ref trangthai);
                    FormViewAccout formViewAccout = new FormViewAccout(id,usernam,pass,trangthai,chucvu);
                    formViewAccout.ShowDialog();

                }
            }
        }
    }
}
