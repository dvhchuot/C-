using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class account
    {
        string username;
        string password;
        int id_nv;
        nhanvien nhanVien;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Id_nv { get => id_nv; set => id_nv = value; }
        public nhanvien NhanVien { get => nhanVien; set => nhanVien = value; }
    }
}