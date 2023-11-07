using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BENH
    {
        QLPMTEntities db;
   
        public DAL_BENH()
        {
            db = new QLPMTEntities();
           
        }

        public dynamic LayThongTinBenh()
        {
            var dsBenh = db.BENHs.Select(s => new
            {
                s.id

            }).ToList();

            var benhs = new List<BENH>();

            foreach (var b in dsBenh)
            {
                BENH benh = db.BENHs.Find(b.id);
                benhs.Add(benh);
            }

            return benhs;
        }

        public void XoaBenh(BENH benh)
        {
            BENH b = db.BENHs.SingleOrDefault(p => p.MaBenh == benh.MaBenh);
            db.BENHs.Remove(b);
            db.SaveChanges();
        }

     

        public void ThemBenh(BENH benh)
        {
            db.BENHs.Add(benh);
            db.SaveChanges();
        }

        public void CapNhatBenh(BENH benh)
        {
            BENH b = db.BENHs.SingleOrDefault(p => p.MaBenh == benh.MaBenh);
            
            b.TenBenh = benh.TenBenh;
            b.TrieuChung = benh.TrieuChung;
            b.idMaThuocDacTri = benh.idMaThuocDacTri;
            b.idMaLoaiBenh = benh.idMaLoaiBenh;
            db.SaveChanges();
        }

        public bool KiemTraBenh(BENH benh)
        {
            try
            {
                BENH b = db.BENHs.FirstOrDefault(p => p.MaBenh == benh.MaBenh);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public BENH LayBenh(string maBenh)
        {
            BENH b = db.BENHs.FirstOrDefault(p => p.MaBenh == maBenh);
            return b;
        }
        public BENH LayBenh(int maBenh)
        {
            BENH b = db.BENHs.Find(maBenh);
            return b;
        }

        public dynamic LocBenh(string kieuLoc, string giaTri)
        {

            List<BENH> benhs = new List<BENH>();

            if (kieuLoc == "Tất cả")
            {
                benhs = db.BENHs.ToList();
            }
            if (kieuLoc == "Mã bệnh")
            {
                benhs = db.BENHs.Where(p => p.MaBenh.Contains(giaTri)).ToList();
            }
            else if(kieuLoc == "Tên bệnh")
            {
                benhs = db.BENHs.Where(p => p.TenBenh.Contains(giaTri)).ToList();
            }

            else if (kieuLoc == "Triệu chứng")
            {
                benhs = db.BENHs.Where(p => p.TrieuChung.Contains(giaTri)).ToList();
            }

            return benhs;
        }

    }
}
