using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
