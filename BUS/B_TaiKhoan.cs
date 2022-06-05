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
    public class B_TaiKhoan
    {
        private static B_TaiKhoan instance;

        public static B_TaiKhoan Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_TaiKhoan();
                }
                return instance;
            }       
        }
        public string quyen;
        public int id;


        [Obsolete]
        public bool UserLogIn(string accUesrLogIn, string passUesrLogIn)
        {

            bool result = false;

            TaiKhoan taiKhoan = DAO.D_TaiKhoan.Instance.userLogIn(accUesrLogIn, passUesrLogIn);
            result = taiKhoan != null ? true : false;

            

            if (result)
            {
                if (taiKhoan.Trangthai == 0 || taiKhoan.Statuslogin  == 1)
                {
                    return false;
                }
                quyen = taiKhoan.Chuvu;
                id = taiKhoan.Idnhanvien;
                updateStatusLogin(id);
            }
            return  result;

        }

        [Obsolete]
        public void updateStatusLogin(int id)
        {
            DAO.D_TaiKhoan.Instance.updateStatusLogin(id);
        }

    }
}
