using Guna.UI2.WinForms;
using QuanLyPhongMachTu.UserControls;
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
using Guna.UI2.WinForms;
using BLL;

namespace QuanLyPhongMachTu
{
    public partial class Form1 : Form
    {

        BLL_DANGKY dDangKyBLL;
        public Form1()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(1890, 1060);
            this.MaximumSize = new System.Drawing.Size(1890, 1060);
        

        }
        Boolean check = true;

        private void btn_Benhnhan_Click(object sender, EventArgs e)
        {
            dDangKyBLL =  new BLL_DANGKY();
            u_danhSachKhamBenh.BringToFront();

           // u_danhSachKhamBenh.HienThiSoNguoiConLaiDangKy();

            int soNguoi = dDangKyBLL.LaySoBenhNhanTiepNhan();
            u_danhSachKhamBenh.txtSoBNtiepnhan.Text = soNguoi.ToString();
          


            ChangeNormalColorOnPanelLeft(sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Phieukhambenh_Click(object sender, EventArgs e)
        {
            u_lapPhieuKhamBenh.BringToFront();

            ChangeNormalColorOnPanelLeft(sender);

        }

        private void btn_Benh_LoaiBenh_Click(object sender, EventArgs e)
        {
            
            u_BenhLoaiBenh.BringToFront();

            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Thuoc_LoaiThuoc_Click(object sender, EventArgs e)
        {
            u_loaiThuocThuoc.BringToFront();

            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Donvi_Cachdung_Click(object sender, EventArgs e)
        {
            u_donViCachDung.BringToFront();

            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Nhapthuoc_Click(object sender, EventArgs e)
        {
            u_nhapThuoc.BringToFront();

            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            uBaoCao.BringToFront();

            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Quidinh_Click(object sender, EventArgs e)
        {
            u_thayDoiQuiDinh.BringToFront();

            ChangeNormalColorOnPanelLeft(sender);
        }

        private void btn_Taikhoan_Click(object sender, EventArgs e)
        {
            if(check == true)
            {
                uTaiKhoancs.BringToFront();
            }
            else
            {
                uTaiKhoanQLy1.BringToFront();
            }

            //DoiMau
            ChangeNormalColorOnPanelLeft(sender);
        }
        public void ChangeNormalColorOnPanelLeft(object sender)
        {
            Guna2TileButton btn = sender as Guna2TileButton;
            btn.ForeColor = Color.IndianRed;
            foreach (Guna2TileButton item in siticonePanel2.Controls)
            {
                if (item.Name != btn.Name && item.ForeColor != Color.SaddleBrown)
                {
                    Guna2TileButton btn1 = item as Guna2TileButton;
                    btn1.ForeColor = Color.SaddleBrown;
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized || this.WindowState == FormWindowState.Normal)
            {
                if (this.Width > 1890)
                    this.Width = 1890;
                if (this.Height > 1030)
                    this.Height =1030;

                if (this.Width < 400)
                    this.Width = 400;
                if (this.Height < 300)
                    this.Height = 300;
            }

        }


    }
}
