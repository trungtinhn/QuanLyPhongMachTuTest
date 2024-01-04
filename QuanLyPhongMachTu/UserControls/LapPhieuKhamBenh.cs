using BLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyPhongMachTu.UserControls
{
    public partial class LapPhieuKhamBenh : UserControl
    {
        BLL_DANGKY dDangKyBLL;
        BLL_LOAITHUOC dLoaiThuocBLL;
        BLL_THUOC dThuocBLL;
        BLL_BENH dBenhBLL;
        BLL_BENHNHAN dBenhNhanBLL;
        BLL_PHIEUKHAMBENH dPhieuKhamBenhBLL;
        BLL_CT_PHIEUKHAMBENH dCTPhieuKhamBenhBLL;
        BLL_HOADON dHoaDonBLL;

        List<CT_PHIEUKHAMBENH> phieuKhamBenh;
        public LapPhieuKhamBenh()
        {
            InitializeComponent();
            dDangKyBLL = new BLL_DANGKY(); 
            dLoaiThuocBLL = new BLL_LOAITHUOC();
            dThuocBLL = new BLL_THUOC();
            dBenhBLL = new BLL_BENH();
            phieuKhamBenh = new List<CT_PHIEUKHAMBENH>();
            dBenhNhanBLL = new BLL_BENHNHAN();
            dPhieuKhamBenhBLL = new BLL_PHIEUKHAMBENH();
            dCTPhieuKhamBenhBLL = new BLL_CT_PHIEUKHAMBENH();
            dHoaDonBLL = new BLL_HOADON();
        }

        private void LapPhieuKhamBenh_Load(object sender, EventArgs e)
        {

            HienThiDanhSachKhamBenh();
            HienThiComboBoxLoaiThuoc();
            HienThiComboBoxTenBenh();

            KhoiTaoDGVThuoc();
            HienThiThongTinPhieuKhamBenh();

            dtbNgayKB.Format = DateTimePickerFormat.Custom;
            dtbNgayKB.CustomFormat = "dd/MM/yyyy";

            HienThiDGVThuoc();

        }

        private void KhoiTaoDGVThuoc()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã thuốc");
            dt.Columns.Add("Tên thuốc");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Thành tiền");

            dgvThuoc.DataSource = dt;
            KhoiTaoKichThuocDGVThuoc();
        }

        private void KhoiTaoKichThuocDGVThuoc()
        {
                dgvThuoc.Columns[0].Width = (int)(dgvThuoc.Width * 0.15);
                dgvThuoc.Columns[1].Width = (int)(dgvThuoc.Width * 0.2);
                dgvThuoc.Columns[2].Width = (int)(dgvThuoc.Width * 0.3);
                dgvThuoc.Columns[3].Width = (int)(dgvThuoc.Width * 0.2);
                dgvThuoc.Columns[4].Width = (int)(dgvThuoc.Width * 0.3);
            
        }

        public void HienThiDanhSachKhamBenh()
        {
            dDangKyBLL = new BLL_DANGKY();
            var dt = new DataTable();
            dt.Columns.Add("Mã bệnh nhân");
            dt.Columns.Add("Họ tên");

            List<BENHNHAN> danhSachDK = dDangKyBLL.LayDanhSachDangKy();

            foreach (var bn in danhSachDK)
            {
                dt.Rows.Add(bn.MaBenhNhan, bn.HoTenBenhNhan);
            }

            dgvDangKy.DataSource = dt;

           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            HienThiDanhSachKhamBenh();
        }

        private void dgvDangKy_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvDangKy.SelectedRows.Count > 0)
            {
                if(dgvDangKy.Rows.Count > 1)
                {
                    DataGridViewRow row = dgvDangKy.SelectedRows[0];
                    try
                    {
                        txtMaBN.Text = row.Cells[0].Value.ToString();
                        txtHotenBN.Text = row.Cells[1].Value.ToString();
                    }
                    catch
                    {

                    }
                }
               
               
            }

            txtPhieuKhamBenh.Text = "";
        }


        public void HienThiComboBoxLoaiThuoc()
        {
            cboTenLoaiThuoc.DataSource = dLoaiThuocBLL.LayDanhSachLoaiThuoc();
            cboTenLoaiThuoc.DisplayMember = "TenLoaiThuoc";
            cboTenLoaiThuoc.ValueMember = "MaLoaiThuoc";
            HienThiComboBoxThuoc();
        }


        public void HienThiComboBoxThuoc()
        {
            string maLoaiThuoc = cboTenLoaiThuoc.SelectedValue.ToString();
            LOAITHUOC loaiThuoc = dLoaiThuocBLL.LayLoaiThuoc(maLoaiThuoc);

            if (loaiThuoc == null)
            {
              
               
            }
            else
            {
                cboTenTHuoc.DataSource = dThuocBLL.LayDanhSachThuoc(loaiThuoc.id);

                if (cboTenTHuoc.Items.Count == 0)
                {
                    cboTenTHuoc.ResetText();
                    numSoLuong.Value = 0;
                    txtDonGiaThuoc.Text = "";
                }    
                   
                cboTenTHuoc.DisplayMember = "TenThuoc";
                cboTenTHuoc.ValueMember = "MaThuoc";

                HienThiGiaTien();
            }
              
            
        }

        private void cboTenLoaiThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiComboBoxThuoc();
           
        }

        private void cboTenTHuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiGiaTien();
        }

        private void HienThiGiaTien()
        {

            if(cboTenTHuoc.Items.Count > 0)
            {
                string maThuoc = cboTenTHuoc.SelectedValue.ToString();

                THUOC thuoc = dThuocBLL.LayThuocByMa(maThuoc);

                if (thuoc == null) return;

                txtDonGiaThuoc.Text = thuoc.DonGia.ToString();
                numSoLuong.Value = 0;

                txtThanhtien.Text = "0";
            }

            
            
        }

        private void HienThiComboBoxTenBenh()
        {
            cboTenBenh.DataSource = dBenhBLL.LayThongTinBenh();
            cboTenBenh.DisplayMember = "TenBenh";
            cboTenBenh.ValueMember = "MaBenh";
        }

        private void ThayDoiThanhTien()
        {
            int donGia = Int32.Parse(txtDonGiaThuoc.Text);

            txtThanhtien.Text = (donGia * numSoLuong.Value) +"";
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            ThayDoiThanhTien();
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhieuKhamBenh.Text))
            {
                MessageBox.Show("Bạn chưa chọn Phiếu khám bệnh!");
                return;
            }

            CT_PHIEUKHAMBENH pn = new CT_PHIEUKHAMBENH();

            THUOC thuoc = dThuocBLL.LayThongTinThuoc(cboTenTHuoc.Text);

            pn.SoPhieuKhamBenh = Int32.Parse(txtPhieuKhamBenh.Text);
            pn.idMaThuoc = thuoc.id;
            pn.DonGia = Int32.Parse(txtDonGiaThuoc.Text);
            pn.ThanhTien = Int32.Parse(txtThanhtien.Text);
            pn.SoLuong = Int32.Parse(numSoLuong.Value.ToString());
            pn.idMaCachDung = thuoc.idMaCachDung;


            if (dCTPhieuKhamBenhBLL.ThemCTPKB(pn))
            {
                HienThiDGVThuoc();
                dPhieuKhamBenhBLL.TinhTongTien(pn.SoPhieuKhamBenh);
                HienThiThongTinPhieuKhamBenh();
            }
            else
            {
                MessageBox.Show("Thuốc này đã được thêm vào, bạn có thể thay đổi số lượng!");
            }
        }

        private void HienThiDGVThuoc()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã thuốc");
            dt.Columns.Add("Tên thuốc");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Thành tiền");
            if (!string.IsNullOrEmpty(txtPhieuKhamBenh.Text))
            {
                List<CT_PHIEUKHAMBENH> phieus = dCTPhieuKhamBenhBLL.LayDanhSachThuoc(Int32.Parse(txtPhieuKhamBenh.Text));

                int i = 0;

                foreach (CT_PHIEUKHAMBENH pkb in phieus)
                {
                    i++;

                    THUOC thuoc = dThuocBLL.LayThuocById(pkb.idMaThuoc);

                    dt.Rows.Add(i, thuoc.MaThuoc, thuoc.TenThuoc, pkb.SoLuong, pkb.ThanhTien);
                }
            }
                

            dgvThuoc.DataSource = null;
            dgvThuoc.DataSource = dt;

            KhoiTaoKichThuocDGVThuoc();
        }

        private bool KiemTraNhapLieuPhieuKhamBenh()
        {
            if (string.IsNullOrEmpty(txtMaBN.Text) || string.IsNullOrEmpty(txtHotenBN.Text)
                    || string.IsNullOrEmpty(txtTrieuchungBenh.Text) || string.IsNullOrEmpty(cboTenBenh.Text)
                ) { return false; }
            return true;
        }

        private void btnLuuPKB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhieuKhamBenh.Text))
            {
                MessageBox.Show("Vui lòng chọn Số phiếu khám bệnh!");
                return;
            }

            PHIEUKHAMBENH pkb = dPhieuKhamBenhBLL.LayPhieuKhamBenh(Int32.Parse(txtPhieuKhamBenh.Text));
           

            if (dPhieuKhamBenhBLL.LuuPhieuKhamBenh(pkb))
            {
                MessageBox.Show("Đã lưu thông tin phiếu khám bệnh");
                HienThiThongTinPhieuKhamBenh();

            }
            else
            {
                MessageBox.Show("Lưu phiếu khám bệnh không thành công!");
            }


            
            HOADON hoaDon = new HOADON();
            hoaDon.SoPhieuKhamBenh = Int32.Parse(txtPhieuKhamBenh.Text);

            BENHNHAN benhNhan = dBenhNhanBLL.LayThongTinBenhNhan(txtMaBN.Text);

            hoaDon.idBenhNhan = benhNhan.id;
            hoaDon.TienThuoc = pkb.TongTien;
            hoaDon.TrangThai = "Chưa thanh toán";

            if (dHoaDonBLL.TaoHoaDon(hoaDon))
            {
                MessageBox.Show("Tạo hóa đơn thành công!");

            }
            else
            {
                MessageBox.Show("Tạo hóa đơn thất bại!");
            }

            List<CT_PHIEUKHAMBENH> listCTPKB = dCTPhieuKhamBenhBLL.LayDanhSachThuoc(hoaDon.SoPhieuKhamBenh.Value);

            foreach(CT_PHIEUKHAMBENH chiTietPhieuKhamBenh in listCTPKB)
            {
                if(dThuocBLL.CapNhatSoLuongTon(chiTietPhieuKhamBenh.idMaThuoc, chiTietPhieuKhamBenh.SoLuong))
                {

                }
                else
                {
                    THUOC thuoc = dThuocBLL.LayThuocById(chiTietPhieuKhamBenh.idMaThuoc);
                    MessageBox.Show("Thuốc " + thuoc.TenThuoc + " không đủ số lượng!");

                    dCTPhieuKhamBenhBLL.XoaCTPKB(chiTietPhieuKhamBenh);
                }

            }

        }

        private void btnThemPKB_Click(object sender, EventArgs e)
        {

            if (!KiemTraNhapLieuPhieuKhamBenh())
            {
                MessageBox.Show("Vui lòng cũng cấp đầy đủ thông tin!");
                return;
            }

            BENHNHAN benhNhan = dBenhNhanBLL.LayThongTinBenhNhan(txtMaBN.Text);
            BENH benh = dBenhBLL.LayBenh(cboTenBenh.SelectedValue.ToString());

            PHIEUKHAMBENH pkb = new PHIEUKHAMBENH();
            pkb.idMaBenhNhan = benhNhan.id;
            pkb.NgayKham = dtbNgayKB.Value;
            pkb.TrieuChung = txtTrieuchungBenh.Text;
            pkb.MaBenh = benh.id;
            pkb.TongTien = 0;
            pkb.TrangThai = 0;

            if (dPhieuKhamBenhBLL.ThemPhieuKhamBenh(pkb))
            {
                MessageBox.Show("Thêm phiếu khám bệnh thành công!");
                HienThiThongTinPhieuKhamBenh();
            }
            else
            {
                MessageBox.Show("Thêm phiếu khám bênh thất bại!");
            }
        }

        public void HienThiThongTinPhieuKhamBenh()
        {
            int selectedRowIndex = 0;
            if (dgvKB.DataSource != null) 
            {
                if (dgvKB.SelectedRows.Count == 0)
                    selectedRowIndex = 0;
                else selectedRowIndex = dgvKB.SelectedCells[0].RowIndex;
            }
           
            DataTable dt = new DataTable();
            dt.Columns.Add("Số phiếu khám bệnh");
            dt.Columns.Add("Ngày khám bệnh");
            dt.Columns.Add("Mã bệnh nhân");
            dt.Columns.Add("Tên bệnh nhân");
            dt.Columns.Add("Tên bệnh");
            dt.Columns.Add("Triệu chứng");
            dt.Columns.Add("Tổng tiền");

            List<PHIEUKHAMBENH> phieus = dPhieuKhamBenhBLL.LayDanhSachPhieuKhamBenh(cboLoc.Text, txtLoc.Text, dtimeStart.Value, dtimeEnd.Value);

            foreach (PHIEUKHAMBENH pkb in phieus)
            {

                if ((pkb.TrangThai == 1 && chkDaLuu.Checked) || (pkb.TrangThai == 0 && chkChuaLuu.Checked))
                {
                    BENHNHAN benhNhan = dBenhNhanBLL.LayThongTinBenhNhan(pkb.idMaBenhNhan);
                    BENH benh = dBenhBLL.LayBenh(pkb.MaBenh);

                    dt.Rows.Add(pkb.SoPhieuKhamBenh, pkb.NgayKham.ToString("dd/MM/yyyy"), benhNhan.MaBenhNhan, benhNhan.HoTenBenhNhan, benh.TenBenh, pkb.TrieuChung, pkb.TongTien);
               }
            }

            dgvKB.DataSource = dt;
            if (dgvKB.Rows.Count > 0 && selectedRowIndex != -1 && selectedRowIndex < dgvKB.Rows.Count)
            {
                dgvKB.Rows[selectedRowIndex].Selected = true;
            }
                

        }

        private void btnSuaThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhieuKhamBenh.Text))
            {
                MessageBox.Show("Bạn chưa chọn Phiếu khám bệnh");
                return;
            }

            CT_PHIEUKHAMBENH pn = new CT_PHIEUKHAMBENH();

            THUOC thuoc = dThuocBLL.LayThongTinThuoc(cboTenTHuoc.Text);

            pn.SoPhieuKhamBenh = Int32.Parse(txtPhieuKhamBenh.Text);
            pn.idMaThuoc = thuoc.id;
            pn.DonGia = Int32.Parse(txtDonGiaThuoc.Text);
            pn.ThanhTien = Int32.Parse(txtThanhtien.Text);
            pn.SoLuong = Int32.Parse(numSoLuong.Value.ToString());
            pn.idMaCachDung = thuoc.idMaCachDung;

            if (dCTPhieuKhamBenhBLL.SuaCTPKB(pn))
            {
                HienThiDGVThuoc();
                dPhieuKhamBenhBLL.TinhTongTien(pn.SoPhieuKhamBenh);
                HienThiThongTinPhieuKhamBenh();
            }
            else
            {
                MessageBox.Show("Bạn đã chọn thuốc đã được thêm, vui lòng chọn lại!");
            }
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhieuKhamBenh.Text))
            {
                MessageBox.Show("Bạn chưa chọn Phiếu khám bệnh");
                return;
            }

            CT_PHIEUKHAMBENH pn = new CT_PHIEUKHAMBENH();

            THUOC thuoc = dThuocBLL.LayThongTinThuoc(cboTenTHuoc.Text);

            pn.SoPhieuKhamBenh = Int32.Parse(txtPhieuKhamBenh.Text);
            pn.idMaThuoc = thuoc.id;
            pn.DonGia = Int32.Parse(txtDonGiaThuoc.Text);
            pn.ThanhTien = Int32.Parse(txtThanhtien.Text);
            pn.SoLuong = Int32.Parse(numSoLuong.Value.ToString());
            pn.idMaCachDung = thuoc.idMaCachDung;


            if (dCTPhieuKhamBenhBLL.XoaCTPKB(pn))
            {
                HienThiDGVThuoc();
                dPhieuKhamBenhBLL.TinhTongTien(pn.SoPhieuKhamBenh);
                HienThiThongTinPhieuKhamBenh();
            }
            else
            {
                MessageBox.Show("Xóa phiếu khám bệnh không thành công!");
            }
        }

        

        private void dgvKB_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKB.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvKB.SelectedRows[0];

                if(row.Cells[0].Value !=  null)
                {
                    txtPhieuKhamBenh.Text = row.Cells[0].Value.ToString();

                    if (!string.IsNullOrEmpty(txtPhieuKhamBenh.Text))
                    {
                        PHIEUKHAMBENH pkb = dPhieuKhamBenhBLL.LayPhieuKhamBenh(Int32.Parse(txtPhieuKhamBenh.Text));
                        dtbNgayKB.Value =  pkb.NgayKham;
                        if(pkb.TrangThai == 1)
                        {
                            btnThemThuoc.Enabled = false;
                            btnXoaThuoc.Enabled = false;
                            btnSuaThuoc.Enabled = false;
                        }
                        else
                        {
                            btnThemThuoc.Enabled = true;
                            btnXoaThuoc.Enabled = true;
                            btnSuaThuoc.Enabled = true;
                        }
                    }
                    else
                    {
                        DateTime dateTime = DateTime.Now;
                        dtbNgayKB.Value = dateTime;
                    }
                       
                        txtMaBN.Text = row.Cells[2].Value.ToString();
                        txtHotenBN.Text = row.Cells[3].Value.ToString();
                        cboTenBenh.Text = row.Cells[4].Value.ToString();
                        txtTrieuchungBenh.Text = row.Cells[5].Value.ToString();
                    
                }
                

            }

            
            HienThiDGVThuoc();
        }

        private void dgvThuoc_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvThuoc.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvThuoc.SelectedRows[0];

                THUOC thuoc = dThuocBLL.LayThuocByMa(row.Cells[1].Value.ToString());
                string  tenLoaiThuoc = dLoaiThuocBLL.LayTenLoaiThuoc(thuoc.idMaLoaiThuoc);
                
                cboTenTHuoc.Text = row.Cells[2].Value.ToString();
                numSoLuong.Value = Int32.Parse(row.Cells[3].Value.ToString());
                cboTenLoaiThuoc.Text = tenLoaiThuoc;
                txtDonGiaThuoc.Text = thuoc.DonGia.ToString();
                txtThanhtien.Text = (thuoc.DonGia * numSoLuong.Value).ToString();

               // MessageBox.Show(row.Cells[3].Value.ToString());
            }
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            HienThiThongTinPhieuKhamBenh();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            HienThiThongTinPhieuKhamBenh();
        }

        private void cboLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoc.Text == "Ngày khám")
            {
                pnLocNgayThang.Visible = true;
                txtLoc.Visible = false;

            }else
            {
                pnLocNgayThang.Visible = false;
                txtLoc.Visible = true;
            }
        }
    }
}
