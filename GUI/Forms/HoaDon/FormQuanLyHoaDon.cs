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

namespace GUI.Forms.HoaDon
{
    public partial class FormQuanLyHoaDon : Form
    {
        public FormQuanLyHoaDon()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            B_HoaDon.Instance.GetAllHoaDonNoDeleted(ref dgvHoaDon);

            txtID.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            dtpNgayLap.Enabled = false;
            dtpSearchNgayEnd.MaxDate = DateTime.Now;
            dtpSearchNgayEnd.MinDate = DateTime.Parse("1/1/2000");

            dtpSearchNgayStar.MinDate = DateTime.Parse("1/1/2000");
            dtpSearchNgayStar.MaxDate = DateTime.Now;
        }

        [Obsolete]
        private void dgvHoaDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvHoaDon.Rows[e.RowIndex];
                //btn view
                int id_hd = int.Parse(row.Cells["ID_HoaDon"].Value.ToString());
                if (e.ColumnIndex == 0)
                {
                    FormChiTietHoaDon formChiTietHoaDon = new FormChiTietHoaDon(id_hd);
                    formChiTietHoaDon.ShowDialog();
                }

                // btn edit
                if (e.ColumnIndex == 1)
                {

                }

                // btn delete
                if (e.ColumnIndex == 2)
                {
                    DialogResult result = MessageBox.Show("Bạn Xác Nhận Xóa Hóa Đơn Này Chứ !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                    {
                        result = MessageBox.Show("Vui Lòng Xác Nhận Lần Nưa Dể Xóa Hóa Đơn Này !!!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                           // int id_hd = int.Parse(row.Cells["ID_HoaDon"].Value.ToString());
                            if (B_HoaDon.Instance.AdminDeletedHoaDon(id_hd))
                            {
                                MessageBox.Show("Xóa Hóa Đơn Thành Công","Thông Báo");
                            }
                            else
                            {
                                MessageBox.Show("Xóa Hóa Đơn Thất Bại", "Thông Báo");
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
            B_HoaDon.Instance.SearchHoaDonByThoiGianStarEnd(StarDate, EndDate,ref dgvHoaDon);
        }
    }
}
