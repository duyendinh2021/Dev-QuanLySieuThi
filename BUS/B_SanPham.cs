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



        [Obsolete]
        public void getSanPhamByLoai_array(List<int> ids, ref DataGridView data)
        {
            List<SanPham> list = new List<SanPham>();
            for (int i = 0; i < ids.Count; i++)
            {
                List<SanPham> temp = D_SanPham.Instance.getSanPhamByLoai(ids[i]);
                foreach (SanPham item in temp)
                {
                    list.Add(item);
                }
            }
            data.DataSource = list;
        }



        [Obsolete]
        public void loadDataSourceDVT(ref ComboBox comboBox)
        {

            List<SanPham> sanPhams = D_SanPham.Instance.loadComboBoxDVT();
            
            comboBox.DisplayMember = "Dvt";
            comboBox.ValueMember = "Dvt";
            comboBox.DataSource = sanPhams;
        }


        [Obsolete]
        public void LoadDataSourceByID(int id, ref ComboBox combox)
        {
            List<SanPham> sanPhams = new List<SanPham>();
            sanPhams.Add(D_SanPham.Instance.LoadSanPhamTheoid(id));
            combox.DataSource = sanPhams;
            combox.DisplayMember = "Dvt";
            combox.ValueMember = "Dvt";
        }


         
        [Obsolete]
        public void getAllSanPhamHoatDong(ref DataGridView data)
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


        [Obsolete]
        public void LoadSamPhamtheoid(int id,ref string ten_sp, ref int id_loai, ref int id_ncc, ref int sl, ref decimal dongia, ref byte[] hinh, ref int trangthai)
        {
           SanPham sanPham =  D_SanPham.Instance.LoadSanPhamTheoid(id);
            //int id_sp = sanPham.Idsanpham;
            id_loai = sanPham.Idloaisanpham;
            id_ncc = sanPham.Idnhacungcap;
            ten_sp = sanPham.Tensanpham;
            sl = sanPham.Sl;
            dongia = sanPham.Dongia;
            hinh = sanPham.Hinh;
            trangthai = sanPham.Trangthai;
        }



        [Obsolete]
        public void getSanPhamByNCC(int id, ref DataGridView data)
        {
            List<SanPham> sanPhams = D_SanPham.Instance.getSanPhamByNCC(id);
            data.DataSource = sanPhams;
        }



        [Obsolete]
        public bool stokerUpdateSanPham(object[] parameter)
        {
            try
            {
                D_SanPham.Instance.stokerUpdateSanPham(parameter);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }




        [Obsolete]
        public bool stokerDeleteSanPham(int id)
        {
            try
            {
                D_SanPham.Instance.stokerDeleteSanPham(id);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }


        [Obsolete]
        public void SelectSanPhamByLoaiAndNCC(int id_loai, int id_ncc,ref DataGridView data)
        {
            List<SanPham> sanPhams = D_SanPham.Instance.SelectSanPhamByLoaiAndNCC(id_loai, id_ncc);

            data.DataSource = sanPhams;
        }


        [Obsolete]
        public void getSanPamHetHang(ref DataGridView data)
        {
            List<SanPham> sanPhams = D_SanPham.Instance.getSanPamHetHang();
            data.DataSource = sanPhams;
        }


        [Obsolete]
        public void getSanPamConHang(ref DataGridView data)
        {
            List<SanPham> sanPhams = D_SanPham.Instance.getSanPamConHang();
            data.DataSource = sanPhams;
        }
    }
}
