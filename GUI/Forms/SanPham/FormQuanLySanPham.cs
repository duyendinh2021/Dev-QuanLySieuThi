using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Forms;
using GUI.Forms.SanPham;
using BUS;

namespace GUI.Forms
{
    public partial class FormQuanLySanPham : Form
    {
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNhapSanPham formNhapSanPham = new FormNhapSanPham();
            formNhapSanPham.ShowDialog();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang formNhapHang = new FormNhapHang();
            formNhapHang.ShowDialog();
        }


        [Obsolete]
        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {
            B_SanPham.Instance.getAllSanPhamHoatDong(ref dtDanhSachSP);
            dtDanhSachSP.Columns["Hinh"].Visible = false;
            dtDanhSachSP.Columns["Trangthai"].Visible = false;
        }

        private void dtDanhSachSP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dtDanhSachSP.Rows[e.RowIndex];
                if (e.ColumnIndex == 1)
                {
                    int id = int.Parse(row.Cells["id_sp"].Value.ToString());
                    int id_ncc = int.Parse(row.Cells["id_ncc"].Value.ToString());
                    int id_loai = int.Parse(row.Cells["id_loaisp"].Value.ToString());
                    string ten_sp = row.Cells["ten_sp"].Value.ToString();
                    string dvt = row.Cells["dvt"].Value.ToString();
                    decimal dongia = decimal.Parse(row.Cells["donGia"].Value.ToString());

                    FormCapNhatSanPham formCapNhatSanPham = new FormCapNhatSanPham(id, id_ncc,id_loai,ten_sp,dvt,dongia);
                    formCapNhatSanPham.ShowDialog();
                }

                if (e.ColumnIndex == 2)
                {
                    // btn xoa
                }
            }
        }
    }
}
