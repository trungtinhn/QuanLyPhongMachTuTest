namespace QuanLyPhongMachTu.UserControls
{
    partial class NhapThuoc
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
            this.btnXong = new Guna.UI2.WinForms.Guna2Button();
            this.txt_DonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.nup_SoLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.txt_SoPhieuNhapThuoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_SoLuongNhap = new System.Windows.Forms.Label();
            this.lbl_TenThuoc = new System.Windows.Forms.Label();
            this.lbl_DonGiaNhap = new System.Windows.Forms.Label();
            this.lbl_NgayLap = new System.Windows.Forms.Label();
            this.btn_Luu = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_SoPhieuNhapThuoc = new System.Windows.Forms.Label();
            this.gbx_PhieNnhapThuoc = new System.Windows.Forms.GroupBox();
            this.lbb_TONGTIEN = new System.Windows.Forms.Label();
            this.btn_HT = new Guna.UI2.WinForms.Guna2Button();
            this.label_tongtien = new System.Windows.Forms.Label();
            this.lbl_Phieunhapthuoc = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.cboTenThuocBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CapNhatThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btn_xoaThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_SoPhieuNhap = new System.Windows.Forms.DataGridView();
            this.lb_Tongtien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nup_SoLuongNhap)).BeginInit();
            this.gbx_PhieNnhapThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXong
            // 
            this.btnXong.BorderThickness = 1;
            this.btnXong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXong.FillColor = System.Drawing.Color.LightGray;
            this.btnXong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXong.ForeColor = System.Drawing.Color.Black;
            this.btnXong.Location = new System.Drawing.Point(195, 184);
            this.btnXong.Margin = new System.Windows.Forms.Padding(2);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(96, 39);
            this.btnXong.TabIndex = 17;
            this.btnXong.Text = "Xong";
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DonGia.DefaultText = "";
            this.txt_DonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DonGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_DonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DonGia.Location = new System.Drawing.Point(152, 174);
            this.txt_DonGia.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.PasswordChar = '\0';
            this.txt_DonGia.PlaceholderText = "";
            this.txt_DonGia.SelectedText = "";
            this.txt_DonGia.Size = new System.Drawing.Size(150, 23);
            this.txt_DonGia.TabIndex = 13;
            this.txt_DonGia.TextChanged += new System.EventHandler(this.txt_DonGia_TextChanged);
            // 
            // nup_SoLuongNhap
            // 
            this.nup_SoLuongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nup_SoLuongNhap.Location = new System.Drawing.Point(152, 127);
            this.nup_SoLuongNhap.Margin = new System.Windows.Forms.Padding(2);
            this.nup_SoLuongNhap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nup_SoLuongNhap.Name = "nup_SoLuongNhap";
            this.nup_SoLuongNhap.Size = new System.Drawing.Size(150, 23);
            this.nup_SoLuongNhap.TabIndex = 12;
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLap.Location = new System.Drawing.Point(213, 99);
            this.dtp_NgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(161, 23);
            this.dtp_NgayLap.TabIndex = 9;
            // 
            // txt_SoPhieuNhapThuoc
            // 
            this.txt_SoPhieuNhapThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoPhieuNhapThuoc.DefaultText = "";
            this.txt_SoPhieuNhapThuoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoPhieuNhapThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoPhieuNhapThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoPhieuNhapThuoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoPhieuNhapThuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoPhieuNhapThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoPhieuNhapThuoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoPhieuNhapThuoc.Location = new System.Drawing.Point(214, 45);
            this.txt_SoPhieuNhapThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoPhieuNhapThuoc.Name = "txt_SoPhieuNhapThuoc";
            this.txt_SoPhieuNhapThuoc.PasswordChar = '\0';
            this.txt_SoPhieuNhapThuoc.PlaceholderText = "";
            this.txt_SoPhieuNhapThuoc.ReadOnly = true;
            this.txt_SoPhieuNhapThuoc.SelectedText = "";
            this.txt_SoPhieuNhapThuoc.Size = new System.Drawing.Size(161, 27);
            this.txt_SoPhieuNhapThuoc.TabIndex = 6;
            // 
            // lbl_SoLuongNhap
            // 
            this.lbl_SoLuongNhap.AutoSize = true;
            this.lbl_SoLuongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoLuongNhap.Location = new System.Drawing.Point(40, 129);
            this.lbl_SoLuongNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoLuongNhap.Name = "lbl_SoLuongNhap";
            this.lbl_SoLuongNhap.Size = new System.Drawing.Size(104, 17);
            this.lbl_SoLuongNhap.TabIndex = 5;
            this.lbl_SoLuongNhap.Text = "Số lượng nhập:";
            // 
            // lbl_TenThuoc
            // 
            this.lbl_TenThuoc.AutoSize = true;
            this.lbl_TenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenThuoc.Location = new System.Drawing.Point(41, 85);
            this.lbl_TenThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenThuoc.Name = "lbl_TenThuoc";
            this.lbl_TenThuoc.Size = new System.Drawing.Size(81, 17);
            this.lbl_TenThuoc.TabIndex = 2;
            this.lbl_TenThuoc.Text = "Tên Thuốc:";
            // 
            // lbl_DonGiaNhap
            // 
            this.lbl_DonGiaNhap.AutoSize = true;
            this.lbl_DonGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DonGiaNhap.Location = new System.Drawing.Point(41, 175);
            this.lbl_DonGiaNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DonGiaNhap.Name = "lbl_DonGiaNhap";
            this.lbl_DonGiaNhap.Size = new System.Drawing.Size(97, 17);
            this.lbl_DonGiaNhap.TabIndex = 3;
            this.lbl_DonGiaNhap.Text = "Đơn giá nhập:";
            this.lbl_DonGiaNhap.Click += new System.EventHandler(this.lbl_DonGiaNhap_Click);
            // 
            // lbl_NgayLap
            // 
            this.lbl_NgayLap.AutoSize = true;
            this.lbl_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayLap.Location = new System.Drawing.Point(59, 98);
            this.lbl_NgayLap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_NgayLap.Name = "lbl_NgayLap";
            this.lbl_NgayLap.Size = new System.Drawing.Size(68, 17);
            this.lbl_NgayLap.TabIndex = 1;
            this.lbl_NgayLap.Text = "Ngày lập:";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BorderThickness = 1;
            this.btn_Luu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Luu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Luu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Luu.FillColor = System.Drawing.Color.LightGray;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Luu.ForeColor = System.Drawing.Color.Black;
            this.btn_Luu.Location = new System.Drawing.Point(361, 31);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(86, 38);
            this.btn_Luu.TabIndex = 15;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderThickness = 1;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.LightGray;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(61, 184);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbl_SoPhieuNhapThuoc
            // 
            this.lbl_SoPhieuNhapThuoc.AutoSize = true;
            this.lbl_SoPhieuNhapThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoPhieuNhapThuoc.Location = new System.Drawing.Point(59, 45);
            this.lbl_SoPhieuNhapThuoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoPhieuNhapThuoc.Name = "lbl_SoPhieuNhapThuoc";
            this.lbl_SoPhieuNhapThuoc.Size = new System.Drawing.Size(143, 17);
            this.lbl_SoPhieuNhapThuoc.TabIndex = 0;
            this.lbl_SoPhieuNhapThuoc.Text = "Số phiếu nhập thuốc:";
            // 
            // gbx_PhieNnhapThuoc
            // 
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbb_TONGTIEN);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.dtp_NgayLap);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.btn_HT);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.label_tongtien);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.btnXong);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.txt_SoPhieuNhapThuoc);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbl_NgayLap);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.lbl_SoPhieuNhapThuoc);
            this.gbx_PhieNnhapThuoc.Controls.Add(this.btnThem);
            this.gbx_PhieNnhapThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_PhieNnhapThuoc.Location = new System.Drawing.Point(156, 134);
            this.gbx_PhieNnhapThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_PhieNnhapThuoc.Name = "gbx_PhieNnhapThuoc";
            this.gbx_PhieNnhapThuoc.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_PhieNnhapThuoc.Size = new System.Drawing.Size(504, 255);
            this.gbx_PhieNnhapThuoc.TabIndex = 13;
            this.gbx_PhieNnhapThuoc.TabStop = false;
            this.gbx_PhieNnhapThuoc.Text = "Phiếu Nhập Thuốc";
            this.gbx_PhieNnhapThuoc.Enter += new System.EventHandler(this.gbx_PhieNnhapThuoc_Enter);
            // 
            // lbb_TONGTIEN
            // 

            this.lbb_TONGTIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb_TONGTIEN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbb_TONGTIEN.Location = new System.Drawing.Point(211, 149);
            this.lbb_TONGTIEN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbb_TONGTIEN.Name = "lbb_TONGTIEN";
            this.lbb_TONGTIEN.Size = new System.Drawing.Size(166, 23);
            this.lbb_TONGTIEN.TabIndex = 22;
            this.lbb_TONGTIEN.Click += new System.EventHandler(this.lbb_TONGTIEN_Click);
            // 
            // btn_HT
            // 
            this.btn_HT.BorderThickness = 1;
            this.btn_HT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_HT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_HT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_HT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_HT.FillColor = System.Drawing.Color.LightGray;
            this.btn_HT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_HT.ForeColor = System.Drawing.Color.Black;
            this.btn_HT.Location = new System.Drawing.Point(345, 184);
            this.btn_HT.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HT.Name = "btn_HT";
            this.btn_HT.Size = new System.Drawing.Size(97, 39);
            this.btn_HT.TabIndex = 17;
            this.btn_HT.Text = "Hoàn Thành";
            this.btn_HT.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_tongtien
            // 
            this.label_tongtien.AutoSize = true;
            this.label_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tongtien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label_tongtien.Location = new System.Drawing.Point(59, 149);
            this.label_tongtien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_tongtien.Name = "label_tongtien";
            this.label_tongtien.Size = new System.Drawing.Size(96, 17);
            this.label_tongtien.TabIndex = 21;
            this.label_tongtien.Text = "TỔNG TIỀN : ";
            this.label_tongtien.Click += new System.EventHandler(this.label3_Click);

            // 
            // lbl_Phieunhapthuoc
            // 
            this.lbl_Phieunhapthuoc.AutoSize = false;
            this.lbl_Phieunhapthuoc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Phieunhapthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8806F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phieunhapthuoc.ForeColor = System.Drawing.Color.Red;
            this.lbl_Phieunhapthuoc.Location = new System.Drawing.Point(610, 22);
            this.lbl_Phieunhapthuoc.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_Phieunhapthuoc.Name = "lbl_Phieunhapthuoc";
            this.lbl_Phieunhapthuoc.Size = new System.Drawing.Size(391, 46);
            this.lbl_Phieunhapthuoc.TabIndex = 12;
            this.lbl_Phieunhapthuoc.Text = "PHIẾU NHẬP THUỐC";
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(747, 447);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThuoc.MultiSelect = false;
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.ReadOnly = true;
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.RowHeadersWidth = 57;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(679, 302);
            this.dgvThuoc.TabIndex = 18;
            this.dgvThuoc.SelectionChanged += new System.EventHandler(this.dgvThuoc_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLoaiThuoc);
            this.groupBox1.Controls.Add(this.cboTenThuocBox);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_TenThuoc);
            this.groupBox1.Controls.Add(this.nup_SoLuongNhap);
            this.groupBox1.Controls.Add(this.lbl_SoLuongNhap);
            this.groupBox1.Controls.Add(this.btn_CapNhatThuoc);
            this.groupBox1.Controls.Add(this.btn_xoaThuoc);
            this.groupBox1.Controls.Add(this.btn_Luu);
            this.groupBox1.Controls.Add(this.lbl_DonGiaNhap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(734, 134);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(514, 255);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thuốc Cần Nhập";
            // 
            // cboLoaiThuoc
            // 
            this.cboLoaiThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiThuoc.FormattingEnabled = true;
            this.cboLoaiThuoc.Location = new System.Drawing.Point(152, 34);
            this.cboLoaiThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.cboLoaiThuoc.Name = "cboLoaiThuoc";
            this.cboLoaiThuoc.Size = new System.Drawing.Size(152, 24);
            this.cboLoaiThuoc.TabIndex = 17;
            this.cboLoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cboLoaiThuoc_SelectedIndexChanged);
            // 
            // cboTenThuocBox
            // 
            this.cboTenThuocBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenThuocBox.FormattingEnabled = true;
            this.cboTenThuocBox.Location = new System.Drawing.Point(153, 83);
            this.cboTenThuocBox.Margin = new System.Windows.Forms.Padding(1);
            this.cboTenThuocBox.Name = "cboTenThuocBox";
            this.cboTenThuocBox.Size = new System.Drawing.Size(152, 24);
            this.cboTenThuocBox.TabIndex = 16;
            this.cboTenThuocBox.SelectedIndexChanged += new System.EventHandler(this.cboTenThuocBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại Thuốc";
            // 
            // btn_CapNhatThuoc
            // 
            this.btn_CapNhatThuoc.BorderThickness = 1;
            this.btn_CapNhatThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhatThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_CapNhatThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_CapNhatThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_CapNhatThuoc.FillColor = System.Drawing.Color.LightGray;
            this.btn_CapNhatThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_CapNhatThuoc.ForeColor = System.Drawing.Color.Black;
            this.btn_CapNhatThuoc.Location = new System.Drawing.Point(361, 141);
            this.btn_CapNhatThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CapNhatThuoc.Name = "btn_CapNhatThuoc";
            this.btn_CapNhatThuoc.Size = new System.Drawing.Size(86, 39);
            this.btn_CapNhatThuoc.TabIndex = 15;
            this.btn_CapNhatThuoc.Text = "Cập Nhật ";
            this.btn_CapNhatThuoc.Click += new System.EventHandler(this.btn_CapNhatThuoc_Click);
            // 
            // btn_xoaThuoc
            // 
            this.btn_xoaThuoc.BorderThickness = 1;
            this.btn_xoaThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_xoaThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_xoaThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_xoaThuoc.FillColor = System.Drawing.Color.LightGray;
            this.btn_xoaThuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_xoaThuoc.ForeColor = System.Drawing.Color.Black;
            this.btn_xoaThuoc.Location = new System.Drawing.Point(361, 88);
            this.btn_xoaThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.btn_xoaThuoc.Name = "btn_xoaThuoc";
            this.btn_xoaThuoc.Size = new System.Drawing.Size(86, 38);
            this.btn_xoaThuoc.TabIndex = 15;
            this.btn_xoaThuoc.Text = "Xóa";
            this.btn_xoaThuoc.Click += new System.EventHandler(this.btn_xoaThuoc_Click);
            // 
            // dgv_SoPhieuNhap
            // 
            this.dgv_SoPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SoPhieuNhap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_SoPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SoPhieuNhap.Location = new System.Drawing.Point(39, 447);
            this.dgv_SoPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_SoPhieuNhap.MultiSelect = false;
            this.dgv_SoPhieuNhap.Name = "dgv_SoPhieuNhap";
            this.dgv_SoPhieuNhap.ReadOnly = true;
            this.dgv_SoPhieuNhap.RowHeadersVisible = false;
            this.dgv_SoPhieuNhap.RowHeadersWidth = 57;
            this.dgv_SoPhieuNhap.RowTemplate.Height = 24;
            this.dgv_SoPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SoPhieuNhap.Size = new System.Drawing.Size(659, 302);
            this.dgv_SoPhieuNhap.TabIndex = 18;
            this.dgv_SoPhieuNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SoPhieuNhap_CellContentClick);
            this.dgv_SoPhieuNhap.SelectionChanged += new System.EventHandler(this.dgv_SoPhieuNhap_SelectionChanged);
            // 
            // lb_Tongtien
            // 
            this.lb_Tongtien.AutoSize = true;
            this.lb_Tongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lb_Tongtien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_Tongtien.Location = new System.Drawing.Point(921, 347);
            this.lb_Tongtien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tongtien.Name = "lb_Tongtien";
            this.lb_Tongtien.Size = new System.Drawing.Size(0, 13);
            this.lb_Tongtien.TabIndex = 21;
            this.lb_Tongtien.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(223, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 24);
            this.label6.TabIndex = 102;
            this.label6.Text = "Danh sách phiếu nhập thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(969, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 102;
            this.label2.Text = "Danh sách thuốc nhập";
            // 
            // NhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_Tongtien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_SoPhieuNhap);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.gbx_PhieNnhapThuoc);
            this.Controls.Add(this.lbl_Phieunhapthuoc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NhapThuoc";
            this.Size = new System.Drawing.Size(1497, 824);
            this.Load += new System.EventHandler(this.NhapThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_SoLuongNhap)).EndInit();
            this.gbx_PhieNnhapThuoc.ResumeLayout(false);
            this.gbx_PhieNnhapThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SoPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnXong;
        private Guna.UI2.WinForms.Guna2TextBox txt_DonGia;
        private System.Windows.Forms.NumericUpDown nup_SoLuongNhap;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoPhieuNhapThuoc;
        private System.Windows.Forms.Label lbl_SoLuongNhap;
        private System.Windows.Forms.Label lbl_TenThuoc;
        private System.Windows.Forms.Label lbl_DonGiaNhap;
        private System.Windows.Forms.Label lbl_NgayLap;
        private Guna.UI2.WinForms.Guna2Button btn_Luu;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Label lbl_SoPhieuNhapThuoc;
        private System.Windows.Forms.GroupBox gbx_PhieNnhapThuoc;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel lbl_Phieunhapthuoc;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLoaiThuoc;
        private System.Windows.Forms.ComboBox cboTenThuocBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_CapNhatThuoc;
        private Guna.UI2.WinForms.Guna2Button btn_xoaThuoc;
        private System.Windows.Forms.DataGridView dgv_SoPhieuNhap;
        public System.Windows.Forms.Label label_tongtien;
        public System.Windows.Forms.Label lb_Tongtien;
        public System.Windows.Forms.Label lbb_TONGTIEN;
        private Guna.UI2.WinForms.Guna2Button btn_HT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
    }
}
