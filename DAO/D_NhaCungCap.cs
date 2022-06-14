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
    public class D_NhaCungCap
    {
        private static D_NhaCungCap instance;

        public static D_NhaCungCap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_NhaCungCap();
                }
                return instance;
            }
        }

        [Obsolete]
        public List<NhaCungCap> loadComboBoxNhaCungCap()
        {
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();
            string query = "EXEC SelectAllNhaCungcapDangHoatDong";

            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    NhaCungCap nhaCungCap = new NhaCungCap();
                    nhaCungCap.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    nhaCungCap.Tencongty = item["TenCongTy"].ToString();
                    nhaCungCap.Diachi = item["DiaChi"].ToString();
                    nhaCungCap.Sdt = item["SDT"].ToString();
                    nhaCungCap.Sotaikhoan = item["SoTKNganHang"].ToString();
                    nhaCungCap.Tennganhang = item["TenNganHang"].ToString();
                    nhaCungCap.Trangthai = int.Parse(item["TrangThai"].ToString());
                    nhaCungCaps.Add(nhaCungCap);
                }
            }

            return nhaCungCaps;
        }



        [Obsolete]
        public List<NhaCungCap> loadNhaCungCapByID(int id)
        {
            string query = "EXEC SelectNhaCungCapByID @id";
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();

            using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { id }))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    NhaCungCap nhaCungCap = new NhaCungCap();
                    nhaCungCap.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    nhaCungCap.Tencongty = item["TenCongTy"].ToString();
                    nhaCungCap.Diachi = item["DiaChi"].ToString();
                    nhaCungCap.Sdt = item["SDT"].ToString();
                    nhaCungCap.Sotaikhoan = item["SoTKNganHang"].ToString();
                    nhaCungCap.Tennganhang = item["TenNganHang"].ToString();
                    nhaCungCap.Trangthai = int.Parse(item["TrangThai"].ToString());
                    nhaCungCaps.Add(nhaCungCap);
                }

            }
            return nhaCungCaps;
        }



        [Obsolete]
        public List<NhaCungCap> GetAllNhaCungCapHoatDong()
        {
            string query = "EXEC SelectAllNhaCungcapDangHoatDong";
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();

            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    NhaCungCap nhaCungCap = new NhaCungCap();
                    nhaCungCap.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    nhaCungCap.Tencongty = item["TenCongTy"].ToString();
                    nhaCungCap.Diachi = item["DiaChi"].ToString();
                    nhaCungCap.Sdt = item["SDT"].ToString();
                    nhaCungCap.Sotaikhoan = item["SoTKNganHang"].ToString();
                    nhaCungCap.Tennganhang = item["TenNganHang"].ToString();
                    nhaCungCap.Trangthai = int.Parse(item["TrangThai"].ToString());
                    nhaCungCaps.Add(nhaCungCap);
                }

            }
            return nhaCungCaps;
        }



        [Obsolete]
        public void StokerDeleteNhanCungCap(int id)
        {
            string query = "EXEC DeleteNhaCungCap @id_ncc";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, new object[] { id });
        }




        [Obsolete]
        // Stoker add thêm nhà cung cấp mới
        public void stokerAddNhaCungCap(object[] parameter)
        {
            string query = "EXEC InsertNhaCungCap @tencongty , @diachi , @sdt , @soTKnganHang , @TenNganHang";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }


        [Obsolete]
        public NhaCungCap GetNhaCungCapByID(int id)
        {
            string query = "EXEC SelectNhaCungCapByID @id_ncc";
            NhaCungCap nhaCungCap = new NhaCungCap();
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query,new object[] {id}))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    nhaCungCap.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    nhaCungCap.Tencongty = item["TenCongTy"].ToString();
                    nhaCungCap.Diachi = item["DiaChi"].ToString();
                    nhaCungCap.Sdt = item["SDT"].ToString();
                    nhaCungCap.Sotaikhoan = item["SoTKNganHang"].ToString();
                    nhaCungCap.Tennganhang = item["TenNganHang"].ToString();
                    nhaCungCap.Trangthai = int.Parse(item["TrangThai"].ToString());
                }
            }
            return nhaCungCap;
        }


        [Obsolete]
        public void StokerUpdateNhaCungCap(object[] parameter)
        {
            string query = "EXEC UpdateNhaCungCap @id_ncc , @tencongty , @diachi , @sdt , @soTKnganHang , @TenNganHang , @trangthai";
            connectionData.Instance.excuteNonQueryStoreProcedure(query,parameter);
        }


        [Obsolete]
        public List<NhaCungCap> GetNhaCungCapByTrangThai(int trangthai)
        {
            string query = "EXEC SelectNhanCungCapByTrangThai @trang_thai";
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();

            using (DataTable dataTable = connectionData.Instance.excuteQuery(query,new object[] {trangthai}))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    NhaCungCap nhaCungCap = new NhaCungCap();
                    nhaCungCap.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    nhaCungCap.Tencongty = item["TenCongTy"].ToString();
                    nhaCungCap.Diachi = item["DiaChi"].ToString();
                    nhaCungCap.Sdt = item["SDT"].ToString();
                    nhaCungCap.Sotaikhoan = item["SoTKNganHang"].ToString();
                    nhaCungCap.Tennganhang = item["TenNganHang"].ToString();
                    nhaCungCap.Trangthai = int.Parse(item["TrangThai"].ToString());
                    nhaCungCaps.Add(nhaCungCap);
                }

            }
            return nhaCungCaps;
        }



        [Obsolete]
        public List<NhaCungCap> SearchNhaCungCapMutiColumnTheoTrangThai(string Search,int trangthai)
        {
            string query = "EXEC SearchNhaCungCapMultiColunmTheoTrangThai @value , @trang_thai";
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();

            using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { Search,trangthai }))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    NhaCungCap nhaCungCap = new NhaCungCap();
                    nhaCungCap.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    nhaCungCap.Tencongty = item["TenCongTy"].ToString();
                    nhaCungCap.Diachi = item["DiaChi"].ToString();
                    nhaCungCap.Sdt = item["SDT"].ToString();
                    nhaCungCap.Sotaikhoan = item["SoTKNganHang"].ToString();
                    nhaCungCap.Tennganhang = item["TenNganHang"].ToString();
                    nhaCungCap.Trangthai = int.Parse(item["TrangThai"].ToString());
                    nhaCungCaps.Add(nhaCungCap);
                }

            }
            return nhaCungCaps;
        }
    }
}
