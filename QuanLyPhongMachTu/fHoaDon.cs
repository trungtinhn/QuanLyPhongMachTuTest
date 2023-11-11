using BLL;
using DTO;
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

namespace QuanLyPhongMachTu
{
    public partial class fHoaDon : Form
    {
        private readonly HOADON _data;
        BLL_PHIEUKHAMBENH dPhieuKhamBenhBLL;
        BLL_BENHNHAN dBenhNhanBLL;
        BLL_CT_PHIEUKHAMBENH dCTPKBBLL;
        BLL_THUOC dThuocBLL;
        BLL_HOADON dHoaDonBLL;
        public fHoaDon(HOADON data)
        {
            _data = data;

            dPhieuKhamBenhBLL = new BLL_PHIEUKHAMBENH();
            dBenhNhanBLL = new BLL_BENHNHAN();
            dCTPKBBLL = new BLL_CT_PHIEUKHAMBENH();
            dThuocBLL = new BLL_THUOC();
            dHoaDonBLL = new BLL_HOADON();
            InitializeComponent();

        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            PHIEUKHAMBENH pkb = dPhieuKhamBenhBLL.LayPhieuKhamBenh(_data.SoPhieuKhamBenh.Value);
            BENHNHAN benhNhan = dBenhNhanBLL.LayThongTinBenhNhan(pkb.idMaBenhNhan);

            lbl_HoVaTen.Text = benhNhan.HoTenBenhNhan.ToString();
            lbl_NgayKham.Text =pkb.NgayKham.ToString("dd/MM/yyyy");
            lbl_TienKham.Text =_data.TienKham.ToString();
            lbl_TienThuoc.Text = _data.TienThuoc.ToString();
            lbl_TongTien.Text = (_data.TienKham + _data.TienThuoc).ToString();

            if(_data.TrangThai == "Chưa thanh toán")
            {
                btnThanhToan.Text = "Thanh Toán";
            }
            else
            {
                btnThanhToan.Text = "Thoát";
            }

            HienThiDanhSachThuoc();

        }

        public void HienThiDanhSachThuoc()
        {
            List<CT_PHIEUKHAMBENH> phieus = dCTPKBBLL.LayDanhSachThuoc(_data.SoPhieuKhamBenh.Value);

            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Mã thuốc");
            dt.Columns.Add("Tên thuốc");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Thành tiền");

            int i = 0;

            foreach(CT_PHIEUKHAMBENH pkb in phieus) 
            {
                i++;

                THUOC thuoc = dThuocBLL.LayThuocById(pkb.idMaThuoc);

                dt.Rows.Add(i, thuoc.MaThuoc, thuoc.TenThuoc, pkb.SoLuong, pkb.ThanhTien);
            }

            dgvHoaDon.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (btnThanhToan.Text == "Thanh Toán")
            {
                dHoaDonBLL.CapNhatThanhToan(_data.SoHoaDon);

                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
