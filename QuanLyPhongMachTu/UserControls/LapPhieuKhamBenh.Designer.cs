namespace QuanLyPhongMachTu.UserControls
{
    partial class LapPhieuKhamBenh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapPhieuKhamBenh));
            this.dgvKB = new System.Windows.Forms.DataGridView();
            this.dgvThuoc = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrieuchungBenh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHotenBN = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.dtbNgayKB = new System.Windows.Forms.DateTimePicker();
            this.dgvDangKy = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLuuPKB = new System.Windows.Forms.Button();
            this.btnHuyPKB = new System.Windows.Forms.Button();
            this.btnSuaThuoc = new System.Windows.Forms.Button();
            this.gxb_Phieukhambenh = new System.Windows.Forms.GroupBox();
            this.cboTenBenh = new System.Windows.Forms.ComboBox();
            this.txtPhieuKhamBenh = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnThemPKB = new System.Windows.Forms.Button();
            this.gxbThuoc = new System.Windows.Forms.GroupBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.cboTenTHuoc = new System.Windows.Forms.ComboBox();
            this.btnXoaThuoc = new System.Windows.Forms.Button();
            this.cboTenLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.txtDonGiaThuoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboLoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.chkChuaLuu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkDaLuu = new Guna.UI2.WinForms.Guna2CheckBox();
            this.pnLocNgayThang = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtimeEnd = new System.Windows.Forms.DateTimePicker();
            this.dtimeStart = new System.Windows.Forms.DateTimePicker();
            this.txtLoc = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).BeginInit();
            this.gxb_Phieukhambenh.SuspendLayout();
            this.gxbThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.pnLocNgayThang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKB
            // 
            this.dgvKB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKB.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKB.Location = new System.Drawing.Point(48, 526);
            this.dgvKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKB.MultiSelect = false;
            this.dgvKB.Name = "dgvKB";
            this.dgvKB.ReadOnly = true;
            this.dgvKB.RowHeadersVisible = false;
            this.dgvKB.RowHeadersWidth = 49;
            this.dgvKB.RowTemplate.Height = 24;
            this.dgvKB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKB.Size = new System.Drawing.Size(1301, 471);
            this.dgvKB.TabIndex = 95;
            this.dgvKB.SelectionChanged += new System.EventHandler(this.dgvKB_SelectionChanged);
            // 
            // dgvThuoc
            // 
            this.dgvThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThuoc.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThuoc.Location = new System.Drawing.Point(1397, 198);
            this.dgvThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvThuoc.Name = "dgvThuoc";
            this.dgvThuoc.RowHeadersVisible = false;
            this.dgvThuoc.RowHeadersWidth = 49;
            this.dgvThuoc.RowTemplate.Height = 24;
            this.dgvThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThuoc.Size = new System.Drawing.Size(338, 831);
            this.dgvThuoc.TabIndex = 94;
            this.dgvThuoc.SelectionChanged += new System.EventHandler(this.dgvThuoc_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 80;
            this.label3.Text = "Tên Bệnh:";
            // 
            // txtTrieuchungBenh
            // 
            this.txtTrieuchungBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrieuchungBenh.Location = new System.Drawing.Point(232, 185);
            this.txtTrieuchungBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTrieuchungBenh.Multiline = true;
            this.txtTrieuchungBenh.Name = "txtTrieuchungBenh";
            this.txtTrieuchungBenh.Size = new System.Drawing.Size(252, 26);
            this.txtTrieuchungBenh.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 78;
            this.label2.Text = "Triệu chứng bệnh:";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBN.Location = new System.Drawing.Point(232, 78);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(252, 28);
            this.txtMaBN.TabIndex = 77;
            // 
            // btnThemThuoc
            // 
            this.btnThemThuoc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThemThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThuoc.Location = new System.Drawing.Point(453, 43);
            this.btnThemThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemThuoc.Name = "btnThemThuoc";
            this.btnThemThuoc.Size = new System.Drawing.Size(131, 55);
            this.btnThemThuoc.TabIndex = 75;
            this.btnThemThuoc.Text = "Thêm Thuốc";
            this.btnThemThuoc.UseVisualStyleBackColor = false;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 22);
            this.label10.TabIndex = 76;
            this.label10.Text = "Mã bệnh nhân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ngày khám bệnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 73;
            this.label1.Text = "Họ và tên:";
            // 
            // txtHotenBN
            // 
            this.txtHotenBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHotenBN.Location = new System.Drawing.Point(232, 111);
            this.txtHotenBN.Margin = new System.Windows.Forms.Padding(1);
            this.txtHotenBN.Name = "txtHotenBN";
            this.txtHotenBN.Size = new System.Drawing.Size(252, 28);
            this.txtHotenBN.TabIndex = 72;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Salmon;
            this.Title.Location = new System.Drawing.Point(656, 31);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(406, 46);
            this.Title.TabIndex = 71;
            this.Title.Text = "PHIẾU KHÁM BỆNH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtbNgayKB
            // 
            this.dtbNgayKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNgayKB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbNgayKB.Location = new System.Drawing.Point(232, 149);
            this.dtbNgayKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtbNgayKB.Name = "dtbNgayKB";
            this.dtbNgayKB.Size = new System.Drawing.Size(252, 28);
            this.dtbNgayKB.TabIndex = 98;
            // 
            // dgvDangKy
            // 
            this.dgvDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDangKy.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangKy.Location = new System.Drawing.Point(1781, 242);
            this.dgvDangKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDangKy.MultiSelect = false;
            this.dgvDangKy.Name = "dgvDangKy";
            this.dgvDangKy.ReadOnly = true;
            this.dgvDangKy.RowHeadersVisible = false;
            this.dgvDangKy.RowHeadersWidth = 49;
            this.dgvDangKy.RowTemplate.Height = 24;
            this.dgvDangKy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangKy.Size = new System.Drawing.Size(275, 787);
            this.dgvDangKy.TabIndex = 100;
            this.dgvDangKy.SelectionChanged += new System.EventHandler(this.dgvDangKy_SelectionChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCapNhat.Location = new System.Drawing.Point(1852, 188);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(91, 39);
            this.btnCapNhat.TabIndex = 106;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuuPKB
            // 
            this.btnLuuPKB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLuuPKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuPKB.Location = new System.Drawing.Point(541, 128);
            this.btnLuuPKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuuPKB.Name = "btnLuuPKB";
            this.btnLuuPKB.Size = new System.Drawing.Size(91, 42);
            this.btnLuuPKB.TabIndex = 107;
            this.btnLuuPKB.Text = "Lưu";
            this.btnLuuPKB.UseVisualStyleBackColor = false;
            this.btnLuuPKB.Click += new System.EventHandler(this.btnLuuPKB_Click);
            // 
            // btnHuyPKB
            // 
            this.btnHuyPKB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnHuyPKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPKB.Location = new System.Drawing.Point(541, 183);
            this.btnHuyPKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyPKB.Name = "btnHuyPKB";
            this.btnHuyPKB.Size = new System.Drawing.Size(91, 41);
            this.btnHuyPKB.TabIndex = 108;
            this.btnHuyPKB.Text = "Hủy";
            this.btnHuyPKB.UseVisualStyleBackColor = false;
            // 
            // btnSuaThuoc
            // 
            this.btnSuaThuoc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSuaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThuoc.Location = new System.Drawing.Point(453, 110);
            this.btnSuaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaThuoc.Name = "btnSuaThuoc";
            this.btnSuaThuoc.Size = new System.Drawing.Size(131, 52);
            this.btnSuaThuoc.TabIndex = 109;
            this.btnSuaThuoc.Text = "Sửa Thuốc";
            this.btnSuaThuoc.UseVisualStyleBackColor = false;
            this.btnSuaThuoc.Click += new System.EventHandler(this.btnSuaThuoc_Click);
            // 
            // gxb_Phieukhambenh
            // 
            this.gxb_Phieukhambenh.Controls.Add(this.cboTenBenh);
            this.gxb_Phieukhambenh.Controls.Add(this.txtPhieuKhamBenh);
            this.gxb_Phieukhambenh.Controls.Add(this.label15);
            this.gxb_Phieukhambenh.Controls.Add(this.txtHotenBN);
            this.gxb_Phieukhambenh.Controls.Add(this.label1);
            this.gxb_Phieukhambenh.Controls.Add(this.btnHuyPKB);
            this.gxb_Phieukhambenh.Controls.Add(this.label5);
            this.gxb_Phieukhambenh.Controls.Add(this.btnThemPKB);
            this.gxb_Phieukhambenh.Controls.Add(this.label10);
            this.gxb_Phieukhambenh.Controls.Add(this.btnLuuPKB);
            this.gxb_Phieukhambenh.Controls.Add(this.txtMaBN);
            this.gxb_Phieukhambenh.Controls.Add(this.label2);
            this.gxb_Phieukhambenh.Controls.Add(this.txtTrieuchungBenh);
            this.gxb_Phieukhambenh.Controls.Add(this.label3);
            this.gxb_Phieukhambenh.Controls.Add(this.dtbNgayKB);
            this.gxb_Phieukhambenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gxb_Phieukhambenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxb_Phieukhambenh.Location = new System.Drawing.Point(48, 107);
            this.gxb_Phieukhambenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gxb_Phieukhambenh.Name = "gxb_Phieukhambenh";
            this.gxb_Phieukhambenh.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gxb_Phieukhambenh.Size = new System.Drawing.Size(675, 283);
            this.gxb_Phieukhambenh.TabIndex = 110;
            this.gxb_Phieukhambenh.TabStop = false;
            this.gxb_Phieukhambenh.Text = "Phiếu Khám Bệnh";
            // 
            // cboTenBenh
            // 
            this.cboTenBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenBenh.FormattingEnabled = true;
            this.cboTenBenh.Location = new System.Drawing.Point(232, 219);
            this.cboTenBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTenBenh.Name = "cboTenBenh";
            this.cboTenBenh.Size = new System.Drawing.Size(252, 30);
            this.cboTenBenh.TabIndex = 126;
            // 
            // txtPhieuKhamBenh
            // 
            this.txtPhieuKhamBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhieuKhamBenh.Location = new System.Drawing.Point(232, 34);
            this.txtPhieuKhamBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtPhieuKhamBenh.Name = "txtPhieuKhamBenh";
            this.txtPhieuKhamBenh.ReadOnly = true;
            this.txtPhieuKhamBenh.Size = new System.Drawing.Size(252, 28);
            this.txtPhieuKhamBenh.TabIndex = 123;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(36, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 22);
            this.label15.TabIndex = 122;
            this.label15.Text = "Sổ phiếu khám bệnh:";
            // 
            // btnThemPKB
            // 
            this.btnThemPKB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnThemPKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPKB.Location = new System.Drawing.Point(541, 69);
            this.btnThemPKB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemPKB.Name = "btnThemPKB";
            this.btnThemPKB.Size = new System.Drawing.Size(91, 46);
            this.btnThemPKB.TabIndex = 107;
            this.btnThemPKB.Text = "Thêm";
            this.btnThemPKB.UseVisualStyleBackColor = false;
            this.btnThemPKB.Click += new System.EventHandler(this.btnThemPKB_Click);
            // 
            // gxbThuoc
            // 
            this.gxbThuoc.Controls.Add(this.numSoLuong);
            this.gxbThuoc.Controls.Add(this.label14);
            this.gxbThuoc.Controls.Add(this.cboTenTHuoc);
            this.gxbThuoc.Controls.Add(this.btnXoaThuoc);
            this.gxbThuoc.Controls.Add(this.btnSuaThuoc);
            this.gxbThuoc.Controls.Add(this.cboTenLoaiThuoc);
            this.gxbThuoc.Controls.Add(this.txtDonGiaThuoc);
            this.gxbThuoc.Controls.Add(this.label12);
            this.gxbThuoc.Controls.Add(this.label4);
            this.gxbThuoc.Controls.Add(this.label6);
            this.gxbThuoc.Controls.Add(this.label11);
            this.gxbThuoc.Controls.Add(this.txtThanhtien);
            this.gxbThuoc.Controls.Add(this.btnThemThuoc);
            this.gxbThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxbThuoc.Location = new System.Drawing.Point(765, 114);
            this.gxbThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.gxbThuoc.Name = "gxbThuoc";
            this.gxbThuoc.Padding = new System.Windows.Forms.Padding(4);
            this.gxbThuoc.Size = new System.Drawing.Size(625, 276);
            this.gxbThuoc.TabIndex = 111;
            this.gxbThuoc.TabStop = false;
            this.gxbThuoc.Text = "Thuốc";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(172, 110);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(236, 28);
            this.numSoLuong.TabIndex = 134;
            this.numSoLuong.ValueChanged += new System.EventHandler(this.numSoLuong_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(67, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 22);
            this.label14.TabIndex = 133;
            this.label14.Text = "Tên thuốc:";
            // 
            // cboTenTHuoc
            // 
            this.cboTenTHuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenTHuoc.FormattingEnabled = true;
            this.cboTenTHuoc.Location = new System.Drawing.Point(172, 76);
            this.cboTenTHuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTenTHuoc.Name = "cboTenTHuoc";
            this.cboTenTHuoc.Size = new System.Drawing.Size(235, 30);
            this.cboTenTHuoc.TabIndex = 132;
            this.cboTenTHuoc.SelectedIndexChanged += new System.EventHandler(this.cboTenTHuoc_SelectedIndexChanged);
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnXoaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThuoc.Location = new System.Drawing.Point(453, 170);
            this.btnXoaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(131, 48);
            this.btnXoaThuoc.TabIndex = 109;
            this.btnXoaThuoc.Text = "Xóa Thuốc";
            this.btnXoaThuoc.UseVisualStyleBackColor = false;
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // cboTenLoaiThuoc
            // 
            this.cboTenLoaiThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenLoaiThuoc.FormattingEnabled = true;
            this.cboTenLoaiThuoc.Location = new System.Drawing.Point(172, 39);
            this.cboTenLoaiThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTenLoaiThuoc.Name = "cboTenLoaiThuoc";
            this.cboTenLoaiThuoc.Size = new System.Drawing.Size(235, 30);
            this.cboTenLoaiThuoc.TabIndex = 131;
            this.cboTenLoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cboTenLoaiThuoc_SelectedIndexChanged);
            // 
            // txtDonGiaThuoc
            // 
            this.txtDonGiaThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGiaThuoc.Location = new System.Drawing.Point(172, 150);
            this.txtDonGiaThuoc.Margin = new System.Windows.Forms.Padding(1);
            this.txtDonGiaThuoc.Name = "txtDonGiaThuoc";
            this.txtDonGiaThuoc.Size = new System.Drawing.Size(235, 28);
            this.txtDonGiaThuoc.TabIndex = 130;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(84, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 22);
            this.label12.TabIndex = 129;
            this.label12.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 125;
            this.label4.Text = "Tên loại thuốc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 126;
            this.label6.Text = "Số Lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(61, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 22);
            this.label11.TabIndex = 127;
            this.label11.Text = "Thành tiền:";
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhtien.Location = new System.Drawing.Point(172, 188);
            this.txtThanhtien.Margin = new System.Windows.Forms.Padding(1);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.Size = new System.Drawing.Size(235, 28);
            this.txtThanhtien.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Salmon;
            this.label7.Location = new System.Drawing.Point(447, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(459, 31);
            this.label7.TabIndex = 71;
            this.label7.Text = "DANH SÁCH PHIẾU KHÁM BỆNH";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Salmon;
            this.label8.Location = new System.Drawing.Point(1430, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 29);
            this.label8.TabIndex = 71;
            this.label8.Text = "DANH SÁCH THUỐC";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Salmon;
            this.label16.Location = new System.Drawing.Point(1776, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(280, 29);
            this.label16.TabIndex = 71;
            this.label16.Text = "DANH SÁCH ĐĂNG KÝ";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboLoc
            // 
            this.cboLoc.BackColor = System.Drawing.Color.Transparent;
            this.cboLoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboLoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboLoc.ItemHeight = 30;
            this.cboLoc.Items.AddRange(new object[] {
            "Tất cả",
            "Ngày khám",
            "Mã bệnh nhân",
            "Tên bệnh nhân",
            "Tên bệnh"});
            this.cboLoc.Location = new System.Drawing.Point(589, 464);
            this.cboLoc.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(185, 36);
            this.cboLoc.StartIndex = 0;
            this.cboLoc.TabIndex = 113;
            this.cboLoc.SelectedIndexChanged += new System.EventHandler(this.cboLoc_SelectedIndexChanged);
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnTraCuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuu.Location = new System.Drawing.Point(831, 464);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(131, 44);
            this.btnTraCuu.TabIndex = 109;
            this.btnTraCuu.Text = "Tra Cứu";
            this.btnTraCuu.UseVisualStyleBackColor = false;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // chkChuaLuu
            // 
            this.chkChuaLuu.AutoSize = true;
            this.chkChuaLuu.Checked = true;
            this.chkChuaLuu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkChuaLuu.CheckedState.BorderRadius = 0;
            this.chkChuaLuu.CheckedState.BorderThickness = 0;
            this.chkChuaLuu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkChuaLuu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkChuaLuu.Location = new System.Drawing.Point(1047, 487);
            this.chkChuaLuu.Margin = new System.Windows.Forms.Padding(4);
            this.chkChuaLuu.Name = "chkChuaLuu";
            this.chkChuaLuu.Size = new System.Drawing.Size(80, 20);
            this.chkChuaLuu.TabIndex = 114;
            this.chkChuaLuu.Text = "Chưa lưu";
            this.chkChuaLuu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkChuaLuu.UncheckedState.BorderRadius = 0;
            this.chkChuaLuu.UncheckedState.BorderThickness = 0;
            this.chkChuaLuu.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkChuaLuu.CheckStateChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkDaLuu
            // 
            this.chkDaLuu.AutoSize = true;
            this.chkDaLuu.Checked = true;
            this.chkDaLuu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkDaLuu.CheckedState.BorderRadius = 0;
            this.chkDaLuu.CheckedState.BorderThickness = 0;
            this.chkDaLuu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkDaLuu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDaLuu.Location = new System.Drawing.Point(1167, 487);
            this.chkDaLuu.Margin = new System.Windows.Forms.Padding(4);
            this.chkDaLuu.Name = "chkDaLuu";
            this.chkDaLuu.Size = new System.Drawing.Size(66, 20);
            this.chkDaLuu.TabIndex = 115;
            this.chkDaLuu.Text = "Đã lưu";
            this.chkDaLuu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDaLuu.UncheckedState.BorderRadius = 0;
            this.chkDaLuu.UncheckedState.BorderThickness = 0;
            this.chkDaLuu.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDaLuu.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // pnLocNgayThang
            // 
            this.pnLocNgayThang.Controls.Add(this.label17);
            this.pnLocNgayThang.Controls.Add(this.label9);
            this.pnLocNgayThang.Controls.Add(this.dtimeEnd);
            this.pnLocNgayThang.Controls.Add(this.dtimeStart);
            this.pnLocNgayThang.Location = new System.Drawing.Point(48, 454);
            this.pnLocNgayThang.Margin = new System.Windows.Forms.Padding(4);
            this.pnLocNgayThang.Name = "pnLocNgayThang";
            this.pnLocNgayThang.Size = new System.Drawing.Size(513, 54);
            this.pnLocNgayThang.TabIndex = 116;
            this.pnLocNgayThang.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(263, 25);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 22);
            this.label17.TabIndex = 3;
            this.label17.Text = "Đến ngày";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Từ ngày ";
            // 
            // dtimeEnd
            // 
            this.dtimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeEnd.Location = new System.Drawing.Point(356, 17);
            this.dtimeEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtimeEnd.Name = "dtimeEnd";
            this.dtimeEnd.Size = new System.Drawing.Size(152, 28);
            this.dtimeEnd.TabIndex = 1;
            // 
            // dtimeStart
            // 
            this.dtimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtimeStart.Location = new System.Drawing.Point(103, 16);
            this.dtimeStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtimeStart.Name = "dtimeStart";
            this.dtimeStart.Size = new System.Drawing.Size(143, 28);
            this.dtimeStart.TabIndex = 0;
            // 
            // txtLoc
            // 
            this.txtLoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoc.DefaultText = "";
            this.txtLoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoc.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtLoc.IconLeft")));
            this.txtLoc.Location = new System.Drawing.Point(48, 464);
            this.txtLoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.PasswordChar = '\0';
            this.txtLoc.PlaceholderText = "";
            this.txtLoc.SelectedText = "";
            this.txtLoc.Size = new System.Drawing.Size(344, 44);
            this.txtLoc.TabIndex = 112;
            // 
            // LapPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.chkDaLuu);
            this.Controls.Add(this.chkChuaLuu);
            this.Controls.Add(this.cboLoc);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.gxbThuoc);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.gxb_Phieukhambenh);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dgvDangKy);
            this.Controls.Add(this.dgvKB);
            this.Controls.Add(this.dgvThuoc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pnLocNgayThang);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LapPhieuKhamBenh";
            this.Size = new System.Drawing.Size(2246, 1100);
            this.Load += new System.EventHandler(this.LapPhieuKhamBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).EndInit();
            this.gxb_Phieukhambenh.ResumeLayout(false);
            this.gxb_Phieukhambenh.PerformLayout();
            this.gxbThuoc.ResumeLayout(false);
            this.gxbThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.pnLocNgayThang.ResumeLayout(false);
            this.pnLocNgayThang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvKB;
        private System.Windows.Forms.DataGridView dgvThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrieuchungBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotenBN;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.DateTimePicker dtbNgayKB;
        private System.Windows.Forms.DataGridView dgvDangKy;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLuuPKB;
        private System.Windows.Forms.Button btnHuyPKB;
        private System.Windows.Forms.Button btnSuaThuoc;
        private System.Windows.Forms.GroupBox gxb_Phieukhambenh;
        private System.Windows.Forms.TextBox txtPhieuKhamBenh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboTenBenh;
        private System.Windows.Forms.GroupBox gxbThuoc;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboTenTHuoc;
        private System.Windows.Forms.ComboBox cboTenLoaiThuoc;
        private System.Windows.Forms.TextBox txtDonGiaThuoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.Button btnXoaThuoc;
        private System.Windows.Forms.Button btnThemPKB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtLoc;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoc;
        private System.Windows.Forms.Button btnTraCuu;
        private Guna.UI2.WinForms.Guna2CheckBox chkChuaLuu;
        private Guna.UI2.WinForms.Guna2CheckBox chkDaLuu;
        private System.Windows.Forms.Panel pnLocNgayThang;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtimeEnd;
        private System.Windows.Forms.DateTimePicker dtimeStart;
    }
}
