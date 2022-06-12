﻿using System;
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
    }
}
