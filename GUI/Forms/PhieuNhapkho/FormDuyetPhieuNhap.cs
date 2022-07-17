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
using GUI.Forms.SanPham;

namespace GUI.Forms.PhieuNhapkho
{
    public partial class FormDuyetPhieuNhap : Form
    {
        int id;

        public FormDuyetPhieuNhap(int id)
        {
            InitializeComponent();
            this.id=id;
        }


        [Obsolete]
        private void FormDuyetPhieuNhap_Load(object sender, EventArgs e)
        {
            B_ChiTietPhieuNhapKho.Instance.GetChiTietPhieuNhapKhoByIDPhieuNhap(id, ref dgvDanhSachDetailsPhieuNhap);

        }

        private void dgvDanhSachDetailsPhieuNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvDanhSachDetailsPhieuNhap.Rows[e.RowIndex];
                //string id_ncc = row.Cells["ID_Ncc"].Value.ToString();
                string id_sp = row.Cells["ID_SanPham"].Value.ToString();
                string sl = row.Cells["SL"].Value.ToString();
                string dongia = row.Cells["DonGia"].Value.ToString();

                txtIDSanPham.Text = id_sp;
                //txtIDNcc.Text = id_ncc;
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

        [Obsolete]
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            try
            {
                if (B_PhieuNhapKho.Instance.confirmReceipt(id))
                {
                    MessageBox.Show("Nhập Hàng Thành Công", "Thông Báo");

                    foreach (DataGridViewRow item in dgvDanhSachDetailsPhieuNhap.Rows)
                    {
                        object[] UpdateSLSanPham = new object[] { int.Parse(item.Cells["ID_SanPham"].Value.ToString()), int.Parse(item.Cells["SL"].Value.ToString()) };
                        B_SanPham.Instance.StokerUpdateSLSanPham(UpdateSLSanPham);
                    }

                }
                else
                {
                    MessageBox.Show("erro", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("msg ::: " + ex.Message, "erro");
            }

        }
    }
}
