using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_DANGKY
    {
        void DangKyKhamBenh(DANGKY dangKy);
        DANGKY LayDangKy(int idBenhNhan);
        dynamic LayDanhSachDangKy();
        int LaySoBenhNhanTiepNhan();
        void XoaDangKy(DANGKY dangKy);
    }
    public class DAL_DANGKY : IDAL_DANGKY
    {
        QLPMTEntities db;
        DAL_THAMSO dThamSo;
        public DAL_DANGKY()
        {
            db = new QLPMTEntities();
        }
        public DAL_DANGKY(QLPMTEntities dbContext)
        {
            db = dbContext;
        }
        public dynamic LayDanhSachDangKy()
        {

            var ds = db.DANGKies.Select(s => new
            {
                s.idMaBenhNhan
            });

            var result = new List<BENHNHAN>();

            foreach (var item in ds)
            {
                BENHNHAN bn = db.BENHNHANs.SingleOrDefault(b => b.id == item.idMaBenhNhan);
                result.Add(bn);
            }

            return result;
        }


        public void DangKyKhamBenh(DANGKY dangKy)
        {
            db.DANGKies.Add(dangKy);
            db.SaveChanges();
        }

        public void XoaDangKy(DANGKY dangKy)
        {
            DANGKY dk = db.DANGKies.SingleOrDefault(p => p.id == dangKy.id);
            if (dk == null) return;
            db.DANGKies.Remove(dk);
            db.SaveChanges();
        }

        public DANGKY LayDangKy(int idBenhNhan)
        {
            return db.DANGKies.FirstOrDefault(s => s.idMaBenhNhan == idBenhNhan);
        }


        public int LaySoBenhNhanTiepNhan()
        {
            DateTime dateTime = DateTime.Now;
            THAMSO thamSo = dThamSo.LayThamSo(1);
            int SoNguoiDK = db.DANGKies.Count();
            return thamSo.SoBenhNhanToiDa - SoNguoiDK;
        }

    }
}
