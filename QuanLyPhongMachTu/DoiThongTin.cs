using DTO;
using QuanLyPhongMachTu.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyPhongMachTu
{
    public partial class fDoiThongTin : Form
    {
        public string UserName = fLogin.currentUserName;
        // Khai báo delegate và sự kiện
        public fDoiThongTin()
        {
            InitializeComponent();

        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string DiaChi = txt_diachi.Text;
            string SoDT = txt_SoDT.Text;
            string hoTen = txt_Hoten.Text;
            dtp_ngaysinh.CustomFormat = "dd/MM/yyyy";
            using (var context = new QLPMTEntities())
            {
                var user = context.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
                if (user == null)
                {
                    // Xử lý lỗi: Không tìm thấy thông tin người dùng trong database
                    return;
                }

                else
                {
                    if (!string.IsNullOrEmpty(hoTen))
                    {
                        user.TenNguoiDung = hoTen;
                    }
                    if (!string.IsNullOrEmpty(DiaChi))
                    {
                        user.DiaChi = DiaChi;
                    }
                    if (!string.IsNullOrEmpty(SoDT))
                    {
                        user.SoDT = SoDT;
                    }
                    if (dtp_ngaysinh.Value != null)
                    {
                        user.NgaySinh = dtp_ngaysinh.Value;
                    }
                }
                context.SaveChanges();

                // Gọi sự kiện CapNhatThongTinKhachHangEvent để cập nhật lại thông tin người dùng ở form chính
                MessageBox.Show("Cập nhật thông tin người dùng thành công!", "Thông báo");

            }
            this.Close();
        }

    }
}