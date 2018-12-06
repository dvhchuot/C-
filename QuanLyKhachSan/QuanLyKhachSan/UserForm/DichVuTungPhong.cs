using QuanLyKhachSan.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.PhongService;
namespace QuanLyKhachSan.UserForm
{
    public partial class DichVuTungPhong : Form
    {
        public DichVuTungPhong()
        {
            InitializeComponent();
        }
        public static string maPhong;
        public static string maPdp;
        public static int idP;
        public static int idPdp;
        List<chitietdichvu> oldList = new List<chitietdichvu>();
        List<chitietdichvu> newList = new List<chitietdichvu>();
        SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
        IphongApiClient client = new IphongApiClient();
        int dv_chon=-1;
        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void loaddv()
        {
            //kn.Open();
            //string sql = "SELECT dv.MA_DV N'Mã dịch vụ', dv.TEN N'Tên', ldv.LOAIDICHVU N'Loại',dv.GIA N'Giá',dv.DONVITINH N'Đơn vị tính' FROM dbo.DICHVU dv,dbo.LOAIDICHVU ldv WHERE dv.MA_LDV=ldv.MA_LDV";
            //SqlCommand commandsql = new SqlCommand(sql, kn);

            //SqlDataAdapter com = new SqlDataAdapter(commandsql);
            //DataTable data = new DataTable();
            //com.Fill(data);
            //tb_dv.DataSource = data;
            //kn.Close();
            List<dichvu> list = new List<dichvu>();
            list = client.getListDichVu().ToList();
            tb_dv.DataSource = list.Select(c=>new  { id = c.Id, ten = c.Name, loai = c.Loaidichvu.Loai, gia = c.Gia, dvt = c.Donvitinh }).ToList();
        }
        public void loaddvp()
        {
            //kn.Open();
            //string sql = "SELECT dv.MA_DV N'Mã dịch vụ', dv.TEN N'Tên', ldv.LOAIDICHVU N'Loại',dv.GIA N'Giá',dv.DONVITINH N'Đơn vị tính',ctdv.soluong N'Số lượng' FROM dbo.CHITIETDICHVU ctdv, dbo.DICHVU dv, dbo.LOAIDICHVU ldv WHERE dv.MA_LDV = ldv.MA_LDV AND ctdv.MA_DV = dv.MA_DV AND ctdv.MA_PDP = '"+maPdp+"'";

            //SqlCommand commandsql = new SqlCommand(sql, kn);

            //SqlDataAdapter com = new SqlDataAdapter(commandsql);
            //DataTable data = new DataTable();
            //com.Fill(data);
            //tb_dvp.DataSource = data;
            //kn.Close();
            
            oldList = client.getDichVuPdp(idPdp).ToList();
            bindData();
            
        }
        public void bindData()
        {
            
            List<chitietdichvu> list = new List<chitietdichvu>();
            foreach (var item in oldList)
                list.Add(item);
            foreach (var item in newList)
                list.Add(item);
            tb_dvp.DataSource = list.Select(c => new { id = c.Dichvu.Id, ten = c.Dichvu.Name, loai = c.Dichvu.Loaidichvu.Loai, gia = c.Dichvu.Gia, dvt = c.Dichvu.Donvitinh, soluong = c.Soluong }).ToList();
        }
        public void themdichvu(int iddv ,int sl)
        {
            //kn.Open();
            ////string sql = "INSERT dbo.CHITIETDICHVU( MA_PDP, MA_DV ,soluong) VALUES  ( '" + maPdp+"','"+mdv+"' , "+sl+" )";
            //string sql = "ThemDV '" + maPdp + "' , '"+mdv+"'," + sl ;

            //SqlCommand commandsql = new SqlCommand(sql, kn);
            //commandsql.ExecuteNonQuery();
            //
            //kn.Close();

            if(client.themdv(iddv, idPdp, sl))
            {
                MessageBox.Show("Thêm thành công");
                dv_chon = -1;
                txt_sl.Text = "";
            }
            else MessageBox.Show("Xảy ra lỗi");

            loaddvp();

        }
        private void DichVuTungPhong_Load(object sender, EventArgs e)
        {
            lb_mp.Text = "Dịch vụ phòng " + idP;
            loaddv();
            loaddvp();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_tt_Click(object sender, EventArgs e)
        {

        }

        private void txt_sl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_madv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tb_dv_MouseClick(object sender, MouseEventArgs e)
        {
            int index = tb_dv.CurrentRow.Index;
            dv_chon = Convert.ToInt32(tb_dv.Rows[index].Cells[0].Value);

        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_lu_Click(object sender, EventArgs e)
        {
            
            int soluong = 0;
            try
            {
                 soluong = Convert.ToInt32(txt_sl.Text);
            }
            catch
            {
               
            }
            

            if (dv_chon == -1 || soluong < 1)  MessageBox.Show("Mời nhập số liệu");
            else
            themdichvu(dv_chon, soluong);
            

        }
    }
}
