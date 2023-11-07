using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LOAITHUOC
    {
        QLPMTEntities db;

        public DAL_LOAITHUOC()
        {
            db = new QLPMTEntities();
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

        public string LayTenLoaiThuoc(int idLoaiBenh)
        {
            LOAITHUOC loaiBenh = db.LOAITHUOCs.Find(idLoaiBenh);
            return loaiBenh.TenLoaiThuoc;
        }

        public bool KiemTra(LOAITHUOC lOAITHUOC)
        {
            try
            {
                if (db.LOAITHUOCs.Any(b => b.MaLoaiThuoc == lOAITHUOC.MaLoaiThuoc)) ;
                return true;
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

        public LOAITHUOC GetDataByMa(int maLoai)
        {
            return db.LOAITHUOCs.SingleOrDefault(m => m.id == maLoai);
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

        public LOAITHUOC getLTbyID(int i)
        {
            return db.LOAITHUOCs.Find(i);
        }

        public List<LOAITHUOC> getall()
        {
            return db.LOAITHUOCs.ToList();
        }


        public LOAITHUOC GetByten(string ten)
        {
            return db.LOAITHUOCs.FirstOrDefault(s => s.TenLoaiThuoc == ten);
        }

       
     
        public THUOC GetTenById(int idMaThuoc)
        {
            return db.THUOCs.Find(idMaThuoc);
        }

    }
}
