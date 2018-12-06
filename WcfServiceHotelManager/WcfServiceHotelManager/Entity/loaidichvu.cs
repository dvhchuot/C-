using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class loaidichvu
    {
        int id;
        string loai;
        string hesogia;
        int status;

        public int Id { get => id; set => id = value; }
        public string Loai { get => loai; set => loai = value; }
        public string Hesogia { get => hesogia; set => hesogia = value; }
        public int Status { get => status; set => status = value; }
    }
}