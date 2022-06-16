using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class B_ChiTietPhieuNhapKho
    {
        private static B_ChiTietPhieuNhapKho instance;

        public static B_ChiTietPhieuNhapKho Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_ChiTietPhieuNhapKho();
                }
                return instance;
            }
        }




        [Obsolete]
        public void stokerCreateDetailsReceipt(object[] parameter)
        {
            D_ChiTietPhieuNhapKho.Instance.stokerCreateDetailsReceipt(parameter);
        }


        [Obsolete]
        public void GetChiTietPhieuNhapKhoByIDPhieuNhap(int id,ref DataGridView data)
        {
            List<ChiTietPhieuNhapKho> chiTietPhieuNhapKhos = D_ChiTietPhieuNhapKho.Instance.GetChiTietPhieuNhapKhoByIDPhieuNhap(id);
            data.DataSource = chiTietPhieuNhapKhos;
        }
    }
}
