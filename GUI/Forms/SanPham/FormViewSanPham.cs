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

        public FormViewSanPham()
        {
            InitializeComponent();
        }

        int id_sp;
        int id_ncc;
        int id_loai;
        string ten_sp;
        string dvt;
        decimal dongia;
        int sl;
        byte[] hinh;
        int trangthai;



        [Obsolete]
        public FormViewSanPham(int id)
        {
            InitializeComponent();
            id_sp = id;
            B_SanPham.Instance.GetProductByID(id_sp, ref ten_sp, ref id_loai, ref id_ncc, ref sl, ref dongia, ref hinh, ref trangthai);
            txtTenSp.Text = ten_sp;
            B_NhaCungCap.Instance.LoadNhaCungCapByID(id_ncc, ref cmbNcc);
            B_SanPham.Instance.LoadDataSourceUnitByID(id_sp, ref cmbDvt);
            B_LoaiSanPham.Instance.GetLoaiSanPhamByID(id_loai, ref cmbLoaiSp);
            txtDonGia.Text = dongia.ToString();
            if (hinh != null)
            {
                ptbShowImage.Image = SupportLogic.Instance.ConvertBinaryToImage(hinh);
            }
        }

        [Obsolete]
        private void FormViewSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}
