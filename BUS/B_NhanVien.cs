using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;
using System.Reflection;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace BUS
{
    public class B_NhanVien
    {
        private static B_NhanVien instance;

        public static B_NhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_NhanVien();
                }
                return instance;
            }
        }
        [Obsolete]
        public void getAllNhanVienHoatDong(ref DataGridView dt)
        {
            List<NhanVien> nhanViens = D_NhanVien.Instance.getAllNhanVienHoatDong();
            dt.DataSource = nhanViens;
        }



        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            System.Reflection.PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        [Obsolete]
        public bool adminAddNhanVien(object[] parameter)
        {
            try
            {
                DAO.D_NhanVien.Instance.adminAddNhanVien(parameter);
            }
            catch (Exception)
            {
                return false;

            }
            return true;
        }



        [Obsolete]

        public bool adminUpdateNhanVien(object[] parameter)
        {
            try
            {
                DAO.D_NhanVien.Instance.adminUpdateNhanVien(parameter);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }


        [Obsolete]
        public Boolean adminDeleteNhanVien(int id)
        {
            try
            {
                DAO.D_NhanVien.Instance.adminDeleteNhanVien(id);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        [Obsolete]
        public void getNhanVienByChucVu(ref DataGridView data,string chuvu)
        {
            List<NhanVien> nhanVienAdmins = DAO.D_NhanVien.Instance.getNhanVienByChucVu(chuvu);
            data.DataSource = nhanVienAdmins;
        }


        [Obsolete]
        public void getNhanVienByTrangThai(ref DataGridView data, int trangThai)
        {
            List<NhanVien> nhanVienByTrangThai = DAO.D_NhanVien.Instance.getNhanVienByTrangThai(trangThai);
            data.DataSource = nhanVienByTrangThai;
        }


        [Obsolete]
        public void getAllNhanVien(ref DataGridView data)
        {
            List<NhanVien> allNhanVien = DAO.D_NhanVien.Instance.getAllNhanVien();
            data.DataSource = allNhanVien;
        }


        [Obsolete]
        public void searchNhanVien(ref DataGridView data, string search)
        {
            List<NhanVien> nhanVienSearch = DAO.D_NhanVien.Instance.searchNhanVien(search);
            data.DataSource = nhanVienSearch;
        }



        [Obsolete]
        public void getNhanVienByChucVuAndTrangThai(ref DataGridView data,string chucvu,int trangthai)
        {
            List<NhanVien> nhanViens = DAO.D_NhanVien.Instance.getNhanVienByChucVuAndTrangThai(chucvu,trangthai);
            data.DataSource = nhanViens;
        }



        [Obsolete]
        public void searchNhanVienByChuVuAndTrangThai(ref DataGridView data,string search, string chucvu,int trangthai)
        {
            List<NhanVien> nhanViens = DAO.D_NhanVien.Instance.searchNhanVienByChuVuAndTrangThai(search, chucvu, trangthai);
            data.DataSource = nhanViens;
        }




        [Obsolete]
        public void searchNhanVienByTrangThai(ref DataGridView data, string search ,int trangthai)
        {
            List<NhanVien> nhanViens = DAO.D_NhanVien.Instance.searchNhanVienByTrangThai(search ,trangthai);
            data.DataSource = nhanViens;
        }


        [Obsolete]
        public void GetTaiKhoanByID(int id,ref string usernam,ref string pass,ref string chucvu,ref int trangthai)
        {
            TaiKhoan tk = DAO.D_NhanVien.Instance.getTaiKhoanByID(id);
            usernam = tk.Uesrname;
            pass = tk.Pass;
            chucvu = tk.Chuvu;
            trangthai = tk.Trangthai;
        }




        [Obsolete]
        public bool stokerAddNhaCungCap(object[] parameter)
        {
            try
            {
                DAO.D_NhanVien.Instance.stokerAddNhaCungCap(parameter);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
