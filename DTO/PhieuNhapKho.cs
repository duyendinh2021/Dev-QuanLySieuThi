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
        private DateTime _ngaylap;
        private Decimal _tongtien;
        private int _trangthai;
        private int _idNhaCungCap;
        private int _trangthainhaphang;
        private string _ghichu;



        public PhieuNhapKho()
        {

        }

        public PhieuNhapKho(int idphieunhapkho, int idnhanvien, DateTime ngaylap, decimal tongtien, int trangthai, int idNhaCungCap, int trangthainhaphang, string ghichu)
        {
            _idphieunhapkho=idphieunhapkho;
            _idnhanvien=idnhanvien;
            _ngaylap=ngaylap;
            _tongtien=tongtien;
            _trangthai=trangthai;
            _idNhaCungCap=idNhaCungCap;
            _trangthainhaphang=trangthainhaphang;
            _ghichu=ghichu;
        }

        public int Idphieunhapkho { get => _idphieunhapkho; set => _idphieunhapkho = value; }
        public int Idnhanvien { get => _idnhanvien; set => _idnhanvien = value; }
        public DateTime Ngaylap { get => _ngaylap; set => _ngaylap = value; }
        public decimal Tongtien { get => _tongtien; set => _tongtien = value; }
        public int Trangthai { get => _trangthai; set => _trangthai = value; }
        public int IdNhaCungCap { get => _idNhaCungCap; set => _idNhaCungCap=value; }
        public int Trangthainhaphang { get => _trangthainhaphang; set => _trangthainhaphang=value; }
        public string Ghichu { get => _ghichu; set => _ghichu=value; }
    }
}
