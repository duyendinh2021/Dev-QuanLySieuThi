using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_Tra
    {
        private int id_hoadon;
        private int id_sanpham;
        private int sl_tra;
        private int tinhtrang;
        private string ghichu;

        public HoaDon_Tra()
        {

        }

        public HoaDon_Tra(int id_hoadon, int id_sanpham, int sl_tra, int tinhtrang, string ghichu)
        {
            this.id_hoadon=id_hoadon;
            this.id_sanpham=id_sanpham;
            this.sl_tra=sl_tra;
            this.tinhtrang=tinhtrang;
            this.ghichu=ghichu;
        }

        public int Id_hoadon { get => id_hoadon; set => id_hoadon=value; }
        public int Id_sanpham { get => id_sanpham; set => id_sanpham=value; }
        public int Sl_tra { get => sl_tra; set => sl_tra=value; }
        public int Tinhtrang { get => tinhtrang; set => tinhtrang=value; }
        public string Ghichu { get => ghichu; set => ghichu=value; }
    }
}
