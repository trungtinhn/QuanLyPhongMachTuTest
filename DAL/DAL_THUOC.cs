using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_THUOC
    {
        dynamic LayDanhSachThuoc(int idLoaiThuoc);
        THUOC LayThuocByMa(string maThuoc);
        THUOC LayThuocById(int idThuoc);
        THUOC LayThongTinThuoc(string tenThuoc);
        bool KiemTra(THUOC tHUOC);
        void Add(THUOC cd);
        bool Check(string ten);
        bool CapNhat(THUOC tHUOC);
        List<THUOC> getThuocSapHet();
        List<THUOC> Getall();
        bool CapNhatSoLuongTon(int idThuoc, int soLuongCapNhat);

    }
    public class DAL_THUOC: IDAL_THUOC
    {
        QLPMTEntities db;
        IDAL_THAMSO dThamSoDAL;
        public DAL_THUOC()
        {
            db = new QLPMTEntities();
            dThamSoDAL = new DAL_THAMSO();
        }
        public DAL_THUOC(QLPMTEntities qLPMTEntities, IDAL_THAMSO dAL_THAMSO)
        {
            db = qLPMTEntities;
            dThamSoDAL = dAL_THAMSO;
        }

        public dynamic LayDanhSachThuoc(int idLoaiThuoc)
        {
            var thuocs = db.THUOCs.Where(p => p.idMaLoaiThuoc == idLoaiThuoc).ToList();
            return thuocs;
        }

        public THUOC LayThuocByMa(string maThuoc)
        {
            THUOC thuoc = db.THUOCs.FirstOrDefault(s => s.MaThuoc == maThuoc);
            return thuoc;
        }

        public THUOC LayThuocById(int idThuoc)
        {
            THUOC thuoc = db.THUOCs.Find(idThuoc);
            return thuoc;
        }

        public THUOC LayThongTinThuoc(string tenThuoc)
        {
            THUOC thuoc = db.THUOCs.FirstOrDefault(s => s.TenThuoc == tenThuoc);
            return thuoc;
        }
        //public List<THUOC> GetDataByMaLoai(int maLoai)
        //{
        //    return db.THUOCs.Where(m => m.idMaLoaiThuoc == maLoai).ToList();
        //}
        public bool KiemTra(THUOC tHUOC)
        {
            try
            {
                return (db.THUOCs.Any(b => b.MaThuoc == tHUOC.MaThuoc));
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void Add(THUOC cd)
        {
            db.THUOCs.Add(cd);
            db.SaveChanges();
        }
        public bool Check(string ten)
        {
            var query = from c in db.THUOCs
                        where c.TenThuoc == ten
                        select c.TenThuoc;

            ten = query.FirstOrDefault();

            if (ten != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CapNhat(THUOC tHUOC)
        {
            try
            {
                var cd = LayThuocById(tHUOC.id);
                if (cd == null) return false;
                cd.TenThuoc = tHUOC.TenThuoc;
                cd.idMaLoaiThuoc = tHUOC.idMaLoaiThuoc;
                cd.idMaCachDung = tHUOC.idMaCachDung;
                cd.idMaDonVi = tHUOC.idMaDonVi;
                cd.DonGia = tHUOC.DonGia;
                cd.CongDung = tHUOC.CongDung;
                cd.HuongDanSuDung = tHUOC.HuongDanSuDung;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<THUOC> Getall()
        {
            return db.THUOCs.ToList();
        }

        public List<THUOC> getThuocSapHet()
        {
            THAMSO thamso = dThamSoDAL.LayThamSo(1);
            return db.THUOCs.Where(s => s.SoLuongTon <= thamso.SoLuongSapHet).ToList();
        }

        public bool CapNhatSoLuongTon(int idThuoc, int soLuongCapNhat)
        {
            THUOC thuoc = db.THUOCs.Find(idThuoc);
            if (thuoc == null) return false;
            if (thuoc.SoLuongTon < soLuongCapNhat) return false;
            thuoc.SoLuongTon -= soLuongCapNhat;
            db.SaveChanges();

            return true;
        }
    }
}
