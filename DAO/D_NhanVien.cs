using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class D_NhanVien
    {
        private static D_NhanVien instance;

        public static D_NhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_NhanVien();
                }
                return instance;
            }
        }
        [Obsolete]
        public List<NhanVien> getAllNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string query = "EXEC SelectAllNhanVienByTrangThai 1";
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    int id = Convert.ToInt32(item["ID_NhanVien"].ToString());
                    string name = item["HoTen"].ToString();
                    string chuVu = item["ChucVu"].ToString();
                    string goiTinh = item["GoiTinh"].ToString();
                    DateTime ngaySinh = DateTime.Parse(item["NgaySinh"].ToString());
                    DateTime ngayVaoLam = DateTime.Parse(item["NgayVaolam"].ToString());
                    string sdt = item["SDT"].ToString();
                    string diaChi = item["DiaChi"].ToString();
                    string tenNganHang = item["TenNganHang"].ToString();
                    string soTKNganHang = item["SoTKNganHang"].ToString();
                    Decimal LuongCB = Decimal.Parse(item["LuongCoBan"].ToString(), System.Globalization.NumberStyles.Currency);
                    Decimal LuongPC = Decimal.Parse(item["LuongPhuCap"].ToString(), System.Globalization.NumberStyles.Currency);
                    Decimal LuongTong = Decimal.Parse(item["TongLuong"].ToString(), System.Globalization.NumberStyles.Currency);
                    string email = item["email"].ToString();
                    byte[] hinh = (byte[])item["Hinh"];
                    int trangThai = int.Parse(item["TrangThai"].ToString());

                    NhanVien nhanVien = new NhanVien(id,name,chuVu,ngaySinh,ngayVaoLam,diaChi,sdt,tenNganHang,soTKNganHang,goiTinh,LuongCB,LuongPC,LuongTong,email,hinh,trangThai);
                    nhanViens.Add(nhanVien);
                }
                return nhanViens;
            }
        }

        [Obsolete]
        public void adminAddNhanVien(object[] parameter)
        {
            string query = "EXEC InsertNhanVien @hoten , @chucvu , @GoiTinh , @NgaySinh , @NgayVaolam  , @DiaChi , @SDT , @TenNganHang , @SoTKNganHang , @LuongCoBan , @email , @hinh";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }
    }
}
