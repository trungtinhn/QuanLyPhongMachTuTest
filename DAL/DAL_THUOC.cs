using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_THUOC
    {
        QLPMTEntities db;
        DAL_THAMSO dThamSoDAL;
        public DAL_THUOC()
        {
            db = new QLPMTEntities();
            dThamSoDAL = new DAL_THAMSO();
        }
        public dynamic LayDanhSach()
        {
            var danhsach = db.THUOCs.Select(s => new
            {
                s.id,
                s.MaThuoc,
                s.TenThuoc,
                s.idMaLoaiThuoc,
                s.idMaCachDung,
                s.idMaDonVi,
                s.HuongDanSuDung,
                s.SoLuongTon,
                s.DonGia,
                s.CongDung
            }).ToList();

            return danhsach;
        }

        public dynamic LayDanhSachThuoc(int idLoaiThuoc)
        {
            var thuocs = db.THUOCs.Where(p => p.idMaLoaiThuoc == idLoaiThuoc).ToList();
            return thuocs;
        }

        public dynamic DanhSachThuoc()
        {
            return db.THUOCs.ToList();
        }

        public THUOC LayThuoc(string maThuoc)
        {
            THUOC thuoc = db.THUOCs.FirstOrDefault(s => s.MaThuoc == maThuoc);
            return thuoc;
        }

        public THUOC LayTenThuoc(int idThuoc)
        {
            THUOC thuoc = db.THUOCs.Find(idThuoc);
            return thuoc;
        }

        public THUOC LayThongTinThuoc(string tenThuoc)
        {
            THUOC thuoc = db.THUOCs.FirstOrDefault(s => s.TenThuoc == tenThuoc);
            return thuoc;
        }

        public List<THUOC> GetDataByMaLoai(int maLoai)
        {
            return db.THUOCs.Where(m => m.idMaLoaiThuoc == maLoai).ToList();
        }

        public THUOC GetDataByMa(int maThuoc)
        {
            return db.THUOCs.SingleOrDefault(m => m.id == maThuoc);
        }


        public bool KiemTra(THUOC tHUOC)
        {
            try
            {
                if (db.THUOCs.Any(b => b.MaThuoc == tHUOC.MaThuoc)) ;
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }


        }
        public void Add(THUOC cd)
        {
            db.THUOCs.Add(cd);
            db.SaveChanges();
        }
        public bool Check(string ten)
        {
            var query = from c in db.THUOCs
                        where c.TenThuoc == ten
                        select c.TenThuoc;

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



        public bool CapNhat(THUOC tHUOC)
        {
            try
            {
                var cd = GetDataByMa(tHUOC.id);
                if (cd == null) return false;
                cd.TenThuoc = tHUOC.TenThuoc;
                cd.idMaLoaiThuoc = tHUOC.idMaLoaiThuoc;
                cd.idMaCachDung = tHUOC.idMaCachDung;
                cd.idMaDonVi = tHUOC.idMaDonVi;
                cd.DonGia = tHUOC.DonGia;
                cd.CongDung = tHUOC.CongDung;
                cd.HuongDanSuDung = tHUOC.HuongDanSuDung;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<THUOC> Getall()
        {
            return db.THUOCs.ToList();
        }




        public List<THUOC> getThuocSapHet()
        {
            THAMSO thamso = dThamSoDAL.LayThamSo(1);
            return db.THUOCs.Where(s => s.SoLuongTon <= thamso.SoLuongSapHet).ToList();
        }

        public bool CapNhatSoLuongTon(int idThuoc, int soLuongCapNhat) 
        {
            THUOC thuoc = db.THUOCs.Find(idThuoc);

            if (thuoc.SoLuongTon < soLuongCapNhat) return false;


            thuoc.SoLuongTon -= soLuongCapNhat;
            db.SaveChanges();

            return true;
        }

        public THUOC GetThuocbyMa(int i)
        {
            return db.THUOCs.SingleOrDefault(s => s.id == i);
        }
        public void Luu(THUOC t)
        {
            THUOC s = db.THUOCs.Where(a => a.id == t.id).FirstOrDefault();
            db.SaveChanges();
        }
        public THUOC GetTenById(int idMaThuoc)
        {
            return db.THUOCs.Find(idMaThuoc);
        }

        //public dynamic LocThuoc(string giaTriTenThuoc)
        //{
        //    return db.THUOCs.Where(p => p.TenThuoc.Contains(giaTriTenThuoc)).ToList();
        //}
    }
}
