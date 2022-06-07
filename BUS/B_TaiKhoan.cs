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
        public bool UserLogIn(string accUesrLogIn, string passUesrLogIn,ref string message)
        {
            bool result = false;
            TaiKhoan taiKhoan = DAO.D_TaiKhoan.Instance.userLogIn(accUesrLogIn, passUesrLogIn);
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
                updateStatusLogin(id);
            }
            return result;
        }

        [Obsolete]
        public void updateStatusLogin(int id)
        {
            DAO.D_TaiKhoan.Instance.updateStatusLogin(id);
        }

    }
}
