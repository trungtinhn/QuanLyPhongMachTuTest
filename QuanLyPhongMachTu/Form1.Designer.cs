using System.Drawing;

namespace QuanLyPhongMachTu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_QuanLyPhongMachTu = new System.Windows.Forms.Label();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            //this.panel_click = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btn_Thuoc_LoaiThuoc = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Benh_LoaiBenh = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Taikhoan = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Donvi_Cachdung = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Quidinh = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Benhnhan = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Baocao = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Nhapthuoc = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Phieukhambenh = new Guna.UI2.WinForms.Guna2TileButton();

            this.btn_Benhnhan = new Guna.UI2.WinForms.Guna2TileButton();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.Desktop.UI.WinForms.SiticonePanel();

            this.siticonePanel3 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.u_BenhLoaiBenh = new QuanLyPhongMachTu.UserControls.TraCuuBenh();
            this.u_thayDoiQuiDinh = new QuanLyPhongMachTu.UserControls.ThayDoiQuiDinh();
            this.u_nhapThuoc = new QuanLyPhongMachTu.UserControls.NhapThuoc();
            this.u_loaiThuocThuoc = new QuanLyPhongMachTu.UserControls.LoaiThuocThuoc();
            this.u_lapPhieuKhamBenh = new QuanLyPhongMachTu.UserControls.LapPhieuKhamBenh();
            this.u_hoaDonThanhToan = new QuanLyPhongMachTu.UserControls.HoaDonThanhToan();
            this.u_danhSachKhamBenh = new QuanLyPhongMachTu.UserControls.DanhSachKhamBenh();
            this.u_donViCachDung = new QuanLyPhongMachTu.UserControls.DonViCachDung();
            this.uTaiKhoanQLy1 = new QuanLyPhongMachTu.UserControls.uTaiKhoanQLy();
            this.uTaiKhoancs = new QuanLyPhongMachTu.UserControls.uTaiKhoancs();
            this.uBaoCao = new QuanLyPhongMachTu.UserControls.uBaoCao();
            this.siticonePanel1.SuspendLayout();
            //this.panel_click.SuspendLayout();
            this.siticonePanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_QuanLyPhongMachTu
            // 
            this.lbl_QuanLyPhongMachTu.AutoSize = true;
            this.lbl_QuanLyPhongMachTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.02985F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QuanLyPhongMachTu.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_QuanLyPhongMachTu.Location = new System.Drawing.Point(800, 7);
            this.lbl_QuanLyPhongMachTu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_QuanLyPhongMachTu.Name = "lbl_QuanLyPhongMachTu";
            this.lbl_QuanLyPhongMachTu.Size = new System.Drawing.Size(407, 36);
            this.lbl_QuanLyPhongMachTu.TabIndex = 0;
            this.lbl_QuanLyPhongMachTu.Text = "QUẢN LÝ PHÒNG MẠCH TƯ";
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.SandyBrown;
            this.siticonePanel1.Controls.Add(this.lbl_QuanLyPhongMachTu);
            this.siticonePanel1.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.siticonePanel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1924, 70);
            this.siticonePanel1.TabIndex = 20;
            // 
            // panel_click
            // 
           
            // 
            // btn_Thuoc_LoaiThuoc
            // 
            this.btn_Thuoc_LoaiThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thuoc_LoaiThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thuoc_LoaiThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thuoc_LoaiThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Thuoc_LoaiThuoc.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Thuoc_LoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold);
            this.btn_Thuoc_LoaiThuoc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Thuoc_LoaiThuoc.Image = global::QuanLyPhongMachTu.Properties.Resources.medicine;
            this.btn_Thuoc_LoaiThuoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Thuoc_LoaiThuoc.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Thuoc_LoaiThuoc.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Thuoc_LoaiThuoc.Location = new System.Drawing.Point(12, 254);
            this.btn_Thuoc_LoaiThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.btn_Thuoc_LoaiThuoc.Name = "btn_Thuoc_LoaiThuoc";
            this.btn_Thuoc_LoaiThuoc.Padding = new System.Windows.Forms.Padding(60, 0, 20, 20);
            this.btn_Thuoc_LoaiThuoc.Size = new System.Drawing.Size(247, 94);
            this.btn_Thuoc_LoaiThuoc.TabIndex = 14;
            this.btn_Thuoc_LoaiThuoc.Text = "Thuốc - Loại Thuốc";
            this.btn_Thuoc_LoaiThuoc.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Thuoc_LoaiThuoc.Click += new System.EventHandler(this.btn_Thuoc_LoaiThuoc_Click);
            // 
            // btn_Benh_LoaiBenh
            // 
            this.btn_Benh_LoaiBenh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benh_LoaiBenh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benh_LoaiBenh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Benh_LoaiBenh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Benh_LoaiBenh.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Benh_LoaiBenh.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Benh_LoaiBenh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Benh_LoaiBenh.Image = global::QuanLyPhongMachTu.Properties.Resources.antibody;
            this.btn_Benh_LoaiBenh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Benh_LoaiBenh.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Benh_LoaiBenh.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Benh_LoaiBenh.Location = new System.Drawing.Point(12, 164);
            this.btn_Benh_LoaiBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.btn_Benh_LoaiBenh.Name = "btn_Benh_LoaiBenh";
            this.btn_Benh_LoaiBenh.Padding = new System.Windows.Forms.Padding(60, 0, 20, 20);
            this.btn_Benh_LoaiBenh.Size = new System.Drawing.Size(247, 96);
            this.btn_Benh_LoaiBenh.TabIndex = 13;
            this.btn_Benh_LoaiBenh.Text = "Bệnh - Loại Bệnh";
            this.btn_Benh_LoaiBenh.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Benh_LoaiBenh.Click += new System.EventHandler(this.btn_Benh_LoaiBenh_Click);
            // 
            // btn_Taikhoan
            // 
            this.btn_Taikhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Taikhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Taikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Taikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Taikhoan.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Taikhoan.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Taikhoan.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Taikhoan.Image = global::QuanLyPhongMachTu.Properties.Resources.profile;
            this.btn_Taikhoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Taikhoan.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Taikhoan.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Taikhoan.Location = new System.Drawing.Point(9, 545);
            this.btn_Taikhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btn_Taikhoan.Name = "btn_Taikhoan";
            this.btn_Taikhoan.Padding = new System.Windows.Forms.Padding(45, 0, 15, 32);
            this.btn_Taikhoan.Size = new System.Drawing.Size(185, 59);
            this.btn_Taikhoan.TabIndex = 19;
            this.btn_Taikhoan.Text = "Tài Khoản";
            this.btn_Taikhoan.Click += new System.EventHandler(this.btn_Taikhoan_Click);
            // 
            // btn_Donvi_Cachdung
            // 
            this.btn_Donvi_Cachdung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Donvi_Cachdung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Donvi_Cachdung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Donvi_Cachdung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Donvi_Cachdung.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Donvi_Cachdung.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Donvi_Cachdung.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Donvi_Cachdung.Image = global::QuanLyPhongMachTu.Properties.Resources.settings;
            this.btn_Donvi_Cachdung.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Donvi_Cachdung.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Donvi_Cachdung.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Donvi_Cachdung.Location = new System.Drawing.Point(12, 342);
            this.btn_Donvi_Cachdung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.btn_Donvi_Cachdung.Name = "btn_Donvi_Cachdung";
            this.btn_Donvi_Cachdung.Padding = new System.Windows.Forms.Padding(60, 0, 20, 20);
            this.btn_Donvi_Cachdung.Size = new System.Drawing.Size(247, 94);
            this.btn_Donvi_Cachdung.TabIndex = 15;
            this.btn_Donvi_Cachdung.Text = "Đơn vị - Cách dùng";
            this.btn_Donvi_Cachdung.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Donvi_Cachdung.Click += new System.EventHandler(this.btn_Donvi_Cachdung_Click);
            // 
            // btn_Quidinh
            // 
            this.btn_Quidinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Quidinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Quidinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Quidinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Quidinh.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Quidinh.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quidinh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Quidinh.Image = global::QuanLyPhongMachTu.Properties.Resources.regulation;
            this.btn_Quidinh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Quidinh.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Quidinh.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Quidinh.Location = new System.Drawing.Point(9, 483);
            this.btn_Quidinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btn_Quidinh.Name = "btn_Quidinh";
            this.btn_Quidinh.Padding = new System.Windows.Forms.Padding(45, 0, 15, 32);
            this.btn_Quidinh.Size = new System.Drawing.Size(185, 59);
            this.btn_Quidinh.TabIndex = 18;
            this.btn_Quidinh.Text = "Qui Định";
            this.btn_Quidinh.Click += new System.EventHandler(this.btn_Quidinh_Click);
            // 
            // btn_Benhnhan
            // 
            this.btn_Benhnhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benhnhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benhnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Benhnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Benhnhan.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Benhnhan.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Benhnhan.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Benhnhan.Image = global::QuanLyPhongMachTu.Properties.Resources.male_nurse;
            this.btn_Benhnhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Benhnhan.ImageOffset = new System.Drawing.Point(0, 25);
            this.btn_Benhnhan.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Benhnhan.Location = new System.Drawing.Point(12, 0);
            this.btn_Benhnhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 1);
            this.btn_Benhnhan.Name = "btn_Benhnhan";
            this.btn_Benhnhan.Padding = new System.Windows.Forms.Padding(60, 0, 20, 39);
            this.btn_Benhnhan.Size = new System.Drawing.Size(247, 71);
            this.btn_Benhnhan.TabIndex = 2;
            this.btn_Benhnhan.Text = "Bệnh Nhân";
            this.btn_Benhnhan.Click += new System.EventHandler(this.btn_Benhnhan_Click);
            // 
            // btn_Baocao
            // 
            this.btn_Baocao.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Baocao.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Baocao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Baocao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Baocao.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Baocao.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baocao.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Baocao.Image = global::QuanLyPhongMachTu.Properties.Resources.report;
            this.btn_Baocao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Baocao.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Baocao.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Baocao.Location = new System.Drawing.Point(9, 420);
            this.btn_Baocao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btn_Baocao.Name = "btn_Baocao";
            this.btn_Baocao.Padding = new System.Windows.Forms.Padding(45, 0, 15, 32);
            this.btn_Baocao.Size = new System.Drawing.Size(185, 59);
            this.btn_Baocao.TabIndex = 17;
            this.btn_Baocao.Text = "Báo Cáo";
            this.btn_Baocao.Click += new System.EventHandler(this.btn_Baocao_Click);
            // 
            // btn_Nhapthuoc
            // 
            this.btn_Nhapthuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Nhapthuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Nhapthuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Nhapthuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Nhapthuoc.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Nhapthuoc.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nhapthuoc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Nhapthuoc.Image = global::QuanLyPhongMachTu.Properties.Resources.packaging;
            this.btn_Nhapthuoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Nhapthuoc.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Nhapthuoc.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Nhapthuoc.Location = new System.Drawing.Point(9, 358);
            this.btn_Nhapthuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btn_Nhapthuoc.Name = "btn_Nhapthuoc";
            this.btn_Nhapthuoc.Padding = new System.Windows.Forms.Padding(45, 0, 15, 32);
            this.btn_Nhapthuoc.Size = new System.Drawing.Size(185, 59);
            this.btn_Nhapthuoc.TabIndex = 16;
            this.btn_Nhapthuoc.Text = "Nhập Thuốc";
            this.btn_Nhapthuoc.Click += new System.EventHandler(this.btn_Nhapthuoc_Click);
            // 

            // btn_Donvi_Cachdung
            // 
            this.btn_Donvi_Cachdung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Donvi_Cachdung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Donvi_Cachdung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Donvi_Cachdung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Donvi_Cachdung.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Donvi_Cachdung.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Donvi_Cachdung.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Donvi_Cachdung.Image = global::QuanLyPhongMachTu.Properties.Resources.settings;
            this.btn_Donvi_Cachdung.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Donvi_Cachdung.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Donvi_Cachdung.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Donvi_Cachdung.Location = new System.Drawing.Point(9, 278);
            this.btn_Donvi_Cachdung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btn_Donvi_Cachdung.Name = "btn_Donvi_Cachdung";
            this.btn_Donvi_Cachdung.Padding = new System.Windows.Forms.Padding(45, 0, 15, 16);
            this.btn_Donvi_Cachdung.Size = new System.Drawing.Size(185, 76);
            this.btn_Donvi_Cachdung.TabIndex = 15;
            this.btn_Donvi_Cachdung.Text = "Đơn vị - Cách dùng";
            this.btn_Donvi_Cachdung.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Donvi_Cachdung.Click += new System.EventHandler(this.btn_Donvi_Cachdung_Click);
            // 
            // btn_Thuoc_LoaiThuoc
            // 
            this.btn_Thuoc_LoaiThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thuoc_LoaiThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Thuoc_LoaiThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Thuoc_LoaiThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Thuoc_LoaiThuoc.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Thuoc_LoaiThuoc.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold);
            this.btn_Thuoc_LoaiThuoc.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Thuoc_LoaiThuoc.Image = global::QuanLyPhongMachTu.Properties.Resources.medicine;
            this.btn_Thuoc_LoaiThuoc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Thuoc_LoaiThuoc.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Thuoc_LoaiThuoc.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Thuoc_LoaiThuoc.Location = new System.Drawing.Point(9, 206);
            this.btn_Thuoc_LoaiThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btn_Thuoc_LoaiThuoc.Name = "btn_Thuoc_LoaiThuoc";
            this.btn_Thuoc_LoaiThuoc.Padding = new System.Windows.Forms.Padding(45, 0, 15, 16);
            this.btn_Thuoc_LoaiThuoc.Size = new System.Drawing.Size(185, 76);
            this.btn_Thuoc_LoaiThuoc.TabIndex = 14;
            this.btn_Thuoc_LoaiThuoc.Text = "Thuốc - Loại Thuốc";
            this.btn_Thuoc_LoaiThuoc.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Thuoc_LoaiThuoc.Click += new System.EventHandler(this.btn_Thuoc_LoaiThuoc_Click);
            // 
            // btn_Benh_LoaiBenh
            // 
            this.btn_Benh_LoaiBenh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benh_LoaiBenh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benh_LoaiBenh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Benh_LoaiBenh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Benh_LoaiBenh.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Benh_LoaiBenh.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Benh_LoaiBenh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Benh_LoaiBenh.Image = global::QuanLyPhongMachTu.Properties.Resources.antibody;
            this.btn_Benh_LoaiBenh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Benh_LoaiBenh.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Benh_LoaiBenh.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Benh_LoaiBenh.Location = new System.Drawing.Point(9, 133);
            this.btn_Benh_LoaiBenh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btn_Benh_LoaiBenh.Name = "btn_Benh_LoaiBenh";
            this.btn_Benh_LoaiBenh.Padding = new System.Windows.Forms.Padding(45, 0, 15, 16);
            this.btn_Benh_LoaiBenh.Size = new System.Drawing.Size(185, 78);
            this.btn_Benh_LoaiBenh.TabIndex = 13;
            this.btn_Benh_LoaiBenh.Text = "Bệnh - Loại Bệnh";
            this.btn_Benh_LoaiBenh.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Benh_LoaiBenh.Click += new System.EventHandler(this.btn_Benh_LoaiBenh_Click);
            // 

            // btn_Phieukhambenh
            // 
            this.btn_Phieukhambenh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Phieukhambenh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Phieukhambenh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Phieukhambenh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Phieukhambenh.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Phieukhambenh.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Phieukhambenh.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Phieukhambenh.Image = global::QuanLyPhongMachTu.Properties.Resources.phieukhambenh;
            this.btn_Phieukhambenh.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Phieukhambenh.ImageOffset = new System.Drawing.Point(0, 20);
            this.btn_Phieukhambenh.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Phieukhambenh.Location = new System.Drawing.Point(9, 60);
            this.btn_Phieukhambenh.Margin = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.btn_Phieukhambenh.Name = "btn_Phieukhambenh";
            this.btn_Phieukhambenh.Padding = new System.Windows.Forms.Padding(52, 0, 15, 16);
            this.btn_Phieukhambenh.Size = new System.Drawing.Size(185, 70);
            this.btn_Phieukhambenh.TabIndex = 12;
            this.btn_Phieukhambenh.Text = "Phiếu Khám Bệnh";
            this.btn_Phieukhambenh.TextOffset = new System.Drawing.Point(0, -10);
            this.btn_Phieukhambenh.Click += new System.EventHandler(this.btn_Phieukhambenh_Click);
            // 

            // btn_Benhnhan
            // 
            this.btn_Benhnhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benhnhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Benhnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Benhnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Benhnhan.FillColor = System.Drawing.Color.BurlyWood;
            this.btn_Benhnhan.Font = new System.Drawing.Font("Segoe UI", 11.8209F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Benhnhan.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btn_Benhnhan.Image = global::QuanLyPhongMachTu.Properties.Resources.male_nurse;
            this.btn_Benhnhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Benhnhan.ImageOffset = new System.Drawing.Point(0, 25);
            this.btn_Benhnhan.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Benhnhan.Location = new System.Drawing.Point(9, 0);
            this.btn_Benhnhan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 1);
            this.btn_Benhnhan.Name = "btn_Benhnhan";
            this.btn_Benhnhan.Padding = new System.Windows.Forms.Padding(45, 0, 15, 32);
            this.btn_Benhnhan.Size = new System.Drawing.Size(185, 58);
            this.btn_Benhnhan.TabIndex = 2;
            this.btn_Benhnhan.Text = "Bệnh Nhân";
            this.btn_Benhnhan.Click += new System.EventHandler(this.btn_Benhnhan_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.SandyBrown;
            this.siticonePanel1.Controls.Add(this.lbl_QuanLyPhongMachTu);
            this.siticonePanel1.CustomBorderColor = System.Drawing.Color.SaddleBrown;
            this.siticonePanel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(1443, 57);
            this.siticonePanel1.TabIndex = 20;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.AutoScroll = true;
            this.siticonePanel2.BackColor = System.Drawing.Color.BurlyWood;
            this.siticonePanel2.Controls.Add(this.btn_Thuoc_LoaiThuoc);
            this.siticonePanel2.Controls.Add(this.btn_Benh_LoaiBenh);
            this.siticonePanel2.Controls.Add(this.btn_Taikhoan);
            this.siticonePanel2.Controls.Add(this.btn_Donvi_Cachdung);
            this.siticonePanel2.Controls.Add(this.btn_Quidinh);
            this.siticonePanel2.Controls.Add(this.btn_Benhnhan);
            this.siticonePanel2.Controls.Add(this.btn_Baocao);
            this.siticonePanel2.Controls.Add(this.btn_Nhapthuoc);
            this.siticonePanel2.Controls.Add(this.btn_Phieukhambenh);
            this.siticonePanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel2.Location = new System.Drawing.Point(0, 57);
            this.siticonePanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.Size = new System.Drawing.Size(208, 798);
            this.siticonePanel2.TabIndex = 21;
            // 

            // siticonePanel3
            // 
            this.siticonePanel3.Controls.Add(this.u_BenhLoaiBenh);
            this.siticonePanel3.Controls.Add(this.u_thayDoiQuiDinh);
            this.siticonePanel3.Controls.Add(this.u_nhapThuoc);
            this.siticonePanel3.Controls.Add(this.u_loaiThuocThuoc);
            this.siticonePanel3.Controls.Add(this.u_lapPhieuKhamBenh);
            this.siticonePanel3.Controls.Add(this.u_hoaDonThanhToan);
            this.siticonePanel3.Controls.Add(this.u_danhSachKhamBenh);
            this.siticonePanel3.Controls.Add(this.u_donViCachDung);
            this.siticonePanel3.Controls.Add(this.uTaiKhoanQLy1);
            this.siticonePanel3.Controls.Add(this.uTaiKhoancs);
            this.siticonePanel3.Controls.Add(this.uBaoCao);
            this.siticonePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel3.Location = new System.Drawing.Point(208, 57);
            this.siticonePanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.Size = new System.Drawing.Size(1235, 798);
            this.siticonePanel3.TabIndex = 22;
            // 
            // u_BenhLoaiBenh
            // 
            this.u_BenhLoaiBenh.BackColor = System.Drawing.Color.PeachPuff;
            this.u_BenhLoaiBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_BenhLoaiBenh.Location = new System.Drawing.Point(0, 0);

            this.u_BenhLoaiBenh.Margin = new System.Windows.Forms.Padding(2);
            this.u_BenhLoaiBenh.Name = "u_BenhLoaiBenh";
            this.u_BenhLoaiBenh.Size = new System.Drawing.Size(1235, 798);

            this.u_BenhLoaiBenh.TabIndex = 7;
            // 
            // u_thayDoiQuiDinh
            // 
            this.u_thayDoiQuiDinh.BackColor = System.Drawing.Color.PeachPuff;
            this.u_thayDoiQuiDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_thayDoiQuiDinh.Location = new System.Drawing.Point(0, 0);

            this.u_thayDoiQuiDinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_thayDoiQuiDinh.Name = "u_thayDoiQuiDinh";
            this.u_thayDoiQuiDinh.Size = new System.Drawing.Size(1235, 798);

            this.u_thayDoiQuiDinh.TabIndex = 6;
            // 
            // u_nhapThuoc
            // 
            this.u_nhapThuoc.BackColor = System.Drawing.Color.PeachPuff;
            this.u_nhapThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_nhapThuoc.Location = new System.Drawing.Point(0, 0);

            this.u_nhapThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_nhapThuoc.Name = "u_nhapThuoc";
            this.u_nhapThuoc.Size = new System.Drawing.Size(1235, 798);

            this.u_nhapThuoc.TabIndex = 5;
            // 
            // u_loaiThuocThuoc
            // 
            this.u_loaiThuocThuoc.AutoScroll = true;
            this.u_loaiThuocThuoc.BackColor = System.Drawing.Color.PeachPuff;
            this.u_loaiThuocThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_loaiThuocThuoc.Location = new System.Drawing.Point(0, 0);
            this.u_loaiThuocThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.u_loaiThuocThuoc.Name = "u_loaiThuocThuoc";
            this.u_loaiThuocThuoc.Size = new System.Drawing.Size(1235, 798);
            this.u_loaiThuocThuoc.TabIndex = 4;
            // 
            // u_lapPhieuKhamBenh
            // 
            this.u_lapPhieuKhamBenh.BackColor = System.Drawing.Color.PeachPuff;
            this.u_lapPhieuKhamBenh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_lapPhieuKhamBenh.Location = new System.Drawing.Point(0, 0);

            this.u_lapPhieuKhamBenh.Margin = new System.Windows.Forms.Padding(2);
            this.u_lapPhieuKhamBenh.Name = "u_lapPhieuKhamBenh";
            this.u_lapPhieuKhamBenh.Size = new System.Drawing.Size(1235, 798);

            this.u_lapPhieuKhamBenh.TabIndex = 3;
            // 
            // u_hoaDonThanhToan
            // 
            this.u_hoaDonThanhToan.BackColor = System.Drawing.Color.PeachPuff;
            this.u_hoaDonThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_hoaDonThanhToan.Location = new System.Drawing.Point(0, 0);

            this.u_hoaDonThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_hoaDonThanhToan.Name = "u_hoaDonThanhToan";
            this.u_hoaDonThanhToan.Size = new System.Drawing.Size(1235, 798);

            this.u_hoaDonThanhToan.TabIndex = 2;
            // 
            // u_danhSachKhamBenh
            // 
            this.u_danhSachKhamBenh.BackColor = System.Drawing.Color.PeachPuff;
            this.u_danhSachKhamBenh.Dock = System.Windows.Forms.DockStyle.Fill;

            this.u_danhSachKhamBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_danhSachKhamBenh.Location = new System.Drawing.Point(0, 0);
            this.u_danhSachKhamBenh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_danhSachKhamBenh.Name = "u_danhSachKhamBenh";
            this.u_danhSachKhamBenh.Size = new System.Drawing.Size(1235, 798);

            this.u_danhSachKhamBenh.TabIndex = 0;
            // 
            // u_donViCachDung
            // 
            this.u_donViCachDung.BackColor = System.Drawing.Color.PeachPuff;
            this.u_donViCachDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.u_donViCachDung.Location = new System.Drawing.Point(0, 0);

            this.u_donViCachDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.u_donViCachDung.Name = "u_donViCachDung";
            this.u_donViCachDung.Size = new System.Drawing.Size(1235, 798);

            this.u_donViCachDung.TabIndex = 1;
            // 
            // uTaiKhoanQLy1
            // 
            this.uTaiKhoanQLy1.BackColor = System.Drawing.Color.PeachPuff;
            this.uTaiKhoanQLy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uTaiKhoanQLy1.Location = new System.Drawing.Point(0, 0);

            this.uTaiKhoanQLy1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uTaiKhoanQLy1.Name = "uTaiKhoanQLy1";
            this.uTaiKhoanQLy1.Size = new System.Drawing.Size(1235, 798);

            this.uTaiKhoanQLy1.TabIndex = 10;
            // 
            // uTaiKhoancs
            // 
            this.uTaiKhoancs.BackColor = System.Drawing.Color.PeachPuff;
            this.uTaiKhoancs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uTaiKhoancs.Location = new System.Drawing.Point(0, 0);
            this.uTaiKhoancs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uTaiKhoancs.Name = "uTaiKhoancs";
            this.uTaiKhoancs.Size = new System.Drawing.Size(1235, 798);
            this.uTaiKhoancs.TabIndex = 9;
            // 
            // uBaoCao
            // 
            this.uBaoCao.BackColor = System.Drawing.Color.PeachPuff;
            this.uBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uBaoCao.Location = new System.Drawing.Point(0, 0);

            this.uBaoCao.Margin = new System.Windows.Forms.Padding(2);
            this.uBaoCao.Name = "uBaoCao";
            this.uBaoCao.Size = new System.Drawing.Size(1235, 798);

            this.uBaoCao.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1443, 855);
            this.Controls.Add(this.siticonePanel3);
            //this.Controls.Add(this.panel_click);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1889, 1047);
            this.MinimumSize = new System.Drawing.Size(1442, 829);
            this.Name = "Form1";
            this.Text = "Quản Lý Phòng Mạch ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.siticonePanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TileButton btn_Benhnhan;
        private System.Windows.Forms.Label lbl_QuanLyPhongMachTu;
        private Guna.UI2.WinForms.Guna2TileButton btn_Thuoc_LoaiThuoc;
        private Guna.UI2.WinForms.Guna2TileButton btn_Benh_LoaiBenh;
        private Guna.UI2.WinForms.Guna2TileButton btn_Phieukhambenh;
        private Guna.UI2.WinForms.Guna2TileButton btn_Donvi_Cachdung;
        private Guna.UI2.WinForms.Guna2TileButton btn_Nhapthuoc;
        private Guna.UI2.WinForms.Guna2TileButton btn_Baocao;
        private Guna.UI2.WinForms.Guna2TileButton btn_Quidinh;
        private Guna.UI2.WinForms.Guna2TileButton btn_Taikhoan;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel2;

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel3;
        private UserControls.HoaDonThanhToan u_hoaDonThanhToan;
        private UserControls.DanhSachKhamBenh u_danhSachKhamBenh;
        private UserControls.DonViCachDung u_donViCachDung;
        private UserControls.uTaiKhoanQLy uTaiKhoanQLy1;
        private UserControls.uTaiKhoancs uTaiKhoancs;
        private UserControls.uBaoCao uBaoCao;
        private UserControls.TraCuuBenh u_BenhLoaiBenh;
        private UserControls.ThayDoiQuiDinh u_thayDoiQuiDinh;
        private UserControls.NhapThuoc u_nhapThuoc;
        private UserControls.LoaiThuocThuoc u_loaiThuocThuoc;
        private UserControls.LapPhieuKhamBenh u_lapPhieuKhamBenh;
    }
}

