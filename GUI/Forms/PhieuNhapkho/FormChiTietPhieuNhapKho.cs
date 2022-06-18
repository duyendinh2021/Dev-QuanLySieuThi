using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Forms.NhaCungCap;
using GUI.Forms.SanPham;
using BUS;

namespace GUI.Forms.PhieuNhapkho
{
    public partial class FormChiTietPhieuNhapKho : Form
    {
        [Obsolete]
        public FormChiTietPhieuNhapKho()
        {
            InitializeComponent();
        }


        int id;

        [Obsolete]
        public FormChiTietPhieuNhapKho(int id)
        {
            InitializeComponent();
            this.id = id;
        }


        [Obsolete]
        private void FormChiTietPhieuNhapKho_Load(object sender, EventArgs e)
        {
            B_ChiTietPhieuNhapKho.Instance.GetChiTietPhieuNhapKhoByIDPhieuNhap(id, ref dgvDanhSachDetailsPhieuNhap);
        }

        private void dgvDanhSachDetailsPhieuNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvDanhSachDetailsPhieuNhap.Rows[e.RowIndex];
                string id_ncc = row.Cells["ID_Ncc"].Value.ToString();
                string id_sp = row.Cells["ID_SanPham"].Value.ToString();
                string sl = row.Cells["SL"].Value.ToString();
                string dongia = row.Cells["DonGia"].Value.ToString();

                txtIDSanPham.Text = id_sp;
                txtIDNcc.Text = id_ncc;
                txtSL.Text = sl;
                txtDonGia.Text = dongia;

            }
        }

        [Obsolete]
        private void btnViewSanPham_Click(object sender, EventArgs e)
        {
            if (txtIDSanPham.Text == "")
            {
                MessageBox.Show("Bạn Chứ Chọn Đơn Nào");
            }
            else
            {
                int id_sp = int.Parse(txtIDSanPham.Text);

                FormViewSanPham formViewSanPham = new FormViewSanPham(id_sp);
                formViewSanPham.ShowDialog();
            }

        }

        private void btnViewNhaCungCap_Click(object sender, EventArgs e)
        {
            if (txtIDNcc.Text == "")
            {
                MessageBox.Show("Bạn Chứ Chọn Đơn Nào");
            }
            else
            {
                int id_ncc = int.Parse(txtIDNcc.Text);
                FormViewNhaCungCap formViewNhaCungCap = new FormViewNhaCungCap(id_ncc);
                formViewNhaCungCap.ShowDialog();
            }
        }
    }
}
