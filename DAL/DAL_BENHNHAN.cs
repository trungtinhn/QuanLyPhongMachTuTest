using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_BENHNHAN
    {
        void CapNhatBenhNhan(BENHNHAN benhNhan);
        bool KiemTraBenhNhan(BENHNHAN benhNhan);
        List<BENHNHAN> LayDanhSachBenhNhan(string kieuLoc, string giaTri, DateTime ngaySinh);
        BENHNHAN LayThongTinBenhNhan(string maBenhNhan);
        BENHNHAN LayThongTinBenhNhan(int idBenhNhan);
        void ThemBenhNhan(BENHNHAN benhNhan);
        void XoaBenhNhan(BENHNHAN benhNhan);
    }
    public class DAL_BENHNHAN : IDAL_BENHNHAN
    {

        QLPMTEntities db;
        public DAL_BENHNHAN()
        {
            db = new QLPMTEntities();
        }
        public List<BENHNHAN> LayDanhSachBenhNhan(string kieuLoc, string giaTri, DateTime ngaySinh)
        {

            List<BENHNHAN> danhSach = new List<BENHNHAN>();
            if(kieuLoc == "Tất cả")
            {
                danhSach = db.BENHNHANs.ToList();
            }else if(kieuLoc == "Mã bệnh nhân")
            {
                danhSach = db.BENHNHANs.Where(p => p.MaBenhNhan.Contains(giaTri)).ToList();
            }else if(kieuLoc == "Tên bệnh nhân")
            {
                danhSach = db.BENHNHANs.Where(p => p.HoTenBenhNhan.Contains(giaTri)).ToList();
            }else if( kieuLoc == "Giới tính")
            {
                danhSach = db.BENHNHANs.Where(p => p.GioiTinh.Contains(giaTri)).ToList();
            }else if(kieuLoc =="Ngày sinh")
            {
                danhSach = db.BENHNHANs.Where(p => p.NgaySinh.Day == ngaySinh.Day && p.NgaySinh.Month == ngaySinh.Month && p.NgaySinh.Year == ngaySinh.Year).ToList();
            }else if (kieuLoc == "Địa chỉ")
            {
                danhSach = db.BENHNHANs.Where(p => p.DiaChi.Contains(giaTri)).ToList();
            }



            //var danhsach = db.BENHNHANs.Select(s => new
            //{
 
            //    s.MaBenhNhan,
            //    s.HoTenBenhNhan,
            //    s.GioiTinh,
            //    s.NgaySinh,
            //    s.DiaChi,
               
            //}).ToList();

            return danhSach;
        }

        public void ThemBenhNhan(BENHNHAN benhNhan)
        {
            db.BENHNHANs.Add(benhNhan);
            db.SaveChanges();
        }

        public bool KiemTraBenhNhan(BENHNHAN benhNhan)
        {
            try
            {
                BENHNHAN bn = db.BENHNHANs.SingleOrDefault(b => b.MaBenhNhan == benhNhan.MaBenhNhan);
               
                return true;
            }
            catch (Exception ex)
            {
              
                Console.WriteLine(ex.Message);
            }
           
            return false;
        }

        public void CapNhatBenhNhan(BENHNHAN benhNhan)
        {
            BENHNHAN bn = db.BENHNHANs.SingleOrDefault(b => b.MaBenhNhan == benhNhan.MaBenhNhan);
            bn.HoTenBenhNhan = benhNhan.HoTenBenhNhan;
            bn.NgaySinh = benhNhan.NgaySinh;
            bn.DiaChi = benhNhan.DiaChi;
            bn.GioiTinh = benhNhan.GioiTinh;

            db.SaveChanges();
        }

        public void XoaBenhNhan(BENHNHAN benhNhan)
        {
            BENHNHAN bn = db.BENHNHANs.SingleOrDefault(b => b.MaBenhNhan == benhNhan.MaBenhNhan);
            db.BENHNHANs.Remove(bn);
            db.SaveChanges();
        }

        public BENHNHAN LayThongTinBenhNhan(string MaBenhNhan)
        {
            BENHNHAN bn = db.BENHNHANs.FirstOrDefault(p => p.MaBenhNhan == MaBenhNhan);
            if (bn == null)
            {
                return null;
            }
            return bn;
        }
        public BENHNHAN LayThongTinBenhNhan(int idBenhNhan)
        {
            BENHNHAN bn = db.BENHNHANs.Find(idBenhNhan);
            if (bn == null)
            {
                return null;
            }
            return bn;
        }

        public dynamic LocBenhNhan(string kieuLoc, string giaTri)
        {
            List<BENHNHAN> danhSach = new List<BENHNHAN>();
            if(kieuLoc == "Mã bệnh nhân")
            {
                danhSach = db.BENHNHANs.Where(p => p.MaBenhNhan.Contains(giaTri)).ToList();
            }else if(kieuLoc =="Tên bệnh nhân")
            {
                danhSach = db.BENHNHANs.Where(p => p.HoTenBenhNhan.Contains(giaTri)).ToList();
            }
            return danhSach;
        }


    }

   
}
