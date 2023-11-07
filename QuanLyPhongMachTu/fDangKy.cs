
﻿using DTO;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongMachTu
{
    public partial class fDangKy : Form
    {
        public fDangKy()
        {
            InitializeComponent();
        }


        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string HoTen = txt_Hoten.Text;
            string ChucVu = txt_Chucvu.Text;
            string SoDT = txt_email.Text;
            DateTime NgaySinh = dtp_ngaysinh.Value;
            string TenDangNhap = txt_tendangnhap.Text;
            string MatKhau = txt_mk.Text;
            string XacThucMatKhau = txt_xnmk.Text;
            string DiaChi = txt_diachi.Text;

            // Tạo đối tượng User để lưu thông tin đăng ký
            NGUOIDUNG newUser = new NGUOIDUNG();
            newUser.TenDangNhap = TenDangNhap;
            newUser.ChucVu = ChucVu;
            newUser.MatKhau = MatKhau;
            newUser.DiaChi = DiaChi;
            newUser.SoDT = SoDT;
            newUser.NgaySinh = NgaySinh;
            newUser.TenNguoiDung = HoTen;
            newUser.idNhomNguoiDung = Convert.ToInt32(XacThucMatKhau);
            using (var context = new QLPMTEntities())
            {
                context.NGUOIDUNGs.Add(newUser);
                context.SaveChanges();
            }

            // Hiển thị thông báo đăng ký thành công
            MessageBox.Show("Đăng ký tài khoản thành công!");


        }

    }
}
