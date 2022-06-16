using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham
    {
        private int _idloaisanpham;
        private string _tensanpham;
        private string _mota;
        private int _trangthai;
        private byte[] _hinh;




        public LoaiSanPham()
        {

        }

        public LoaiSanPham(int idloaisanpham, string tensanpham, string mota, int trangthai, byte[] hinh)
        {
            _idloaisanpham = idloaisanpham;
            _tensanpham = tensanpham;
            _mota = mota;
            _trangthai = trangthai;
            _hinh = hinh;
        }

        public int Idloaisanpham { get => _idloaisanpham; set => _idloaisanpham = value; }
        public string Tensanpham { get => _tensanpham; set => _tensanpham = value; }
        public string Mota { get => _mota; set => _mota = value; }
        public int Trangthai { get => _trangthai; set => _trangthai = value; }
        public byte[] Hinh { get => _hinh; set => _hinh = value; }
    }
}
