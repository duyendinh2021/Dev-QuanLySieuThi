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
            BUS.B_NhanVien.Instance.getAllNhanVien(ref dtGVDanhSachNV);
            dtGVDanhSachNV.Columns["Ngayvaolam"].Visible = false;
            dtGVDanhSachNV.Columns["Tennganhang"].Visible = false;
            dtGVDanhSachNV.Columns["Sotaikhoan"].Visible = false;
            dtGVDanhSachNV.Columns["Luongcoban"].Visible = false;
            dtGVDanhSachNV.Columns["Luongphucap"].Visible = false;
            dtGVDanhSachNV.Columns["Trangthai"].Visible = false;
            dtGVDanhSachNV.Columns["Hinh"].Visible = false;
        }


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

                FormCapNhatNhanVien formCapNhatNhanVien = new FormCapNhatNhanVien();
                formCapNhatNhanVien.idNhanVien = id;
                formCapNhatNhanVien.txtHoTen.Text = hoten;
                formCapNhatNhanVien.txtEmail.Text = email;
                formCapNhatNhanVien.txtSDT.Text = sdt;
                formCapNhatNhanVien.dtpNgaySinh.Value = ngaySinh;
                formCapNhatNhanVien.txtLuong.Text = luong.ToString();
                formCapNhatNhanVien.txtTenNganHang.Text = tenNganHang;
                formCapNhatNhanVien.txtSoNganHang.Text = soNganHang;
                //formCapNhatNhanVien.dtpNgayVaoLam.Value
                formCapNhatNhanVien.txtDiachi.Text = diachi;

                formCapNhatNhanVien.img = SupportLogic.Instance.ConvertBinaryToImage((byte[])row.Cells["Hinh"].Value);

                switch (chucvu)
                {
                    case "Admin":
                        formCapNhatNhanVien.cmbChucvu.SelectedIndex = 0;
                        break;
                    case "Cashier":
                        formCapNhatNhanVien.cmbChucvu.SelectedIndex = 1;
                        break;
                    case "Stoker":
                        formCapNhatNhanVien.cmbChucvu.SelectedIndex = 2;
                        break;
                    default:
                        break;
                }

                switch (gioiTinh)
                {
                    case "Nữ":
                        formCapNhatNhanVien.cmbGioiTinh.SelectedIndex = 1;
                        break;
                    case "Nam":
                        formCapNhatNhanVien.cmbGioiTinh.SelectedIndex = 0;
                        break;
                    default:
                        break;
                }
                formCapNhatNhanVien.ShowDialog();
            }
        }


        private void dtGVDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            edit(sender, e);
        }
        [Obsolete]
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemNhanVien formThemNhanVien = new FormThemNhanVien();
            formThemNhanVien.ShowDialog();
            //FormCollection fc = Application.OpenForms;
            //foreach (Form form in fc)
            //{
            //    if (form.Name == "FormCapNhatNhanVien")
            //    {
            //        BUS.B_NhanVien.Instance.getAllNhanVien(ref dtGVDanhSachNV);
            //    }
            //}
        }
    }
}
