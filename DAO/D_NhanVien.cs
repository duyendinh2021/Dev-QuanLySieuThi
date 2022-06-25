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


        // Get tất cả nhân viên trạng thái đang làm việt 
        [Obsolete]
        public List<NhanVien> getAllNhanVienHoatDong()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string query = "EXEC SelectAllNhanVienByTrangThai @trangthai";
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query,new object[] {1}))
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

                    NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                    nhanViens.Add(nhanVien);
                }
                return nhanViens;
            }
        }


        // nhân viên admin thêm nhân viên mới
        [Obsolete]
        public void adminAddNhanVien(object[] parameter)
        {
            string query = "EXEC InsertNhanVien @hoten , @chucvu , @GoiTinh , @NgaySinh , @NgayVaolam  , @DiaChi , @SDT , @TenNganHang , @SoTKNganHang , @LuongCoBan , @email , @hinh";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }


        // nhân viên admin cập nhật thông tin cho nhân viên
        [Obsolete]
        public void adminUpdateNhanVien(object[] parameter)
        {
            String query = "EXEC UpdateNhanVien @id , @hoten , @chucvu , @GoiTinh , @NgaySinh , @NgayVaolam , @DiaChi , @SDT , @TenNganHang , @SoTKNganHang , @LuongCoBan , @email , @hinh";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }


        // nhân viên tiến hành tính hành delete nhân viên
        [Obsolete]
        public void adminDeleteNhanVien(int id)
        {
            string query = "EXEC DeleteNhanVien @id";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, new object[] { id });
        }


        // Get nhân viên theo chúc vụ
        [Obsolete]
        public List<NhanVien> getNhanVienByChucVu(string chucvu)
        {
            string query = "EXEC SelectNhanVienByChucVU @chucvu";
            List<NhanVien> nhanVienAdmin = new List<NhanVien>();


            using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { chucvu }))
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

                    NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                    nhanVienAdmin.Add(nhanVien);
                }
                return nhanVienAdmin;
            }
        }

        // Get nhân viên theo trạng thái
        [Obsolete]
        public List<NhanVien> getNhanVienByTrangThai(int trangThaiquery)
        {
            List<NhanVien> nhanVienAdmin = new List<NhanVien>();
            string query = "EXEC SelectAllNhanVienByTrangThai @trangthai";

            using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { trangThaiquery }))
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

                    NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                    nhanVienAdmin.Add(nhanVien);
                }
                return nhanVienAdmin;
            }
        }


        // Get tất cả các nhân viên trong hệ thống
        [Obsolete]
        public List<NhanVien> getAllNhanVien()
        {
            List<NhanVien> nhanVienAll = new List<NhanVien>();
            string query = "EXEC SelectAllNhanvien";


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

                    NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                    nhanVienAll.Add(nhanVien);
                }
                return nhanVienAll;
            }
        }

        // tìm kiến nhân viên
        [Obsolete]
        public List<NhanVien> searchNhanVien(string search)
        {
            List<NhanVien> nhanVienSearch = new List<NhanVien>();

            string query = "EXEC SearchMultiColumn @value";
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { search }))
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

                    NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                    nhanVienSearch.Add(nhanVien);
                }
                return nhanVienSearch;
            }
        }

        
        [Obsolete]
        public List<NhanVien> getNhanVienByChucVuAndTrangThai(string chucvu,int trangthai)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string query;
            if (trangthai == -1)
            {
                query = "EXEC SelectNhanVienByChucVuAndTrangThai @chucVu";             
                using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { chucvu}))
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

                        NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                        nhanViens.Add(nhanVien);
                    }
                    return nhanViens;
                }
            }
            else
            {
                query = "EXEC SelectNhanVienByChucVuAndTrangThai @chucVu , @trangthai";
                using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { chucvu, trangthai }))
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

                        NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                        nhanViens.Add(nhanVien);
                    }
                    return nhanViens;
                }
            }          
        }




        [Obsolete]
        public List<NhanVien> searchNhanVienByChuVuAndTrangThai(string search,string chucvu,int trangthai)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();

            string query;
            if (trangthai == -1)
            {
                query = "EXEC SearchNhanVienByChucVuAndTrangThai @value , @chucVu";
                using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { search, chucvu }))
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

                        NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                        nhanViens.Add(nhanVien);
                    }
                    
                }
            }
            else
            {
                query = "SearchNhanVienByChucVuAndTrangThai @value , @chucVu , @trangthai";
                using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { search, chucvu , trangthai}))
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

                        NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                        nhanViens.Add(nhanVien);
                    }
                }
            }
            return nhanViens;
        }



        [Obsolete]
        public List<NhanVien> searchNhanVienByTrangThai(string search ,int trangthai)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string query;
            if (trangthai == -1)
            {
                query = "EXEC SearchNhanVienByTrangThaiMultiColumn @value";
                using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { search}))
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

                        NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                        nhanViens.Add(nhanVien);
                    }
                }
            }
            else
            {
                query = "EXEC SearchNhanVienByTrangThaiMultiColumn @value , @trangthai";
                using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { search , trangthai}))
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

                        NhanVien nhanVien = new NhanVien(id, name, chuVu, ngaySinh, ngayVaoLam, diaChi, sdt, tenNganHang, soTKNganHang, goiTinh, LuongCB, LuongPC, LuongTong, email, hinh, trangThai);
                        nhanViens.Add(nhanVien);
                    }
                }
            }
            return nhanViens;
        }






        [Obsolete]
        public TaiKhoan getTaiKhoanByID(int id)
        {
            TaiKhoan TaiKhoan = new TaiKhoan();
            string query = "EXEC SearchTaiKhoanByID @id";
            using(DataTable data = connectionData.Instance.excuteQuery(query,new object[] { id }))
            {
                foreach (DataRow item in data.Rows)
                {
                    TaiKhoan.Idnhanvien = int.Parse(item["ID_NhanVien"].ToString());
                    TaiKhoan.Uesrname = item["TenTK"].ToString();
                    TaiKhoan.Pass = item["MK"].ToString();
                    TaiKhoan.Chuvu = item["ChucVu"].ToString();
                    TaiKhoan.Trangthai = int.Parse(item["TrangThai"].ToString());
                    TaiKhoan.Statuslogin = int.Parse(item["StatusLogIn"].ToString());
                }
            }
            return TaiKhoan;
        }


        [Obsolete]
        public void stokerAddLoaiSanPham(object[] parameter)
        {
            string query = "EXEC InsertLoaiSanPham @ten_loaiSP , @mota , @hinh";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }

        [Obsolete]
        public DataTable LoadDataSumProductEveryDayOfMonth(int month, int year)
        {
            //Gọi function trả về Data
            DataTable dt = new DataTable();
            dt = connectionData.Instance.excuteQuery("EXEC calSumSPEveryDayOrMonth @thang , @nam", new object[] { month, year });
            return dt;
        }

        [Obsolete]
        public DataTable LoadDataSumProductImportEveryDayOfMonth(int month, int year)
        {
            //Gọi function trả về Data
            DataTable dt = new DataTable();
            dt = connectionData.Instance.excuteQuery("EXEC calSumSPImportEveryDayOrMonth @thang , @nam", new object[] { month, year });
            return dt;
        }
    }
}