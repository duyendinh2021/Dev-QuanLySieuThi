using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Windows.Forms;
using System.Data;

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
        public void GetLoaiSanPhamByID(int id,ref ComboBox comboBox)
        {
            List<LoaiSanPham> loaiSanPham = D_LoaiSanPham.Instance.loadloaiSanPhamByID(id);

            comboBox.DisplayMember = "Tensanpham";
            comboBox.ValueMember = "Idloaisanpham";
            comboBox.DataSource = loaiSanPham;

        }

        [Obsolete]
        public string GetNameProductTypeByID(int id)
        {
            LoaiSanPham loaiSanPham = D_LoaiSanPham.Instance.GetOneProductTypeByID(id);
            return loaiSanPham.Tensanpham;
        }

        [Obsolete]
        public void loadDataSourcecmbLoaiSp(ref DataGridView dataGridView)
        {
            List<LoaiSanPham> loaiSanPhams = DAO.D_LoaiSanPham.Instance.loadDataSourcecmbLoaiSp();
            dataGridView.DataSource = loaiSanPhams;
        }
        [Obsolete]
        public DataTable cashierLoadLoaiSP()
        {
            DataTable dt = new DataTable();
            dt = D_LoaiSanPham.Instance.cashierLoadLoaiSP();
            return dt;
        }

        [Obsolete]
        public void CashierGetProductTypes(ref DataGridView data)
        {
            List<LoaiSanPham> loaiSanPhams = D_LoaiSanPham.Instance.CashierGetProductTypes();

            data.DataSource = loaiSanPhams;
        }


        [Obsolete]
        public void GetAllProductTypesNoDeleted(ref DataGridView dataGridView)
        {
            List<LoaiSanPham> loaiSanPhams = D_LoaiSanPham.Instance.GetAllProductTypesNoDeleted();
            dataGridView.DataSource = loaiSanPhams;
        }


        [Obsolete]
        public void SearchProductTypes(int trangthai, string search , ref DataGridView data)
        {
            List<LoaiSanPham> loaiSanPhams = D_LoaiSanPham.Instance.SearchProductTypes(trangthai, search);
            data.DataSource = loaiSanPhams;
        }

        [Obsolete]
        public void GetProductTypesByTrangthai(int trangthai,ref DataGridView data)
        {
            List<LoaiSanPham> loaiSanPhams = D_LoaiSanPham.Instance.GetProductTypesByTrangthai(trangthai);
            data.DataSource = loaiSanPhams;
        }

        [Obsolete]
        public void GetInforProductTypesByID(int id , ref string name,ref string mota,ref byte[] hinh)
        {
            LoaiSanPham loaiSanPham = D_LoaiSanPham.Instance.GetOneProductTypeByID(id);
            name = loaiSanPham.Tensanpham;
            mota = loaiSanPham.Mota;
            hinh = loaiSanPham.Hinh;
        }


        [Obsolete]
        public bool UpdateProductType(object[] paremeter)
        {
            try
            {
                D_LoaiSanPham.Instance.UpdateProductType(paremeter);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
