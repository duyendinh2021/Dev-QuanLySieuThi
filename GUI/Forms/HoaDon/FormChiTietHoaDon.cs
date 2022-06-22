using BUS;
using GUI.Forms.NhaCungCap;
using GUI.Forms.SanPham;
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

namespace GUI.Forms.HoaDon
{
    public partial class FormChiTietHoaDon : Form
    {
        [Obsolete]
        public FormChiTietHoaDon()
        {
            InitializeComponent();
        }
        int id;

        [Obsolete]
        public FormChiTietHoaDon(int id)
        {
            InitializeComponent();
            this.id = id;
            B_ChiTietHoaDon.Instance.GetChiTietHoaDonByID(this.id,ref dgvDanhSachDetailsPhieuNhap);
        }

        private void dgvDanhSachDetailsPhieuNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvDanhSachDetailsPhieuNhap.Rows[e.RowIndex];
                txtIDSanPham.Text = row.Cells["ID_SanPham"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtChietKhau.Text = row.Cells["ChietKhau"].Value.ToString();
                txtSL.Text = row.Cells["SL"].Value.ToString();
            }
        }


        [Obsolete]
        private void btnViewSanPham_Click(object sender, EventArgs e)
        {
            if (txtIDSanPham.Text == "")
            {
                MessageBox.Show("Bạn Chưa Chọn Hóa Đơn Nào, Vui Lòng Chọn", "Thông Báo");
            }
            else
            {
                FormViewSanPham formViewSanPham = new FormViewSanPham(int.Parse(txtIDSanPham.Text));
                formViewSanPham.ShowDialog();
            }
        }
    }
}
