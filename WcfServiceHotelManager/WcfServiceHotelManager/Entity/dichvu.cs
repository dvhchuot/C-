using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class dichvu
    {
        int id;
        string name;
        double gia;
        string donvitinh;
        int id_ldv;
        int status;
        loaidichvu loaidichvu;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Gia { get => gia; set => gia = value; }
        public string Donvitinh { get => donvitinh; set => donvitinh = value; }
        public int Id_ldv { get => id_ldv; set => id_ldv = value; }
        public int Status { get => status; set => status = value; }
        public loaidichvu Loaidichvu { get => loaidichvu; set => loaidichvu = value; }
    }
}