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



        [Obsolete]
        public List<LoaiSanPham> loadloaiSanPhamByID(int id)
        {
            string query = "EXEC SelectLoaiSanPhamByID @id";
            List<LoaiSanPham> loaiSanPhams = new List<LoaiSanPham>();

            using(DataTable dataTable = connectionData.Instance.excuteQuery(query,new object[] { id }))
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

        [Obsolete]
        public LoaiSanPham GetOneProductTypeByID(int id)
        {
            string query = "EXEC SelectLoaiSanPhamByID @id";
            LoaiSanPham loaiSanPham = new LoaiSanPham();
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { id }))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    loaiSanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    loaiSanPham.Tensanpham = item["TenLoaiSanPham"].ToString();
                    loaiSanPham.Mota = item["MoTa"].ToString();
                    loaiSanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    loaiSanPham.Hinh = (byte[])item["Hinh"];
                }
            }
            return loaiSanPham;
        }
        [Obsolete]
        public DataTable cashierLoadLoaiSP()
        {
            string query = "exec cashierLoadLoaiSP";
            DataTable dt = new DataTable();
            dt = connectionData.Instance.excuteQuery(query, new object[] { });
            return dt;
        }


        [Obsolete]
        public List<LoaiSanPham> CashierGetProductTypes()
        {
            string query = "exec SelectAllLoaiDangHoatDong";
            List<LoaiSanPham> loaiSanPhams = new List<LoaiSanPham>();
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    LoaiSanPham loaiSanPham = new LoaiSanPham();

                    loaiSanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    loaiSanPham.Tensanpham = item["TenLoaiSanPham"].ToString();
                    loaiSanPham.Mota = item["MoTa"].ToString();
                    loaiSanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    loaiSanPham.Hinh = (byte[])item["Hinh"];
                    loaiSanPhams.Add(loaiSanPham);
                }
            }
            return loaiSanPhams;

        }




        [Obsolete]
        public List<LoaiSanPham> GetAllProductTypesNoDeleted()
        {
            string query = "exec SelectAllLoaiDangHoatDong";
            List<LoaiSanPham> loaiSanPhams = new List<LoaiSanPham>();
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    LoaiSanPham loaiSanPham = new LoaiSanPham();

                    loaiSanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    loaiSanPham.Tensanpham = item["TenLoaiSanPham"].ToString();
                    loaiSanPham.Mota = item["MoTa"].ToString();
                    loaiSanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    loaiSanPham.Hinh = (byte[])item["Hinh"];
                    loaiSanPhams.Add(loaiSanPham);
                }
            }
            return loaiSanPhams;

        }


        [Obsolete]
        public List<LoaiSanPham> SearchProductTypes(int trangthai, string search)
        {
            string query = "EXEC SearchProductType @trang_thai , @value";
            List<LoaiSanPham> loaiSanPhams = new List<LoaiSanPham>();
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query,new object[] {trangthai,search}))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    LoaiSanPham loaiSanPham = new LoaiSanPham();

                    loaiSanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    loaiSanPham.Tensanpham = item["TenLoaiSanPham"].ToString();
                    loaiSanPham.Mota = item["MoTa"].ToString();
                    loaiSanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    loaiSanPham.Hinh = (byte[])item["Hinh"];
                    loaiSanPhams.Add(loaiSanPham);
                }
            }
            return loaiSanPhams;
        }

        [Obsolete]
        public List<LoaiSanPham> GetProductTypesByTrangthai(int trangthai)
        {
            List<LoaiSanPham> loaiSanPhams = new List<LoaiSanPham>();
            string query = "EXEC SelectProductTypesByTrangthai @trang_thai";

            using (DataTable dataTable = connectionData.Instance.excuteQuery(query, new object[] { trangthai }))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    LoaiSanPham loaiSanPham = new LoaiSanPham();

                    loaiSanPham.Idloaisanpham = int.Parse(item["ID_LoaiSanPham"].ToString());
                    loaiSanPham.Tensanpham = item["TenLoaiSanPham"].ToString();
                    loaiSanPham.Mota = item["MoTa"].ToString();
                    loaiSanPham.Trangthai = int.Parse(item["TrangThai"].ToString());
                    loaiSanPham.Hinh = (byte[])item["Hinh"];
                    loaiSanPhams.Add(loaiSanPham);
                }
            }

            return loaiSanPhams;
        }

        [Obsolete]
        public void UpdateProductType(object[] parameter)
        {
            string query = "EXEC UpdateLoaiSP @id , @ten_loaiSP , @mota , @hinh";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }
    }
}
