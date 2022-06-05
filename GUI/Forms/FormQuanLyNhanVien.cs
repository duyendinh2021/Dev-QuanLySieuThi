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

                Image tempImg = SupportLogic.Instance.ConvertBinaryToImage((byte[])row.Cells["Hinh"].Value);
                FormCapNhatNhanVien formCapNhatNhanVien = new FormCapNhatNhanVien(id,hoten,email,sdt,ngaySinh,luong,tenNganHang,soNganHang,ngayVaoLam,diachi,tempImg,chucvu,gioiTinh);
         
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
