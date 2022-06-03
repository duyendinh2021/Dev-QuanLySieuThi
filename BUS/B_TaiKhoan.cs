using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class B_TaiKhoan
    {
        private static B_TaiKhoan _instance;

        public static B_TaiKhoan Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new B_TaiKhoan();
                }
                return _instance;
            }       
        }
        public string quyen;
        public int id;


        [Obsolete]
        public bool UserLogIn(string accUesrLogIn, string passUesrLogIn)
        {
            TaiKhoan taiKhoan = DAO.D_TaiKhoan.Instance.userLogIn(accUesrLogIn, passUesrLogIn);
            quyen = taiKhoan.Chuvu;
            id = taiKhoan.Idnhanvien;
            if (taiKhoan.Trangthai == 1)
            {
                if (taiKhoan.Statuslogin == 1)
                {
                    return false;
                }
            }
            updateStatusLogin(id);
            return true;
        }

        [Obsolete]
        public void updateStatusLogin(int id)
        {
            DAO.D_TaiKhoan.Instance.updateStatusLogin(id);
        }



        // Test hop nhat 2 branch
    }
}
