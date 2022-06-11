﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Forms;
using GUI.Forms.SanPham;

namespace GUI.Forms
{
    public partial class FormQuanLySanPham : Form
    {
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNhapSanPham formNhapSanPham = new FormNhapSanPham();
            formNhapSanPham.ShowDialog();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang formNhapHang = new FormNhapHang();
            formNhapHang.ShowDialog();
        }
    }
}