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
        int trangthai;
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
            B_SanPham.Instance.LoadSamPhamtheoid(id,ref ten_sp,ref id_loai,ref id_ncc,ref sl,ref dongia,ref hinh,ref trangthai);

            txtTenSP.Text = ten_sp;
        }
    }
}
