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
using BUS;

namespace GUI.Forms.NhaCungCap
{
    public partial class FormQuanLyNhaCungCap : Form
    {
        public FormQuanLyNhaCungCap()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void FormQuanLyNhaCungCap_Load(object sender, EventArgs e)
        {
            B_NhaCungCap.Instance.GetAllNhaCungCapHoatDong(ref dtGVDanhSachNCC);
            List<int> trangthai = new List<int>();
            trangthai.Add(1);
            trangthai.Add(0);
            cmbTrangThaiNCC.DataSource = trangthai;
            cmbTrangThaiNCC.SelectedIndex = 0;
        }




        [Obsolete]
        private void dtGVDanhSachNCC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dtGVDanhSachNCC.Rows[e.RowIndex];

                // btn edit Nha Cung Cap
                if (e.ColumnIndex == 0)
                {
                    int id_ncc = int.Parse(row.Cells["ID_NCC"].Value.ToString());
                    string ten_tc = row.Cells["Ten_CT"].Value.ToString();
                    string sdt  = row.Cells["SDT"].Value.ToString();
                    string soNganHang = row.Cells["SO_NganHang"].Value.ToString();
                    string tenNganHang = row.Cells["Ten_NganHang"].Value.ToString();
                    string diachi = row.Cells["Dia_Chi"].Value.ToString();
                    FormCapNhatNhaCungCap cap = new FormCapNhatNhaCungCap(id_ncc,ten_tc,diachi,sdt,soNganHang,tenNganHang);
                    cap.ShowDialog();
                    B_NhaCungCap.Instance.GetAllNhaCungCapHoatDong(ref dtGVDanhSachNCC);
                }

                //btn delete Nha Cung Cap
                if (e.ColumnIndex == 1)
                {
                    DialogResult result = MessageBox.Show("Xác Nhận Dể Tiến Hành Xóa Nhà Cung Cấp", "Thông Báo Quan Trọng", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (result == DialogResult.Yes)
                    {
                        result = MessageBox.Show("Chất Chắn Chứ. Nhà Cung Cấp Này Dang Cung Cấp 1 Số Sản Phẩm Cho Hệ Thống", "Thông Báo Quan Trọng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            int id_ncc = int.Parse(row.Cells["ID_NCC"].Value.ToString());

                            if (B_NhaCungCap.Instance.StokerDeleteNhaCungCap(id_ncc))
                            {
                                MessageBox.Show("Xóa Nhà Cung Cấp Thành Công", "THông Báo");
                                B_NhaCungCap.Instance.GetAllNhaCungCapHoatDong(ref dtGVDanhSachNCC);
                            }
                        }
                    }
                }
            }
        }


        [Obsolete]
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            FormThemNhaCungCap formThemNhaCungCap = new FormThemNhaCungCap();
            formThemNhaCungCap.ShowDialog();
            B_NhaCungCap.Instance.GetAllNhaCungCapHoatDong(ref dtGVDanhSachNCC);
        }



        [Obsolete]
        private void cmbTrangThaiNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            int trangthai = int.Parse(cmbTrangThaiNCC.SelectedValue.ToString());
            B_NhaCungCap.Instance.GetNhaCungCapByTrangThai(trangthai, ref dtGVDanhSachNCC);
        }


        [Obsolete]
        private void txtSearchNCC_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearchNCC.Text;
            int trangthai = int.Parse(cmbTrangThaiNCC.SelectedValue.ToString());
            B_NhaCungCap.Instance.SearchNhaCungCapMutiColumnTheoTrangThai(search, trangthai, ref dtGVDanhSachNCC);
        }
    }
}
