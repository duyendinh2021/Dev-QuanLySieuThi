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

namespace GUI.Forms.PhieuNhapkho
{
    public partial class FormQuanLyPhieuNhapKho : Form
    {
        public FormQuanLyPhieuNhapKho()
        {
            InitializeComponent();
        }


        [Obsolete]
        private void FormQuanLyPhieuNhapKho_Load(object sender, EventArgs e)
        {
            B_PhieuNhapKho.Instance.GetAllPhieuNhapKhoNoDeleted(ref dgvDanhSachNcc);
        }
    }
}
