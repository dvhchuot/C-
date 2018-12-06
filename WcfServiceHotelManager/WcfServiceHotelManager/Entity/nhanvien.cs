using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServiceHotelManager.Entity
{
    public class nhanvien
    {
        int id;
        string ten;
        DateTime ngaysinh;
        Boolean gioitinh;
        string diachi;
        string sdt;
        string chucvu;
        int status;
        

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public bool Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }
        public int Status { get => status; set => status = value; }
        
    }
}