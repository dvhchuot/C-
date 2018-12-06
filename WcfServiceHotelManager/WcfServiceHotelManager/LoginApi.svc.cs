using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfServiceHotelManager.Entity;
namespace WcfServiceHotelManager
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginApi" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoginApi.svc or LoginApi.svc.cs at the Solution Explorer and start debugging.
    public class LoginApi : ILoginApi
    {
        DataTable dt = new DataTable();
        public void DoWork()
        {
        }
        public account Login(string username,string password)
        {
            

            using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
            {
                dt.TableName = "account";
                SqlCommand cmd = con.CreateCommand();
                string query = "SELECT * FROM dbo.HETHONG AS A JOIN dbo.NHANVIEN AS B ON B.MA_NV = A.MA_NV WHERE A.USENAME = @username AND A.PASSWORD = @password";
                
                cmd.CommandText = query;
                cmd.Parameters.Add("@username", SqlDbType.Char).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.Char).Value = password;
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();


            }

            var a = (from row in dt.AsEnumerable()
                   select new account()
                   {
                       Username = row["USENAME"].ToString(),
                       Password = row["PASSWORD"].ToString(),
                       Id_nv = Convert.ToInt32(row["MA_NV"].ToString()),
                       NhanVien = new nhanvien()
                       {
                           Id= Convert.ToInt32(row["MA_NV"].ToString()),
                           Ten = row["HOTEN"].ToString(),
                           Diachi = row["DIACHI"].ToString(),
                           Ngaysinh = Convert.ToDateTime(row["NGAYSINH"].ToString()),
                           Sdt = row["SDT"].ToString(),
                           Chucvu = row["CHUCVU"].ToString(),
                           Gioitinh = Convert.ToBoolean(row["GIOITINH"].ToString()),
                       }

                   }
                ).ToList();
            account account = new account();
            if (a.Count > 0) account = a[0];
            return account;
            
        }
    }
}
