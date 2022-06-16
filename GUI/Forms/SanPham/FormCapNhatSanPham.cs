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
using GUI.ClassSupport;


namespace GUI.Forms.SanPham
{
    public partial class FormCapNhatSanPham : Form
    {
        public FormCapNhatSanPham()
        {
            InitializeComponent();
        }

        int id;
        int id_ncc;
        int id_loai;
        string ten_sp;
        string dvt;
        decimal dongia;
        int sl;
        byte[] hinh;
        Image image;
        int trangthai;
        string sPathImg = "";
        public FormCapNhatSanPham(int id, int id_ncc, int id_loai, string ten_sp, string dvt, decimal dongia)
        {
            InitializeComponent();
            this.id = id;
            this.id_ncc = id_ncc;
            this.id_loai = id_loai;
            this.ten_sp = ten_sp;
            this.dvt = dvt;
            this.dongia = dongia;
        }


        [Obsolete]
        private void FormCapNhatSanPham_Load(object sender, EventArgs e)
        {
            B_SanPham.Instance.GetProductByID(id, ref ten_sp, ref id_loai, ref id_ncc, ref sl, ref dongia, ref hinh, ref trangthai);

            txtTenSP.Text = ten_sp;

            B_NhaCungCap.Instance.LoadNhaCungCapByID(id_ncc, ref cmbNCC);
            B_LoaiSanPham.Instance.GetLoaiSanPhamByID(id_loai, ref cmbID_Loaisp);
            B_SanPham.Instance.LoadDataSourceUnitByID(id, ref cmbDVT);



            cmbDVT.SelectedIndex = 0;
            cmbID_Loaisp.SelectedIndex = 0;
            cmbNCC.SelectedIndex = 0;



            ptcShowImg.Image = SupportLogic.Instance.ConvertBinaryToImage(hinh);
            txtDonGia.Text = dongia.ToString();
            ptcShowImg.Image = SupportLogic.Instance.ConvertBinaryToImage(hinh);
        }

        private void btnRowImg_Click(object sender, EventArgs e)
        {
            sPathImg = SupportLogic.Instance.getPathFile();
            if (sPathImg != "")
            {
                hinh = System.IO.File.ReadAllBytes(sPathImg);
                image = Image.FromFile(sPathImg);
                ptcShowImg.Image = image;
            }
        }


        [Obsolete]
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Vui lòng xác nhận dể tiến hành cập nhật", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id_sp = id;
                int id_ncc2 = int.Parse(cmbNCC.SelectedValue.ToString());
                int id_loai2 = int.Parse(cmbID_Loaisp.SelectedValue.ToString());
                decimal dongia2 = decimal.Parse(txtDonGia.Text);
                string dvt = cmbDVT.Text;
                string ten_sp2 = txtTenSP.Text;
                byte[] imgInsert;
                if (sPathImg == "")
                {
                    imgInsert = hinh;
                }
                else
                {
                    imgInsert = System.IO.File.ReadAllBytes(sPathImg);
                }

                object[] sanpham = new object[] { id_sp, ten_sp2, id_ncc2, id_loai2, dvt, dongia2, imgInsert, 1 };
                if (B_SanPham.Instance.StokerUpdateProduct(sanpham))
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                }
                else
                {
                    MessageBox.Show("Ô Nô !!!", "Cập Nhật Thất Bại");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenSP.Clear();
            cmbDVT.SelectedIndex = -1;
            cmbID_Loaisp.SelectedIndex = -1;
            cmbNCC.SelectedIndex = -1;
            txtDonGia.Clear();
            ptcShowImg.Image = null;
        }


        [Obsolete]
        private void btnEditNCC_Click(object sender, EventArgs e)
        {
            B_NhaCungCap.Instance.loadComboBoxNhaCungCap(ref cmbNCC);

        }


        [Obsolete]
        private void btnEditID_Click(object sender, EventArgs e)
        {
            B_LoaiSanPham.Instance.loadDataSourcecmbLoaiSp(ref cmbID_Loaisp);
        }


        [Obsolete]
        private void btnEditDVT_Click(object sender, EventArgs e)
        {
            B_SanPham.Instance.loadDataSourceUnits(ref cmbDVT);
            cmbDVT.DropDownStyle = ComboBoxStyle.DropDown;
        }
    }
}
