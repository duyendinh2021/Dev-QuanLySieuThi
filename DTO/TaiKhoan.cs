using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private int _idnhanvien;
        private string _uesrname;
        private string _pass;
        private string _chuvu;
        private int _trangthai;
        private int _statuslogin;

        public TaiKhoan()
        {

        }

        public TaiKhoan(int idnhanvien, string uesrname, string pass, string chuvu, int trangthai, int statuslogin)
        {
            _idnhanvien = idnhanvien;
            _uesrname = uesrname;
            _pass = pass;
            _chuvu = chuvu;
            _trangthai = trangthai;
            _statuslogin = statuslogin;
        }

        public int Idnhanvien { get => _idnhanvien; set => _idnhanvien = value; }
        public string Uesrname { get => _uesrname; set => _uesrname = value; }
        public string Pass { get => _pass; set => _pass = value; }
        public string Chuvu { get => _chuvu; set => _chuvu = value; }
        public int Trangthai { get => _trangthai; set => _trangthai = value; }
        public int Statuslogin { get => _statuslogin; set => _statuslogin = value; }
    }
}
