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
    public class D_SanPham
    {
        private static D_SanPham instance;

        public static D_SanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_SanPham();
                }
                return instance;
            }
        }

        [Obsolete]
        public List<SanPham> selectAllSanPhamDanghoatDong()
        {
            List<SanPham> sanPhams = new List<SanPham>();
            string query = "EXEC SelectAllSanPhamDangHoatDong";
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    SanPham sanPham = new SanPham();
                    sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                    sanPham.Tensanpham = item["TenSanPham"].ToString();
                    sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                    sanPham.Dvt = item["DVT"].ToString();
                    sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                    sanPham.Hinh = (Byte[])item["Hinh"];
                    sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    sanPhams.Add(sanPham);
                }
            }

            return sanPhams;
        }



        [Obsolete]
        public List<SanPham> loadComboBoxDVT()
        {
            List<SanPham> sanPhams = new List<SanPham>();
            string query = "EXEC LoadComboBoxDVT";
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    SanPham sanPham = new SanPham();
                    //sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                    //sanPham.Tensanpham = item["TenSanPham"].ToString();
                    //sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    //sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    //sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                    sanPham.Dvt = item["DVT"].ToString();
                    //sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                    //sanPham.Hinh = (Byte[])item["Hinh"];
                    //sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    sanPhams.Add(sanPham);
                }
            }
            //var list2 = sanPhams
            return sanPhams;
        }


        [Obsolete]
        public List<SanPham> loadSanPhamByLoaiSP(int id)
        {
            List<SanPham> sanPhams = new List<SanPham>();
            string query;
            if (id == 0)
            {
                query = "EXEC SearchSanPhamByLoaiSP";
                using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
                {
                    foreach (DataRow item in dataTable.Rows)
                    {
                        SanPham sanPham = new SanPham();
                        sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                        sanPham.Tensanpham = item["TenSanPham"].ToString();
                        sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                        sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                        sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                        sanPham.Dvt = item["DVT"].ToString();
                        sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                        sanPham.Hinh = (Byte[])item["Hinh"];
                        sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                        sanPhams.Add(sanPham);
                    }
                }
            }
            else
            {
                query = "EXEC SearchSanPhamByLoaiSP @id_loaiSP";

                using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { id }))
                {
                    foreach (DataRow item in dataTable.Rows)
                    {
                        SanPham sanPham = new SanPham();
                        sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                        sanPham.Tensanpham = item["TenSanPham"].ToString();
                        sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                        sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                        sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                        sanPham.Dvt = item["DVT"].ToString();
                        sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                        sanPham.Hinh = (Byte[])item["Hinh"];
                        sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                        sanPhams.Add(sanPham);
                    }
                }
            }
            return sanPhams;
        }



        [Obsolete]
        public void stokerAddSanPham(object[] parameter)
        {
            string query = "EXEC stokerImportTempProduct @tenSP , @id_ncc , @id_loaiSP , @sl , @dvt , @donGia , @hinh";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }


        [Obsolete]
        public SanPham stokerGetNewProduct()
        {
            string query = "EXEC stokerGetNewProduct";
            SanPham sanPham = new SanPham();

            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                    sanPham.Tensanpham = item["TenSanPham"].ToString();
                    sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                    sanPham.Dvt = item["DVT"].ToString();
                    sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                    sanPham.Hinh = (Byte[])item["Hinh"];
                    sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());

                }
            }
            return sanPham;
        }


        [Obsolete]
        public void UpdateSLSanPham(object[] parameter)
        {
            string query = "EXEC UpdateSLSanPham @id , @sl";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }


        [Obsolete]
        public SanPham LoadSanPhamTheoid(int id)
        {
            string query = "EXEC SearchSanPhamByID @id";
            SanPham sanPham = new SanPham();

            using (DataTable dataTable = connectionData.Instance.excuteQuery(query,new object[] {id}))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                    sanPham.Tensanpham = item["TenSanPham"].ToString();
                    sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                    sanPham.Dvt = item["DVT"].ToString();
                    sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                    sanPham.Hinh = (Byte[])item["Hinh"];
                    sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());

                }
            }
            return sanPham;
        }


        [Obsolete]
        public List<SanPham> getSanPhamByNCC(int id)
        {
            string query = "EXEC SearchSanPhamByNhaCungCap @id_ncc";
            List<SanPham> sanPhams = new List<SanPham>();


            using (DataTable dataTable = connectionData.Instance.excuteQuery(query,new object[] {id}))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    SanPham sanPham = new SanPham();
                    sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                    sanPham.Tensanpham = item["TenSanPham"].ToString();
                    sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                    sanPham.Dvt = item["DVT"].ToString();
                    sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                    sanPham.Hinh = (Byte[])item["Hinh"];
                    sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    sanPhams.Add(sanPham);
                }
            }

            return sanPhams;
        }



        [Obsolete]
        public void stokerUpdateSanPham(object[] parameter)
        {
            string query = "EXEC UpdateSanPham @id_sp , @tenSP , @id_ncc , @id_loaiSP , @dvt , @dongia , @hinh , @trangthai";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }




        [Obsolete]
        public void stokerDeleteSanPham(int id)
        {
            string query = "EXEC DeleteSanPham @id_sp";
            connectionData.Instance.excuteNonQueryStoreProcedure(query,new object[] {id});
        }


        [Obsolete]
        public List<SanPham> SelectSanPhamByLoaiAndNCC(int id_loai, int id_ncc)
        {
            string query = "EXEC SelectSanPhamByLoaiAndNCC @id_loai , @id_ncc";
            List<SanPham> sanPhams = new List<SanPham>();
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { id_loai,id_ncc }))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    SanPham sanPham = new SanPham();
                    sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                    sanPham.Tensanpham = item["TenSanPham"].ToString();
                    sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                    sanPham.Dvt = item["DVT"].ToString();
                    sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                    sanPham.Hinh = (Byte[])item["Hinh"];
                    sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    sanPhams.Add(sanPham);
                }
            }
            return sanPhams;
        }


        [Obsolete]
        public List<SanPham> getSanPhamByLoai(int id)
        {
            string query = "EXEC SearchSanPhamByLoaiSP @id_loaiSP";
            List<SanPham> sanPhams = new List<SanPham>();
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[]{ id }))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    SanPham sanPham = new SanPham();
                    sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                    sanPham.Tensanpham = item["TenSanPham"].ToString();
                    sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                    sanPham.Dvt = item["DVT"].ToString();
                    sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                    sanPham.Hinh = (Byte[])item["Hinh"];
                    sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    sanPhams.Add(sanPham);
                }
            }
            return sanPhams;
        }


        [Obsolete]
        public List<SanPham> getSanPamHetHang()
        {
            string query = "EXEC SelectSanPhamhetHang";
            List<SanPham> sanPhams = new List<SanPham>();
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    SanPham sanPham = new SanPham();
                    sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                    sanPham.Tensanpham = item["TenSanPham"].ToString();
                    sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                    sanPham.Dvt = item["DVT"].ToString();
                    sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                    sanPham.Hinh = (Byte[])item["Hinh"];
                    sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    sanPhams.Add(sanPham);
                }
            }
            return sanPhams;
        }


        [Obsolete]
        public List<SanPham> getSanPamConHang()
        {
            string query = "EXEC SelectSanPhamConHang";
            List<SanPham> sanPhams = new List<SanPham>();
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    SanPham sanPham = new SanPham();
                    sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                    sanPham.Tensanpham = item["TenSanPham"].ToString();
                    sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                    sanPham.Dvt = item["DVT"].ToString();
                    sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                    sanPham.Hinh = (Byte[])item["Hinh"];
                    sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    sanPhams.Add(sanPham);
                }
            }
            return sanPhams;
        }
        [Obsolete]
        public DataTable adminGetProductSole(int month)
        {
            DataTable sole = new DataTable();
            string query = "exec sumProductSoleInMonth @month";
            sole = connectionData.Instance.excuteQuery(query, new object[] { month });
            return sole;
        }
        [Obsolete]
        public DataTable top5ProductSole(int month)
        {
            DataTable sole = new DataTable();
            string query = "exec top5ProductSole @month";
            sole = connectionData.Instance.excuteQuery(query, new object[] { month });
            return sole;
        }
        [Obsolete]
        public DataTable adminGetProductCurrent()
        {
            DataTable dt = new DataTable();
            string query = "exec sumNumberOfProduct";
            dt = connectionData.Instance.excuteQuery(query, new object[] { });
            return dt;
        }
        [Obsolete]
        public DataTable getSanPhamByID(int id)
        {
            DataTable dt = new DataTable();
            string query = "exec getSanPhamByID @id";
            dt = connectionData.Instance.excuteQuery(query, new object[] { id });
            return dt;
        }

        [Obsolete]
        public void updateNumberSanPham(int id, decimal number)
        {
            string query = "exec updateNumberSanPham @id , @number";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, new object[] { id, number });
        }
        [Obsolete]
        public DataTable cashierGetAllProduct(int id = 0)
        {
            DataTable dt = new DataTable();
            if (id == 0)
            {
                string query = "exec cashierGetAllProduct @loai";
                dt = connectionData.Instance.excuteQuery(query, new object[] { 0 });
            }
            else
            {
                string query = "exec cashierGetAllProduct @loai";
                dt = connectionData.Instance.excuteQuery(query, new object[] { id });
            }
            return dt;
        }


        [Obsolete]
        public List<SanPham> GetSanPhamDeleted()
        {
            string query = "EXEC SelectSanPhamDeleted";
            List<SanPham> sanPhams = new List<SanPham>();
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    SanPham sanPham = new SanPham();
                    sanPham.Idsanpham = int.Parse(item["ID_SanPham"].ToString());
                    sanPham.Tensanpham = item["TenSanPham"].ToString();
                    sanPham.Idnhacungcap = int.Parse(item["ID_NhaCungCap"].ToString());
                    sanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    sanPham.Sl = int.Parse(item["SoLuong"].ToString());
                    sanPham.Dvt = item["DVT"].ToString();
                    sanPham.Dongia = decimal.Parse(item["DonGia"].ToString());
                    sanPham.Hinh = (Byte[])item["Hinh"];
                    sanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    sanPhams.Add(sanPham);
                }
            }
            return sanPhams;
        }
    }
}
