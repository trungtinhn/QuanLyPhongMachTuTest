using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.Entity;
using System.Web.UI;
using System.Xml.Linq;
using UserControl = System.Windows.Forms.UserControl;
using System.Web.UI.WebControls;
using static QuanLyPhongMachTu.fLogin;
using System.IO;
using System.Runtime.Remoting.Contexts;

namespace QuanLyPhongMachTu.UserControls
{
    public partial class uTaiKhoancs : UserControl
    {

        public string UserName = fLogin.currentUserName;

        QLPMTEntities db = new QLPMTEntities();
        public uTaiKhoancs()
        {
            InitializeComponent();

            // Đăng ký sự kiện ChinhSuaThongTinNguoiDungEvent
        }

        public void CapNhatThongTinNguoiDung(string userName)
        {
            var user = db.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == userName);
            if (user != null)
            {
                label1.Text = user.MaNguoiDung;
                label2.Text = user.SoDT;
                label3.Text = user.TenNguoiDung.ToString();
                DateTime datevalue = (Convert.ToDateTime(user.NgaySinh.ToString()));

                String dy = datevalue.Day.ToString();
                String mn = datevalue.Month.ToString();
                String yy = datevalue.Year.ToString();

                label4.Text = dy + " / " + mn + " / " + yy;
                label5.Text = user.ChucVu;
                label6.Text = user.DiaChi;
            }
        }
        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uTaiKhoancs_Load(object sender, EventArgs e)
        {

            var user = db.NGUOIDUNGs.FirstOrDefault(a => a.TenDangNhap == UserName);

            if (user != null)
            {
               
                label1.Text = user.MaNguoiDung;
                label2.Text = user.SoDT;
                label3.Text = user.TenNguoiDung.ToString();
                //DateTime datevalue = (Convert.ToDateTime(user.NgaySinh.ToString()));
                DateTime? nullableDate = user.NgaySinh;
                if (nullableDate.HasValue)
                {
                    //DateTime datevalue = (DateTime)nullableDate;
                    DateTime datevalue = nullableDate.Value;
                    // Tiếp tục sử dụng datevalue
                    String dy = datevalue.Day.ToString();
                    String mn = datevalue.Month.ToString();
                    String yy = datevalue.Year.ToString();

                    label4.Text = dy + " / " + mn + " / " + yy;
                }
                else
                {
                    // Xử lý trường hợp khi NgaySinh là null
                }
                
                label5.Text = user.ChucVu;
                label6.Text = user.DiaChi;

                lbl_Name.Text = user.TenNguoiDung;
                lbl_Job.Text = user.ChucVu;
            }
            else
            {
                MessageBox.Show("NOT OKE");
            }
        }
        private string ImageToBase64(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }

        private void SaveImageToDatabase(System.Drawing.Image image)
        {
            try
            {
                using (var context = new QLPMTEntities())
                {
                    var user = context.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
                    if (user != null)
                    {
                        user.AnhDaiDien = ImageToBase64(image);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("SOMETHING WRONG");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}");
            }
        }

        private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbx_Avatar.Image = new Bitmap(openFileDialog.FileName);

                // Lưu ảnh dưới dạng chuỗi vào cơ sở dữ liệu
                SaveImageToDatabase(pbx_Avatar.Image);

                // Hiển thị ảnh lên PictureBox
                pbx_Avatar.ImageLocation = openFileDialog.FileName;
            }
        }


        private void lbl_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa ảnh đại diện không?", "Xóa ảnh đại diện", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Thực hiện xóa ảnh đại diện của người dùng trong cơ sở dữ liệu
                using (var db = new QLPMTEntities())
                {
                    var user = db.NGUOIDUNGs.FirstOrDefault(a => a.TenDangNhap == UserName);
                    if (user != null)
                    {
                        user.AnhDaiDien = null;
                        db.SaveChanges();
                    }
                }

                // Load lại ảnh đại diện mặc định
                pbx_Avatar.Image = Properties.Resources.boy;
            }
        }

        private void btn_loggout_Click(object sender, EventArgs e)
        {

            // Hiển thị form đăng nhập
            Application.Restart();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            fDoiMatKhau doiMatKhau = new fDoiMatKhau();
            doiMatKhau.Show();
        }

        private void btn_Chinhsua_Click(object sender, EventArgs e)
        {
            fDoiThongTin f = new fDoiThongTin();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CapNhatThongTinNguoiDung(UserName);
        }

        private void btn_rgt_Click(object sender, EventArgs e)
        {
            using (QLPMTEntities db = new QLPMTEntities())
            {
                var user = db.NGUOIDUNGs.FirstOrDefault(u => u.TenDangNhap == UserName);
                if (user != null)
                {
                    if (user.idNhomNguoiDung == 1)
                    {
                        fDangKy dangKy = new fDangKy();
                        dangKy.Show();
                    }
                    else
                    {
                        MessageBox.Show("YOU DON'T HAVE PERMISSION TO DO THAT");
                    }
                }
            }

        }
    }
}
