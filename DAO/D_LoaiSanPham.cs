using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class D_LoaiSanPham
    {
        private static D_LoaiSanPham instance;

        public static D_LoaiSanPham Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_LoaiSanPham();
                }
                return instance;
            }
        }
    }
}
