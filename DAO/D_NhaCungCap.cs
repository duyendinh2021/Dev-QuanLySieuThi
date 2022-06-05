using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class D_NhaCungCap
    {
        private static D_NhaCungCap instance;

        public static D_NhaCungCap Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new D_NhaCungCap();
                }
                return instance;
            }
        }
    }
}
