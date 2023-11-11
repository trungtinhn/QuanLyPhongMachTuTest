﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public interface IDAL_CACHDUNG
    {
        void AddCachDung(CACHDUNG cd);
        void CapNhatCachDung(CACHDUNG cACHDUNG);
        bool CheckCachDung(string ten);
        List<CACHDUNG> getall();
        CACHDUNG GetByTen(string ten);
        CACHDUNG getCDbyID(int idMaCachDung);
        bool KiemTraCachDung(CACHDUNG cACHDUNG);
        object LayDanhSach();
        void XoaCachDung(CACHDUNG cACHDUNG);
    }
    public class DAL_CACHDUNG : IDAL_CACHDUNG
    {
        QLPMTEntities db;

        public DAL_CACHDUNG()
        {
            db = new QLPMTEntities();
        }
        //GET DANHSACH
        public dynamic LayDanhSach()
        {
            var danhsach = db.CACHDUNGs.Select(s => new
            {
                s.id,
                s.MaCachDung,
                s.TenCachDung,
            }).ToList();
            return danhsach;
        }

        public bool KiemTraCachDung(CACHDUNG cACHDUNG)
        {
            try
            {
                CACHDUNG bn = db.CACHDUNGs.SingleOrDefault(b => b.MaCachDung == cACHDUNG.MaCachDung);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //ADD
        public void AddCachDung(CACHDUNG cd)
        {
            try
            {
                db.CACHDUNGs.Add(cd);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw; // Rethrow the exception to signal that the addition failed
            }
        }



        public bool CheckCachDung(string ten)
        {
            var query = from c in db.CACHDUNGs
                        where c.TenCachDung == ten
                        select c.TenCachDung;

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



        public void XoaCachDung(CACHDUNG cACHDUNG)
        {
            CACHDUNG cd = db.CACHDUNGs.Find(cACHDUNG.id);
            if (cd != null)
            {
                db.CACHDUNGs.Remove(cd);
                db.SaveChanges();
            }
        }



        public void CapNhatCachDung(CACHDUNG cACHDUNG)
        {
            CACHDUNG cd = db.CACHDUNGs.SingleOrDefault(b => b.MaCachDung == cACHDUNG.MaCachDung);
            cd.TenCachDung = cACHDUNG.TenCachDung;
            db.SaveChanges();
        }



        public List<CACHDUNG> getall()
        {
            return db.CACHDUNGs.ToList();
        }


        public CACHDUNG GetByTen(string ten)
        {
            return db.CACHDUNGs.FirstOrDefault(s => s.TenCachDung == ten);
        }



        public CACHDUNG getCDbyID(int idMaCachDung)
        {
            return db.CACHDUNGs.Find(idMaCachDung);
        }
    }
}
