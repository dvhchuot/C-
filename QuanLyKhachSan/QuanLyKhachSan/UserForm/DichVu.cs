using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using QuanLyKhachSan.data;

namespace QuanLyKhachSan.UserForm
{
    public partial class DichVu : Form
    {
        bool themmoi = false;
        int dong = -1;
        public DichVu()
        {
            InitializeComponent();
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
            //cnn = new SqlConnection(strCnn);
            cnn.Open();
            Show_CboMaloaidichvu("");
            Show_CboDonvitinh("");
            Show_Dichvu("");
        }
        private void Show_CboMaloaidichvu(string MA_LDV)
        {
            string sql = "Select MA_LDV,LOAIDICHVU From dbo.LOAIDICHVU";
            if (MA_LDV != "")
                sql = sql + "Where MA_LDV='" + MA_LDV+ "'";
            SqlDataAdapter daLoaidichvu = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            daLoaidichvu.Fill(dt);
            cbo_maloaidichvu.DataSource = dt;
            cbo_maloaidichvu.ValueMember = "MA_LDV";
            cbo_maloaidichvu.DisplayMember = "LOAIDICHVU"; 
 
       }

        private void Show_CboDonvitinh(string MA_DV)
        {
            string sql = "Select MA_DV,DONVITINH From dbo.DICHVU";
            if (MA_DV != "")
                sql = sql + "Where MA_DV='" + MA_DV + "'";
            SqlDataAdapter daDonvitinh = new SqlDataAdapter(sql, cnn);
            DataTable dt1 = new DataTable();
            daDonvitinh.Fill(dt1);
            cbo_maloaidichvu.DataSource = dt1;
            cbo_maloaidichvu.ValueMember = "MA_DV";
            cbo_maloaidichvu.DisplayMember = "DONVITINH";

        }

        private void Show_Dichvu(string MA_DV)
        {
            string sql = "Select MA_DV,MA_LDV,TEN,GIA,DONViTINH  From DICHVU";
            if (MA_DV != "")
                sql = sql + " Where MA_DV='" + MA_DV + "'";
            SqlDataAdapter daDichvu = new SqlDataAdapter(sql, cnn);
            DataTable dt1 = new DataTable();
            daDichvu.Fill(dt1);
            tabledichvu.DataSource = dt1;
        }
        public void Mo_btn()
        {
            //các txt mở lại để nhập
            txt_madichvu.ReadOnly = false;
            txt_giatien.ReadOnly = false;
        }
        public void Khoa_btn()
        {
            //các txt khóa, ko cho nhập 
            txt_madichvu.ReadOnly = true;
            txt_giatien.ReadOnly = true;
        }
        SqlConnection cnn = new SqlConnection(Connectsql.connectionsql);
        private void Ketnoicsdl()
        {
            cnn.Open();
            string sql = "select * from DICHVU";
            SqlCommand com = new SqlCommand(sql, cnn);
            
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            tabledichvu.DataSource = dt;
        }
        public void SetNull()
        {
            txt_madichvu.Text = "";
            txt_giatien.Text = "";
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            if (txt_madichvu.Text == "")
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin");
                Khoa_btn();
                return;
            }
            else
            {
                //Them DV
                #region 
                if (themmoi == true)
                {
                    try
                    {
                        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
                        cnn.Open();
                        SqlCommand cmd = new SqlCommand("SP_ThemDV", cnn);
                        
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter p = new SqlParameter("@MaDV", txt_madichvu.Text);
                        cmd.Parameters.Add(p);
                       
                        p = new SqlParameter("@MaLDV", cbo_maloaidichvu.SelectedValue.ToString());
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@Donvitinh", cbo_donvitinh.SelectedValue.ToString());
                        cmd.Parameters.Add(p);

                        p = new SqlParameter("@Gia", txt_giatien.Text);
                        cmd.Parameters.Add(p);

                        cmd.ExecuteNonQuery();
                        //Hiển thị lại thông tin sau khi thêm và thông báo
                        Ketnoicsdl();
                        MessageBox.Show("Thêm mới thành công");

                        //
                        txt_madichvu.Enabled = false;
                        bt_luu.Enabled = false;
                        bt_sua.Enabled = true;
                        bt_xoa.Enabled = true;
                        SetNull();
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                //Sua GV
                #region
                else
                {
                    try
                    {
                        SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
                        cnn.Open();
                        //MessageBox.Show("ok");

                        SqlCommand cmd2 = new SqlCommand("SP_SuaDV", cnn);
                        cmd2.CommandType = CommandType.StoredProcedure;

                        SqlParameter p = new SqlParameter("@MaDV", txt_madichvu.Text);
                        cmd2.Parameters.Add(p);

                        p = new SqlParameter("@MaLDV", cbo_maloaidichvu.SelectedValue.ToString());
                        cmd2.Parameters.Add(p);

                        p = new SqlParameter("@Donvitinh", cbo_donvitinh.SelectedValue.ToString());
                        cmd2.Parameters.Add(p);

                        p = new SqlParameter("@Gia", txt_giatien.Text);
                        cmd2.Parameters.Add(p);


                        cmd2.ExecuteNonQuery();

                        //Hiển thị lại thông tin sau khi thêm và thông báo
                        //Ketnoi();

                        MessageBox.Show("Thay đổi thông tin dịch vụ thành công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                #endregion

                bt_them.Enabled = true;
                bt_luu.Enabled = false;
                bt_xoa.Enabled = true;
                SetNull();
                Khoa_btn();/*không cho thao tác*/
                Ketnoicsdl();
            }

        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            Khoa_btn();
            Ketnoicsdl();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            if (dong < 0)
            {
                MessageBox.Show("Chưa chọn dịch vụ để sửa!");
                return;
            }
            Mo_btn();
            bt_them.Enabled = false;
            bt_xoa.Enabled = false;
            bt_luu.Enabled = true;
            //hienthi ds Ma dich vu
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_SuaPhongBan", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            //string strSQL = "select * from DICHVU";
            //DataTable dt = new DataTable();
            //SqlDataAdapter sqlDa = new SqlDataAdapter(strSQL, cnn);
            //sqlDa.Fill(dt);

            //cbo_maloaidichvu.DataSource = dt;
            //cbo_maloaidichvu.DisplayMember = "LOAIDICHVU";
            //cbo_maloaidichvu.ValueMember = "MA_LDV";

            //cbo_donvitinh.DataSource = dt;
            //cbo_donvitinh.DisplayMember = "DONVITINH";
            //cbo_donvitinh.ValueMember = "MA_DV";

            SqlParameter p = new SqlParameter("@MaDV", txt_madichvu.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@MaLDV", cbo_maloaidichvu.SelectedValue.ToString());
            cmd.Parameters.Add(p);

            p = new SqlParameter("@Donvitinh", cbo_donvitinh.SelectedValue.ToString());
            cmd.Parameters.Add(p);

            p = new SqlParameter("@Gia", txt_giatien.Text);
            cmd.Parameters.Add(p);

            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công");
                Show_Dichvu("");
            }
            else MessageBox.Show("Không thể sửa được");
            cnn.Close();

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn xóa dữ liệu?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SP_XoaDV", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter("@MaDV", txt_madichvu.Text);
                cmd.Parameters.Add(p);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Xoá thành công");
                Ketnoicsdl();
            }
        }
        
        private void bt_them_Click(object sender, EventArgs e)
        {
            themmoi = true;
            #region
            ////Lấy mã môn học
            //SqlConnection conn = new SqlConnection(DTO.ConnectionString.stringConnect);
            //conn.Open();
            //string sql = "Select *from tblMonhoc";
            //cboMamon.DataSource = sql;
            //cboMamon.DisplayMember = "MaMon";
            //cboMamon.ValueMember = "MaMon";
            #endregion

            //Mở nút thêm và lưu 
            txt_madichvu.Enabled = true;
            bt_sua.Enabled = false;
            bt_xoa.Enabled = false;
            bt_luu.Enabled = true;
                
            SqlConnection cnn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
            cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_ThemDV", cnn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter p = new SqlParameter("@MaDV", txt_madichvu.Text);
            cmd.Parameters.Add(p);

            p = new SqlParameter("@MaLDV", cbo_maloaidichvu.SelectedValue.ToString());
            cmd.Parameters.Add(p);

            p = new SqlParameter("@Donvitinh", cbo_donvitinh.SelectedValue.ToString());
            cmd.Parameters.Add(p);

            p = new SqlParameter("@Gia", txt_giatien.Text);
            cmd.Parameters.Add(p);

            // Thực thi thủ tục 
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                Show_Dichvu("");
            }
            else MessageBox.Show("Không thể thêm mới"); 

            txt_madichvu.Focus();
            Mo_btn();
            SetNull();
            cnn.Close();
        }

        private void txt_madichvu_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection kn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QUANLY_KHACHSAN;Integrated Security=True");
                kn.Open();
                string sqlTimKiem = "select * from DICHVU where Ma_DV='" + txt_madichvu.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sqlTimKiem, kn);

                cmd.Parameters.AddWithValue("Ma_DV", txt_madichvu.Text.Trim());
                cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                tabledichvu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbo_maloaidichvu_Click(object sender, EventArgs e)
        {
            Show_CboMaloaidichvu("");
        }

        private void cbo_donvitinh_Click(object sender, EventArgs e)
        {
            Show_CboDonvitinh("");
        }

        private void tabledichvu_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }

    
   
}

