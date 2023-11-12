using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_PHIEUKHAMBENH
    {
        void ThemPhieuKhamBenh(PHIEUKHAMBENH pkb);
        dynamic LayDanhSachPhieuKhamBenh(string kieuLoc, string giaTri, DateTime start, DateTime end);
        PHIEUKHAMBENH LayPhieuKhamBenh(int soPhieuKhamBenh);
        void TinhTongTien(int soPhieuKhamBenh);
        void LuuPhieuKhamBenh(PHIEUKHAMBENH pkb);
        dynamic ListTheoNgay(int ngay, int thang, int nam);

    }
    public class DAL_PHIEUKHAMBENH: IDAL_PHIEUKHAMBENH
    {
        QLPMTEntities db;
        IDAL_CTPHIEUKHAMBENH chiTietPKBDAL;
        IDAL_BENHNHAN benhNhanDAL;
        IDAL_BENH benhDAL;
        public DAL_PHIEUKHAMBENH()
        {
            db = new QLPMTEntities();
            chiTietPKBDAL = new DAL_CT_PHIEUKHAMBENH();
            benhNhanDAL = new DAL_BENHNHAN();
            benhDAL = new DAL_BENH();
        }
        public DAL_PHIEUKHAMBENH(QLPMTEntities db, IDAL_CTPHIEUKHAMBENH chiTietPKBDAL,IDAL_BENHNHAN benhNhanDAL, IDAL_BENH benhDAL)
        {
            this.db = db;
            this.chiTietPKBDAL = chiTietPKBDAL;
            this.benhNhanDAL = benhNhanDAL;
            this.benhDAL = benhDAL;
        }

        public void ThemPhieuKhamBenh(PHIEUKHAMBENH pkb)
        {
            db.PHIEUKHAMBENHs.Add(pkb);
            db.SaveChanges();

        }

        public dynamic LayDanhSachPhieuKhamBenh(string kieuLoc, string giaTri, DateTime start, DateTime end)
        {
            List<PHIEUKHAMBENH> danhSach = new List<PHIEUKHAMBENH>();
            if (kieuLoc == "Tất cả")
            {
                danhSach = db.PHIEUKHAMBENHs.ToList();
            }else if (kieuLoc == "Mã bệnh nhân" || kieuLoc == "Tên bệnh nhân")
            {
                List<BENHNHAN> benhNhans = benhNhanDAL.LocBenhNhan(kieuLoc, giaTri);
                foreach(BENHNHAN benh in benhNhans)
                {
                    List<PHIEUKHAMBENH> ds = db.PHIEUKHAMBENHs.Where(p => p.idMaBenhNhan == benh.id).ToList();
                    foreach (PHIEUKHAMBENH d in ds)
                    {
                        danhSach.Add(d);
                    }
                } 
            }else if(kieuLoc == "Ngày khám")
            {
                DateTime startDate = start;
                DateTime endDate = end;
                danhSach = db.PHIEUKHAMBENHs.Where(p => p.NgayKham >= startDate && p.NgayKham <= endDate).ToList();
            }else if(kieuLoc == "Tên bệnh")
            {
                List<BENH> benhs = benhDAL.LocBenh(kieuLoc, giaTri);
                foreach (BENH b in benhs)
                {
                    List<PHIEUKHAMBENH> ds = db.PHIEUKHAMBENHs.Where(p => p.MaBenh == b.id).ToList();
                    foreach(PHIEUKHAMBENH d in ds)
                    {
                        danhSach.Add(d);
                    }
                }
            }

            return danhSach;
        }

        public PHIEUKHAMBENH LayPhieuKhamBenh(int soPhieuKhamBenh)
        {
            PHIEUKHAMBENH pbk = db.PHIEUKHAMBENHs.Find(soPhieuKhamBenh);
            return pbk;
        }

        public void TinhTongTien(int soPhieuKhamBenh)
        { 
            List<CT_PHIEUKHAMBENH> danhSachThuoc = chiTietPKBDAL.LayDanhSachThuoc(soPhieuKhamBenh);
            int tongTien = 0;
            foreach(CT_PHIEUKHAMBENH ctpkb in  danhSachThuoc)
            {
                tongTien += ctpkb.ThanhTien;
            }

            PHIEUKHAMBENH pkb = db.PHIEUKHAMBENHs.Find(soPhieuKhamBenh);
            pkb.TongTien = tongTien;
            db.SaveChanges();
        }

        public void LuuPhieuKhamBenh(PHIEUKHAMBENH pkb)
        {
            PHIEUKHAMBENH phieuKB = db.PHIEUKHAMBENHs.Find(pkb.SoPhieuKhamBenh);
            phieuKB.TrangThai = 1;
            db.SaveChanges();
        }

        public dynamic ListTheoNgay(int ngay, int thang, int nam)
        {
            List<PHIEUKHAMBENH> phieus = db.PHIEUKHAMBENHs.Where(p => p.NgayKham.Day == ngay && p.NgayKham.Month == thang && p.NgayKham.Year == nam).ToList();

            return phieus;
        }
    }
}
