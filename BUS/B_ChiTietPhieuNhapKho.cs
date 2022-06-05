using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
