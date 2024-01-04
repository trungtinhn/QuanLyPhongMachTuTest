using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using QuanLyPhongMachTu.UserControls;

namespace QuanLyPhongMachTu
{
    public partial class fLogin : Form
    {
        public static string currentUserName;

        public fLogin()

        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1890, 1030);
            this.MinimumSize = new System.Drawing.Size(1890, 1030);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string password = txt_Password.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
            }

            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập");
            }
            if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }

            BLL_LOGIN account = new BLL_LOGIN();

            bool isValid = account.Login(username, password);
            if (isValid)
            {
                MessageBox.Show("Bạn đã đăng nhập thành công!");
                currentUserName = username;
                this.Hide();
                fHome form1 = new fHome();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }


    }
}
