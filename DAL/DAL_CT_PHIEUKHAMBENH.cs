using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_CTPHIEUKHAMBENH
    {
        dynamic LayDanhSachThuoc(int soPhieuKhamBenh);
        dynamic LayTheoThuoc(int idThuoc);
        void SuaCTPKB(CT_PHIEUKHAMBENH cTPKB);
        void ThemCTPKB(CT_PHIEUKHAMBENH cTPKB);
        void XoaCTPKB(CT_PHIEUKHAMBENH cTPKB);
    }
    public class DAL_CT_PHIEUKHAMBENH : IDAL_CTPHIEUKHAMBENH
    {
        QLPMTEntities db;
        public DAL_CT_PHIEUKHAMBENH()
        {
            db = new QLPMTEntities();
        }

        public DAL_CT_PHIEUKHAMBENH(QLPMTEntities dbContext)
        {
            this.db = dbContext;
        }

        public void ThemCTPKB(CT_PHIEUKHAMBENH cTPKB)
        {
            db.CT_PHIEUKHAMBENH.Add(cTPKB);
            db.SaveChanges();
        }

        public dynamic LayDanhSachThuoc(int soPhieuKhamBenh)
        {
            var danhsach = db.CT_PHIEUKHAMBENH.Where(p => p.SoPhieuKhamBenh == soPhieuKhamBenh).ToList();

            return danhsach;
        }

        public void SuaCTPKB(CT_PHIEUKHAMBENH cTPKB)
        {
            CT_PHIEUKHAMBENH chiTietPKB = db.CT_PHIEUKHAMBENH.Find(cTPKB.SoPhieuKhamBenh, cTPKB.idMaThuoc);

            chiTietPKB.idMaCachDung = cTPKB.idMaCachDung;
            chiTietPKB.DonGia = cTPKB.DonGia;
            chiTietPKB.SoLuong = cTPKB.SoLuong;
            chiTietPKB.ThanhTien = cTPKB.ThanhTien;

            db.SaveChanges();
        }

        public void XoaCTPKB(CT_PHIEUKHAMBENH cTPKB)
        {
            CT_PHIEUKHAMBENH chiTietPKB = db.CT_PHIEUKHAMBENH.Find(cTPKB.SoPhieuKhamBenh, cTPKB.idMaThuoc);

            db.CT_PHIEUKHAMBENH.Remove(chiTietPKB);
            db.SaveChanges();
        }

        public dynamic LayTheoThuoc(int idThuoc)
        {
            return db.CT_PHIEUKHAMBENH.Where(s => s.idMaThuoc == idThuoc).ToList();
        }
       
    }
}
