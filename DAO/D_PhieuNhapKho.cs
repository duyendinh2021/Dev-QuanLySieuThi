using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
