using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_LOAITHUOC
    {
        dynamic LayDanhSachLoaiThuoc();
        LOAITHUOC LayLoaiThuoc(string MaLoaiThuoc);
        string LayTenLoaiThuoc(int idLoaiThuoc);
        bool KiemTra(LOAITHUOC lOAITHUOC);
        void Add(LOAITHUOC cd);
        bool Check(string ten);
        bool CapNhat(LOAITHUOC lOAITHUOC);
        List<LOAITHUOC> GetData();
        LOAITHUOC GetDataByMa(int maLoai);
        void Xoa(LOAITHUOC loaiThuoc);
        LOAITHUOC GetDataByten(string ten);

    }
    public class DAL_LOAITHUOC: IDAL_LOAITHUOC
    {
        QLPMTEntities db;

        public DAL_LOAITHUOC()
        {
            db = new QLPMTEntities();
        }
        public DAL_LOAITHUOC(QLPMTEntities qLPMTEntities)
        {
            db = qLPMTEntities;
        }
        public dynamic LayDanhSachLoaiThuoc()
        {
            var loaiThuocs = db.LOAITHUOCs.Select(s => new
            {
                s.id,
                s.MaLoaiThuoc,
                s.TenLoaiThuoc
            }).ToList();

            return loaiThuocs;
        }

        public LOAITHUOC LayLoaiThuoc(string MaLoaiThuoc)
        {
            LOAITHUOC loaiThuoc = db.LOAITHUOCs.FirstOrDefault(p => p.MaLoaiThuoc == MaLoaiThuoc);
            return loaiThuoc;
        }

        public string LayTenLoaiThuoc(int idLoaiThuoc)
        {
            LOAITHUOC loaiThuoc = db.LOAITHUOCs.Find(idLoaiThuoc);
            return loaiThuoc.TenLoaiThuoc;
        }

        public bool KiemTra(LOAITHUOC lOAITHUOC)
        {
            try
            {
                return (db.LOAITHUOCs.Any(b => b.MaLoaiThuoc == lOAITHUOC.MaLoaiThuoc));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public void Add(LOAITHUOC cd)
        {
            db.LOAITHUOCs.Add(cd);
            db.SaveChanges();
        }
        public bool Check(string ten)
        {
            var query = from c in db.LOAITHUOCs
                        where c.TenLoaiThuoc == ten
                        select c.TenLoaiThuoc;

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

        public bool CapNhat(LOAITHUOC lOAITHUOC)
        {
            try
            {
                var cd = GetDataByMa(lOAITHUOC.id);
                if (cd == null) return false;
                cd.TenLoaiThuoc = lOAITHUOC.TenLoaiThuoc;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<LOAITHUOC> GetData()
        {
            return db.LOAITHUOCs.ToList();
        }

        public LOAITHUOC GetDataByMa(int id)
        {
            return db.LOAITHUOCs.Find(id);
        }

        public void Xoa(LOAITHUOC loaiThuoc)
        {
            LOAITHUOC cd = db.LOAITHUOCs.Find(loaiThuoc.id);
            if (cd != null)
            {
                db.LOAITHUOCs.Remove(cd);
                db.SaveChanges();
            }
        }
        public LOAITHUOC GetDataByten(string ten)
        {
            return db.LOAITHUOCs.FirstOrDefault(s => s.TenLoaiThuoc == ten);
        }
     

    }
}
