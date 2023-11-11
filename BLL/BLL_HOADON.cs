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
        private IDAL_HOADON dHoaDonDAL;

        public BLL_HOADON(IDAL_HOADON dalHoaDon)
        {
            dHoaDonDAL = dalHoaDon;
        }

        public BLL_HOADON()
        {
        }

        public bool TaoHoaDon(HOADON hoaDon)
        {
            try
            {
                dHoaDonDAL.TaoHoaDon(hoaDon);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public dynamic LayDanhSachHoaDon(int idBenhNhan)
        {
            return dHoaDonDAL.LayDanhSachHoaDon(idBenhNhan);
        }

        public HOADON LayHoaDon(int soPhieuKhamBenh)
        {
            return dHoaDonDAL.LayHoaDon(soPhieuKhamBenh);
        }
        public void CapNhatThanhToan(int id)
        {
            dHoaDonDAL.CapNhatThanhToan(id);
        }

        public int TongDoanhThuNgay(int ngay, int thang, int nam)
        {
            return dHoaDonDAL.TongDoanhThuNgay(ngay, thang, nam);
        }
    }
}
