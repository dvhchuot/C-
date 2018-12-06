using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class hoadon
    {
        int id;
        DateTime ngaythanhtoan;
        float tongtien;
        int id_pdp;
        int id_kh;
        string username;
        int status;
        phieudatphong phieudatphong;
        khachhang khachhang;
        account account;

        public int Id { get => id; set => id = value; }
        public DateTime Ngaythanhtoan { get => ngaythanhtoan; set => ngaythanhtoan = value; }
        public float Tongtien { get => tongtien; set => tongtien = value; }
        public int Id_pdp { get => id_pdp; set => id_pdp = value; }
        public int Id_kh { get => id_kh; set => id_kh = value; }
        public string Username { get => username; set => username = value; }
        public int Status { get => status; set => status = value; }
        public phieudatphong Phieudatphong { get => phieudatphong; set => phieudatphong = value; }
        public khachhang Khachhang { get => khachhang; set => khachhang = value; }
        public account Account { get => account; set => account = value; }
    }
}