using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Forms.PhieuNhapkho;
using BUS;

namespace GUI.Forms.PhieuNhapkho
{
    public partial class FormQuanLyPhieuNhapKho : Form
    {
        public FormQuanLyPhieuNhapKho()
        {
            InitializeComponent();
        }


        [Obsolete]
        private void FormQuanLyPhieuNhapKho_Load(object sender, EventArgs e)
        {
            B_PhieuNhapKho.Instance.GetAllPhieuNhapKhoNoDeleted(ref dgvDanhSachPhieuNhap);
            txtID.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            dtpNgayLap.Enabled = false;
            dtpSearchNgayEnd.MaxDate = DateTime.Now;
            dtpSearchNgayEnd.MinDate = DateTime.Parse("1/1/2000");


            dtpSearchNgayStar.MinDate = DateTime.Parse("1/1/2000");
            dtpSearchNgayStar.MaxDate = DateTime.Now;

        }

        [Obsolete]
        private void dgvDanhSachPhieuNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvDanhSachPhieuNhap.Rows[e.RowIndex];
                int id_phieuNhap = int.Parse(row.Cells["ID_PhieuNhapKho"].Value.ToString());

                // btn view chi tiet phieu nhap
                if (e.ColumnIndex == 0)
                {
                    FormChiTietPhieuNhapKho formChiTietPhieuNhapKho = new FormChiTietPhieuNhapKho(id_phieuNhap);
                    formChiTietPhieuNhapKho.ShowDialog();
                }
                // btn xoa phieu nhap
                if (e.ColumnIndex == 1)
                {
                    DialogResult result = MessageBox.Show("Xác Nhận Xóa Phiếu Nhập kho Chứ ???", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                    {
                        result = MessageBox.Show("Vui Lòng Xác Nhận Lại", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            id_phieuNhap = int.Parse(row.Cells["ID_PhieuNhapKho"].Value.ToString());
                            if (B_PhieuNhapKho.Instance.StokerDeletePhieuNhapKhoByID(id_phieuNhap))
                            {
                                MessageBox.Show("Xóa Phiếu Nhập Kho Thành Công", "Thông Báo");
                                B_PhieuNhapKho.Instance.GetAllPhieuNhapKhoNoDeleted(ref dgvDanhSachPhieuNhap);
                            }
                            else
                            {
                                MessageBox.Show("Ô NÔ !!!", "Xóa Không Thành Công");
                            }
                        }
                    }
                }

                txtID.Text = row.Cells["ID_NhanVien"].Value.ToString();
                dtpNgayLap.Value = DateTime.Parse(row.Cells["NgayLap"].Value.ToString());
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
            }
        }


        [Obsolete]
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime StarDate = dtpSearchNgayStar.Value;
            DateTime EndDate = dtpSearchNgayEnd.Value;
            B_PhieuNhapKho.Instance.GetReceiptInStarDateToEndDate(StarDate, EndDate,ref dgvDanhSachPhieuNhap);
        }
    }
}
