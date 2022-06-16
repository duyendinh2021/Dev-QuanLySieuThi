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
        public FormViewSanPham(int id,int id_ncc,int id_loai,string ten_sp, decimal dongia, byte[] hinh,int trangthai)
        {
            InitializeComponent();
            this.id_sp = id;
            this.ten_sp = ten_sp;
            this.dongia = dongia;
            this.hinh = hinh;
            this.id_ncc = id_ncc;
            this.id_loai = id_loai;

            this.trangthai = trangthai;

        }

        [Obsolete]
        private void FormViewSanPham_Load(object sender, EventArgs e)
        {
            txtTenSp.Text = ten_sp;
            txtDonGia.Text = dongia.ToString();
            // bug 
            txtDVT.Text = dvt;



            txtNcc.Text = B_NhaCungCap.Instance.GetNhaCungCapByID(id_ncc);
            txtLoaiSP.Text = B_LoaiSanPham.Instance.GetNameProductTypeByID(id_loai);

            ptbShowImage.Image = SupportLogic.Instance.ConvertBinaryToImage(hinh);
        }
    }
}
