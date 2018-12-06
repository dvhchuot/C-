using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class chitietdatphong
    {
        int id_pdp;
        int id_p;
        int status;
        phong phong;
        phieudatphong phieudatphong;
        public int Id_pdp { get => id_pdp; set => id_pdp = value; }
        public int Id_p { get => id_p; set => id_p = value; }
        public int Status { get => status; set => status = value; }
        public phong Phong { get => phong; set => phong = value; }
        public phieudatphong Phieudatphong { get => phieudatphong; set => phieudatphong = value; }
    }
}