using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class connectionData
    {
        private static connectionData _instance;

        public static connectionData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new connectionData();
                }
                return _instance;
            }
        }

        [Obsolete]
        private string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;

        private SqlConnection connection = new SqlConnection();

        [Obsolete]
        public void openConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cloesConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        [Obsolete]
        public SqlDataReader dataReader(string _query)
        {
            openConnection();
            using (SqlCommand cmd = new SqlCommand(_query, connection))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                return reader;
            }
        }


        public Object showDataInGridView(string _query)
        {
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(_query, connection))
            using (DataSet dataSet = new DataSet())
            {
                dataAdapter.Fill(dataSet);
                object data = dataSet.Tables[0];
                return data;
            }

        }

        //[Obsolete]
        //public DataTable excuteQuery2(string _query, object[] parameter = null)
        //{
        //    using (DataTable dt = new DataTable())
        //    using (SqlCommand cmd = new SqlCommand(_query, connection))
        //    {
        //        openConnection();
        //        if (parameter != null)
        //        {
        //            string[] listPara = _query.Split(' ');
        //            int dem = 0;
        //            foreach (string item in listPara)
        //            {
        //                if (item.Contains('@'))
        //                {
        //                    cmd.Parameters.AddWithValue(item, parameter[dem]);
        //                    dem++;
        //                }
        //            }
        //        }
        //        using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
        //        {
        //            dataAdapter.Fill(dt);
        //            cloesConnection();
        //            return dt;
        //        }
        //    }
        //}

        [Obsolete]
        public void excuteNonQueryStoreProcedure(string _query, object[] parameter)
        {
            using (SqlCommand cmd = new SqlCommand(_query, connection))
            {
                openConnection();
                if (parameter != null)
                {
                    string[] listPara = _query.Split(' ');
                    int dem = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[dem] ?? (object)DBNull.Value);
                            dem++;
                        }
                    }
                }
                cmd.ExecuteNonQuery();
                cloesConnection();
            }
        }


        //[Obsolete]
        //public void ExcuteNonQueryStoreProcedure(string sql, object[] parameter)
        //{
        //    //SqlConnection con = CreateConnect();
        //    SqlCommand cmd = new SqlCommand(sql, connection);
        //    //_conn.Open();
        //    openConnection();
        //    if (parameter != null)
        //    {
        //        string[] ListPara = sql.Split(' ');
        //        int i = 0;
        //        foreach (string item in ListPara)
        //        {
        //            if (item.Contains('@'))
        //            {
        //                cmd.Parameters.AddWithValue(item, parameter[i] ?? (object)DBNull.Value);
        //                i++;
        //            }
        //        }
        //    }
        //    cmd.ExecuteNonQuery();
        //    //con.Close();
        //    cloesConnection();
        //    cmd.Dispose();
        //}


        [Obsolete]
        public DataTable excuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            SqlCommand cmd = new SqlCommand(query, connection);
            openConnection();
            if (parameter != null)
            {
                string[] ListPara = query.Split(' ');
                int i = 0;
                foreach (string item in ListPara)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }
            }
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(data);
            cloesConnection();
            //con.Close();
            return data;
        }
    }
}
