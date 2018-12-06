using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class phong
    {
        int id;
        string name;
        int id_lp;
        string trangthai;
        int status;
        loaiPhong loaiPhong;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Id_lp { get => id_lp; set => id_lp = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
        public int Status { get => status; set => status = value; }
        public loaiPhong LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
    }
}