using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace DAO
{
    public class D_TaiKhoan
    {
        private static D_TaiKhoan instance;

        public static D_TaiKhoan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_TaiKhoan();
                }
                return instance;
            }
        }


        [Obsolete]
        public TaiKhoan GetOneAccout(string accUesrLogIn, string passUesrLogIn)
        {
            TaiKhoan taiKhoan = new TaiKhoan();

            using (DataTable dt = connectionData.Instance.excuteQuery("EXEC SelectAllTaiKhoan @acc , @pass", new object[] { accUesrLogIn, passUesrLogIn }))
            {
                foreach (DataRow item in dt.Rows)
                {
                    taiKhoan.Idnhanvien = Convert.ToInt32(item["ID_NhanVien"].ToString());
                    taiKhoan.Uesrname = item["TenTK"].ToString();
                    taiKhoan.Pass = item["MK"].ToString();
                    taiKhoan.Chuvu = item["ChucVu"].ToString();
                    taiKhoan.Trangthai = Convert.ToInt32(item["TrangThai"].ToString());
                    taiKhoan.Statuslogin = Convert.ToInt32(item["StatusLogIn"].ToString());
                }
            }
            return taiKhoan;
        }



        [Obsolete]
        public TaiKhoan GetOneAccoutById(int id)
        {
            TaiKhoan taiKhoan = new TaiKhoan();

            using (DataTable dt = connectionData.Instance.excuteQuery("EXEC SearchTaiKhoanByID @id", new object[] { id }))
            {
                foreach (DataRow item in dt.Rows)
                {
                    taiKhoan.Idnhanvien = Convert.ToInt32(item["ID_NhanVien"].ToString());
                    taiKhoan.Uesrname = item["TenTK"].ToString();
                    taiKhoan.Pass = item["MK"].ToString();
                    taiKhoan.Chuvu = item["ChucVu"].ToString();
                    taiKhoan.Trangthai = Convert.ToInt32(item["TrangThai"].ToString());
                    taiKhoan.Statuslogin = Convert.ToInt32(item["StatusLogIn"].ToString());
                }
            }
            return taiKhoan;
        }


        [Obsolete]
        public void updateStatusLogin(int id)
        {
            connectionData.Instance.excuteNonQueryStoreProcedure("EXEC ChangeStatusLogIn @id", new object[] { id });
        }


        [Obsolete]
        public void updateTaiKhoan(object[] parameter)
        {
            string query = "EXEC UpdateTaiKhoan @id , @tentk , @mk , @chucVu , @trangthai";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }



        [Obsolete]
        public DataTable adminGetTableLoginStatus()
        {
            DataTable dt = new DataTable();
            string query = "EXEC sumAccountCurrent";
            dt = connectionData.Instance.excuteQuery(query, new object[] { });
            return dt;
        }


        [Obsolete]
        public void userChangePassWord(object[] parameter)
        {
            string query = "EXEC userChangePassWord @id , @Pass";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }
    }
}
