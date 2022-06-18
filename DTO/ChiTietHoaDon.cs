using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        private int _idhd;
        private int _idsp;
        private Decimal _dongia;
        private int _sl;
        private int _chietkhau;
        private int _trangthai;

        public ChiTietHoaDon(int idhd, int idsp, decimal dongia, int sl, int chietkhau, int trangthai)
        {
            _idhd = idhd;
            _idsp = idsp;
            _dongia = dongia;
            _sl = sl;
            _chietkhau = chietkhau;
            _trangthai = trangthai;
        }

        public ChiTietHoaDon()
        {

        }


        public int Idhd { get => _idhd; set => _idhd = value; }
        public int Idsp { get => _idsp; set => _idsp = value; }
        public decimal Dongia { get => _dongia; set => _dongia = value; }
        public int Sl { get => _sl; set => _sl = value; }
        public int Chietkhau { get => _chietkhau; set => _chietkhau = value; }
        public int Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}
