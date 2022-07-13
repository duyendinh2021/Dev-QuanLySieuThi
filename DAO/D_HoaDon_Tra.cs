using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
namespace DAO
{
    public class D_HoaDon_Tra
    {
        private static D_HoaDon_Tra instance;

        public static D_HoaDon_Tra Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_HoaDon_Tra();
                }
                return instance;
            }
        }

        [Obsolete]
        public void InsertHD_Tra(object[] parameter)
        {
            string query = "EXEC Create_HD_Tra @id_HD , @id_sp , @SL_Tra , @TinhTrang , @ghichu";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }
    }
}
