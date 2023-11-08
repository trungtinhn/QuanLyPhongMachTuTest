namespace QuanLyPhongMachTu.UserControls
{
    partial class TraCuuBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraCuuBenh));
            this.dgvLoaiBenh = new System.Windows.Forms.DataGridView();
            this.txtMaLoaiBenh = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoaiBenh = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhatLoaiBenh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaBenh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenBenh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTrieuChungBenh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvBenh = new System.Windows.Forms.DataGridView();
            this.btnCapNhatBenh = new System.Windows.Forms.Button();
            this.btnXoaBenh = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThemBenh = new System.Windows.Forms.Button();
            this.btnKhongLuuBenh = new System.Windows.Forms.Button();
            this.gxb_Thongtinloaibenh = new System.Windows.Forms.GroupBox();
            this.gxb_Thontinbenh = new System.Windows.Forms.GroupBox();
            this.cboTenLoaiBenh = new System.Windows.Forms.ComboBox();
            this.cboTenTHuoc = new System.Windows.Forms.ComboBox();
            this.cboTenLoaiThuoc = new System.Windows.Forms.ComboBox();
            this.txtTraCuuLoaiBenh = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboTraCuuLoaiBenh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTraCuuLoaiBenh = new System.Windows.Forms.Button();
            this.btnTraCuuBenh = new System.Windows.Forms.Button();
            this.txtTraCuuBenh = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboTraCuuBenh = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenh)).BeginInit();
            this.gxb_Thongtinloaibenh.SuspendLayout();
            this.gxb_Thontinbenh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLoaiBenh
            // 
            this.dgvLoaiBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiBenh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLoaiBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvLoaiBenh.Location = new System.Drawing.Point(779, 144);
            this.dgvLoaiBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLoaiBenh.Name = "dgvLoaiBenh";
            this.dgvLoaiBenh.ReadOnly = true;
            this.dgvLoaiBenh.RowHeadersVisible = false;
            this.dgvLoaiBenh.RowHeadersWidth = 49;
            this.dgvLoaiBenh.RowTemplate.Height = 24;
            this.dgvLoaiBenh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiBenh.Size = new System.Drawing.Size(1041, 290);
            this.dgvLoaiBenh.TabIndex = 68;
            this.dgvLoaiBenh.SelectionChanged += new System.EventHandler(this.dgvLoaiBenh_SelectionChanged);
            // 
            // txtMaLoaiBenh
            // 
            this.txtMaLoaiBenh.Location = new System.Drawing.Point(217, 44);
            this.txtMaLoaiBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaLoaiBenh.Name = "txtMaLoaiBenh";
            this.txtMaLoaiBenh.ReadOnly = true;
            this.txtMaLoaiBenh.Size = new System.Drawing.Size(273, 28);
            this.txtMaLoaiBenh.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 22);
            this.label10.TabIndex = 65;
            this.label10.Text = "Mã loại bệnh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tên loại bệnh:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTenLoaiBenh
            // 
            this.txtTenLoaiBenh.Location = new System.Drawing.Point(217, 102);
            this.txtTenLoaiBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenLoaiBenh.Name = "txtTenLoaiBenh";
            this.txtTenLoaiBenh.Size = new System.Drawing.Size(273, 28);
            this.txtTenLoaiBenh.TabIndex = 63;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Salmon;
            this.Title.Location = new System.Drawing.Point(771, 30);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(481, 46);
            this.Title.TabIndex = 62;
            this.Title.Text = "THÔNG TIN LOẠI BỆNH";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightGray;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(441, 334);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 47);
            this.btnXoa.TabIndex = 69;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhatLoaiBenh
            // 
            this.btnCapNhatLoaiBenh.BackColor = System.Drawing.Color.LightGray;
            this.btnCapNhatLoaiBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiBenh.Location = new System.Drawing.Point(276, 334);
            this.btnCapNhatLoaiBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatLoaiBenh.Name = "btnCapNhatLoaiBenh";
            this.btnCapNhatLoaiBenh.Size = new System.Drawing.Size(113, 43);
            this.btnCapNhatLoaiBenh.TabIndex = 70;
            this.btnCapNhatLoaiBenh.Text = "Cập nhật";
            this.btnCapNhatLoaiBenh.UseVisualStyleBackColor = false;
            this.btnCapNhatLoaiBenh.Click += new System.EventHandler(this.btnCapNhatLoaiBenh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(812, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 46);
            this.label2.TabIndex = 71;
            this.label2.Text = "THÔNG TIN BỆNH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMaBenh
            // 
            this.txtMaBenh.Location = new System.Drawing.Point(188, 28);
            this.txtMaBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtMaBenh.Name = "txtMaBenh";
            this.txtMaBenh.ReadOnly = true;
            this.txtMaBenh.Size = new System.Drawing.Size(201, 28);
            this.txtMaBenh.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 74;
            this.label3.Text = "Mã bệnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 22);
            this.label4.TabIndex = 73;
            this.label4.Text = "Tên bệnh:";
            // 
            // txtTenBenh
            // 
            this.txtTenBenh.Location = new System.Drawing.Point(188, 71);
            this.txtTenBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTenBenh.Name = "txtTenBenh";
            this.txtTenBenh.Size = new System.Drawing.Size(201, 28);
            this.txtTenBenh.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 77;
            this.label5.Text = "Triệu chứng:";
            // 
            // txtTrieuChungBenh
            // 
            this.txtTrieuChungBenh.Location = new System.Drawing.Point(188, 112);
            this.txtTrieuChungBenh.Margin = new System.Windows.Forms.Padding(1);
            this.txtTrieuChungBenh.Name = "txtTrieuChungBenh";
            this.txtTrieuChungBenh.Size = new System.Drawing.Size(201, 28);
            this.txtTrieuChungBenh.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 79;
            this.label6.Text = "Tên loại bệnh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tên thuốc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 22);
            this.label8.TabIndex = 83;
            this.label8.Text = "Tên loại thuốc:";
            // 
            // dgvBenh
            // 
            this.dgvBenh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBenh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBenh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBenh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBenh.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvBenh.Location = new System.Drawing.Point(88, 752);
            this.dgvBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvBenh.Name = "dgvBenh";
            this.dgvBenh.ReadOnly = true;
            this.dgvBenh.RowHeadersVisible = false;
            this.dgvBenh.RowHeadersWidth = 49;
            this.dgvBenh.RowTemplate.Height = 24;
            this.dgvBenh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBenh.Size = new System.Drawing.Size(1774, 290);
            this.dgvBenh.TabIndex = 84;
            this.dgvBenh.SelectionChanged += new System.EventHandler(this.dgvBenh_SelectionChanged);
            // 
            // btnCapNhatBenh
            // 
            this.btnCapNhatBenh.BackColor = System.Drawing.Color.LightGray;
            this.btnCapNhatBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatBenh.Location = new System.Drawing.Point(1203, 570);
            this.btnCapNhatBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhatBenh.Name = "btnCapNhatBenh";
            this.btnCapNhatBenh.Size = new System.Drawing.Size(117, 50);
            this.btnCapNhatBenh.TabIndex = 86;
            this.btnCapNhatBenh.Text = "Cập nhật";
            this.btnCapNhatBenh.UseVisualStyleBackColor = false;
            this.btnCapNhatBenh.Click += new System.EventHandler(this.btnCapNhatBenh_Click);
            // 
            // btnXoaBenh
            // 
            this.btnXoaBenh.BackColor = System.Drawing.Color.LightGray;
            this.btnXoaBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBenh.Location = new System.Drawing.Point(1357, 570);
            this.btnXoaBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaBenh.Name = "btnXoaBenh";
            this.btnXoaBenh.Size = new System.Drawing.Size(116, 50);
            this.btnXoaBenh.TabIndex = 87;
            this.btnXoaBenh.Text = "Xóa ";
            this.btnXoaBenh.UseVisualStyleBackColor = false;
            this.btnXoaBenh.Click += new System.EventHandler(this.btnXoaBenh_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.BackColor = System.Drawing.Color.LightGray;
            this.btnKhongLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.Location = new System.Drawing.Point(585, 330);
            this.btnKhongLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(109, 49);
            this.btnKhongLuu.TabIndex = 88;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = false;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightGray;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(117, 334);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 43);
            this.btnThem.TabIndex = 90;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThemBenh
            // 
            this.btnThemBenh.BackColor = System.Drawing.Color.LightGray;
            this.btnThemBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemBenh.Location = new System.Drawing.Point(1057, 570);
            this.btnThemBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemBenh.Name = "btnThemBenh";
            this.btnThemBenh.Size = new System.Drawing.Size(108, 50);
            this.btnThemBenh.TabIndex = 92;
            this.btnThemBenh.Text = "Thêm";
            this.btnThemBenh.UseVisualStyleBackColor = false;
            this.btnThemBenh.Click += new System.EventHandler(this.btnThemBenh_Click);
            // 
            // btnKhongLuuBenh
            // 
            this.btnKhongLuuBenh.BackColor = System.Drawing.Color.LightGray;
            this.btnKhongLuuBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuuBenh.Location = new System.Drawing.Point(1516, 570);
            this.btnKhongLuuBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhongLuuBenh.Name = "btnKhongLuuBenh";
            this.btnKhongLuuBenh.Size = new System.Drawing.Size(117, 50);
            this.btnKhongLuuBenh.TabIndex = 93;
            this.btnKhongLuuBenh.Text = "Không lưu";
            this.btnKhongLuuBenh.UseVisualStyleBackColor = false;
            this.btnKhongLuuBenh.Click += new System.EventHandler(this.btnKhongLuuBenh_Click);
            // 
            // gxb_Thongtinloaibenh
            // 
            this.gxb_Thongtinloaibenh.BackColor = System.Drawing.Color.PeachPuff;
            this.gxb_Thongtinloaibenh.Controls.Add(this.txtTenLoaiBenh);
            this.gxb_Thongtinloaibenh.Controls.Add(this.label1);
            this.gxb_Thongtinloaibenh.Controls.Add(this.label10);
            this.gxb_Thongtinloaibenh.Controls.Add(this.txtMaLoaiBenh);
            this.gxb_Thongtinloaibenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxb_Thongtinloaibenh.Location = new System.Drawing.Point(117, 144);
            this.gxb_Thongtinloaibenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gxb_Thongtinloaibenh.Name = "gxb_Thongtinloaibenh";
            this.gxb_Thongtinloaibenh.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gxb_Thongtinloaibenh.Size = new System.Drawing.Size(577, 166);
            this.gxb_Thongtinloaibenh.TabIndex = 95;
            this.gxb_Thongtinloaibenh.TabStop = false;
            this.gxb_Thongtinloaibenh.Text = "Thông Tin Loại Bệnh";
            // 
            // gxb_Thontinbenh
            // 
            this.gxb_Thontinbenh.Controls.Add(this.cboTenLoaiBenh);
            this.gxb_Thontinbenh.Controls.Add(this.cboTenTHuoc);
            this.gxb_Thontinbenh.Controls.Add(this.cboTenLoaiThuoc);
            this.gxb_Thontinbenh.Controls.Add(this.label7);
            this.gxb_Thontinbenh.Controls.Add(this.txtTenBenh);
            this.gxb_Thontinbenh.Controls.Add(this.label4);
            this.gxb_Thontinbenh.Controls.Add(this.label3);
            this.gxb_Thontinbenh.Controls.Add(this.txtMaBenh);
            this.gxb_Thontinbenh.Controls.Add(this.txtTrieuChungBenh);
            this.gxb_Thontinbenh.Controls.Add(this.label5);
            this.gxb_Thontinbenh.Controls.Add(this.label6);
            this.gxb_Thontinbenh.Controls.Add(this.label8);
            this.gxb_Thontinbenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gxb_Thontinbenh.Location = new System.Drawing.Point(88, 522);
            this.gxb_Thontinbenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gxb_Thontinbenh.Name = "gxb_Thontinbenh";
            this.gxb_Thontinbenh.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gxb_Thontinbenh.Size = new System.Drawing.Size(916, 158);
            this.gxb_Thontinbenh.TabIndex = 96;
            this.gxb_Thontinbenh.TabStop = false;
            this.gxb_Thontinbenh.Text = "Thông Tin Bệnh";
            // 
            // cboTenLoaiBenh
            // 
            this.cboTenLoaiBenh.FormattingEnabled = true;
            this.cboTenLoaiBenh.Location = new System.Drawing.Point(587, 110);
            this.cboTenLoaiBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTenLoaiBenh.Name = "cboTenLoaiBenh";
            this.cboTenLoaiBenh.Size = new System.Drawing.Size(195, 30);
            this.cboTenLoaiBenh.TabIndex = 119;
            // 
            // cboTenTHuoc
            // 
            this.cboTenTHuoc.FormattingEnabled = true;
            this.cboTenTHuoc.Location = new System.Drawing.Point(587, 69);
            this.cboTenTHuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTenTHuoc.Name = "cboTenTHuoc";
            this.cboTenTHuoc.Size = new System.Drawing.Size(195, 30);
            this.cboTenTHuoc.TabIndex = 118;
            // 
            // cboTenLoaiThuoc
            // 
            this.cboTenLoaiThuoc.FormattingEnabled = true;
            this.cboTenLoaiThuoc.Location = new System.Drawing.Point(587, 23);
            this.cboTenLoaiThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTenLoaiThuoc.Name = "cboTenLoaiThuoc";
            this.cboTenLoaiThuoc.Size = new System.Drawing.Size(195, 30);
            this.cboTenLoaiThuoc.TabIndex = 117;
            this.cboTenLoaiThuoc.SelectedIndexChanged += new System.EventHandler(this.cboTenLoaiThuoc_SelectedIndexChanged);
            // 
            // txtTraCuuLoaiBenh
            // 
            this.txtTraCuuLoaiBenh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTraCuuLoaiBenh.DefaultText = "";
            this.txtTraCuuLoaiBenh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTraCuuLoaiBenh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTraCuuLoaiBenh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuuLoaiBenh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuuLoaiBenh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuuLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTraCuuLoaiBenh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuuLoaiBenh.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTraCuuLoaiBenh.IconLeft")));
            this.txtTraCuuLoaiBenh.Location = new System.Drawing.Point(899, 82);
            this.txtTraCuuLoaiBenh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTraCuuLoaiBenh.Name = "txtTraCuuLoaiBenh";
            this.txtTraCuuLoaiBenh.PasswordChar = '\0';
            this.txtTraCuuLoaiBenh.PlaceholderText = "Nhập loại bệnh";
            this.txtTraCuuLoaiBenh.SelectedText = "";
            this.txtTraCuuLoaiBenh.Size = new System.Drawing.Size(267, 44);
            this.txtTraCuuLoaiBenh.TabIndex = 97;
            // 
            // cboTraCuuLoaiBenh
            // 
            this.cboTraCuuLoaiBenh.BackColor = System.Drawing.Color.Transparent;
            this.cboTraCuuLoaiBenh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTraCuuLoaiBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTraCuuLoaiBenh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTraCuuLoaiBenh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTraCuuLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTraCuuLoaiBenh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTraCuuLoaiBenh.ItemHeight = 30;
            this.cboTraCuuLoaiBenh.Items.AddRange(new object[] {
            "Tất cả",
            "Mã loại bệnh",
            "Tên loại bệnh"});
            this.cboTraCuuLoaiBenh.Location = new System.Drawing.Point(1243, 82);
            this.cboTraCuuLoaiBenh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTraCuuLoaiBenh.Name = "cboTraCuuLoaiBenh";
            this.cboTraCuuLoaiBenh.Size = new System.Drawing.Size(204, 36);
            this.cboTraCuuLoaiBenh.StartIndex = 0;
            this.cboTraCuuLoaiBenh.TabIndex = 98;
            // 
            // btnTraCuuLoaiBenh
            // 
            this.btnTraCuuLoaiBenh.BackColor = System.Drawing.Color.LightGray;
            this.btnTraCuuLoaiBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuLoaiBenh.Location = new System.Drawing.Point(1541, 82);
            this.btnTraCuuLoaiBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuuLoaiBenh.Name = "btnTraCuuLoaiBenh";
            this.btnTraCuuLoaiBenh.Size = new System.Drawing.Size(117, 44);
            this.btnTraCuuLoaiBenh.TabIndex = 93;
            this.btnTraCuuLoaiBenh.Text = "Tra Cứu";
            this.btnTraCuuLoaiBenh.UseVisualStyleBackColor = false;
            this.btnTraCuuLoaiBenh.Click += new System.EventHandler(this.btnTraCuuLoaiBenh_Click);
            // 
            // btnTraCuuBenh
            // 
            this.btnTraCuuBenh.BackColor = System.Drawing.Color.LightGray;
            this.btnTraCuuBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraCuuBenh.Location = new System.Drawing.Point(841, 689);
            this.btnTraCuuBenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTraCuuBenh.Name = "btnTraCuuBenh";
            this.btnTraCuuBenh.Size = new System.Drawing.Size(117, 44);
            this.btnTraCuuBenh.TabIndex = 93;
            this.btnTraCuuBenh.Text = "Tra Cứu";
            this.btnTraCuuBenh.UseVisualStyleBackColor = false;
            this.btnTraCuuBenh.Click += new System.EventHandler(this.btnTraCuuBenh_Click_1);
            // 
            // txtTraCuuBenh
            // 
            this.txtTraCuuBenh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTraCuuBenh.DefaultText = "";
            this.txtTraCuuBenh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTraCuuBenh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTraCuuBenh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuuBenh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTraCuuBenh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuuBenh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTraCuuBenh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTraCuuBenh.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTraCuuBenh.IconLeft")));
            this.txtTraCuuBenh.Location = new System.Drawing.Point(199, 689);
            this.txtTraCuuBenh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTraCuuBenh.Name = "txtTraCuuBenh";
            this.txtTraCuuBenh.PasswordChar = '\0';
            this.txtTraCuuBenh.PlaceholderText = "Nhập thông tin bệnh";
            this.txtTraCuuBenh.SelectedText = "";
            this.txtTraCuuBenh.Size = new System.Drawing.Size(267, 44);
            this.txtTraCuuBenh.TabIndex = 97;
            // 
            // cboTraCuuBenh
            // 
            this.cboTraCuuBenh.BackColor = System.Drawing.Color.Transparent;
            this.cboTraCuuBenh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTraCuuBenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTraCuuBenh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTraCuuBenh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTraCuuBenh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTraCuuBenh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTraCuuBenh.ItemHeight = 30;
            this.cboTraCuuBenh.Items.AddRange(new object[] {
            "Tất cả",
            "Mã bệnh",
            "Tên bệnh",
            "Triệu chứng",
            "Thuốc đặc trị",
            "Tên loại bệnh"});
            this.cboTraCuuBenh.Location = new System.Drawing.Point(563, 689);
            this.cboTraCuuBenh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTraCuuBenh.Name = "cboTraCuuBenh";
            this.cboTraCuuBenh.Size = new System.Drawing.Size(204, 36);
            this.cboTraCuuBenh.StartIndex = 0;
            this.cboTraCuuBenh.TabIndex = 98;
            // 
            // TraCuuBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.cboTraCuuBenh);
            this.Controls.Add(this.cboTraCuuLoaiBenh);
            this.Controls.Add(this.txtTraCuuBenh);
            this.Controls.Add(this.txtTraCuuLoaiBenh);
            this.Controls.Add(this.gxb_Thontinbenh);
            this.Controls.Add(this.gxb_Thongtinloaibenh);
            this.Controls.Add(this.btnTraCuuBenh);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTraCuuLoaiBenh);
            this.Controls.Add(this.btnKhongLuuBenh);
            this.Controls.Add(this.btnThemBenh);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoaBenh);
            this.Controls.Add(this.btnCapNhatBenh);
            this.Controls.Add(this.dgvBenh);
            this.Controls.Add(this.btnCapNhatLoaiBenh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLoaiBenh);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TraCuuBenh";
            this.Size = new System.Drawing.Size(1918, 1111);
            this.Load += new System.EventHandler(this.TraCuuBenh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBenh)).EndInit();
            this.gxb_Thongtinloaibenh.ResumeLayout(false);
            this.gxb_Thongtinloaibenh.PerformLayout();
            this.gxb_Thontinbenh.ResumeLayout(false);
            this.gxb_Thontinbenh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiBenh;
        private System.Windows.Forms.TextBox txtMaLoaiBenh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoaiBenh;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhatLoaiBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaBenh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenBenh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTrieuChungBenh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvBenh;
        private System.Windows.Forms.Button btnCapNhatBenh;
        private System.Windows.Forms.Button btnXoaBenh;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThemBenh;
        private System.Windows.Forms.Button btnKhongLuuBenh;
        private System.Windows.Forms.GroupBox gxb_Thongtinloaibenh;
        private System.Windows.Forms.GroupBox gxb_Thontinbenh;
        private System.Windows.Forms.ComboBox cboTenTHuoc;
        private System.Windows.Forms.ComboBox cboTenLoaiThuoc;
        private System.Windows.Forms.ComboBox cboTenLoaiBenh;
        private Guna.UI2.WinForms.Guna2TextBox txtTraCuuLoaiBenh;
        private Guna.UI2.WinForms.Guna2ComboBox cboTraCuuLoaiBenh;
        private System.Windows.Forms.Button btnTraCuuLoaiBenh;
        private System.Windows.Forms.Button btnTraCuuBenh;
        private Guna.UI2.WinForms.Guna2TextBox txtTraCuuBenh;
        private Guna.UI2.WinForms.Guna2ComboBox cboTraCuuBenh;
    }
}
