using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public interface IDAL_DONVI
    {
        void Add(DONVI cd);
        void CapNhat(DONVI dONVI);
        bool Check(string ten);
        List<DONVI> getall();
        DONVI GetByten(string ten);
        DONVI getDVbyID(int idMaDonVi);
        bool KiemTra(DONVI dONVI);
        object LayDanhSach();
        void Xoa(DONVI dONVI);
    }
    public class DAL_DONVI : IDAL_DONVI
    {
        QLPMTEntities db;
        public DAL_DONVI()
        {
            db = new QLPMTEntities();
        }


        public dynamic LayDanhSach()
        {
            var danhsach = db.DONVIs.Select(s => new
            {
                s.id,
                s.MaDonvi,
                s.TenDonVi,
            }).ToList();

            return danhsach;
        }


        public bool KiemTra(DONVI dONVI)
        {
            try
            {
                DONVI bn = db.DONVIs.SingleOrDefault(b => b.MaDonvi == dONVI.MaDonvi);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }

        }

        public void Add(DONVI cd)
        {
            db.DONVIs.Add(cd);
            db.SaveChanges();
        }


        public bool Check(string ten)
        {
            var query = from c in db.DONVIs
                        where c.TenDonVi == ten
                        select c.TenDonVi;

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



        public void Xoa(DONVI dONVI)
        {
            DONVI cd = db.DONVIs.Find(dONVI.id);
            if (cd != null)
            {
                db.DONVIs.Remove(cd);
                db.SaveChanges();
            }
        }


        public void CapNhat(DONVI dONVI)
        {
            DONVI cd = db.DONVIs.SingleOrDefault(b => b.MaDonvi == dONVI.MaDonvi);
            cd.TenDonVi = dONVI.TenDonVi;
            db.SaveChanges();
        }


        public List<DONVI> getall()
        {
            return db.DONVIs.ToList();
        }


        public DONVI GetByten(string ten)
        {
            return db.DONVIs.FirstOrDefault(s => s.TenDonVi == ten);
        }

        public DONVI getDVbyID(int idMaDonVi)
        {
            return db.DONVIs.Find(idMaDonVi);
        }
    }

}
