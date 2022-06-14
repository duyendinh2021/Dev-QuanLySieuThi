using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class D_ChiTietPhieuNhapKho
    {
        private static D_ChiTietPhieuNhapKho instance;

        public static D_ChiTietPhieuNhapKho Instance
        {
            get

            {
                if (instance == null)
                {
                    instance = new D_ChiTietPhieuNhapKho();
                }
                return instance;
            }
        }



        [Obsolete]
        public void stokerCreateDetailsReceipt(object[] parameter)
        {
            string query = "EXEC InsertChiTietPhieuNhapKho @id_phieuNhap , @id_sp , @id_ncc , @dongia , @sl";
            connectionData.Instance.excuteNonQueryStoreProcedure(query, parameter);
        }
    }
}
