using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class phieudatphong
    {
        int id;
        int id_kh;
        DateTime ngayden;
        DateTime ngaydi;
        double tiendatcoc;
        string tinhtrang;
        int songuoi;
        int status;
        khachhang khachhang;

        public int Id { get => id; set => id = value; }
        public int Id_kh { get => id_kh; set => id_kh = value; }
        public DateTime Ngayden { get => ngayden; set => ngayden = value; }
        public DateTime Ngaydi { get => ngaydi; set => ngaydi = value; }
        public double Tiendatcoc { get => tiendatcoc; set => tiendatcoc = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }
        public int Songuoi { get => songuoi; set => songuoi = value; }
        public int Status { get => status; set => status = value; }
        public khachhang Khachhang { get => khachhang; set => khachhang = value; }
    }
}