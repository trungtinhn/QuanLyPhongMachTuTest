using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_HOADON
    {
        void CapNhatThanhToan(int id);
        dynamic LayDanhSachHoaDon(int idBenhNhan);
        HOADON LayHoaDon(int soPhieuKhamBenh);
        void TaoHoaDon(HOADON hoaDon);
        int TongDoanhThuNgay(int ngay, int thang, int nam);
    }
    public class DAL_HOADON : IDAL_HOADON
    {
        QLPMTEntities db;
        DAL_THAMSO thamSoDAL;
        DAL_PHIEUKHAMBENH dPKB;

        public DAL_HOADON()
        {
            db = new QLPMTEntities();
            thamSoDAL = new DAL_THAMSO();
            dPKB = new DAL_PHIEUKHAMBENH();
        }
        public DAL_HOADON(QLPMTEntities dbContext)
        {
            this.db = dbContext;
            thamSoDAL = new DAL_THAMSO();
            dPKB = new DAL_PHIEUKHAMBENH();
        }

        public void TaoHoaDon(HOADON hoaDon)
        {
            THAMSO thamso = thamSoDAL.LayThamSo(1);
            hoaDon.TienKham = thamso.TienKham;
            
            db.HOADONs.Add(hoaDon);
            db.SaveChanges();
        }

        public dynamic LayDanhSachHoaDon(int idBenhNhan)
        {
            List<HOADON> hoaDons = db.HOADONs.Where(s => s.idBenhNhan == idBenhNhan).ToList();
            return hoaDons;
        }

        public HOADON LayHoaDon(int soPhieuKhamBenh)
        {
            return db.HOADONs.FirstOrDefault(s => s.SoPhieuKhamBenh == soPhieuKhamBenh);
        }

        public void CapNhatThanhToan(int id)
        {
            HOADON hoaDon = db.HOADONs.Find(id);
            hoaDon.TrangThai = "Đã thanh toán";
            db.SaveChanges();
        }

        public int TongDoanhThuNgay(int ngay, int thang, int nam)
        {
            List<HOADON> hoaDons = db.HOADONs.ToList();

            int tongTien = 0;

            foreach(var hoaDon in hoaDons)
            {
                PHIEUKHAMBENH pkb = dPKB.LayPhieuKhamBenh(hoaDon.SoPhieuKhamBenh.Value);
                if (pkb.NgayKham.Day == ngay && pkb.NgayKham.Month == thang && pkb.NgayKham.Year == nam)
                {
                    tongTien += (hoaDon.TienKham + hoaDon.TienThuoc);
                }
            }

            return tongTien;
        }
    }
}
