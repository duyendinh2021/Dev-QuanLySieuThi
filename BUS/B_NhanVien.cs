using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_NhanVien
    {
        private static B_NhanVien instance;

        public static B_NhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_NhanVien();
                }
                return instance;
            }
        }
    }
}
