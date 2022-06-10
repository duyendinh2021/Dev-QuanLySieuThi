using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private int _idnhacungcap;
        private string _tencongty;
        private string _diachi;
        private string _sdt;
        private string _tennganhang;
        private string _sotaikhoan;
        private int _trangthai;

        public NhaCungCap(int idnhacungcap, string tencongty, string diachi, string sdt, string tennganhang, string sotaikhoan, int trangthai)
        {
            _idnhacungcap = idnhacungcap;
            _tencongty = tencongty;
            _diachi = diachi;
            _sdt = sdt;
            _tennganhang = tennganhang;
            _sotaikhoan = sotaikhoan;
            _trangthai = trangthai;
        }

        public NhaCungCap()
        {

        }

        public int Idnhacungcap { get => _idnhacungcap; set => _idnhacungcap = value; }
        public string Tencongty { get => _tencongty; set => _tencongty = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string Tennganhang { get => _tennganhang; set => _tennganhang = value; }
        public string Sotaikhoan { get => _sotaikhoan; set => _sotaikhoan = value; }
        public int Trangthai { get => _trangthai; set => _trangthai = value; }
    }
}
