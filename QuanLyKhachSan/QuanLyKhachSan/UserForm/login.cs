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
using QuanLyKhachSan.LoginService;
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
            LoginApiClient loginService = new LoginApiClient();
            account account = new account();
            try
            {
                account = loginService.Login(tk, mk);
                if (account.Username != null && account.Password != null)
                {
                    Login.usename = account.Username;
                    Login.pass = account.Password;
                    Login.chucvu = account.NhanVien.Chucvu;
                    Form1 f = new Form1();
                    this.Hide();
                    f.ShowDialog();
                }

                else
                {
                    MessageBox.Show("tài khoản hoặc mk sai");
                    txt_mk.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối service thất bại! Vui lòng thử lại.");
            }
        }
    }
}
