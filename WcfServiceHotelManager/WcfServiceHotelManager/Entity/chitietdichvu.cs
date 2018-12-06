using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class chitietdichvu
    {
        int id_dv;
        int id_pdp;
        int soluong;
        int status;
        dichvu dichvu;
        phieudatphong phieudatphong;
        public int Id_dv { get => id_dv; set => id_dv = value; }
        public int Id_pdp { get => id_pdp; set => id_pdp = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public int Status { get => status; set => status = value; }
        public dichvu Dichvu { get => dichvu; set => dichvu = value; }
        public phieudatphong Phieudatphong { get => phieudatphong; set => phieudatphong = value; }
    }
}