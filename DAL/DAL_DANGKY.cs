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
            dThamSo = new DAL_THAMSO(); 
        }
        public DAL_DANGKY(QLPMTEntities dbContext)
        {
            this.db = dbContext;
            dThamSo = new DAL_THAMSO();
        }
        public dynamic LayDanhSachDangKy()
        {
            DateTime date = DateTime.Now;
            var ds = db.DANGKies.Where(p => p.NgayDangKy.Day == date.Day && p.NgayDangKy.Month == date.Month && p.NgayDangKy.Year == date.Year).Select(s => new
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

            var changedEntries = db.ChangeTracker.Entries<DANGKY>().Where(x => x.State != EntityState.Unchanged);
        }

        public void XoaDangKy(DANGKY dangKy)
        {
            db.DANGKies.Remove(dangKy);
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
            int SoNguoiDK = db.DANGKies.Where(p => p.NgayDangKy.Day == dateTime.Day && p.NgayDangKy.Month == dateTime.Month && p.NgayDangKy.Year == dateTime.Year).Count();
            return thamSo.SoBenhNhanToiDa - SoNguoiDK;
        }

    }
}
