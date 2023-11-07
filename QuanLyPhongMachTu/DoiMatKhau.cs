using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyPhongMachTu
{
    public partial class fDoiMatKhau : Form
    {
        public string UserName = fLogin.currentUserName;

        public fDoiMatKhau()
        {
            InitializeComponent();
        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {

            using (var context = new QLPMTEntities())
            {
                var user = context.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
                if (user == null)
                {
                    // Xử lý lỗi: Không tìm thấy thông tin người dùng trong database
                    return;
                }

                string currentPassword = user.MatKhau;
                string newPassword = txt_mkmoi.Text;
                string confirmNewPassword = txt_xacnhanmkmoi.Text;

                // Kiểm tra mật khẩu cũ
                if (currentPassword != txt_mk.Text)
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác.", "Thông báo");
                    return;
                }

                // Kiểm tra xác nhận mật khẩu
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("Mật khẩu mới không khớp với xác nhận mật khẩu mới.", "Thông báo");
                    return;
                }

                // Cập nhật mật khẩu mới vào database
                user.MatKhau = newPassword;
                context.SaveChanges();

                MessageBox.Show("Mật khẩu đã được cập nhật thành công.", "Thông báo");
                this.Hide();
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}