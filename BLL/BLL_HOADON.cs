using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_HOADON
    {
        DAL_HOADON dHoaDonBLL;
        public BLL_HOADON()
        {
            dHoaDonBLL = new DAL_HOADON();
        }

        public bool TaoHoaDon(HOADON hoaDon)
        {
            try
            {
                dHoaDonBLL.TaoHoaDon(hoaDon);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public dynamic LayDanhSachHoaDon(int idBenhNhan)
        {
            return dHoaDonBLL.LayDanhSachHoaDon(idBenhNhan);
        }

        public HOADON LayHoaDon(int soPhieuKhamBenh)
        {
            return dHoaDonBLL.LayHoaDon(soPhieuKhamBenh);
        }
        public void CapNhatThanhToan(int id)
        {
            dHoaDonBLL.CapNhatThanhToan(id);
        }

        public int TongDoanhThuNgay(int ngay, int thang, int nam)
        {
            return dHoaDonBLL.TongDoanhThuNgay(ngay, thang, nam);
        }
    }
}
