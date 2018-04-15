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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tk = Txt_tk.Text;
            string mk = txt_mk.Text;
            SqlConnection kn = new SqlConnection(Connectsql.connectionsql);
            kn.Open();
            string sql = "SELECT nv.CHUCVU, ht.USENAME FROM dbo.HETHONG ht, dbo.NHANVIEN nv WHERE ht.MA_NV=nv.MA_NV AND ht.USENAME='"+tk+"' AND ht.PASSWORD='"+mk+"'";
            //MessageBox.Show(sql);

            SqlCommand commandsql = new SqlCommand(sql, kn);

            SqlDataAdapter com = new SqlDataAdapter(commandsql);
            DataTable data = new DataTable();
            com.Fill(data);
            if(data.Rows.Count>0)
            {
                Login.usename = tk;
                Login.chucvu = data.Rows[0][0].ToString();
                Login.pass = mk;
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
               
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mk sai");
                txt_mk.Text = "";
            }
        }
    }
}
