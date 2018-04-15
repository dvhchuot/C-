using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSan.data;
namespace QuanLyKhachSan.UserForm
{
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }
        public void layttp()
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql_ttp = "SELECT TRANGTHAI FROM dbo.TRANGTHAIPHONG";
            SqlCommand command_ttp = new SqlCommand(sql_ttp, kn);

            SqlDataAdapter com_ttp = new SqlDataAdapter(command_ttp);
            DataTable data_ttp = new DataTable();
            com_ttp.Fill(data_ttp);
            cmb_ttp.Items.Clear();
            for (int i = 0; i < data_ttp.Rows.Count; i++)
            {
                string ma_lp = data_ttp.Rows[i][0].ToString();
                cmb_ttp.Items.Add(ma_lp);
            }
            kn.Close();
        }
        public void layloaiphong()
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT MA_LP FROM dbo.LOAIPHONG";
            SqlCommand command = new SqlCommand(sql, kn);

            SqlDataAdapter com = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            com.Fill(data);
            cmb_lp.Items.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string ma_lp = data.Rows[i][0].ToString();
                cmb_lp.Items.Add(ma_lp);
            }
            kn.Close();
        }
        public void dataphong()
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();

            string sql_p = "SELECT p.MA_P Phòng,lp.MA_LP N'Loại Phòng',lp.GIA giá,lp.SONGUOI N'Số người tối đa',TTP.TRANGTHAI N'Trạng thái' FROM dbo.PHONG P,dbo.TRANGTHAIPHONG TTP, dbo.LOAIPHONG LP WHERE P.MA_LP=LP.MA_LP AND P.MA_TTP=TTP.MA_TTP";
            SqlCommand commandsql_p = new SqlCommand(sql_p, kn);
            SqlDataAdapter com_p = new SqlDataAdapter(commandsql_p);
            DataTable data_p = new DataTable();
            com_p.Fill(data_p);
            tb_p.DataSource = data_p;
            kn.Close();
        }
        public void themphong(string mp,string mlp,string ttp)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
           try
            {
                string sql_p = "INSERT INTO dbo.PHONG( MA_P, MA_LP, MA_TTP )VALUES( '" + mp + "', '" + mlp + "',(SELECT MA_TTP FROM dbo.TRANGTHAIPHONG WHERE TRANGTHAI=N'" + ttp + "'))";

                SqlCommand commandsql_p = new SqlCommand(sql_p, kn);

                commandsql_p.ExecuteNonQuery();


                MessageBox.Show("thêm thành công");
            }
            catch
            {
                MessageBox.Show("Mã Phòng đã tồn tại");
            }
            kn.Close();
            dataphong();
        }
        public void suaphong(string mp, string mlp, string ttp)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql_p = "UPDATE dbo.PHONG SET MA_LP='"+mlp+"',MA_TTP= ((SELECT MA_TTP FROM dbo.TRANGTHAIPHONG WHERE TRANGTHAI=N'"+ttp+"')) WHERE MA_P='"+mp+"'";

            SqlCommand commandsql_p = new SqlCommand(sql_p, kn);

            commandsql_p.ExecuteNonQuery();


            MessageBox.Show("Sửa thành công");
            kn.Close();
            dataphong();
        }

        public void timkiem(string mp)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();

            string sql_p = "SELECT p.MA_P Phòng,lp.MA_LP N'Loại Phòng',lp.GIA giá,lp.SONGUOI N'Số người tối đa',TTP.TRANGTHAI N'Trạng thái' FROM dbo.PHONG P,dbo.TRANGTHAIPHONG TTP, dbo.LOAIPHONG LP WHERE P.MA_LP=LP.MA_LP AND P.MA_TTP=TTP.MA_TTP  AND p.MA_P='"+mp+"'";
            SqlCommand commandsql_p = new SqlCommand(sql_p, kn);
            SqlDataAdapter com_p = new SqlDataAdapter(commandsql_p);
            DataTable data_p = new DataTable();
            com_p.Fill(data_p);
            tb_p.DataSource = data_p;
            kn.Close();
        }
        public void XoaPhong(string mp)
        {
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            try
            {
                string sql_p = "DELETE dbo.PHONG WHERE MA_P='"+mp+"'";

                SqlCommand commandsql_p = new SqlCommand(sql_p, kn);

                commandsql_p.ExecuteNonQuery();

                MessageBox.Show("Đã xóa");
            }
            catch
            {
                MessageBox.Show("Phòng không tồn tại");
            }
        }
        public void ketnoi()
        {
            layttp();
            layloaiphong();
            dataphong();



        }
        private void Phong_Load(object sender, EventArgs e)
        {
            ketnoi();
        }

        private void cmbMaLPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void cmbMaTTrPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_p_MouseClick(object sender, MouseEventArgs e)
        {
            int index = tb_p.CurrentRow.Index;
            txtMaPhong.Text=tb_p.Rows[index].Cells[0].Value.ToString();
            cmb_lp.Text= tb_p.Rows[index].Cells[1].Value.ToString();
            cmb_ttp.Text= tb_p.Rows[index].Cells[4].Value.ToString();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {

            string mp = txtMaPhong.Text;
            string mlp = cmb_lp.Text;
            string ttp = cmb_ttp.Text;

            themphong(mp,mlp,ttp);
            


        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            string mp = txtMaPhong.Text;
            string mlp = cmb_lp.Text;
            string ttp = cmb_ttp.Text;

            suaphong(mp, mlp, ttp);
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            string mp = txtMaPhong.Text;
            timkiem(mp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaPhong.Text = "";
            ketnoi();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string mp = txtMaPhong.Text;
            XoaPhong(mp);
        }
    }
}
