using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class B_NhaCungCap
    {
        private static B_NhaCungCap instance;

        public static B_NhaCungCap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_NhaCungCap();
                }
                return instance;
            }
        }
    }
}
