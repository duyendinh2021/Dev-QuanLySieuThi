using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class D_HoaDon
    {
        private static D_HoaDon instance;

        public static D_HoaDon Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_HoaDon();
                }
                return instance;
            }
        }
    }
}
