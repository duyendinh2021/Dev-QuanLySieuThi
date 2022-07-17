using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class D_ChiTietPhieuNhapKho
    {
        private static D_ChiTietPhieuNhapKho instance;

        public static D_ChiTietPhieuNhapKho Instance
        {
            get

            {
                if (instance == null)
                {
                    instance = new D_ChiTietPhieuNhapKho();
                }
                return instance;
            }
        }



        [Obsolete]
        public void stokerCreateDetailsReceipt(object[] parameter)
        {
            string query = "EXEC InsertChiTietPhieuNhapKho @id_phieuNhap , @id_sp , @dongia , @sl";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }



        [Obsolete]
        public List<ChiTietPhieuNhapKho> GetChiTietPhieuNhapKhoByIDPhieuNhap(int id)
        {
            List<ChiTietPhieuNhapKho> chiTietPhieuNhapKhos = new List<ChiTietPhieuNhapKho>();
            string query = "EXEC SelectChiTietPhieuNhapKhoByIDPhieuNhap @id_PhieuNhap";
            using(DataTable data = connectionData.Instance.excuteQuery(query,new object[] { id }))
            {
                foreach (DataRow item in data.Rows)
                {
                    ChiTietPhieuNhapKho chiTietPhieuNhap = new ChiTietPhieuNhapKho();
                    chiTietPhieuNhap.Idphieunhapkho = int.Parse(item["ID_PhieuNhapKho"].ToString());
                    chiTietPhieuNhap.Idsp = int.Parse(item["ID_SanPham"].ToString());                   
                    chiTietPhieuNhap.Dongia = decimal.Parse(item["DonGia"].ToString());
                    chiTietPhieuNhap.Sl = int.Parse(item["SoLuong"].ToString());
                    chiTietPhieuNhap.Trangthai = int.Parse(item["TrangThai"].ToString());
                    chiTietPhieuNhapKhos.Add(chiTietPhieuNhap);
                }
            }
            return chiTietPhieuNhapKhos;
        }
    }
}
