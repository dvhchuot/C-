using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class chitietvattu
    {
        int id_p;
        int id_vt;
        int soluong;
        int status;

        public int Id_p { get => id_p; set => id_p = value; }
        public int Id_vt { get => id_vt; set => id_vt = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Status { get => status; set => status = value; }
    }
}