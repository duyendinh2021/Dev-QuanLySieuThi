using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Forms.SanPham;
using BUS;

namespace GUI.Forms.LoaiSanPham
{
    public partial class FormQuanLyLoaiSanPham : Form
    {
        public FormQuanLyLoaiSanPham()
        {
            InitializeComponent();
        }
        
        [Obsolete]
        private void FormQuanLyLoaiSanPham_Load(object sender, EventArgs e)
        {
            List<int> trangthai = new List<int>();
            trangthai.Add(1);
            trangthai.Add(0);
            cmbTrangThai.DataSource = trangthai;
            cmbTrangThai.SelectedIndex = 0;
            B_LoaiSanPham.Instance.GetAllProductTypesNoDeleted(ref dgvDanhSachLoaiSP);
        }


        [Obsolete]
        private void btnThemLoaiSP_Click(object sender, EventArgs e)
        {
            FormNhapLoaiSP formNhapLoaiSP = new FormNhapLoaiSP();
            formNhapLoaiSP.ShowDialog();
            B_LoaiSanPham.Instance.GetAllProductTypesNoDeleted(ref dgvDanhSachLoaiSP);

        }


        [Obsolete]
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int trangthai = int.Parse(cmbTrangThai.SelectedValue.ToString());
            string search = txtSearch.Text;
            B_LoaiSanPham.Instance.SearchProductTypes(trangthai, search, ref dgvDanhSachLoaiSP);
        }


        [Obsolete]
        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int trangthai = int.Parse(cmbTrangThai.SelectedValue.ToString());
            B_LoaiSanPham.Instance.GetProductTypesByTrangthai(trangthai, ref dgvDanhSachLoaiSP);
        }
    }
}
