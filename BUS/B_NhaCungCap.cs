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
    }
}
