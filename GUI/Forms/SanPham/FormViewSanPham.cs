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

namespace GUI.Forms.SanPham
{
    public partial class FormViewSanPham : Form
    {
        int id_sp;
        int id_ncc;
        int id_loai;
        string ten_sp;
        string dvt;
        decimal dongia;
        int sl;
        byte[] hinh;
        int trangthai;
        public FormViewSanPham()
        {
            InitializeComponent();
        }
        public FormViewSanPham(int id)
        {
            InitializeComponent();
            this.id_sp = id;
        }


        [Obsolete]
        private void FormViewSanPham_Load(object sender, EventArgs e)
        {
            B_SanPham.Instance.LoadSamPhamtheoid(id_sp,ref ten_sp,ref id_loai, ref id_ncc,ref sl, ref dongia,ref hinh,ref trangthai);
            txtTenSp.Text = ten_sp;
            txtDonGia.Text = dongia.ToString();
            

            // bug 

            //B_NhaCungCap.Instance.LoadNhaCungCapByID(id_ncc,ref cmbNcc);
            //B_LoaiSanPham.Instance.loadLoaiSanPhamByID(id_loai, ref cmbLoaiSp);


            //B_SanPham.Instance.LoadDataSourceByID(this.id_sp, ref cmbDVT);

            //cmbLoaiSp.SelectedIndex = 0;
            //cmbDVT.SelectedIndex = 0;
            //cmbNcc.SelectedIndex = 0;

            ptbShowImage.Image = SupportLogic.Instance.ConvertBinaryToImage(hinh);
        }
    }
}
