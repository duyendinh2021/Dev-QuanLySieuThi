using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class D_SanPham
    {
        private static D_SanPham instance;

        public static D_SanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_SanPham();
                }
                return instance;
            }
        }


        
    }
}
