using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class B_LoaiSanPham
    {
        private static B_LoaiSanPham instance;

        public static B_LoaiSanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_LoaiSanPham();
                }
                return instance;
            }
        }
    }
}
