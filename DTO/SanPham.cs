using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        private int _idsanpham;
        private string _tensanpham;
        private int _idnhacungcap;
        private int _idloaisanpham;
        private int _sl;
        private string _dvt;
        private Decimal _dongia;
        private byte[] _hinh;
        private int _trangthai;

        public SanPham(int idsanpham, string tensanpham, int idnhacungcap, int idloaisanpham, int sl, string dvt, decimal dongia, byte[] hinh, int trangthai)
        {
            _idsanpham = idsanpham;
            _tensanpham = tensanpham;
            _idnhacungcap = idnhacungcap;
            _idloaisanpham = idloaisanpham;
            _sl = sl;
            _dvt = dvt;
            _dongia = dongia;
            _hinh = hinh;
            _trangthai = trangthai;
        }

        public SanPham()
        {

        }


        public int Idsanpham { get => _idsanpham; set => _idsanpham = value; }
        public string Tensanpham { get => _tensanpham; set => _tensanpham = value; }
        public int Idnhacungcap { get => _idnhacungcap; set => _idnhacungcap = value; }
        public int Idloaisanpham { get => _idloaisanpham; set => _idloaisanpham = value; }
        public int Sl { get => _sl; set => _sl = value; }
        public string Dvt { get => _dvt; set => _dvt = value; }
        public decimal Dongia { get => _dongia; set => _dongia = value; }
        public byte[] Hinh { get => _hinh; set => _hinh = value; }
        public int Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}