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

namespace GUI.Forms.LoaiSanPham
{
    public partial class FormCapNhatLoaiSp : Form
    {
        int id;
        string ten;
        string mota;
        byte[] hinh;
        string sPathImg = "";
        public FormCapNhatLoaiSp()
        {
            InitializeComponent();
        }

        [Obsolete]
        public FormCapNhatLoaiSp(int id)
        {
            InitializeComponent();
            this.id = id;
            B_LoaiSanPham.Instance.GetInforProductTypesByID(id, ref ten, ref mota, ref hinh);
            txtTenSP.Text = ten;
            txtMoTa.Text = mota;
            ptcbShowImg.Image = SupportLogic.Instance.ConvertBinaryToImage(hinh);
        }

        private void btnBrowsImg_Click(object sender, EventArgs e)
        {
            try
            {
                sPathImg = SupportLogic.Instance.getPathFile();
                ptcbShowImg.Image = Image.FromFile(sPathImg);
            }
            catch (Exception)
            {
                ptcbShowImg.Image = SupportLogic.Instance.ConvertBinaryToImage(hinh);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtTenSP.Clear();
            txtMoTa.Clear();
            ptcbShowImg.Image = null;
        }

        [Obsolete]
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vui Lòng Xác Nhận Dể Tiến Hành Cập Nhật", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (txtMoTa.Text == "" || txtTenSP.Text == "" || hinh == null)
                {
                    MessageBox.Show("Thông Tin Chứa Dủ, Vui Lòng Kiểm Tra Lại", "Thông Báo");
                }
                else
                {
                    mota = txtMoTa.Text;
                    ten = txtTenSP.Text;
                    byte[] img;
                    if (sPathImg == "")
                    {
                        img =  hinh;
                    }
                    else
                    {
                        img = File.ReadAllBytes(sPathImg);
                    }
                    object[] loaisp = new object[] { id, ten, mota, img };
                    if (B_LoaiSanPham.Instance.UpdateProductType(loaisp))
                    {
                        MessageBox.Show("Cập Nhật Thành Công", "Thông Báo");
                    }
                    else
                    {
                        MessageBox.Show("Ô Nô !!!", "Cập Nhật Thất Bại");
                    }
                }
            }

        }

        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không nhập các kí tự này được !!!");
                e.Handled = true;
            }
        }

        private void txtMoTa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn không nhập các kí tự này được !!!");
                e.Handled = true;
            }
        }
    }
}
