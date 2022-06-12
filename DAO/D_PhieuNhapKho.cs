using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class D_PhieuNhapKho
    {
        private static D_PhieuNhapKho instance;

        public static D_PhieuNhapKho Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_PhieuNhapKho();

                }
                return instance;
            }
        }


        [Obsolete]
        public void stokerCreatePhieuNhapKho(object[] parameter)
        {
            string query = "EXEC InsertPhieuNhapKho @id_nv , @ngaylap , @tongTien";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }



        [Obsolete]
        public int stokerGetNewReceipt()
        {
            string query = "EXEC stokerGetNewReceipt";
            int id = 0;
            using(DataTable data = connectionData.Instance.excuteQuery(query))
            {
                foreach (DataRow item in data.Rows)
                {
                    id = int.Parse(item["id"].ToString());
                }
            }
            return id;
        }
    }
}
