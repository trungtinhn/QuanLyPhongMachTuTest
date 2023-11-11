using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_LOAIBENH
    {
        dynamic LayDanhSachLoaiBenh(string kieuLoc, string giaTri);
        string LayTenLoaiBenh(int maBenh);
        void ThemLoaiBenh(LOAIBENH loaiBenh);
        bool KiemTraLoaiBenh(LOAIBENH loaiBenh);
        void CapNhatLoaiBenh(LOAIBENH loaiBenh);
        void XoaLoaiBenh(LOAIBENH loaiBenh);
        LOAIBENH LayThongTinLoaiBenh(string tenLoaiBenh);

    }
    public class DAL_LOAIBENH: IDAL_LOAIBENH
    {
        QLPMTEntities db;
        IDAL_BENH dBenhDAL;

        public DAL_LOAIBENH()
        {
            db = new QLPMTEntities();
            dBenhDAL = new DAL_BENH();  
        }
        public DAL_LOAIBENH(QLPMTEntities qLPMTEntities, IDAL_BENH dAL_BENH)
        {
            db = qLPMTEntities;
            dBenhDAL = dAL_BENH;
        }
        public dynamic LayDanhSachLoaiBenh(string kieuLoc, string giaTri)
        {

            List<LOAIBENH> danhSach = new List<LOAIBENH>();

            if (kieuLoc == "Tất cả")
            {
                danhSach = db.LOAIBENHs.ToList();
            }else if(kieuLoc == "Mã loại bệnh")
            {
                danhSach = db.LOAIBENHs.Where(p => p.MaLoaiBenh.Contains(giaTri)).ToList();
            }else if (kieuLoc == "Tên loại bệnh")
            {
                danhSach = db.LOAIBENHs.Where(p => p.TenLoaiBenh.Contains(giaTri)).ToList();
            }
            return danhSach;
        }

        public string LayTenLoaiBenh(int maBenh)
        {
            LOAIBENH loaiBenh = db.LOAIBENHs.Find(maBenh);
            return loaiBenh.TenLoaiBenh.ToString();
        }

        public void ThemLoaiBenh(LOAIBENH loaiBenh)
        {
            db.LOAIBENHs.Add(loaiBenh);
            db.SaveChanges();
        }
        public bool KiemTraLoaiBenh(LOAIBENH loaiBenh)
        {
            try
            {
                LOAIBENH lb = db.LOAIBENHs.SingleOrDefault(b => b.MaLoaiBenh == loaiBenh.MaLoaiBenh);
                if (lb == null) return false;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void CapNhatLoaiBenh(LOAIBENH loaiBenh)
        {
            LOAIBENH lb = db.LOAIBENHs.FirstOrDefault(b => b.MaLoaiBenh == loaiBenh.MaLoaiBenh);
            lb.TenLoaiBenh = loaiBenh.TenLoaiBenh;

            db.SaveChanges();
        }

        public void XoaLoaiBenh(LOAIBENH loaiBenh)
        {
            LOAIBENH lb = db.LOAIBENHs.FirstOrDefault(p => p.MaLoaiBenh == loaiBenh.MaLoaiBenh);

            var benhs = db.BENHs.Where(p => p.idMaLoaiBenh == lb.id);

            foreach(BENH benh in benhs)
            {
                dBenhDAL.XoaBenh(benh);
            }

            db.LOAIBENHs.Remove(lb);
            db.SaveChanges();
        }

        public LOAIBENH LayThongTinLoaiBenh(string tenLoaiBenh)
        {
            LOAIBENH lb = db.LOAIBENHs.FirstOrDefault(p => p.TenLoaiBenh == tenLoaiBenh);
            return lb;
        }
    }
}
