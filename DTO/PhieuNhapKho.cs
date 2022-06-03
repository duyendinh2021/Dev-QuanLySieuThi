using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapKho
    {
        private int _idphieunhapkho;
        private int _idnhanvien;
        private int _idnhacungcap;
        private DateTime _ngaylap;
        private Decimal _tongtien;
        private int _trangthai;

        public PhieuNhapKho(int idphieunhapkho, int idnhanvien, int idnhacungcap, DateTime ngaylap, decimal tongtien, int trangthai)
        {
            _idphieunhapkho = idphieunhapkho;
            _idnhanvien = idnhanvien;
            _idnhacungcap = idnhacungcap;
            _ngaylap = ngaylap;
            _tongtien = tongtien;
            _trangthai = trangthai;
        }

        public int Idphieunhapkho { get => _idphieunhapkho; set => _idphieunhapkho = value; }
        public int Idnhanvien { get => _idnhanvien; set => _idnhanvien = value; }
        public int Idnhacungcap { get => _idnhacungcap; set => _idnhacungcap = value; }
        public DateTime Ngaylap { get => _ngaylap; set => _ngaylap = value; }
        public decimal Tongtien { get => _tongtien; set => _tongtien = value; }
        public int Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}
