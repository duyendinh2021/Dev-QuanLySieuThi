using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class B_SanPham
    {
        private static B_SanPham instance;

        public static B_SanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_SanPham();
                }
                return instance;
            }
        }

        //public List<SanPham> SanPhamList(List<int> ids)
        //{
        //    List<SanPham> list = new List<SanPham>();
        //    for (int i = 0; i < ids.Count; i++)
        //    {
        //        List<SanPham> temp = new List<SanPham>();
        //        foreach (SanPham item in temp)
        //        {
        //            list.Add(item);
        //        }
        //    }
        //    return list;
        //}
        //public DataTable sanpham = new DataTable();

        [Obsolete]
        public void loaiDataSourceDVT(ref ComboBox comboBox)
        {
            List<SanPham> sanPhams = DAO.D_SanPham.Instance.selectAllSanPhamDanghoatDong();
            comboBox.DataSource = sanPhams;
            comboBox.DisplayMember = "Dvt";
            comboBox.ValueMember = "Dvt";
        }

         
        [Obsolete]
        public void getAllSanPham(ref DataGridView data)
        {
            List<SanPham> sanPhams = DAO.D_SanPham.Instance.selectAllSanPhamDanghoatDong();
            data.DataSource = sanPhams;
        }


        [Obsolete]
        public void loadSanPhamByLoaiSp(ref DataGridView data,int id)
        {
            List<SanPham> sanPhams = DAO.D_SanPham.Instance.loadSanPhamByLoaiSP(id);
            data.DataSource = sanPhams;
        }


        [Obsolete]
        public bool stokerAddSanPham(object[] parameter)
        {
            try
            {
                DAO.D_SanPham.Instance.stokerAddSanPham(parameter);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        [Obsolete]
        public void stokerGetNewProduct(ref DataTable dataTable)
        {
            SanPham sanPham = D_SanPham.Instance.stokerGetNewProduct();

            dataTable.Columns.Add("id");
            dataTable.Columns.Add("ten_sp");
            dataTable.Columns.Add("id_ncc");
            dataTable.Columns.Add("id_loai");
            dataTable.Columns.Add("sl");
            dataTable.Columns.Add("dvt");
            dataTable.Columns.Add("dongia");
            dataTable.Columns.Add("hinh");
            dataTable.Columns.Add("trangthai");

            dataTable.Rows.Add(sanPham);
        }

        [Obsolete]
        public void UpdateSLSanPham(object[] parameter)
        {
            D_SanPham.Instance.UpdateSLSanPham(parameter);
        }
    }
}
