using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class B_PhieuNhapKho
    {
        private static B_PhieuNhapKho instance;

        public static B_PhieuNhapKho Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_PhieuNhapKho();
                }
                return instance;
            }
        }
    }
}
