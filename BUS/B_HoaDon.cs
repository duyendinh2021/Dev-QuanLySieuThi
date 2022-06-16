using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
