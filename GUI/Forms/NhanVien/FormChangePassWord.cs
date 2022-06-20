using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.ClassSupport;
using BUS;

namespace GUI.Forms.NhanVien
{
    public partial class FormChangePassWord : Form
    {
        int Captcha = 0;
        int id_nv;
        [Obsolete]
        public FormChangePassWord(int id_nv)
        {
            InitializeComponent();
            LoadCaptcha();
            this.id_nv = id_nv;
            txtAcc.Text = B_TaiKhoan.Instance.GetNameAccoutById(id_nv);
        }


        private void LoadCaptcha()
        {
            Random random = new Random();
            Captcha = random.Next(999, 9999);
            var image = new Bitmap(this.ptcCaptcha.Width, this.ptcCaptcha.Height);
            var font = new Font("Consolas", 26f, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(Captcha.ToString(), font, Brushes.Green, new Point(0, 0));
            ptcCaptcha.Image = image;
        }

        private void btnRefreshCaptcha_Click(object sender, EventArgs e)
        {
            LoadCaptcha();
        }

        private void txtPassold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Password_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Dùng Ký Tự Này Cho Passworrd :((", "Thông Báo");
                e.Handled = true;
            }
        }

        private void txtPassNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Password_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Dùng Ký Tự Này Cho Passworrd :((", "Thông Báo");
                e.Handled = true;
            }
        }

        private void txtPassNew2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Rule_Regex.Instance.Password_Regex.IsMatch(e.KeyChar.ToString()) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Bạn Không Thể Dùng Ký Tự Này Cho Passworrd :((", "Thông Báo");
                e.Handled = true;
            }
        }


        [Obsolete]
        private void btnConfrim_Click(object sender, EventArgs e)
        {

            if (B_TaiKhoan.Instance.CheckAccoutUser(txtAcc.Text, txtPassold.Text))
            {
                if (txtCaptcha.Text == Captcha.ToString())
                {
                    if (txtPassNew.Text == "" || txtPassNew2.Text == "")
                    {
                        MessageBox.Show("PassWord Không Thể Dể Trống !!!", "Thông Báo");
                        LoadCaptcha();
                    }
                    else
                    {
                        if (txtPassNew.Text == txtPassNew2.Text)
                        {

                            object[] Accout = new object[] { id_nv, txtPassNew2.Text };
                            if (B_TaiKhoan.Instance.userChangePassWord(Accout))
                            {
                                MessageBox.Show("Cập Nhật Mật khẩu Thành Công", "Thông Báo");
                            }
                            else
                            {
                                MessageBox.Show("Cập Nhật Mật khẩu Thất Bại", "Thông Báo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp !!!!!", "Thông Báo");
                            LoadCaptcha();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Captcha err !!!!!!!!!!!!!!!!!!!!!");
                    LoadCaptcha();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không Đúng !!!!!", "Thông Báo");
                LoadCaptcha();
            }
        }

        private void txtPassold_KeyDown(object sender, KeyEventArgs e)
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
                    txtPassNew.Focus();
                }
            }
        }
    }
}
