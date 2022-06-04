using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private int _id;
        private string _name;
        private string _chucvu;
        private DateTime _ngaysinh;
        private DateTime _ngayvaolam;
        private string _diachi;
        private string _sdt;
        private string _tennganhang;
        private string _sotaikhoan;
        private string _gioitinh;
        private Decimal _luongcoban;
        private Decimal _luongphucap;
        private Decimal _tongluong;
        private string _email;
        private byte[] _hinh;
        private int _trangthai;

        public NhanVien(int id, string name, string chucvu, DateTime ngaysinh, DateTime ngayvaolam, string diachi, string sdt, string tennganhang, string sotaikhoan, string gioitinh, decimal luongcoban, decimal luongphucap, decimal tongluong, string email, byte[] hinh, int trangthai)
        {
            _id = id;
            _name = name;
            _chucvu = chucvu;
            _ngaysinh = ngaysinh;
            _ngayvaolam = ngayvaolam;
            _diachi = diachi;
            _sdt = sdt;
            _tennganhang = tennganhang;
            _sotaikhoan = sotaikhoan;
            _gioitinh = gioitinh;
            _luongcoban = luongcoban;
            _luongphucap = luongphucap;
            _tongluong = tongluong;
            _email = email;
            _hinh = hinh;
            _trangthai = trangthai;
        }


        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Chucvu { get => _chucvu; set => _chucvu = value; }
        public DateTime Ngaysinh { get => _ngaysinh; set => _ngaysinh = value; }
        public DateTime Ngayvaolam { get => _ngayvaolam; set => _ngayvaolam = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public string Sdt { get => _sdt; set => _sdt = value; }
        public string Tennganhang { get => _tennganhang; set => _tennganhang = value; }
        public string Sotaikhoan { get => _sotaikhoan; set => _sotaikhoan = value; }
        public decimal Luongcoban { get => _luongcoban; set => _luongcoban = value; }
        public decimal Luongphucap { get => _luongphucap; set => _luongphucap = value; }
        public decimal Tongluong { get => _tongluong; set => _tongluong = value; }
        public string Email { get => _email; set => _email = value; }
        public byte[] Hinh { get => _hinh; set => _hinh = value; }
        public int Trangthai { get => _trangthai; set => _trangthai = value; }
        public string Gioitinh { get => _gioitinh; set => _gioitinh = value; }
    }
}
