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
    }
}
