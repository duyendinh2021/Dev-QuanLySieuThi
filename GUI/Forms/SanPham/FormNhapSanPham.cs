using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GUI.ClassSupport;
using BUS;

namespace GUI.Forms
{
    public partial class FormNhapSanPham : Form
    {
        public FormNhapSanPham()
        {
            InitializeComponent();
        }
        string sPathImg;

        public DataTable sanpham = new DataTable();

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenSp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Product_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không được nhập ký tự này !!!", "Thông Báo");
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không được nhập ký tự này !!!", "Thông Báo");
                e.Handled = true;
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Number_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không được nhập ký tự này !!!", "Thông Báo");
                e.Handled = true;
            }
        }

        [Obsolete]
        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            FormThemNhaCungCap formThemNhaCungCap = new FormThemNhaCungCap();
            formThemNhaCungCap.ShowDialog();
            BUS.B_NhaCungCap.Instance.loadComboBoxNhaCungCap(ref cmbNcc);
        }


        [Obsolete]
        private void FormNhapSanPham_Load(object sender, EventArgs e)
        {
            B_NhaCungCap.Instance.loadComboBoxNhaCungCap(ref cmbNcc);
            B_LoaiSanPham.Instance.loadDataSourcecmbLoaiSp(ref cmbLoaiSp);
            B_SanPham.Instance.loadDataSourceUnits(ref cmbDVT);
            cmbDVT.SelectedIndex = -1;
            cmbNcc.SelectedIndex = -1;
            cmbLoaiSp.SelectedIndex = -1;
        }

        [Obsolete]
        private void btnThemLoaiSp_Click(object sender, EventArgs e)
        {
            FormNhapLoaiSP formNhapLoaiSP = new FormNhapLoaiSP();
            formNhapLoaiSP.ShowDialog();
            B_LoaiSanPham.Instance.loadDataSourcecmbLoaiSp(ref cmbLoaiSp);
        }

        private void btnBrowsImg_Click(object sender, EventArgs e)
        {
            sPathImg = SupportLogic.Instance.getPathFile();
            if (sPathImg != "")
            {
                Image image = Image.FromFile(sPathImg);
                ptbShowImage.Image = image;
            }
        }


        [Obsolete]
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // tí phải làm phiếu nhập kho chi tiết phiếu nhập kho + với insert sản phẩm

            if (txtTenSp.Text == "" || cmbNcc.SelectedIndex == -1 || cmbLoaiSp.SelectedIndex == -1 || cmbDVT.Text == "" || txtDonGia.Text == "" || sPathImg == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Dủ Thông Tin, Vui Lòng Kiểm tra Lại, Tks !!!");
            }
            else
            {
                string tensp = txtTenSp.Text;
                int id_ncc = int.Parse(cmbNcc.SelectedValue.ToString());
                int id_loai = int.Parse(cmbLoaiSp.SelectedValue.ToString());
                //int sl = int.Parse(txtSoLuong.Text);
                string dvt = cmbDVT.Text;
                decimal dongai = decimal.Parse(txtDonGia.Text);
                byte[] hinh = System.IO.File.ReadAllBytes(sPathImg);

                // object chứa thông tinh san phẩm dc nhập
                object[] objects = new object[] { tensp, id_ncc, id_loai, 0, dvt, dongai, hinh };

                if (B_SanPham.Instance.StokerAddProduc(objects))
                {
                    B_SanPham.Instance.StokerGetNewProduct(ref sanpham);
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenSp.Clear();
            txtDonGia.Focus();

            cmbDVT.SelectedIndex = -1;
            cmbLoaiSp.SelectedIndex = -1;
            cmbNcc.SelectedIndex = -1;
            sPathImg = "";
        }

        private void txtTenSp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbNcc.Focus();
                }
            }
        }

        private void cmbNcc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbLoaiSp.Focus();
            }
        }

        private void cmbLoaiSp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbDVT.Focus();
            }
        }

        private void cmbDVT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDonGia.Focus();
            }
        }

        private void txtDonGia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnBrowsImg.Focus();
                }
            }
        }
    }
}
