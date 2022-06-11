using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using GUI.ClassSupport;

namespace GUI.Forms
{
    public partial class FormNhapLoaiSP : Form
    {
        public FormNhapLoaiSP()
        {
            InitializeComponent();
        }

        string sPathImg;

        private void txtTenSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Name_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này !!!");
                e.Handled = true;
            }
        }

        private void txtMoTa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Describe_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Nhập Ký Tự Này !!!");
                e.Handled = true;

            }
        }

        private void txtTenSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMoTa.Focus();
            }
        }

        private void txtMoTa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBrowsImg.Focus();
            }
        }

        private void btnBrowsImg_Click(object sender, EventArgs e)
        {
            sPathImg = SupportLogic.Instance.getPathFile();
            if (sPathImg != "")
            {
                Image image = Image.FromFile(sPathImg);
                ptcbShowImg.Image = image;
            }
        }

        private void btnBrowsImg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sPathImg = SupportLogic.Instance.getPathFile();
                if (sPathImg != "")
                {
                    Image image = Image.FromFile(sPathImg);
                    ptcbShowImg.Image = image;
                }
            }
        }


        [Obsolete]
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string tenLoaiSP = txtTenSP.Text;
            string mota = txtMoTa.Text;
            Byte[] img = System.IO.File.ReadAllBytes(sPathImg);

            if (txtTenSP.Text == "" || txtMoTa.Text == "" || sPathImg == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Dủ thông Tin, Vui Lòng Kiểm Tra lại, Tks");
            }
            else
            {
                object[] objects = new object[] {tenLoaiSP, mota, img};
                if (BUS.B_NhanVien.Instance.stokerAddLoaiSanPham(objects))
                {
                    MessageBox.Show("Thật Tuyệt Vời", "Ô Mai Good");
                }
                else
                {
                    MessageBox.Show("Ô NÔ !!!", "Có Gì Đó Sải Không Đúng");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtTenSP.Clear();
            txtMoTa.Clear();
            sPathImg = "";
            ptcbShowImg.Image = null;
        }
    }
}
