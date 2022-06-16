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

namespace GUI.Forms.NhaCungCap
{
    public partial class FormViewNhaCungCap : Form
    {
        public FormViewNhaCungCap()
        {
            InitializeComponent();
        }

        int id_ncc;
        string ten_ct;
        string dc;
        string sdt;
        string songanHang;
        string tenNganhang;


        public FormViewNhaCungCap(int id)
        {
            InitializeComponent();
            this.id_ncc = id;
        }


        [Obsolete]
        private void FormViewNhaCungCap_Load(object sender, EventArgs e)
        {
            B_NhaCungCap.Instance.GetNhaCungCapByID(id_ncc,ref ten_ct,ref sdt,ref songanHang,ref dc,ref tenNganhang);
            txtTenCongTy.Text = ten_ct;
            txtDiaChi.Text = dc;
            txtSDT.Text = sdt;
            txtSoNganHang.Text = songanHang;
            txtTenNganHang.Text = tenNganhang;
            B_NhaCungCap.Instance.LoadComBoBoxNhaCungCapByID(id_ncc, ref cmbTrangThai);
        }
    }
}
