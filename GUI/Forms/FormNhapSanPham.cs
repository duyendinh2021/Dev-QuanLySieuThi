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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenSp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
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
            BUS.B_NhaCungCap.Instance.loadComboBoxNhaCungCap(ref cmbNcc);
            BUS.B_LoaiSanPham.Instance.loadDataSourcecmbLoaiSp(ref cmbLoaiSp);
            cmbNcc.SelectedIndex = -1;
            cmbLoaiSp.SelectedIndex = -1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int idNCC = int.Parse(cmbNcc.SelectedValue.ToString());
            MessageBox.Show(idNCC.ToString());
        }
    }
}
