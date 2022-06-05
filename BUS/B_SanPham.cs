using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class B_SanPham
    {
        private static B_SanPham instance;

        public static B_SanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_SanPham();
                }
                return instance;
            }
        }
    }
}
