using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapKho
    {
        private int _idphieunhapkho;
        private int _idsp;
        private Decimal _dongia;
        private int _sl;
        private int _trangthai;

        public ChiTietPhieuNhapKho(int idphieunhapkho, int idsp, decimal dongia, int sl, int trangthai)
        {
            _idphieunhapkho = idphieunhapkho;
            _idsp = idsp;
            _dongia = dongia;
            _sl = sl;
            _trangthai = trangthai;
        }

        public int Idphieunhapkho { get => _idphieunhapkho; set => _idphieunhapkho = value; }
        public int Idsp { get => _idsp; set => _idsp = value; }
        public decimal Dongia { get => _dongia; set => _dongia = value; }
        public int Sl { get => _sl; set => _sl = value; }
        public int Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}
