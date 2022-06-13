using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Windows.Forms;

namespace BUS
{
    public class B_LoaiSanPham
    {
        private static B_LoaiSanPham instance;

        public static B_LoaiSanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_LoaiSanPham();
                }
                return instance;
            }
        }


        [Obsolete]
        public void loadDataSourcecmbLoaiSp(ref ComboBox comboBox)
        {
            List<LoaiSanPham> loaiSanPhams = DAO.D_LoaiSanPham.Instance.loadDataSourcecmbLoaiSp();
            comboBox.DisplayMember = "Tensanpham";
            comboBox.ValueMember = "Idloaisanpham";
            comboBox.DataSource = loaiSanPhams;
        }

        [Obsolete]
        public void loadLoaiSanPhamByID(int id,ref ComboBox comboBox)
        {
            List<LoaiSanPham> loaiSanPham = D_LoaiSanPham.Instance.loadloaiSanPhamByID(id);

            comboBox.DisplayMember = "Tensanpham";
            comboBox.ValueMember = "Idloaisanpham";
            comboBox.DataSource = loaiSanPham;

        }

        [Obsolete]
        public void loadDataSourcecmbLoaiSp(ref DataGridView dataGridView)
        {
            List<LoaiSanPham> loaiSanPhams = DAO.D_LoaiSanPham.Instance.loadDataSourcecmbLoaiSp();
            dataGridView.DataSource = loaiSanPhams;
        }
    }
}
