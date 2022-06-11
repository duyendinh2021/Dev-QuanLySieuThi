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
    public class D_LoaiSanPham
    {
        private static D_LoaiSanPham instance;

        public static D_LoaiSanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_LoaiSanPham();
                }
                return instance;
            }
        }



        [Obsolete]
        public List<LoaiSanPham> loadDataSourcecmbLoaiSp()
        {
            List<LoaiSanPham> loaiSanPhams = new List<LoaiSanPham>();
            string query = "EXEC SelectAllLoaiDangHoatDong";
            using(DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    LoaiSanPham loaiSanPham = new LoaiSanPham();
                    loaiSanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    loaiSanPham.Tensanpham = item["TenLoaiSanPham"].ToString();
                    loaiSanPham.Mota = item["MoTa"].ToString();
                    loaiSanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    loaiSanPhams.Add(loaiSanPham);
                }
            }

            return loaiSanPhams;
        }


    }
}
