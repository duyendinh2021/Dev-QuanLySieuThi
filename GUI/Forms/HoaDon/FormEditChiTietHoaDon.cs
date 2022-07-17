using BUS;
using GUI.Forms.SanPham;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            this.id_hd = id_hd;
            B_ChiTietHoaDon.Instance.GetChiTietHoaDonByID(this.id_hd, ref dgvDanhSachChiTietHD);
            DGVhasChanged  = false;
        }


        private void FormEditChiTietHoaDon_Load(object sender, EventArgs e)
        {
            DGVhasChanged  = false;
            dgvDanhSachChiTietHD.Columns["idhd"].Visible = false;
            //btnEdit.Enabled = false;
            txtSlTra.ReadOnly = true;
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
                txtSlTra.Text = row.Cells["SlTra"].Value.ToString();

                // vô hiệu quá .....
                cmbTrangThai.Enabled = false;
                btnConfirm.Enabled = false;
                txtGhiChu.ReadOnly = true;
                txtSlTra.ReadOnly = true;

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
            var TrangThai = new Dictionary<string, int>
            {
                {"Không Trả Hàng",1 },
                {"Trả Hành",0 }
            }.ToList();



            cmbTrangThai.DataSource = null;
            cmbTrangThai.DisplayMember = "Key";
            cmbTrangThai.ValueMember = "Value";
            cmbTrangThai.DataSource = TrangThai;
            cmbTrangThai.Enabled = true;

            btnConfirm.Enabled = true;

            txtSlTra.Enabled = true;
        }


        //btn Xác Nhận thông tin mới edit
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // tao ra DataGridViewRow moi bang voi gia tri cua row cua row select
            try
            {
                if (chkLoiKT.Checked == false && chkBinhThuong.Checked == false)
                {
                    MessageBox.Show("Chưa chọn tình trạng hàng hoá, vui lòng chọn", "Thông Báo");
                }
                else
                {
                    DataGridViewRow newValueRow = dgvDanhSachChiTietHD.Rows[SelectedRow];
                    int tinhtrang;
                    if (chkBinhThuong.Checked == true)
                    {
                        tinhtrang = 1;
                    }
                    else
                    {
                        tinhtrang = 0;
                    }

                    if (txtSlTra.Text == "")
                    {

                        newValueRow.Cells["TrangThai"].Value = cmbTrangThai.SelectedValue.ToString();
                        newValueRow.Cells["SlTra"].Value = txtSL.Text.ToString();
                        newValueRow.Cells["GhiChu"].Value = txtGhiChu.Text.ToString();
                        newValueRow.Cells["TinhTrang"].Value = tinhtrang.ToString();
                        if (DGVhasChanged)
                        {
                            btnSave.Enabled = true;
                        }
                        MessageBox.Show(tinhtrang.ToString());
                    }
                    else
                    {
                        //newValueRow = dgvDanhSachChiTietHD.Rows[SelectedRow];
                        newValueRow.Cells["TrangThai"].Value = cmbTrangThai.SelectedValue.ToString();
                        newValueRow.Cells["SlTra"].Value = txtSlTra.Text.ToString();
                        newValueRow.Cells["GhiChu"].Value = txtGhiChu.Text.ToString();
                        newValueRow.Cells["TinhTrang"].Value = tinhtrang.ToString();
                        if (DGVhasChanged)
                        {
                            btnSave.Enabled = true;
                        }
                        MessageBox.Show(tinhtrang.ToString());

                    }

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
                        // update HD 
                        object[] ChiTietHD = new object[]
                        {
                            int.Parse(item.Cells["idhd"].Value.ToString()),
                            int.Parse(item.Cells["ID_SanPham"].Value.ToString()),
                            int.Parse(item.Cells["TrangThai"].Value.ToString()),
                            item.Cells["GhiChu"].Value.ToString()
                        };
                    
                        // neu nhu trang thai la khach hoang hang
                        if (int.Parse(item.Cells["TrangThai"].Value.ToString()) == 0)
                        {
                            // insert HD_tra Hang
                            object[] HD_Tra = new object[]
                            {
                             int.Parse(item.Cells["idhd"].Value.ToString()),
                             int.Parse(item.Cells["ID_SanPham"].Value.ToString()),
                             int.Parse(item.Cells["SlTra"].Value.ToString()),
                             int.Parse(item.Cells["TinhTrang"].Value.ToString()),
                             item.Cells["GhiChu"].Value.ToString()
                            };

                            if (B_ChiTietHoaDon.Instance.UpdateCTHoaDon(ChiTietHD) && B_HoaDon_Tra.Instance.IsInsertHD_Tra(HD_Tra))
                            {

                                object[] TraHang = new object[]
                                {
                                    int.Parse(item.Cells["idhd"].Value.ToString()),
                                    int.Parse(item.Cells["ID_SanPham"].Value.ToString()),
                                    int.Parse(item.Cells["SlTra"].Value.ToString()),
                                };

                                if (item.Cells["TinhTrang"].Value.ToString() == "1")
                                {
                                    object[] UpdateSl_SanPham = new object[]
                                    {
                                        int.Parse(item.Cells["ID_SanPham"].Value.ToString()),
                                        int.Parse(item.Cells["SlTra"].Value.ToString())
                                    };
                                    B_SanPham.Instance.StokerUpdateSLSanPham(UpdateSl_SanPham);
                                }
                            
                                B_ChiTietHoaDon.Instance.TraHang(TraHang);
                                coutUpdate++;
                            }
                            else
                            {
                                MessageBox.Show("Có Vấn Dề Trong Lúc Update", "Thông Báo");
                            }
                        }
                        // khong lam gi ca
                        else
                        {
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
        }


        // trạng thái HD thai đổi
        private void cmbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTrangThai.SelectedIndex != -1)
            {
                if (cmbTrangThai.SelectedValue.ToString() == "0")
                {
                    txtGhiChu.ReadOnly = false;
                    txtSlTra.ReadOnly = false;
                }
            }
        }

        private void dgvDanhSachChiTietHD_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DGVhasChanged = true;
        }

        private void dgvDanhSachChiTietHD_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            DGVhasChanged = true;
        }

        private void txtSlTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không thể nhập ký tự này", "Thông Báo");
                e.Handled = true;
            }
        }

        private void chkLoiKT_CheckedChanged(object sender, EventArgs e)
        {
            chkBinhThuong.Checked = !chkLoiKT.Checked;
        }

        private void chkBinhThuong_CheckedChanged(object sender, EventArgs e)
        {
            chkLoiKT.Checked = !chkBinhThuong.Checked;
        }
    }
}
