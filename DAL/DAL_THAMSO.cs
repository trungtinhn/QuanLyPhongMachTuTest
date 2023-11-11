using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_THAMSO
    {
        THAMSO LayThamSo(int id);
        void ThayDoiThamSo(int TienKham, int SoBenhNhanToiDa, int SoLuongThuocSapHet);
    }
    public class DAL_THAMSO: IDAL_THAMSO
    {
        QLPMTEntities db;
        public DAL_THAMSO()
        {
            db = new QLPMTEntities();
        }
        public DAL_THAMSO(QLPMTEntities dbContext)
        {
            db = dbContext;
        }

        public THAMSO LayThamSo(int id) 
        {
            return db.THAMSOes.Find(id);
        }

        public void ThayDoiThamSo(int TienKham, int SoBenhNhanToiDa, int SoLuongThuocSapHet)
        {
            THAMSO thamSo = db.THAMSOes.Find(1);
            thamSo.TienKham = TienKham;
            thamSo.SoBenhNhanToiDa = SoBenhNhanToiDa;
            thamSo.SoLuongSapHet = SoLuongThuocSapHet;
            db.SaveChanges();
        }
    }
}
