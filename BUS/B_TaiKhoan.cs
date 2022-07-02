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
        public string pass;

        [Obsolete]
        public bool UserLogIn(string accUesrLogIn, string passUesrLogIn,ref string message)
        {
            bool result = false;
            TaiKhoan taiKhoan = D_TaiKhoan.Instance.GetOneAccout(accUesrLogIn, passUesrLogIn);
            result = taiKhoan.Idnhanvien != 0 ? true : false;
            if (!result)
            {
                message = "tài khoản hoạt mật khẩu sai, vui lòng nhập lại";
            }
            else
            {
                if (taiKhoan.Idnhanvien != 0 && taiKhoan.Trangthai == 0)
                {
                    message = "Tài khoản của bản bị vô hiệu hóa, vui lòng liên hệ quản trị viên dể biết thêm chi tiết";
                    result = false;
                }
                else if (taiKhoan.Idnhanvien != 0 && taiKhoan.Trangthai == 1 && taiKhoan.Statuslogin == 1)
                {
                    message = "Tài Khoản hiện dang đăng nhập trong hệ thống, vui long đăng xuất dể tiếp tục";
                    result = false;
                }
                quyen = taiKhoan.Chuvu;
                id = taiKhoan.Idnhanvien;
                pass = taiKhoan.Pass;
                //updateStatusLogin(id);
            }
            return result;
        }

        [Obsolete]
        public void updateStatusLogin(int id)
        {
            D_TaiKhoan.Instance.updateStatusLogin(id);
        }




        [Obsolete]
        public bool updateTaikhoan(object[] parameter)
        {
            try
            {
                D_TaiKhoan.Instance.updateTaiKhoan(parameter);
            }
            catch (Exception)
            {

               return false;
            }
            return true;
        }


        [Obsolete]
        public DataTable adminGetTableLoginStatus()
        {
            DataTable dt = new DataTable();
            dt = D_TaiKhoan.Instance.adminGetTableLoginStatus();
            return dt;
        }


        [Obsolete]
        public bool CheckAccoutUser(string Acc, string Pass)
        {
            bool result = false;
            TaiKhoan taiKhoan = D_TaiKhoan.Instance.GetOneAccout(Acc, Pass);
            result = taiKhoan.Idnhanvien != 0 ? true : false;
            return result;
        }

        [Obsolete]
        public bool userChangePassWord(object[] parameter)
        {
            try
            {
                D_TaiKhoan.Instance.userChangePassWord(parameter);
            }
            catch (Exception)
            {
                return false;             
            }
            return true;
        }


        [Obsolete]
        public string GetNameAccoutById(int id)
        {
            TaiKhoan taiKhoan = D_TaiKhoan.Instance.GetOneAccoutById(id);
            return taiKhoan.Uesrname;
        }
    }
}
