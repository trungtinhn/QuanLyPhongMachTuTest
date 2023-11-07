using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PHIEUNHAPTHUOC
    {
        QLPMTEntities db;
        public DAL_PHIEUNHAPTHUOC()
        {
            db = new QLPMTEntities();
        }
        public List<PHIEUNHAPTHUOC> GetData()
        {
            return db.PHIEUNHAPTHUOCs.ToList();
        }


        public PHIEUNHAPTHUOC GetDataByMa(int maPhieu)
        {
            return db.PHIEUNHAPTHUOCs.SingleOrDefault(m => m.SoPhieuNhapThuoc == maPhieu);
        }

        public int GetMaMax()
        {
            return db.PHIEUNHAPTHUOCs.Max(m => m.SoPhieuNhapThuoc);
        }


        public bool ThemPhieu(PHIEUNHAPTHUOC phieu)
        {
            db.PHIEUNHAPTHUOCs.Add(phieu);
            int result = db.SaveChanges();

            return result > 0;
        }

        public void LuuPhieuNhapThuoc(PHIEUNHAPTHUOC pnt)
        {
            PHIEUNHAPTHUOC phieuNT = db.PHIEUNHAPTHUOCs.Find(pnt.SoPhieuNhapThuoc);
            phieuNT.TrangThai = 1;
            db.SaveChanges();
        }





        public bool XoaPhieuNhap(int soPhieu)
        {
            PHIEUNHAPTHUOC phieu = db.PHIEUNHAPTHUOCs.Find(soPhieu);
            int result = 0;
            if (phieu != null)
            {
                db.PHIEUNHAPTHUOCs.Remove(phieu);
                result = db.SaveChanges();
            }

            return result > 0;
        }
        public int TongTien(int i)
        {
            List<CT_PHIEUNHAP> list = db.CT_PHIEUNHAP.Where(s => s.SoPhieuNhapThuoc == i).ToList();
            PHIEUNHAPTHUOC phieu = new PHIEUNHAPTHUOC();
            phieu.TongTien = 0;
            foreach (CT_PHIEUNHAP s in list)
            {
                phieu.TongTien += s.ThanhTien;
            }
            db.SaveChanges();
            return phieu.TongTien;

        }
        public int getTongtien(PHIEUNHAPTHUOC p)
        {
            return p.TongTien;
        }
    }
}
