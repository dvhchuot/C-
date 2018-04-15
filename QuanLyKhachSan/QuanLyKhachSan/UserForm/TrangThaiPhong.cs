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

namespace QuanLyKhachSan.UserForm
{
    public partial class TrangThaiPhong : Form
    {
        public TrangThaiPhong()
        {
            InitializeComponent();
        }
        public static string maphong;
        public static string trangthai;

        public void layttp()
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql_ttp = "SELECT TRANGTHAI FROM dbo.TRANGTHAIPHONG";
            SqlCommand command_ttp = new SqlCommand(sql_ttp, kn);

            SqlDataAdapter com_ttp = new SqlDataAdapter(command_ttp);
            DataTable data_ttp = new DataTable();
            com_ttp.Fill(data_ttp);

            for (int i = 0; i < data_ttp.Rows.Count; i++)
            {
                string ma_lp = data_ttp.Rows[i][0].ToString();
                cmb_ttp.Items.Add(ma_lp);
            }
            kn.Close();
        }
        public void thaydoittp(string maphong,string ttp)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql_ttp = "UPDATE dbo.PHONG SET MA_TTP= (SELECT MA_TTP FROM dbo.TRANGTHAIPHONG WHERE TRANGTHAI='"+ttp+"') WHERE MA_P='"+maphong+"'";
            SqlCommand command_ttp = new SqlCommand(sql_ttp, kn);
            command_ttp.ExecuteNonQuery();


        }
        private void TrangThaiPhong_Load(object sender, EventArgs e)
        {
            lb_trangthai.Text = lb_trangthai.Text + trangthai;
            layttp();


        }

        private void lb_trangthai_Click(object sender, EventArgs e)
        {

            thaydoittp(maphong, cmb_ttp.Text);
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "UPDATE dbo.PHONG  SET MA_TTP =( SELECT MA_TTP FROM dbo.TRANGTHAIPHONG WHERE TRANGTHAI=N'" + cmb_ttp.Text + "')";
            SqlCommand command = new SqlCommand(sql, kn);
            command.ExecuteNonQuery();
            MessageBox.Show("Thay đổi thành công");
            kn.Close();
            this.Close();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
