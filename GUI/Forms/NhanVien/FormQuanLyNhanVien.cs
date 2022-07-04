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
            B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);
            dtGVDanhSachNV.Columns["Ngayvaolam"].Visible = false;
            dtGVDanhSachNV.Columns["Tennganhang"].Visible = false;
            dtGVDanhSachNV.Columns["Sotaikhoan"].Visible = false;
            dtGVDanhSachNV.Columns["Luongcoban"].Visible = false;
            dtGVDanhSachNV.Columns["Luongphucap"].Visible = false;
            dtGVDanhSachNV.Columns["Trangthai"].Visible = false;
            dtGVDanhSachNV.Columns["Hinh"].Visible = false;

            var chuvu = new Dictionary<string, string>
            {
                {"Admin","Admin" },
                {"Stoker","Stoker" },
                {"Cashier","Cashier" },
                {"Tất Cả Loại Nhân Viên","" }
            }.ToList();
            var trangthai = new Dictionary<string, int>
            {
                {"Dang Hoạt Động",1 },
                {"Không Hoạt Động",0 },
                {"Tất Cả",-1 }
            }.ToList();


            cmbTrangThai.DisplayMember = "Key";
            cmbTrangThai.ValueMember = "Value";
            cmbTrangThai.DataSource = trangthai;

            cmbChucvu.DisplayMember = "Key";
            cmbChucvu.ValueMember = "Value";
            cmbChucvu.DataSource = chuvu;


            cmbTrangThai.SelectedIndex = 0;
            cmbChucvu.SelectedIndex = 3;
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
                B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);

            }
            else if (e.ColumnIndex == 2)
            {
                DialogResult dialog = MessageBox.Show("Bạn Có Chất Muốn Xóa", "Thông báo đặt biệt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    delete(sender, e);
                }
                B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);
            }
            DataGridViewRow row2 = dtGVDanhSachNV.Rows[e.RowIndex];
            picBoxImg.Image = SupportLogic.Instance.ConvertBinaryToImage((byte[])row2.Cells["Hinh"].Value);
        }

            
        [Obsolete]
        private void delete(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtGVDanhSachNV.Rows[e.RowIndex];
            int id = int.Parse(row.Cells["colManv"].Value.ToString());
            if (B_NhanVien.Instance.adminDeleteNhanVien(id))
            {
                MessageBox.Show("Xóa Nhân Viên Thành Công", "Thật Tuyệt Vời");
            }
            else
            {
                MessageBox.Show("Ô Nô !!!", "Có Vẽ Sai Sai");
            }
        }


        [Obsolete]
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemNhanVien formThemNhanVien = new FormThemNhanVien();
            formThemNhanVien.ShowDialog();
            B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);
        }


        [Obsolete]
        private void cmbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chucvu = "";
            int trangThai = -1;
            txtSeacrch.Clear();

            if (cmbChucvu.SelectedIndex != -1)
            {
                chucvu = cmbChucvu.SelectedValue.ToString();
                trangThai = int.Parse(cmbTrangThai.SelectedValue.ToString());
                try
                {
                    if (chucvu == "")
                    {
                        // tat ca nha vien
                        if (trangThai == -1)
                        {
                            B_NhanVien.Instance.getAllNhanVien(ref dtGVDanhSachNV);
                        }
                        // get nhan vien voi trang thai tuong ung
                        else
                        {
                            B_NhanVien.Instance.GetAllNhanVienTheoTrangThai(ref dtGVDanhSachNV, trangThai);
                        }
                    }
                    // nhan vien va trang thai tuong ung
                    else
                    {
                        B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Msg ::: " + ex, "erro");
                }
            }
        }


        [Obsolete]
        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int trangThai = -1;
            string chucvu = "";

            txtSeacrch.Clear();
            if (cmbTrangThai.SelectedIndex != -1)
            {
                try
                {
                    trangThai = int.Parse(cmbTrangThai.SelectedValue.ToString());
                    chucvu = cmbChucvu.SelectedValue.ToString();
                    if (trangThai == -1)
                    {
                        if (chucvu == "")
                        {
                            B_NhanVien.Instance.getAllNhanVien(ref dtGVDanhSachNV);
                        }
                        else
                        {
                            B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                        }
                    }
                    // get nhan vien tuong uong voi trang thai anh chuc vu
                    else
                    {
                        if (chucvu == "")
                        {
                            B_NhanVien.Instance.getNhanVienByTrangThai(ref dtGVDanhSachNV, trangThai);
                        }
                        else
                        {
                            B_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(ref dtGVDanhSachNV, chucvu, trangThai);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Msg ::: " + ex,"erro");
                }
            }
        }


        [Obsolete]
        private void txtSeacrch__TextChanged(object sender, EventArgs e)
        {
            int trangthai = int.Parse(cmbTrangThai.SelectedValue.ToString());
            string chuvu = cmbChucvu.SelectedValue.ToString();
            string search = txtSeacrch.Text;

            try
            {
                if (chuvu == "")
                {
                    B_NhanVien.Instance.searchNhanVienByTrangThai(ref dtGVDanhSachNV, search, trangthai);
                }
                else
                {
                    B_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(ref dtGVDanhSachNV, search, chuvu, trangthai);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Msg ::: " + ex, "erro");
            }
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
                if (e.ColumnIndex == 0)
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
                if (e.ColumnIndex == 1)
                {
                    DialogResult dialog = MessageBox.Show("Bạn Có Chất Muốn Xóa", "Thông báo đặt biệt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        dialog = MessageBox.Show("Bạn Có Chất Muốn Xóa ????", "Thông báo đặt biệt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
                        if (dialog == DialogResult.Yes)
                        {
                            if (row.Cells["colChucVu"].Value.ToString() == "Admin")
                            {
                                MessageBox.Show("Không Thể Xóa Tài Khoản Admin", "Thông Báo");
                            }
                            else
                            {
                                int id = int.Parse(row.Cells["colManv"].Value.ToString());
                                if (B_NhanVien.Instance.adminDeleteNhanVien(id))
                                {
                                    MessageBox.Show("Xóa Nhân Viên Thành Công", "Thật Tuyệt Vời");
                                }
                                else
                                {
                                    MessageBox.Show("Ô Nô !!!", "Có Vẽ Sai Sai");
                                }
                            }
                        }
                    }
                    BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);
                }
                // Click vào btn xem tài khoản
                if (e.ColumnIndex == 2)
                {
                    int id = int.Parse(row.Cells["colManv"].Value.ToString());
                    string usernam = "";
                    string pass = "";
                    string chucvu = "";

                    int trangthai = -1;
                    BUS.B_NhanVien.Instance.GetTaiKhoanByID(id, ref usernam, ref pass, ref chucvu, ref trangthai);
                    FormCapNhapAccout formViewAccout = new FormCapNhapAccout(id, usernam, pass, trangthai, chucvu);
                    formViewAccout.ShowDialog();
                }
            }
        }
    }
}
