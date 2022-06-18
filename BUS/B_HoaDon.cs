using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class B_HoaDon
    {
        private static B_HoaDon instance;

        public static B_HoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_HoaDon();
                }
                return instance;
            }
        }
        [Obsolete]
        public int cashierGetHoaDonID()
        {
            int cashierID = D_HoaDon.Instance.getOneHoaDon().Idhd;

            return cashierID;
        }

        [Obsolete]
        public bool cashierAddHoaDon(object[] parameter)
        {
            try
            {
                D_HoaDon.Instance.cashierAddHoaDon(parameter);
            }
            catch (Exception)
            {
                return false;

            }
            return true;
        }

        [Obsolete]
        public DataTable adminGetTableOneMonth(DateTime date)
        {
            int month = date.Month;
            DataTable dt = new DataTable();
            dt = D_HoaDon.Instance.addminGetDoanhThu(month);
            return dt;
        }
        [Obsolete]
        public DataTable adminGetTableSumOrderOneMonth(DateTime date)
        {
            int month = date.Month;
            DataTable dt = new DataTable();
            dt = D_HoaDon.Instance.addminGetSumOrderOneMonth(month);
            return dt;
        }
        [Obsolete]
        public DataTable LoadDataSumIncomeEveryDayOfMonth(DateTime date)
        {
            int month = date.Month;
            int year = date.Year;
            //Gọi function trả về Data
            DataTable dt = new DataTable();
            dt = D_HoaDon.Instance.LoadDataSumIncomeEveryDayOfMonth(month, year);
            return dt;
        }


        [Obsolete]
        public void GetAllHoaDonNoDeleted(ref DataGridView data)
        {
            List<HoaDon> hoaDons = D_HoaDon.Instance.GetAllHoaDonNoDeleted();
            data.DataSource = hoaDons;
        }



        [Obsolete]
        public bool AdminDeletedHoaDon(int id)
        {
            try
            {
                D_HoaDon.Instance.AdminDeletedHoaDon(id);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        [Obsolete]
        public void SearchHoaDonByThoiGianStarEnd(DateTime Star, DateTime End, ref DataGridView data)
        {
            List<HoaDon> hoaDons = D_HoaDon.Instance.SearchHoaDonByThoiGianStarEnd(Star, End);
            data.DataSource = hoaDons;
        }
    }
}
