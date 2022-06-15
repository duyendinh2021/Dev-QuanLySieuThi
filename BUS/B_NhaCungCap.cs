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
using System.Reflection;

namespace BUS
{
    public class B_NhaCungCap
    {
        private static B_NhaCungCap instance;

        public static B_NhaCungCap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_NhaCungCap();
                }
                return instance;
            }
        }


        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            System.Reflection.PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (System.Reflection.PropertyInfo prop in Props)
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
        public void loadComboBoxNhaCungCap(ref ComboBox comboBox)
        {
            List<NhaCungCap> nhaCungCaps = DAO.D_NhaCungCap.Instance.loadComboBoxNhaCungCap();
            //DataTable dataTable = ToDataTable<NhaCungCap>(nhaCungCaps);

            comboBox.DisplayMember = "Tencongty";
            comboBox.ValueMember = "Idnhacungcap";
            comboBox.DataSource = nhaCungCaps;
        }


        [Obsolete]
        public void LoadNhaCungCapByID(int id, ref ComboBox comboBox)
        {
            List<NhaCungCap> nhaCungCap = D_NhaCungCap.Instance.loadNhaCungCapByID(id);
            comboBox.DisplayMember = "Tencongty";
            comboBox.ValueMember = "Idnhacungcap";
            comboBox.DataSource = nhaCungCap;
        }


        [Obsolete]
        public void LoadNhaCungCapByID(int id,ref string ten_ct,ref string sdt,ref string songanhang,ref string dc, ref string tennganhang)
        {
            NhaCungCap nhaCungCap = D_NhaCungCap.Instance.loadOneNhaCungCapByID(id);
            ten_ct = nhaCungCap.Tencongty;
            sdt = nhaCungCap.Sdt;
            songanhang = nhaCungCap.Sotaikhoan;
            dc = nhaCungCap.Diachi;
            tennganhang = nhaCungCap.Tennganhang;
        }


        [Obsolete]
        public void GetAllNhaCungCapHoatDong(ref DataGridView data)
        {
            List<NhaCungCap> nhaCungCaps = D_NhaCungCap.Instance.GetAllNhaCungCapHoatDong();
            data.DataSource = nhaCungCaps;
        }



        [Obsolete]
        public bool StokerDeleteNhaCungCap(int id)
        {
            try
            {
                D_NhaCungCap.Instance.StokerDeleteNhanCungCap(id);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }



        [Obsolete]
        public bool stokerAddNhaCungCap(object[] parameter)
        {
            try
            {
                DAO.D_NhaCungCap.Instance.stokerAddNhaCungCap(parameter);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        [Obsolete]
        public void LoadComBoBoxNhaCungCapByID(int id, ref ComboBox comboBox)
        {
            List<NhaCungCap> nhaCungCaps = D_NhaCungCap.Instance.loadNhaCungCapByID(id);
            comboBox.DataSource = nhaCungCaps;
            comboBox.DisplayMember = "Trangthai";
            comboBox.ValueMember = "Trangthai";
        }



        [Obsolete]
        public bool StokerUpdateNhaCungCap(object[] parameter)
        {
            try
            {
                D_NhaCungCap.Instance.StokerUpdateNhaCungCap(parameter);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }


        [Obsolete]
        public void GetNhaCungCapByTrangThai(int trangthai, ref DataGridView data)
        {
            List<NhaCungCap> nhaCungCaps = D_NhaCungCap.Instance.GetNhaCungCapByTrangThai(trangthai);
            data.DataSource = nhaCungCaps;
        }



        [Obsolete]
        public void SearchNhaCungCapMutiColumnTheoTrangThai(string Search, int trangThai, ref DataGridView data)
        {
            List<NhaCungCap> nhaCungCaps = D_NhaCungCap.Instance.SearchNhaCungCapMutiColumnTheoTrangThai(Search, trangThai);
            data.DataSource = nhaCungCaps;
        }
    }
}
