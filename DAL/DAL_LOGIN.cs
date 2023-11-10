using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL_LOGIN
    {
        bool Login(string username, string password);
        bool Check(String username);

    }
    public class DAL_LOGIN: IDAL_LOGIN
    {
        QLPMTEntities db;
        public DAL_LOGIN()
        {
            db = new QLPMTEntities();

        }
        public DAL_LOGIN(QLPMTEntities dbContext)
        {
            this.db = dbContext;
        }
        public bool Login(string username, string password)
        {
            return db.NGUOIDUNGs.Any(a => a.TenDangNhap == username && a.MatKhau == password);
        }
        public bool Check(string username)
        {
            return db.NGUOIDUNGs.Any(a => a.TenDangNhap == username);
        }
    }
}
