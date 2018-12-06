using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class loaiPhong
    {
        int id;
        double gia;
        int soNguoi;
        int status;
        string mota;
        public int Id { get => id; set => id = value; }
        public double Gia { get => gia; set => gia = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
        public int Status { get => status; set => status = value; }
        public string Mota { get => mota; set => mota = value; }
    }
}