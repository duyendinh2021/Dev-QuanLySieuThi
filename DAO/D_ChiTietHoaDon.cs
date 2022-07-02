using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

using DTO;

namespace DAO
{
    public class D_ChiTietHoaDon
    {
        private static D_ChiTietHoaDon instance;

        public static D_ChiTietHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_ChiTietHoaDon();
                }
                return instance;
            }
        }



        [Obsolete]
        public void cashierAddCTHoaDon(object[] parameter)
        {
            string query = "EXEC InsertChiTietHoaDon @id_HD , @id_SanPham , @dongia , @soluong , @chietkhau";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }

        [Obsolete]
        public void UpdateCTHoaDon(object[] parameter)
        {
            string query = "EXEC updateChiTietHD @id_HD , @id_sp , @trang_thai , @ghichu";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }

        [Obsolete]
        public List<ChiTietHoaDon> GetChiTietHoaDonByID(int id)
        {
            string query = "EXEC SelectChiTietHoaDonByIDHoaDon @id";
            List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
            using(DataTable data = connectionData.Instance.excuteQuery(query,new object[] { id }))
            {
                foreach (DataRow item in data.Rows)
                {
                    ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon();
                    chiTietHoaDon.Idhd = int.Parse(item["ID_HD"].ToString());
                    chiTietHoaDon.Idsp = int.Parse(item["ID_SanPham"].ToString());
                    chiTietHoaDon.Dongia = decimal.Parse(item["DonGia"].ToString());
                    chiTietHoaDon.Sl = int.Parse(item["SoLuong"].ToString());
                    chiTietHoaDon.Chietkhau = int.Parse(item["ChietKhau"].ToString());
                    chiTietHoaDon.Trangthai = int.Parse(item["TrangThai"].ToString());
                    chiTietHoaDon.Ghichu = item["GhiChu"].ToString();
                    chiTietHoaDons.Add(chiTietHoaDon);
                }
            }
            return chiTietHoaDons;
        }
    }
}
