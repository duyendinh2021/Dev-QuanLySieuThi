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
    }
}
