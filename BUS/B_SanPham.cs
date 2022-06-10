using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        //public List<SanPham> SanPhamList(List<int> ids)
        //{
        //    List<SanPham> list = new List<SanPham>();
        //    for (int i = 0; i < ids.Count; i++)
        //    {
        //        List<SanPham> temp = new List<SanPham>();
        //        foreach (SanPham item in temp)
        //        {
        //            list.Add(item);
        //        }
        //    }
        //    return list;
        //}




    }
}
