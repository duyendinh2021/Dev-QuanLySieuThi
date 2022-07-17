using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;

namespace BUS
{
    public class B_ChiTietHoaDon
    {
        private static B_ChiTietHoaDon instance;

        public static B_ChiTietHoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_ChiTietHoaDon();
                }
                return instance;
            }
        }
        [Obsolete]
        public bool cashierAddCTHoaDon(object[] parameter)
        {
            try
            {
                D_ChiTietHoaDon.Instance.cashierAddCTHoaDon(parameter);
            }
            catch (Exception)
            {
                return false;

            }
            return true;
        }


        [Obsolete]
        public void GetChiTietHoaDonByID(int id,ref DataGridView data)
        {
            List<ChiTietHoaDon> chiTietHoaDons = D_ChiTietHoaDon.Instance.GetChiTietHoaDonByID(id);
            data.DataSource = chiTietHoaDons;
        }


        [Obsolete]
        public bool UpdateCTHoaDon(object[] parameter) {
            try
            {
                D_ChiTietHoaDon.Instance.UpdateCTHoaDon(parameter);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        [Obsolete]
        public void TraHang(object[] parameter) {

            try
            {
                D_ChiTietHoaDon.Instance.TraHang(parameter);
            }
            catch (Exception ex)
            {
                throw ex;         
            }
        }
    }
}
