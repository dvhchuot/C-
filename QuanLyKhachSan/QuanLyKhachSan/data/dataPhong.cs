using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.UserForm;
namespace QuanLyKhachSan.data
{
    class dataPhong
    {
        public int Kiemtraphong(string maphong)
        {
            int kt=0;

            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT MA_TTP FROM dbo.PHONG WHERE MA_P='"+maphong+"'";
            SqlCommand command = new SqlCommand(sql, kn);
            SqlDataAdapter com = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            com.Fill(data);
            DataRow dr = data.Rows[0];

            if (dr.ItemArray[0].ToString() == "TTP01     ")
                kt = 0;
            if (dr.ItemArray[0].ToString() == "TTP02     ")
                kt = 1;
            if (dr.ItemArray[0].ToString() == "TTP03     ")
                kt = 2;
            if (dr.ItemArray[0].ToString() == "TTP04     ")
                kt = 3;
            return kt;

        }
    }
    
}
