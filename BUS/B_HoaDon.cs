using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class B_HoaDon
    {
        private static B_HoaDon instance;

        public static B_HoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_HoaDon();
                }
                return instance;
            }
        }
    }
}
