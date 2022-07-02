using System;
using System.Activities.Expressions;
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

namespace GUI.Forms.HoaDon
{
    public partial class FormEditChiTietHoaDon : Form
    {
        private int id_hd;
        private int SelectedRow;
        private bool DGVhasChanged = false;

        public FormEditChiTietHoaDon()
        {
            InitializeComponent();
        }

        [Obsolete]
        public FormEditChiTietHoaDon(int id_hd)
        {
            InitializeComponent();
            this.id_hd=id_hd;
            B_ChiTietHoaDon.Instance.GetChiTietHoaDonByID(this.id_hd, ref dgvDanhSachChiTietHD);
            DGVhasChanged  = false;
        }


        private void FormEditChiTietHoaDon_Load(object sender, EventArgs e)
        {
            DGVhasChanged  = false;
        }



        private void dgvDanhSachChiTietHD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                // get row click  => hiển thị thông tin lên
                DataGridViewRow row = dgvDanhSachChiTietHD.Rows[e.RowIndex];
                SelectedRow = e.RowIndex;

                txtIDSanPham.Text = row.Cells["ID_SanPham"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtChietKhau.Text = row.Cells["ChietKhau"].Value.ToString();
                txtSL.Text = row.Cells["SL"].Value.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value.ToString();

                // vô hiệu quá .....
                cmbTrangThai.Enabled = false;
                txtGhiChu.ReadOnly = true;
                btnConfirm.Enabled = false;


                // gán trang thái của HD vào cmb
                List<int> TrangThai = new List<int>();
                TrangThai.Add(int.Parse(row.Cells["TrangThai"].Value.ToString()));             
                cmbTrangThai.DataSource = TrangThai;
               

            }
        }


        // btn xem thông tin sản phẩm
        [Obsolete]
        private void btnViewSanPham_Click(object sender, EventArgs e)
        {
            FormViewSanPham formViewSanPham = new FormViewSanPham(int.Parse(txtIDSanPham.Text));
            formViewSanPham.ShowDialog();
        }


        // btn edit chi tiết HD
        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<int> TrangThai = new List<int>();
            TrangThai.Add(1);
            TrangThai.Add(0);
            cmbTrangThai.DataSource = null;
            cmbTrangThai.DataSource = TrangThai;
            cmbTrangThai.Enabled = true;

            btnConfirm.Enabled = true;
        }


        //btn Xác Nhận thông tin mới edit
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // tao ra DataGridViewRow moi bang voi gia tri cua row cua row select
            try
            {
                DataGridViewRow newValueRow = dgvDanhSachChiTietHD.Rows[SelectedRow];
                newValueRow.Cells["TrangThai"].Value = cmbTrangThai.Text;
                newValueRow.Cells["GhiChu"].Value = txtGhiChu.Text;
                if (DGVhasChanged)
                {
                    btnSave.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("msg :: " + ex);
            }
   

        }

        [Obsolete]
        // btn confirm -> lưu hoá đơn edit vào database
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vui Lòng Xác Nhận Dể Tiến Hành Update", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                result = MessageBox.Show("Vui Lòng Xác Nhận Lại Dể Tiến Hành Update", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (result == DialogResult.Yes)
                {
                    int coutUpdate = 0;
                    foreach (DataGridViewRow item in dgvDanhSachChiTietHD.Rows)
                    {
                        object[] ChiTietHD = new object[] { int.Parse(item.Cells["ID_HD"].Value.ToString()), int.Parse(item.Cells["ID_SanPham"].Value.ToString()), int.Parse(item.Cells["TrangThai"].Value.ToString()), item.Cells["GhiChu"].Value.ToString() };
                        if (B_ChiTietHoaDon.Instance.UpdateCTHoaDon(ChiTietHD))
                        {
                            coutUpdate++;
                        }
                        else
                        {
                            MessageBox.Show("Có Vấn Dề Trong Lúc Update", "Thông Báo");
                        }
                    }
                    if (coutUpdate == dgvDanhSachChiTietHD.RowCount)
                    {
                        MessageBox.Show("Udate HD Thành Công", "Thông Báo");
                    }
                }
            }
        }


        // trạng thái HD thai đổi
        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrangThai.SelectedIndex != -1)
            {
                if (cmbTrangThai.SelectedValue.ToString() == "0")
                {
                    txtGhiChu.ReadOnly = false;
                }
            }
        }

        private void dgvDanhSachChiTietHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DGVhasChanged = true;
            //MessageBox.Show("msg ::: " + DGVhasChanged.ToString());
        }

        private void dgvDanhSachChiTietHD_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DGVhasChanged = true;
            //MessageBox.Show("msg ::: " + DGVhasChanged.ToString());
        }
    }
}
