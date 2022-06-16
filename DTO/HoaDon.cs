using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private int _idhd;
        private int _idnhanvien;
        private DateTime _ngaytao;
        private Decimal _tonggia;
        private int _trangthai;

        public HoaDon()
        {
        }

        public HoaDon(int idhd, int idnhanvien, DateTime ngaytao, decimal tonggia, int trangthai)
        {
            _idhd = idhd;
            _idnhanvien = idnhanvien;
            _ngaytao = ngaytao;
            _tonggia = tonggia;
            _trangthai = trangthai;
        }

        public int Idhd { get => _idhd; set => _idhd = value; }
        public int Idnhanvien { get => _idnhanvien; set => _idnhanvien = value; }
        public DateTime Ngaytao { get => _ngaytao; set => _ngaytao = value; }
        public decimal Tonggia { get => _tonggia; set => _tonggia = value; }
        public int Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}
