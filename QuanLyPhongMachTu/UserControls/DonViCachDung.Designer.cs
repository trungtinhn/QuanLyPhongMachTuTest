using System;

namespace QuanLyPhongMachTu.UserControls
{
    partial class DonViCachDung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ThongTinCachDung = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.txt_Tencachdung = new System.Windows.Forms.TextBox();
            this.txt_Macachdung_Search = new System.Windows.Forms.TextBox();
            this.lbl_Tencachdung = new System.Windows.Forms.Label();
            this.btn_KhongLuu_Cachdung = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoa_Cachdung = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Tracuu_Cachdung = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them_Cachdung = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Capnhat_Cachdung = new Guna.UI2.WinForms.Guna2Button();
            this.gbx_Thongtincachdung = new System.Windows.Forms.GroupBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_MaCachDung = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Macachdung = new System.Windows.Forms.Label();
            this.lbl_dsCachdung = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgv_CachDung = new System.Windows.Forms.DataGridView();
            this.lbl_dsdv = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgv_DonVi = new System.Windows.Forms.DataGridView();
            this.txt_TenDonVi = new System.Windows.Forms.TextBox();
            this.txt_MaDonVi_Tracuu = new System.Windows.Forms.TextBox();
            this.lbl_Tendonvi = new System.Windows.Forms.Label();
            this.lbl_MaDonVi = new System.Windows.Forms.Label();
            this.btn_Khongluu_dv = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Tracuu_dv = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them_dv = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Capnhat_dv = new Guna.UI2.WinForms.Guna2Button();
            this.gbx_donvi = new System.Windows.Forms.GroupBox();
            this.txt_ID2 = new System.Windows.Forms.TextBox();
            this.txt_MaDonVi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Thongtindonvi = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gbx_Thongtincachdung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CachDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonVi)).BeginInit();
            this.gbx_donvi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ThongTinCachDung
            // 
            this.lbl_ThongTinCachDung.AutoSize = false;
            this.lbl_ThongTinCachDung.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ThongTinCachDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongTinCachDung.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_ThongTinCachDung.Location = new System.Drawing.Point(494, 475);
            this.lbl_ThongTinCachDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_ThongTinCachDung.Name = "lbl_ThongTinCachDung";
            this.lbl_ThongTinCachDung.Size = new System.Drawing.Size(391, 46);
            this.lbl_ThongTinCachDung.TabIndex = 46;
            this.lbl_ThongTinCachDung.Text = "THÔNG TIN CÁCH DÙNG";
            // 
            // txt_Tencachdung
            // 
            this.txt_Tencachdung.Location = new System.Drawing.Point(243, 147);
            this.txt_Tencachdung.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tencachdung.Name = "txt_Tencachdung";
            this.txt_Tencachdung.Size = new System.Drawing.Size(189, 20);
            this.txt_Tencachdung.TabIndex = 3;
            // 
            // txt_Macachdung_Search
            // 
            this.txt_Macachdung_Search.Location = new System.Drawing.Point(1329, 1062);
            this.txt_Macachdung_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Macachdung_Search.Name = "txt_Macachdung_Search";
            this.txt_Macachdung_Search.Size = new System.Drawing.Size(130, 20);
            this.txt_Macachdung_Search.TabIndex = 2;
            this.txt_Macachdung_Search.TextChanged += new System.EventHandler(this.txt_Macachdung_TextChanged);
            // 
            // lbl_Tencachdung
            // 
            this.lbl_Tencachdung.AutoSize = true;
            this.lbl_Tencachdung.Location = new System.Drawing.Point(65, 147);
            this.lbl_Tencachdung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tencachdung.Name = "lbl_Tencachdung";
            this.lbl_Tencachdung.Size = new System.Drawing.Size(86, 13);
            this.lbl_Tencachdung.TabIndex = 1;
            this.lbl_Tencachdung.Text = "Tên Cách Dùng:";
            // 
            // btn_KhongLuu_Cachdung
            // 
            this.btn_KhongLuu_Cachdung.BorderThickness = 1;
            this.btn_KhongLuu_Cachdung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_KhongLuu_Cachdung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_KhongLuu_Cachdung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_KhongLuu_Cachdung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_KhongLuu_Cachdung.FillColor = System.Drawing.Color.LightGray;
            this.btn_KhongLuu_Cachdung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_KhongLuu_Cachdung.ForeColor = System.Drawing.Color.Black;
            this.btn_KhongLuu_Cachdung.Location = new System.Drawing.Point(733, 783);
            this.btn_KhongLuu_Cachdung.Margin = new System.Windows.Forms.Padding(4);
            this.btn_KhongLuu_Cachdung.Name = "btn_KhongLuu_Cachdung";
            this.btn_KhongLuu_Cachdung.Size = new System.Drawing.Size(117, 37);
            this.btn_KhongLuu_Cachdung.TabIndex = 53;
            this.btn_KhongLuu_Cachdung.Text = "Không Lưu";
            this.btn_KhongLuu_Cachdung.Click += new System.EventHandler(this.btn_KhongLuu_Cachdung_Click);
            // 
            // btn_xoa_Cachdung
            // 
            this.btn_xoa_Cachdung.BorderThickness = 1;
            this.btn_xoa_Cachdung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa_Cachdung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoa_Cachdung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoa_Cachdung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoa_Cachdung.FillColor = System.Drawing.Color.LightGray;
            this.btn_xoa_Cachdung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoa_Cachdung.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa_Cachdung.Location = new System.Drawing.Point(733, 1018);
            this.btn_xoa_Cachdung.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa_Cachdung.Name = "btn_xoa_Cachdung";
            this.btn_xoa_Cachdung.Size = new System.Drawing.Size(117, 37);
            this.btn_xoa_Cachdung.TabIndex = 52;
            this.btn_xoa_Cachdung.Text = "Xóa";
            this.btn_xoa_Cachdung.Click += new System.EventHandler(this.btn_xoa_Cachdung_Click);
            // 
            // btn_Tracuu_Cachdung
            // 
            this.btn_Tracuu_Cachdung.BorderThickness = 1;
            this.btn_Tracuu_Cachdung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Tracuu_Cachdung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Tracuu_Cachdung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Tracuu_Cachdung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Tracuu_Cachdung.FillColor = System.Drawing.Color.LightGray;
            this.btn_Tracuu_Cachdung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Tracuu_Cachdung.ForeColor = System.Drawing.Color.Black;
            this.btn_Tracuu_Cachdung.Location = new System.Drawing.Point(1176, 1121);
            this.btn_Tracuu_Cachdung.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tracuu_Cachdung.Name = "btn_Tracuu_Cachdung";
            this.btn_Tracuu_Cachdung.Size = new System.Drawing.Size(138, 44);
            this.btn_Tracuu_Cachdung.TabIndex = 51;
            this.btn_Tracuu_Cachdung.Text = "Tra Cứu";
            this.btn_Tracuu_Cachdung.Click += new System.EventHandler(this.btn_Tracuu_Cachdung_Click);
            // 
            // btn_Them_Cachdung
            // 
            this.btn_Them_Cachdung.BorderThickness = 1;
            this.btn_Them_Cachdung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them_Cachdung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them_Cachdung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them_Cachdung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them_Cachdung.FillColor = System.Drawing.Color.LightGray;
            this.btn_Them_Cachdung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_Cachdung.ForeColor = System.Drawing.Color.Black;
            this.btn_Them_Cachdung.Location = new System.Drawing.Point(733, 900);
            this.btn_Them_Cachdung.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them_Cachdung.Name = "btn_Them_Cachdung";
            this.btn_Them_Cachdung.Size = new System.Drawing.Size(117, 37);
            this.btn_Them_Cachdung.TabIndex = 50;
            this.btn_Them_Cachdung.Text = "Thêm";
            this.btn_Them_Cachdung.Click += new System.EventHandler(this.btn_Them_Cachdung_Click);
            // 
            // btn_Capnhat_Cachdung
            // 
            this.btn_Capnhat_Cachdung.BorderThickness = 1;
            this.btn_Capnhat_Cachdung.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Capnhat_Cachdung.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Capnhat_Cachdung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Capnhat_Cachdung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Capnhat_Cachdung.FillColor = System.Drawing.Color.LightGray;
            this.btn_Capnhat_Cachdung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Capnhat_Cachdung.ForeColor = System.Drawing.Color.Black;
            this.btn_Capnhat_Cachdung.Location = new System.Drawing.Point(188, 1018);
            this.btn_Capnhat_Cachdung.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Capnhat_Cachdung.Name = "btn_Capnhat_Cachdung";
            this.btn_Capnhat_Cachdung.Size = new System.Drawing.Size(109, 37);
            this.btn_Capnhat_Cachdung.TabIndex = 49;
            this.btn_Capnhat_Cachdung.Text = "Cập Nhật";
            this.btn_Capnhat_Cachdung.Click += new System.EventHandler(this.btn_Capnhat_Cachdung_Click);
            // 
            // gbx_Thongtincachdung
            // 
            this.gbx_Thongtincachdung.Controls.Add(this.txt_Tencachdung);
            this.gbx_Thongtincachdung.Controls.Add(this.txt_ID);
            this.gbx_Thongtincachdung.Controls.Add(this.txt_MaCachDung);
            this.gbx_Thongtincachdung.Controls.Add(this.ID);
            this.gbx_Thongtincachdung.Controls.Add(this.label2);
            this.gbx_Thongtincachdung.Controls.Add(this.lbl_Tencachdung);
            this.gbx_Thongtincachdung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_Thongtincachdung.Location = new System.Drawing.Point(188, 783);
            this.gbx_Thongtincachdung.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_Thongtincachdung.Name = "gbx_Thongtincachdung";
            this.gbx_Thongtincachdung.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_Thongtincachdung.Size = new System.Drawing.Size(512, 196);
            this.gbx_Thongtincachdung.TabIndex = 47;
            this.gbx_Thongtincachdung.TabStop = false;
            this.gbx_Thongtincachdung.Text = "Thông Tin Cách Dùng";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(133, 24);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(93, 20);
            this.txt_ID.TabIndex = 2;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_Macachdung_TextChanged);
            // 
            // txt_MaCachDung
            // 
            this.txt_MaCachDung.Location = new System.Drawing.Point(243, 95);
            this.txt_MaCachDung.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaCachDung.Name = "txt_MaCachDung";
            this.txt_MaCachDung.ReadOnly = true;
            this.txt_MaCachDung.Size = new System.Drawing.Size(189, 20);
            this.txt_MaCachDung.TabIndex = 2;
            this.txt_MaCachDung.TextChanged += new System.EventHandler(this.txt_Macachdung_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(88, 27);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Cách Dùng:";
            // 
            // lbl_Macachdung
            // 
            this.lbl_Macachdung.AutoSize = true;
            this.lbl_Macachdung.Location = new System.Drawing.Point(1171, 1062);
            this.lbl_Macachdung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Macachdung.Name = "lbl_Macachdung";
            this.lbl_Macachdung.Size = new System.Drawing.Size(82, 13);
            this.lbl_Macachdung.TabIndex = 0;
            this.lbl_Macachdung.Text = "Mã Cách Dùng:";
            // 
            // lbl_dsCachdung
            // 
            this.lbl_dsCachdung.AutoSize = false;
            this.lbl_dsCachdung.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dsCachdung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dsCachdung.Location = new System.Drawing.Point(1181, 776);
            this.lbl_dsCachdung.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_dsCachdung.Name = "lbl_dsCachdung";
            this.lbl_dsCachdung.Size = new System.Drawing.Size(173, 21);
            this.lbl_dsCachdung.TabIndex = 55;
            this.lbl_dsCachdung.Text = "DANH SÁCH CÁCH DÙNG";
            // 
            // dgv_CachDung
            // 
            this.dgv_CachDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CachDung.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_CachDung.ColumnHeadersHeight = 32;
            this.dgv_CachDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_CachDung.Location = new System.Drawing.Point(1063, 824);
            this.dgv_CachDung.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_CachDung.Name = "dgv_CachDung";
            this.dgv_CachDung.RowHeadersVisible = false;
            this.dgv_CachDung.RowHeadersWidth = 57;
            this.dgv_CachDung.RowTemplate.Height = 24;
            this.dgv_CachDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CachDung.Size = new System.Drawing.Size(552, 225);
            this.dgv_CachDung.TabIndex = 54;
            this.dgv_CachDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CachDung_CellContentClick);
            this.dgv_CachDung.SelectionChanged += new System.EventHandler(this.dgv_CachDung_SelectionChanged);
            // 
            // lbl_dsdv
            // 
            this.lbl_dsdv.AutoSize = false;
            this.lbl_dsdv.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dsdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dsdv.Location = new System.Drawing.Point(1225, 130);
            this.lbl_dsdv.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_dsdv.Name = "lbl_dsdv";
            this.lbl_dsdv.Size = new System.Drawing.Size(137, 21);
            this.lbl_dsdv.TabIndex = 45;
            this.lbl_dsdv.Text = "DANH SÁCH ĐƠN VỊ";
            // 
            // dgv_DonVi
            // 
            this.dgv_DonVi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DonVi.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_DonVi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DonVi.Location = new System.Drawing.Point(817, 121);
            this.dgv_DonVi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DonVi.Name = "dgv_DonVi";
            this.dgv_DonVi.ReadOnly = true;
            this.dgv_DonVi.RowHeadersVisible = false;
            this.dgv_DonVi.RowHeadersWidth = 57;
            this.dgv_DonVi.RowTemplate.Height = 24;
            this.dgv_DonVi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DonVi.Size = new System.Drawing.Size(540, 225);
            this.dgv_DonVi.TabIndex = 44;
            this.dgv_DonVi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DonVi_CellContentClick);
            this.dgv_DonVi.SelectionChanged += new System.EventHandler(this.dgv_DonVi_SelectionChanged);
            // 
            // txt_TenDonVi
            // 
            this.txt_TenDonVi.Location = new System.Drawing.Point(232, 145);
            this.txt_TenDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenDonVi.Name = "txt_TenDonVi";
            this.txt_TenDonVi.Size = new System.Drawing.Size(195, 20);
            this.txt_TenDonVi.TabIndex = 3;
            // 
            // txt_MaDonVi_Tracuu
            // 
            this.txt_MaDonVi_Tracuu.Location = new System.Drawing.Point(1329, 468);
            this.txt_MaDonVi_Tracuu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaDonVi_Tracuu.Name = "txt_MaDonVi_Tracuu";
            this.txt_MaDonVi_Tracuu.Size = new System.Drawing.Size(130, 20);
            this.txt_MaDonVi_Tracuu.TabIndex = 2;
            // 
            // lbl_Tendonvi
            // 
            this.lbl_Tendonvi.AutoSize = true;
            this.lbl_Tendonvi.Location = new System.Drawing.Point(74, 150);
            this.lbl_Tendonvi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tendonvi.Name = "lbl_Tendonvi";
            this.lbl_Tendonvi.Size = new System.Drawing.Size(64, 13);
            this.lbl_Tendonvi.TabIndex = 1;
            this.lbl_Tendonvi.Text = "Tên Đơn Vị:";
            // 
            // lbl_MaDonVi
            // 
            this.lbl_MaDonVi.AutoSize = true;
            this.lbl_MaDonVi.Location = new System.Drawing.Point(1171, 468);
            this.lbl_MaDonVi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaDonVi.Name = "lbl_MaDonVi";
            this.lbl_MaDonVi.Size = new System.Drawing.Size(60, 13);
            this.lbl_MaDonVi.TabIndex = 0;
            this.lbl_MaDonVi.Text = "Mã Đơn Vị:";
            // 
            // btn_Khongluu_dv
            // 
            this.btn_Khongluu_dv.BorderThickness = 1;
            this.btn_Khongluu_dv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Khongluu_dv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Khongluu_dv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Khongluu_dv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Khongluu_dv.FillColor = System.Drawing.Color.LightGray;
            this.btn_Khongluu_dv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Khongluu_dv.ForeColor = System.Drawing.Color.Black;
            this.btn_Khongluu_dv.Location = new System.Drawing.Point(733, 212);
            this.btn_Khongluu_dv.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Khongluu_dv.Name = "btn_Khongluu_dv";
            this.btn_Khongluu_dv.Size = new System.Drawing.Size(117, 36);
            this.btn_Khongluu_dv.TabIndex = 43;
            this.btn_Khongluu_dv.Text = "Không Lưu";
            this.btn_Khongluu_dv.Click += new System.EventHandler(this.btn_Khongluu_dv_Click);
            // 
            // btn_Tracuu_dv
            // 
            this.btn_Tracuu_dv.BorderThickness = 1;
            this.btn_Tracuu_dv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Tracuu_dv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Tracuu_dv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Tracuu_dv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Tracuu_dv.FillColor = System.Drawing.Color.LightGray;
            this.btn_Tracuu_dv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Tracuu_dv.ForeColor = System.Drawing.Color.Black;
            this.btn_Tracuu_dv.Location = new System.Drawing.Point(1176, 517);
            this.btn_Tracuu_dv.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tracuu_dv.Name = "btn_Tracuu_dv";
            this.btn_Tracuu_dv.Size = new System.Drawing.Size(138, 39);
            this.btn_Tracuu_dv.TabIndex = 41;
            this.btn_Tracuu_dv.Text = "Tra Cứu";
            this.btn_Tracuu_dv.Click += new System.EventHandler(this.btn_Tracuu_dv_Click);
            // 
            // btn_Them_dv
            // 
            this.btn_Them_dv.BorderThickness = 1;
            this.btn_Them_dv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them_dv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them_dv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them_dv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them_dv.FillColor = System.Drawing.Color.LightGray;
            this.btn_Them_dv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_dv.ForeColor = System.Drawing.Color.Black;
            this.btn_Them_dv.Location = new System.Drawing.Point(733, 313);
            this.btn_Them_dv.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them_dv.Name = "btn_Them_dv";
            this.btn_Them_dv.Size = new System.Drawing.Size(117, 32);
            this.btn_Them_dv.TabIndex = 40;
            this.btn_Them_dv.Text = "Thêm";
            this.btn_Them_dv.Click += new System.EventHandler(this.btn_Them_dv_Click);
            // 
            // btn_Capnhat_dv
            // 
            this.btn_Capnhat_dv.BorderThickness = 1;
            this.btn_Capnhat_dv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Capnhat_dv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Capnhat_dv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Capnhat_dv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Capnhat_dv.FillColor = System.Drawing.Color.LightGray;
            this.btn_Capnhat_dv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Capnhat_dv.ForeColor = System.Drawing.Color.Black;
            this.btn_Capnhat_dv.Location = new System.Drawing.Point(188, 423);
            this.btn_Capnhat_dv.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Capnhat_dv.Name = "btn_Capnhat_dv";
            this.btn_Capnhat_dv.Size = new System.Drawing.Size(117, 32);
            this.btn_Capnhat_dv.TabIndex = 39;
            this.btn_Capnhat_dv.Text = "Cập Nhật";
            this.btn_Capnhat_dv.Click += new System.EventHandler(this.btn_Capnhat_dv_Click);
            // 
            // gbx_donvi
            // 
            this.gbx_donvi.Controls.Add(this.txt_TenDonVi);
            this.gbx_donvi.Controls.Add(this.txt_ID2);
            this.gbx_donvi.Controls.Add(this.txt_MaDonVi);
            this.gbx_donvi.Controls.Add(this.label3);
            this.gbx_donvi.Controls.Add(this.label1);
            this.gbx_donvi.Controls.Add(this.lbl_Tendonvi);
            this.gbx_donvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_donvi.Location = new System.Drawing.Point(269, 121);
            this.gbx_donvi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbx_donvi.Name = "gbx_donvi";
            this.gbx_donvi.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_donvi.Size = new System.Drawing.Size(537, 189);
            this.gbx_donvi.TabIndex = 37;
            this.gbx_donvi.TabStop = false;
            this.gbx_donvi.Text = "Thông Tin Đơn Vị";
            // 
            // txt_ID2
            // 
            this.txt_ID2.Location = new System.Drawing.Point(127, 28);
            this.txt_ID2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ID2.Name = "txt_ID2";
            this.txt_ID2.ReadOnly = true;
            this.txt_ID2.Size = new System.Drawing.Size(91, 20);
            this.txt_ID2.TabIndex = 2;
            // 
            // txt_MaDonVi
            // 
            this.txt_MaDonVi.Location = new System.Drawing.Point(232, 100);
            this.txt_MaDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaDonVi.Name = "txt_MaDonVi";
            this.txt_MaDonVi.ReadOnly = true;
            this.txt_MaDonVi.Size = new System.Drawing.Size(195, 20);
            this.txt_MaDonVi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Đơn Vị:";
            // 
            // lbl_Thongtindonvi
            // 
            this.lbl_Thongtindonvi.AutoSize = false;
            this.lbl_Thongtindonvi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Thongtindonvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Thongtindonvi.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_Thongtindonvi.Location = new System.Drawing.Point(486, 36);
            this.lbl_Thongtindonvi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_Thongtindonvi.Name = "lbl_Thongtindonvi";
            this.lbl_Thongtindonvi.Size = new System.Drawing.Size(391, 46);
            this.lbl_Thongtindonvi.TabIndex = 36;
            this.lbl_Thongtindonvi.Text = "THÔNG TIN ĐƠN VỊ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(733, 419);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(117, 35);
            this.guna2Button1.TabIndex = 43;
            this.guna2Button1.Text = "Xóa";
            this.guna2Button1.Click += new System.EventHandler(this.btn_XoaDV);
            // 
            // DonViCachDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.lbl_ThongTinCachDung);
            this.Controls.Add(this.txt_Macachdung_Search);
            this.Controls.Add(this.lbl_Macachdung);
            this.Controls.Add(this.txt_MaDonVi_Tracuu);
            this.Controls.Add(this.lbl_MaDonVi);
            this.Controls.Add(this.btn_KhongLuu_Cachdung);
            this.Controls.Add(this.btn_xoa_Cachdung);
            this.Controls.Add(this.btn_Tracuu_Cachdung);
            this.Controls.Add(this.btn_Them_Cachdung);
            this.Controls.Add(this.btn_Capnhat_Cachdung);
            this.Controls.Add(this.gbx_Thongtincachdung);
            this.Controls.Add(this.lbl_dsCachdung);
            this.Controls.Add(this.dgv_CachDung);
            this.Controls.Add(this.lbl_dsdv);
            this.Controls.Add(this.dgv_DonVi);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_Khongluu_dv);
            this.Controls.Add(this.btn_Tracuu_dv);
            this.Controls.Add(this.btn_Them_dv);
            this.Controls.Add(this.btn_Capnhat_dv);
            this.Controls.Add(this.gbx_donvi);
            this.Controls.Add(this.lbl_Thongtindonvi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DonViCachDung";
            this.Size = new System.Drawing.Size(1455, 850);
            this.Load += new System.EventHandler(this.DonViCachDung_Load);
            this.gbx_Thongtincachdung.ResumeLayout(false);
            this.gbx_Thongtincachdung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CachDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DonVi)).EndInit();
            this.gbx_donvi.ResumeLayout(false);
            this.gbx_donvi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lbl_ThongTinCachDung;
        private System.Windows.Forms.TextBox txt_Tencachdung;
        private System.Windows.Forms.TextBox txt_Macachdung_Search;
        private System.Windows.Forms.Label lbl_Tencachdung;
        private Guna.UI2.WinForms.Guna2Button btn_KhongLuu_Cachdung;
        private Guna.UI2.WinForms.Guna2Button btn_xoa_Cachdung;
        private Guna.UI2.WinForms.Guna2Button btn_Tracuu_Cachdung;
        private Guna.UI2.WinForms.Guna2Button btn_Them_Cachdung;
        private Guna.UI2.WinForms.Guna2Button btn_Capnhat_Cachdung;
        private System.Windows.Forms.GroupBox gbx_Thongtincachdung;
        private System.Windows.Forms.Label lbl_Macachdung;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_dsCachdung;
        private System.Windows.Forms.DataGridView dgv_CachDung;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbl_dsdv;
        private System.Windows.Forms.DataGridView dgv_DonVi;
        private System.Windows.Forms.TextBox txt_TenDonVi;
        private System.Windows.Forms.TextBox txt_MaDonVi_Tracuu;
        private System.Windows.Forms.Label lbl_Tendonvi;
        private System.Windows.Forms.Label lbl_MaDonVi;
        private Guna.UI2.WinForms.Guna2Button btn_Khongluu_dv;
        private Guna.UI2.WinForms.Guna2Button btn_Tracuu_dv;
        private Guna.UI2.WinForms.Guna2Button btn_Them_dv;
        private Guna.UI2.WinForms.Guna2Button btn_Capnhat_dv;
        private System.Windows.Forms.GroupBox gbx_donvi;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lbl_Thongtindonvi;
        private System.Windows.Forms.TextBox txt_MaDonVi;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TextBox txt_MaCachDung;    
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txt_ID2;
        private System.Windows.Forms.Label label3;

        public EventHandler txt_TenDonVi_TextChanged { get; private set; }
    }
}
