using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class D_NhanVien
    {
        private static D_NhanVien instance;

        public static D_NhanVien Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_NhanVien();
                }
                return instance;
            }
        }
    }
}
