using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
