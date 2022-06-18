using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class D_HoaDon
    {
        private static D_HoaDon instance;

        public static D_HoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_HoaDon();
                }
                return instance;
            }
        }
        [Obsolete]
        public HoaDon getOneHoaDon()
        {
            HoaDon hoaDon = new HoaDon();
            string query = "select top 1 * from HoaDon order by ID_HoaDon desc";
            using (DataTable dataTable = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in dataTable.Rows)
                {
                    int id_hd = Convert.ToInt32(item["ID_HoaDon"].ToString());
                    int id_nv = Convert.ToInt32(item["ID_NhanVien"].ToString());
                    DateTime ngTao = DateTime.Parse(item["NgayTao"].ToString());
                    Decimal dGia = Decimal.Parse(item["TongGia"].ToString(), System.Globalization.NumberStyles.Currency);
                    int trangThai = int.Parse(item["TrangThai"].ToString());
                    HoaDon hd = new HoaDon(id_hd, id_nv, ngTao, dGia, trangThai);
                    hoaDon = hd;
                }
                return hoaDon;
            }
        }
        [Obsolete]
        public void cashierAddHoaDon(object[] parameter)
        {
            string query = "EXEC InsertHoaDon @id , @sumCost";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }
        [Obsolete]
        public DataTable addminGetDoanhThu(int month)
        {
            DataTable dt = new DataTable();
            string query = "exec incomeInOneMonth @month";
            dt = connectionData.Instance.excuteQuery(query, new object[] { month });
            return dt;
        }
        [Obsolete]
        public DataTable addminGetSumOrderOneMonth(int month)
        {
            DataTable dt = new DataTable();
            string query = "exec sumOrderInMonth @month";
            dt = connectionData.Instance.excuteQuery(query, new object[] { month });
            return dt;
        }
        [Obsolete]
        public DataTable LoadDataSumIncomeEveryDayOfMonth(int month, int year)
        {
            //Gọi function trả về Data
            DataTable dt = new DataTable();
            dt = connectionData.Instance.excuteQuery("EXEC calSumIncomeEveryDayOrMonth @thang , @nam", new object[] { month, year });
            return dt;
        }

        [Obsolete]
        public List<HoaDon> GetAllHoaDonNoDeleted()
        {
            string query = "EXEC SelectAllHoaDonNoDeleted";
            List<HoaDon> hoaDons = new List<HoaDon>();
            using(DataTable data  = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in data.Rows)
                {
                    int id_hd = Convert.ToInt32(item["ID_HoaDon"].ToString());
                    int id_nv = Convert.ToInt32(item["ID_NhanVien"].ToString());
                    DateTime ngTao = DateTime.Parse(item["NgayTao"].ToString());
                    Decimal dGia = Decimal.Parse(item["TongGia"].ToString(), System.Globalization.NumberStyles.Currency);
                    int trangThai = int.Parse(item["TrangThai"].ToString());
                    HoaDon hd = new HoaDon(id_hd, id_nv, ngTao, dGia, trangThai);
                    hoaDons.Add(hd);
                }
            }
            return hoaDons;
        }


        [Obsolete]
        public void AdminDeletedHoaDon(int id)
        {
            string query = "EXEC DeleteHoaDon @id";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, new object[] { id });
        }


        [Obsolete]
        public List<HoaDon> SearchHoaDonByThoiGianStarEnd(DateTime Star, DateTime End)
        {
            string query = "EXEC SelectHoaDonByThoiGianStarAndThoiGianEnd @StartDate , @EndDate";
            List<HoaDon> hoaDons = new List<HoaDon>();
            using (DataTable data = connectionData.Instance.excuteQuery(query,new object[] {Star, End}))
            {
                foreach (DataRow item in data.Rows)
                {
                    int id_hd = Convert.ToInt32(item["ID_HoaDon"].ToString());
                    int id_nv = Convert.ToInt32(item["ID_NhanVien"].ToString());
                    DateTime ngTao = DateTime.Parse(item["NgayTao"].ToString());
                    Decimal dGia = Decimal.Parse(item["TongGia"].ToString(), System.Globalization.NumberStyles.Currency);
                    int trangThai = int.Parse(item["TrangThai"].ToString());
                    HoaDon hd = new HoaDon(id_hd, id_nv, ngTao, dGia, trangThai);
                    hoaDons.Add(hd);
                }
            }
            return hoaDons;
        }
    }
}
