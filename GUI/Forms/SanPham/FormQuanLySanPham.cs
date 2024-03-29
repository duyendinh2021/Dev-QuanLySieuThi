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
using BUS;
using GUI.ClassSupport;

namespace GUI.Forms
{
    public partial class FormQuanLySanPham : Form
    {
        [Obsolete]
        public FormQuanLySanPham()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormNhapSanPham formNhapSanPham = new FormNhapSanPham();
            formNhapSanPham.ShowDialog();
        }


        [Obsolete]
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang formNhapHang = new FormNhapHang();
            formNhapHang.ShowDialog();
            B_SanPham.Instance.GetAllSanPhamNoDeleted(ref dtDanhSachSP);
            Load_Category();

        }


        [Obsolete]
        private void FormQuanLySanPham_Load(object sender, EventArgs e)
        {
     


            B_SanPham.Instance.GetAllSanPhamNoDeleted(ref dtDanhSachSP);
            dtDanhSachSP.Columns["Hinh"].Visible = false;
            dtDanhSachSP.Columns["Trangthai"].Visible = false;
            Load_Category();
            if (B_TaiKhoan.Instance.quyen == "Cashier")
            {
                //panSideMenu.Visible = false;
                btnNhapHang.Visible = false;
                dtDanhSachSP.Columns["colbtnXoa"].Visible = false;
                dtDanhSachSP.Columns["colbtnSua"].Visible = false;
                lblHangHoa.Visible = false;
                dtDanhSachSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }



        [Obsolete]
        private void Load_Category()
        {
            flpCategory.Controls.Clear();
            dataGridView.AllowUserToAddRows = false;
            B_LoaiSanPham.Instance.loadDataSourcecmbLoaiSp(ref dataGridView);
            foreach (DataGridViewRow item in dataGridView.Rows)
            {
                int id = int.Parse(item.Cells["Idloaisanpham"].Value.ToString());
                string name = item.Cells["Tensanpham"].Value.ToString();
                CheckBox checkBox = new CheckBox();

                checkBox.Tag = id.ToString();
                checkBox.Text = name;

                checkBox.AutoSize = true;
                checkBox.Margin = new Padding(25, 25, 0, 0);
                FontFamily fontFamily = new FontFamily("Consolas");
                checkBox.Font = new Font(fontFamily, 10.2f, FontStyle.Bold);


                flpCategory.Controls.Add(checkBox);
            }
        }



        [Obsolete]
        private void dtDanhSachSP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dtDanhSachSP.Rows[e.RowIndex];
                if (B_TaiKhoan.Instance.quyen == "Stoker" || B_TaiKhoan.Instance.quyen == "Admin")
                {
                    // btn edit
                    if (e.ColumnIndex == 0)
                    {
                        int id = int.Parse(row.Cells["id_sp"].Value.ToString());
                        int id_ncc = int.Parse(row.Cells["id_ncc"].Value.ToString());
                        int id_loai = int.Parse(row.Cells["id_loaisp"].Value.ToString());
                        string ten_sp = row.Cells["ten_sp"].Value.ToString();
                        string dvt = row.Cells["dvt"].Value.ToString();
                        decimal dongia = decimal.Parse(row.Cells["donGia"].Value.ToString());

                        FormCapNhatSanPham formCapNhatSanPham = new FormCapNhatSanPham(id, id_ncc, id_loai, ten_sp, dvt, dongia);
                        formCapNhatSanPham.ShowDialog();
                        B_SanPham.Instance.GetAllSanPhamNoDeleted(ref dtDanhSachSP);
                        row = dtDanhSachSP.Rows[e.RowIndex];

                        ptbXemSanPham.Image = SupportLogic.Instance.ConvertBinaryToImage((byte[])row.Cells["Hinh"].Value);

                    }

                    // btn xoa
                    if (e.ColumnIndex == 1)
                    {
                        DialogResult result = MessageBox.Show("Vui Lòng Xác Nhận Dể Tiến Hành Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            result = MessageBox.Show("Vui Lòng Xác Nhận Lại Dể Tiến Hành Xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                int id = int.Parse(row.Cells["id_sp"].Value.ToString());
                                if (B_SanPham.Instance.StokerDeleteProduct(id))
                                {
                                    MessageBox.Show("Đã Xóa Thành Công !!!");
                                }
                                else
                                {
                                    MessageBox.Show("Ô Nô !!!", "Có Gì Đó Không Ổn");
                                }
                                B_SanPham.Instance.GetAllSanPhamNoDeleted(ref dtDanhSachSP);
                                row = dtDanhSachSP.Rows[e.RowIndex];


                            }
                        }
                    }
                }      
                ptbXemSanPham.Image = SupportLogic.Instance.ConvertBinaryToImage((byte[])row.Cells["Hinh"].Value);
            }
        }

        [Obsolete]
        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            B_SanPham.Instance.GetAllSanPhamNoDeleted(ref dtDanhSachSP);
        }



        [Obsolete]
        private void radConHang_CheckedChanged(object sender, EventArgs e)
        {
            B_SanPham.Instance.GetProductIsStillInStock(ref dtDanhSachSP);
        }




        [Obsolete]
        private void radHetHang_CheckedChanged(object sender, EventArgs e)
        {
            B_SanPham.Instance.GetProductIsOut(ref dtDanhSachSP);
        }


        [Obsolete]
        private void btnBrowField_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            foreach (Control item in flpCategory.Controls)
            {
                if (item.GetType() == typeof(CheckBox))
                {
                    if (((CheckBox)item).Checked)
                    {
                        ids.Add(int.Parse(((CheckBox)item).Tag.ToString()));
                    }
                }
            }
            B_SanPham.Instance.GetProducByProducTypes(ids, ref dtDanhSachSP);
        }


        [Obsolete]
        private void radSPKhongHoat_CheckedChanged(object sender, EventArgs e)
        {
            B_SanPham.Instance.GetSanPhamDeleted(ref dtDanhSachSP);
        }
    }
}
