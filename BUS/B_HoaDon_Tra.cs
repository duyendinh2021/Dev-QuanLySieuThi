using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using DAO;

namespace BUS
{
    public class B_HoaDon_Tra
    {
        private static B_HoaDon_Tra instance;

        public static B_HoaDon_Tra Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new B_HoaDon_Tra();
                }
                return instance;
            }
        }
        [Obsolete]
        public bool IsInsertHD_Tra(object[] parameter)
        {
            try
            {
                D_HoaDon_Tra.Instance.InsertHD_Tra(parameter);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
