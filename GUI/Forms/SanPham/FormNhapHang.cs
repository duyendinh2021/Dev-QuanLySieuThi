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

namespace GUI.Forms.SanPham
{
    public partial class FormNhapHang : Form
    {
        private int baseQTY = 1;

        private int id_ncc_Nhap;
        private bool isNhapHang;

        [Obsolete]
        public FormNhapHang()
        {
            InitializeComponent();
        }


        [Obsolete]
        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            B_LoaiSanPham.Instance.loadDataSourcecmbLoaiSp(ref cmbLoaiSP);

            B_SanPham.Instance.GetAllSanPhamNoDeleted(ref dtgDSHangHoa);

            B_NhaCungCap.Instance.loadComboBoxNhaCungCap(ref cmbNCC);

            cmbLoaiSP.SelectedIndex = -1;
            cmbNCC.SelectedIndex = -1;

            dtgDSHangHoa.Columns["Hinh"].Visible = false;
            dtgDSHangHoa.Columns["Trangthai"].Visible = false;

            cmbNCC.Enabled = true;
            cmbLoaiSP.Enabled = true;
        }


        [Obsolete]
        private void cmbLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_loai;
            int id_ncc;
            if (cmbLoaiSP.SelectedIndex == -1)
            {
                id_loai = 0;
                B_SanPham.Instance.GetProducByProducType(ref dtgDSHangHoa, id_loai);
            }
            else
            {
                if (cmbNCC.SelectedIndex == -1)
                {
                    id_loai = int.Parse(cmbLoaiSP.SelectedValue.ToString());
                    B_SanPham.Instance.GetProducByProducType(ref dtgDSHangHoa, id_loai);
                }
                else
                {
                    id_loai = int.Parse(cmbLoaiSP.SelectedValue.ToString());
                    id_ncc = int.Parse(cmbNCC.SelectedValue.ToString());
                    B_SanPham.Instance.GetProductByProductTypeAndSupplier(id_loai, id_ncc, ref dtgDSHangHoa);
                }
            }
        }


        private void dtgDSHangHoa_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dtgDSHangHoa.Rows[e.RowIndex];
            if (e.RowIndex != -1)
            {
                if (cmbNCC.SelectedIndex == -1)
                {
                    MessageBox.Show("Bạn chưa chọn nhà cung cấp, vui lòng chọn nhà cung cấp", "Thông Báo");
                }
                else
                {
                    // btn nhap san pham
                    if (e.ColumnIndex == 0)
                    {
                        if (txtSl.Text == "")
                        {
                            MessageBox.Show("Vui lòng nhập sồ lượng muốn nhập");
                            txtSl.Focus();
                        }
                        else
                        {
                            int sl = int.Parse(txtSl.Text);

                            if (dgvHoaDonNhap.Rows.Count > 0)
                            {

                                foreach (DataGridViewRow item in dgvHoaDonNhap.Rows)
                                {

                                    if (item.Cells["ID"].Value.ToString() == row.Cells["ID_SP"].Value.ToString())
                                    {
                                        item.Cells["QTY"].Value = (int.Parse(item.Cells["QTY"].Value.ToString()) + int.Parse(txtSl.Text));
                                        item.Cells["COST"].Value = decimal.Parse(item.Cells["QTY"].Value.ToString()) * decimal.Parse(row.Cells["dongia"].Value.ToString());
                                        tinhTongGia();

                                        return;
                                    }

                                }
                                dgvHoaDonNhap.Rows.Add(row.Cells["Ten"].Value.ToString(), sl, decimal.Parse(row.Cells["dongia"].Value.ToString()) * decimal.Parse(txtSl.Text), row.Cells["ID_SP"].Value.ToString());
                            }
                            else
                            {
                                dgvHoaDonNhap.Rows.Add(row.Cells["Ten"].Value.ToString(), sl, (decimal.Parse(row.Cells["dongia"].Value.ToString()) * decimal.Parse(txtSl.Text)).ToString(), row.Cells["ID_SP"].Value.ToString());

                                // cho biết là đã có hàng hoá nhập
                                isNhapHang = true;
                            }

                            tinhTongGia();
                        }
                    }
                }
            }
        }



        private void tinhTongGia()
        {
            decimal tonggia = 0;
            foreach (DataGridViewRow item_gia in dgvHoaDonNhap.Rows)
            {
                tonggia += decimal.Parse(item_gia.Cells["COST"].Value.ToString());
            }
            txtTongGia.Clear();
            txtTongGia.Text = tonggia.ToString();
        }


        [Obsolete]
        private void btnHangMoi_Click(object sender, EventArgs e)
        {
            FormNhapSanPham formNhapSanPham = new FormNhapSanPham();
            formNhapSanPham.ShowDialog();

            // kiem tra xem da co hang hang hoa nao nhap chua
            if (!isNhapHang)
            {
                B_SanPham.Instance.GetAllSanPhamNoDeleted(ref dtgDSHangHoa);
            }

        }



        [Obsolete]
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận nhập các mặt hàng trên chứ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //string ngaylap = DateTime.Now.ToShortDateString();
                if (dgvHoaDonNhap.Rows.Count <= 0 || txtTongGia.Text == "")
                {
                    MessageBox.Show("Data err !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    decimal tonggia = decimal.Parse(txtTongGia.Text);
                    // them id nha cung cap
                    object[] phieunhatkho = new object[] { B_TaiKhoan.Instance.id,id_ncc_Nhap, tonggia };
                    if (B_PhieuNhapKho.Instance.stokerCreatePhieuNhapKho(phieunhatkho))
                    {
                        int id_phieuNhap = B_PhieuNhapKho.Instance.stokerGetNewReceipt();

                        foreach (DataGridViewRow item in dgvHoaDonNhap.Rows)
                        {
                            object[] chitietPhieuNhap = new object[] { id_phieuNhap, int.Parse(item.Cells["ID"].Value.ToString()), decimal.Parse(item.Cells["COST"].Value.ToString()), int.Parse(item.Cells["QTY"].Value.ToString()) };
                            B_ChiTietPhieuNhapKho.Instance.stokerCreateDetailsReceipt(chitietPhieuNhap);

                            //object[] UpdateSLSanPham = new object[] { int.Parse(item.Cells["ID"].Value.ToString()), int.Parse(item.Cells["QTY"].Value.ToString()) };

                            //B_SanPham.Instance.StokerUpdateSLSanPham(UpdateSLSanPham);
                        }
                        MessageBox.Show("Tạo Phiếu Nhập kho Thành Công", "Tuyệt vời");
                    }
                    else
                    {
                        MessageBox.Show("That Bai");
                    }
                }
            }
            B_SanPham.Instance.GetAllSanPhamNoDeleted(ref dtgDSHangHoa);
        }

        private void dgvHoaDonNhap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 5)
                {
                    dgvHoaDonNhap.Rows.RemoveAt(e.RowIndex);
                    tinhTongGia();
                }
            }
        }


        [Obsolete]
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbLoaiSP.SelectedIndex = -1;
            cmbNCC.SelectedIndex = -1;
            B_SanPham.Instance.GetAllSanPhamNoDeleted(ref dtgDSHangHoa);

            cmbNCC.Enabled = true;
            cmbLoaiSP.Enabled = true;
        }



        [Obsolete]
        private void cmbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNCC.SelectedIndex == -1)
            {
                B_SanPham.Instance.GetAllSanPhamNoDeleted(ref dtgDSHangHoa);
            }
            else
            {
                if (cmbLoaiSP.SelectedIndex == -1)
                {
                    // load data 
                    B_SanPham.Instance.GetProductBySupplier(int.Parse(cmbNCC.SelectedValue.ToString()), ref dtgDSHangHoa);

                    // gan id nha cung 
                    id_ncc_Nhap = int.Parse(cmbNCC.SelectedValue.ToString());


                    cmbNCC.Enabled = false;
                    cmbLoaiSP.Enabled = false;
                }
                else
                {
                    // load data
                    B_SanPham.Instance.GetProductByProductTypeAndSupplier(int.Parse(cmbLoaiSP.SelectedValue.ToString()), int.Parse(cmbNCC.SelectedValue.ToString()), ref dtgDSHangHoa);

                    // gan id nha cung 
                    id_ncc_Nhap = int.Parse(cmbNCC.SelectedValue.ToString());


                    cmbNCC.Enabled = false;
                    cmbLoaiSP.Enabled = false;
                }
            }
        }

        private void btnClearDS_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvHoaDonNhap.Rows)
            {
                dgvHoaDonNhap.Rows.Clear();
            }
            tinhTongGia();
        }

        decimal GetBaseGia(int id_sp)
        {
            decimal baseGia = 0;

            foreach (DataGridViewRow item in dtgDSHangHoa.Rows)
            {
                if (id_sp == int.Parse(item.Cells["ID_SP"].Value.ToString()))
                {
                    baseGia = decimal.Parse(item.Cells["dongia"].Value.ToString());
                    break;
                }
            }

            return baseGia;
        }

        // click sua so sl san pham
        private void dgvHoaDonNhap_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvHoaDonNhap.Rows[e.RowIndex];
                if (e.ColumnIndex == 1 && dgvHoaDonNhap[1, e.RowIndex].Value != null)
                {
                    decimal baseCost = GetBaseGia(int.Parse(row.Cells["ID"].Value.ToString()));
                    if (int.Parse(dgvHoaDonNhap[1, e.RowIndex].Value.ToString()) == 0)
                    {
                        dgvHoaDonNhap[1, e.RowIndex].Value = baseQTY;
                    }
                    dgvHoaDonNhap[2, e.RowIndex].Value = baseCost * decimal.Parse(dgvHoaDonNhap[1, e.RowIndex].Value.ToString());
                    tinhTongGia();
                }
            }
        }

        private void txtSl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không thể nhập ký tự này", "Thông Báo");
                e.Handled = true;
            }
        }

        private void dgvHoaDonNhap_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += new KeyPressEventHandler(DataGridViewCellEventArgs);
            //e.Control.KeyPress += new KeyPressEventHandler(DataGridViewCellEventArgs);
        }

        private void DataGridViewCellEventArgs(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Kí Tự Này", "Thông Báo");
                e.Handled = true;
            }
        }

        private void dgvHoaDonNhap_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                baseQTY = int.Parse(dgvHoaDonNhap[1, e.RowIndex].Value.ToString());
            }
        }
    }
}
