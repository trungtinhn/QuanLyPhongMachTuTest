using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_CTPHIEUNHAP
    {
        dynamic Getall(int i);
        List<CT_PHIEUNHAP> GetCTByMa(int ma);
        object GetDataCTPhieuByMaPhieu(int maPhieu);
        bool SuaChiTietPhieu(CT_PHIEUNHAP model);
        bool ThemChiTietPhieu(CT_PHIEUNHAP model);
        bool XoaAllChiTietPhieu(int soPhieu);
        bool XoaChiTietPhieu(CT_PHIEUNHAP model);
    }
    public class DAL_CT_PHIEUNHAP : IDAL_CTPHIEUNHAP
    {
        QLPMTEntities db;
        public DAL_CT_PHIEUNHAP()
        {
            db = new QLPMTEntities();
        }
        public DAL_CT_PHIEUNHAP(QLPMTEntities dbContext)
        {
            this.db = dbContext;
        }
        public List<CT_PHIEUNHAP> GetCTByMa(int ma)
        {
            return db.CT_PHIEUNHAP.Where(s => s.SoPhieuNhapThuoc == ma).ToList();
        }
        public bool ThemChiTietPhieu(CT_PHIEUNHAP model)
        {
            CT_PHIEUNHAP ct = db.CT_PHIEUNHAP.Where(m => m.SoPhieuNhapThuoc == model.SoPhieuNhapThuoc && m.idMaThuoc == model.idMaThuoc).FirstOrDefault();
            if (ct == null)
            {
                model.ThanhTien = model.SoLuongNhap * model.DonGiaNhap;
                db.CT_PHIEUNHAP.Add(model);
            }
            else
            {
                ct.SoLuongNhap += model.SoLuongNhap;
                ct.DonGiaNhap = model.DonGiaNhap;
                ct.ThanhTien = ct.SoLuongNhap * ct.DonGiaNhap;
            }
            int result = db.SaveChanges();

            return result > 0;
        }
        public object GetDataCTPhieuByMaPhieu(int maPhieu)
        {
            var query = db.CT_PHIEUNHAP
                .Where(m => m.SoPhieuNhapThuoc == maPhieu)
                .Select(m => new
                {
                    m.idMaThuoc,
                    m.THUOC.TenThuoc,
                    m.SoLuongNhap,
                    m.DonGiaNhap,
                    m.ThanhTien
                })
                .ToList();

            return query;
        }
        public bool XoaChiTietPhieu(CT_PHIEUNHAP model)
        {
            CT_PHIEUNHAP ct = db.CT_PHIEUNHAP.Where(m => m.SoPhieuNhapThuoc == model.SoPhieuNhapThuoc && m.idMaThuoc == model.idMaThuoc).FirstOrDefault();
            int result = 0;
            if (ct != null)
            {
                db.CT_PHIEUNHAP.Remove(ct);
                result = db.SaveChanges();
            }

            return result > 0;
        }

        public bool SuaChiTietPhieu(CT_PHIEUNHAP model)
        {
            CT_PHIEUNHAP ct = db.CT_PHIEUNHAP.Where(m => m.SoPhieuNhapThuoc == model.SoPhieuNhapThuoc && m.idMaThuoc == model.idMaThuoc).FirstOrDefault();
            int result = 0;
            if (ct != null)
            {
                ct.SoLuongNhap = model.SoLuongNhap;
                ct.DonGiaNhap = model.DonGiaNhap;
                ct.ThanhTien = model.SoLuongNhap * model.DonGiaNhap;
                result = db.SaveChanges();
                PHIEUNHAPTHUOC pn = new PHIEUNHAPTHUOC();

            }

            return result > 0;
        }
        public bool XoaAllChiTietPhieu(int soPhieu)
        {
            foreach (CT_PHIEUNHAP ct in db.CT_PHIEUNHAP)
            {
                if (ct.SoPhieuNhapThuoc == soPhieu)
                    db.CT_PHIEUNHAP.Remove(ct);
            }
            int result = db.SaveChanges();

            return result > 0;
        }
        public dynamic Getall(int i)
        {
            var ds = db.CT_PHIEUNHAP.Where(s => s.SoPhieuNhapThuoc == i).ToList();
            return ds;
        }

    }
}
