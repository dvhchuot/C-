using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class khachhang
    {
        int id;
        string hoten;
        Boolean gioitinh;
        string cmt;
        string sdt;
        string email;
        int status;

        public int Id { get => id; set => id = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Cmt { get => cmt; set => cmt = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public int Status { get => status; set => status = value; }
    }
}