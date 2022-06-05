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

namespace GUI
{
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

        private void dtGVDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemNhanVien formThemNhanVien = new FormThemNhanVien();
            formThemNhanVien.ShowDialog();
        }
    }
}
