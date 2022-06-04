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
        public void getAllNhanVien(ref DataGridView dt)
        {
            List<NhanVien> nhanViens = D_NhanVien.Instance.getAllNhanVien();
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
    }
}
