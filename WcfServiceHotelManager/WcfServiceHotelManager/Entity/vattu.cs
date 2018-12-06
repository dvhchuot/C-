using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class vattu
    {
        int id;
        string ten;
        float gia;
        int status;

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public float Gia { get => gia; set => gia = value; }
        public int Status { get => status; set => status = value; }
    }
}