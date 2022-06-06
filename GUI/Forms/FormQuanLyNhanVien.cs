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
                Decimal luong = decimal.Parse(row.Cells["colLuong"].Value.ToString());
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
                delete(sender, e);
                BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);

            }

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
            edit(sender, e);
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
            string chucvu = "";
            chucvu = cmbChucvu.Text;
            BUS.B_NhanVien.Instance.getNhanVienByChucVu(ref dtGVDanhSachNV, chucvu);
            if (cmbChucvu.SelectedIndex == 3)
            {
                BUS.B_NhanVien.Instance.getAllNhanVienHoatDong(ref dtGVDanhSachNV);
            }
        }


        [Obsolete]
        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int trangThai;
            string chucvu = "";
            if (cmbTrangThai.SelectedIndex == 0)
            {
                trangThai = 1;
                BUS.B_NhanVien.Instance.getNhanVienByTrangThai(ref dtGVDanhSachNV,trangThai);

            }
            else if (cmbTrangThai.SelectedIndex == 1)
            {
                trangThai = 0;
                BUS.B_NhanVien.Instance.getNhanVienByTrangThai(ref dtGVDanhSachNV,trangThai);

            }
            else if (cmbTrangThai.SelectedIndex == 2)
            {
                BUS.B_NhanVien.Instance.getAllNhanVien(ref dtGVDanhSachNV);
            }

        }
    }
}
