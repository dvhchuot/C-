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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "phongApi" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select phongApi.svc or phongApi.svc.cs at the Solution Explorer and start debugging.
    public class phongApi : IphongApi
    {
        DataTable dt = new DataTable();
        //public static string sqlConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN_CNLTTH;Integrated Security=True";
        public void DoWork()
        {

        }
        //lấy danh sách phòng trong database đưa lên api
        public List<phong> getListPhong(int status = -1)
        {
            List<phong> listPhong = new List<phong>();
            //connect database
            using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
            {
                dt.TableName = "phong";
                SqlCommand cmd = con.CreateCommand();
                string query = "select * from PHONG ";
                if (status > 0)
                {
                    query += "where STATUS = @status";
                }
                else query += "where STATUS != 0";
                cmd.CommandText = query;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();


            }
            //convert dữ liệu ra dạng list
            listPhong = (from row in dt.AsEnumerable()
                         select new phong()
                         {
                             Id = Convert.ToInt32(row["MA_P"].ToString()),
                             Name = row["name"].ToString(),
                             Trangthai = row["TRANGTHAI"].ToString(),
                             Id_lp = Convert.ToInt32(row["MA_LP"].ToString()),
                             Status = Convert.ToInt32(row["STATUS"].ToString()),

                         }
                           ).ToList();
            return listPhong;
        }
        public chitietdatphong getPhongById(int idPhong)
        {
            chitietdatphong phong = new chitietdatphong();
            using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
            {
                dt.TableName = "phong";
                SqlCommand cmd = con.CreateCommand();
                string query = "SELECT C.TIENDATCOC AS tiendatcoc, A.name AS name, A.MA_P AS idP,E.MOTA AS lp,E.GIA AS gia,E.SONGUOI AS songuoi,D.HOTEN AS tenkh,D.SDT AS sdt,D.CMT AS cmt,C.MA_PDP AS idpdp,C.SONGUOI AS slthue,C.NGAYDEN AS ngayden FROM dbo.PHONG AS A JOIN dbo.CHITIETDATPHONG AS B ON B.MA_P = A.MA_P JOIN dbo.PHIEUDATPHONG AS C ON  C.MA_PDP = B.MA_PDP JOIN dbo.KHACHHANG D ON D.MA_KH = C.MA_KH JOIN dbo.LOAIPHONG AS E ON E.MA_LP = A.MA_LP WHERE C.STATUS=2 AND A.MA_P=@idPhong";

                cmd.CommandText = query;
                cmd.Parameters.Add("@idPhong", SqlDbType.Int).Value = idPhong;
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();


            }
            var list = (from row in dt.AsEnumerable()
                        select new chitietdatphong()
                        {
                            Id_p = Convert.ToInt32(row["idP"]),
                            Id_pdp = Convert.ToInt32(row["idpdp"]),
                            Phong = new phong()
                            {
                                Id = Convert.ToInt32(row["idP"]),
                                Name = row["name"].ToString(),
                                LoaiPhong = new loaiPhong()
                                {
                                    Mota = row["lp"].ToString(),
                                    Gia = Convert.ToDouble(row["gia"].ToString()),
                                    Id = Convert.ToInt32(row["songuoi"].ToString()),

                                },
                            },
                            Phieudatphong = new phieudatphong()
                            {
                                Id = Convert.ToInt32(row["idpdp"]),
                                Songuoi = Convert.ToInt32(row["slthue"]),
                                Ngayden = Convert.ToDateTime(row["ngayden"]),
                                Tiendatcoc = Convert.ToDouble(row["tiendatcoc"]),
                                Khachhang = new khachhang()
                                {
                                    Hoten = row["tenkh"].ToString(),
                                    Sdt = row["sdt"].ToString(),
                                    Cmt = row["cmt"].ToString(),
                                }
                            }
                        }

                    ).ToList();

            return list[0];
        }
        public chitietdatphong getPhieuDatPhongById(int idPdp)
        {
            chitietdatphong phong = new chitietdatphong();
            using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
            {
                dt.TableName = "pdphong";
                SqlCommand cmd = con.CreateCommand();
                string query = "SELECT C.TIENDATCOC AS tiendatcoc, A.name AS name, A.MA_P AS idP,E.MOTA AS lp,E.GIA AS gia,E.SONGUOI AS songuoi,D.HOTEN AS tenkh,D.SDT AS sdt,D.CMT AS cmt,C.MA_PDP AS idpdp,C.SONGUOI AS slthue,C.NGAYDEN AS ngayden FROM dbo.PHONG AS A JOIN dbo.CHITIETDATPHONG AS B ON B.MA_P = A.MA_P JOIN dbo.PHIEUDATPHONG AS C ON  C.MA_PDP = B.MA_PDP JOIN dbo.KHACHHANG D ON D.MA_KH = C.MA_KH JOIN dbo.LOAIPHONG AS E ON E.MA_LP = A.MA_LP WHERE B.MA_PDP= @idPdp";

                cmd.CommandText = query;
                cmd.Parameters.Add("@idPdp", SqlDbType.Int).Value = idPdp;
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();


            }
            var list = (from row in dt.AsEnumerable()
                        select new chitietdatphong()
                        {
                            Id_p = Convert.ToInt32(row["idP"]),
                            Id_pdp = Convert.ToInt32(row["idpdp"]),
                            Phong = new phong()
                            {
                                Id = Convert.ToInt32(row["idP"]),
                                Name = row["name"].ToString(),
                                LoaiPhong = new loaiPhong()
                                {
                                    Mota = row["lp"].ToString(),
                                    Gia = Convert.ToDouble(row["gia"].ToString()),
                                    Id = Convert.ToInt32(row["songuoi"].ToString()),

                                },
                            },
                            Phieudatphong = new phieudatphong()
                            {
                                Id = Convert.ToInt32(row["idpdp"]),
                                Songuoi = Convert.ToInt32(row["slthue"]),
                                Ngayden = Convert.ToDateTime(row["ngayden"]),
                                Tiendatcoc = Convert.ToDouble(row["tiendatcoc"]),
                                Khachhang = new khachhang()
                                {
                                    Hoten = row["tenkh"].ToString(),
                                    Sdt = row["sdt"].ToString(),
                                    Cmt = row["cmt"].ToString(),
                                }
                            }
                        }

                    ).ToList();

            return list[0];
        }
        public List<chitietdichvu> getDichVuPdp(int idPdp)
        {
            List<chitietdichvu> list = new List<chitietdichvu>();
            using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
            {
                dt.TableName = "dichvu";
                SqlCommand cmd = con.CreateCommand();
                string query = "SELECT A.MA_DV idDv,A.TEN ten,B.LOAIDICHVU loai,A.GIA gia,A.DONVITINH dvt,C.SOLUONG soluong FROM dbo.DICHVU  A JOIN dbo.LOAIDICHVU B ON B.MA_LDV = A.MA_LDV JOIN dbo.CHITIETDICHVU C ON C.MA_DV = A.MA_DV WHERE C.MA_PDP= @idPdp";

                cmd.CommandText = query;
                cmd.Parameters.Add("@idPdp", SqlDbType.Int).Value = idPdp;
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();


            }
            list = (from row in dt.AsEnumerable()
                    select new chitietdichvu()
                    {
                        Soluong = Convert.ToInt32(row["soluong"]),
                        Dichvu = new dichvu()
                        {
                            Id = Convert.ToInt32(row["idDv"]),
                            Name = row["ten"].ToString(),
                            Gia = Convert.ToDouble(row["gia"]),
                            Donvitinh = row["dvt"].ToString(),
                            Loaidichvu = new loaidichvu()
                            {
                                Loai = row["loai"].ToString(),
                            }
                        }


                    }

                    ).ToList();


            return list;
        }
        public List<dichvu> getListDichVu()
        {
            List<dichvu> list = new List<dichvu>();
            using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
            {
                dt.TableName = "dichvu";
                SqlCommand cmd = con.CreateCommand();
                string query = "SELECT A.MA_DV idDv,A.TEN ten,B.LOAIDICHVU loai,A.GIA gia,A.DONVITINH dvt FROM dbo.DICHVU  A JOIN dbo.LOAIDICHVU B ON B.MA_LDV = A.MA_LDV  WHERE A.STATUS=1";

                cmd.CommandText = query;

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();


            }
            list = (from row in dt.AsEnumerable()
                    select new dichvu()
                    {

                        Id = Convert.ToInt32(row["idDv"]),
                        Name = row["ten"].ToString(),
                        Gia = Convert.ToDouble(row["gia"]),
                        Donvitinh = row["dvt"].ToString(),
                        Loaidichvu = new loaidichvu()
                        {
                            Loai = row["loai"].ToString(),
                        }
                    }

                    ).ToList();


            return list;
        }
        public bool traphong(int idPdp, double tongtien, string username, int idp)
        {
            try
            {
                SqlConnection kn = new SqlConnection(env.sqlConnectionString);
                kn.Open();
                string sql = "UPDATE dbo.PHIEUDATPHONG SET NGAYDI=GETDATE(), STATUS=1 WHERE MA_PDP=" + idPdp + "";
                SqlCommand commandsql = new SqlCommand(sql, kn);
                commandsql.ExecuteNonQuery();
                sql = "INSERT dbo.HOADON(  NGAYTHANHTOAN ,TONGTIEN , MA_PDP , MA_KH , USERNAME)VALUES  ( '" + DateTime.Now.ToString() + "' ," + tongtien.ToString() + " , " + idPdp + " ,  (SELECT MA_KH FROM dbo.PHIEUDATPHONG WHERE MA_PDP=" + idPdp + ") ,  '" + username + "') ";
                commandsql = new SqlCommand(sql, kn);
                commandsql.ExecuteNonQuery();
                sql = "UPDATE dbo.PHONG SET STATUS=1 WHERE MA_P=" + idp + "";
                commandsql = new SqlCommand(sql, kn);
                commandsql.ExecuteNonQuery();
                kn.Close();
                //using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
                //{

                //    SqlCommand cmd = con.CreateCommand();
                //    string query = "UPDATE dbo.PHIEUDATPHONG SET NGAYDI=GETDATE(), STATUS=1 WHERE MA_PDP=@idPdp";
                //    cmd.CommandText = query;
                //    cmd.Parameters.Add("@idPdp", SqlDbType.Int).Value = idPdp;
                //    con.Open();
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //    cmd.CommandText = "INSERT dbo.HOADON(  NGAYTHANHTOAN ,TONGTIEN , MA_PDP , MA_KH , USERNAME)VALUES  ( @ngaythanhtoan ,@tongtien , @idPdp1 ,  (SELECT MA_KH FROM dbo.PHIEUDATPHONG WHERE MA_PDP=@idPdp) ,  @username) ";
                //    cmd.Parameters.Add("@idPdp", SqlDbType.Int).Value = idPdp;
                //    cmd.Parameters.Add("@idPdp1", SqlDbType.Int).Value = idPdp;
                //    cmd.Parameters.Add("@tongtien", SqlDbType.Float).Value = tongtien;
                //    cmd.Parameters.Add("@username", SqlDbType.Char).Value = username;
                //    cmd.Parameters.Add("@ngaythanhtoan", SqlDbType.DateTime).Value = DateTime.Now.ToString();
                //    Console.WriteLine(cmd.CommandText);
                //    con.Open();
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //    cmd.CommandText = "UPDATE dbo.PHONG SET STATUS=1 WHERE MA_P=@idp";
                //    cmd.Parameters.Add("@idp", SqlDbType.Int).Value = idp;
                //    con.Open();
                //    cmd.ExecuteNonQuery();
                //    con.Close();
                //}
            }
            catch
            {
                return false;
            }
            return true;
        }

        public int ktraPhong(int idPhong)
        {
            using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
            {
                dt.TableName = "phong";
                SqlCommand cmd = con.CreateCommand();
                string query = "SELECT STATUS FROM dbo.PHONG WHERE MA_P=@idPhong";

                cmd.CommandText = query;
                cmd.Parameters.Add("@idPhong", SqlDbType.Int).Value = idPhong;
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();


            }
            var list = (from row in dt.AsEnumerable()
                        select new phong()
                        {
                            Status = Convert.ToInt32(row["STATUS"]),
                        }
                           ).ToList();

            return list[0].Status;
        }
        public bool themdv(int iddv, int idpdp, int soluong)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
                {

                    SqlCommand cmd = con.CreateCommand();
                    string query = "INSERT dbo.CHITIETDICHVU( MA_PDP, MA_DV ,soluong) VALUES  ( @idpdp,@iddv ,@soluong)";

                    cmd.CommandText = query;
                    cmd.Parameters.Add("@idpdp", SqlDbType.Int).Value = idpdp;
                    cmd.Parameters.Add("@iddv", SqlDbType.Int).Value = iddv;
                    cmd.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool themmoidv()
        {
            try
            {

            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool updatedv(dichvu dv)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
                {

                    SqlCommand cmd = con.CreateCommand();

                    string query;
                    if (dv.Id == -1)
                    {
                        query = "INSERT dbo.DICHVU  (  TEN, MA_LDV,GIA, DONVITINH, STATUS )VALUES  (  @ten, @idloai,@gia, @dvt,  1 )";
                        cmd.CommandText = query;
                        cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = dv.Name;
                        cmd.Parameters.Add("@idloai", SqlDbType.Int).Value = dv.Id_ldv;
                        cmd.Parameters.Add("@gia", SqlDbType.Float).Value = dv.Gia;
                        cmd.Parameters.Add("@dvt", SqlDbType.VarChar).Value = dv.Donvitinh;
                    }
                    else
                    {
                        query = "UPDATE dbo.DICHVU SET TEN=@ten,MA_LDV=@idloai,GIA=@gia,DONVITINH=@dvt WHERE MA_DV=@id";
                        cmd.CommandText = query;
                        cmd.Parameters.Add("@ten", SqlDbType.NVarChar).Value = dv.Name;
                        cmd.Parameters.Add("@idloai", SqlDbType.Int).Value = dv.Id_ldv;
                        cmd.Parameters.Add("@gia", SqlDbType.Float).Value = dv.Gia;
                        cmd.Parameters.Add("@dvt", SqlDbType.VarChar).Value = dv.Donvitinh;
                        cmd.Parameters.Add("@id", SqlDbType.Int).Value = dv.Id;
                    }


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool xoadv(int id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
                {

                    SqlCommand cmd = con.CreateCommand();

                    string query;

                    query = "UPDATE dbo.DICHVU SET STATUS=0 WHERE MA_DV=@id";
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public List<loaidichvu> getLoaidichvu()
        {
            List<loaidichvu> list = new List<loaidichvu>();
            using (SqlConnection con = new SqlConnection(env.sqlConnectionString))
            {
                dt.TableName = "phong";
                SqlCommand cmd = con.CreateCommand();
                string query = "SELECT * FROM dbo.LOAIDICHVU WHERE STATUS=1";

                cmd.CommandText = query;

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();


            }
            list = (from row in dt.AsEnumerable()
                    select new loaidichvu()
                    {
                        Id = Convert.ToInt32(row["MA_LDV"]),
                        Loai = row["LOAIDICHVU"].ToString(),
                    }
                          ).ToList();
            return list;
        }
    }
}
