using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LOGIN
    {
        public bool Login(string username, string password)
        {
            using (QLPMTEntities dbContext = new QLPMTEntities())
            {
                return dbContext.NGUOIDUNGs.Any(a => a.TenDangNhap == username && a.MatKhau == password);
            }
        }
        public bool Check(string username)
        {
            using (QLPMTEntities dbContext = new QLPMTEntities())
            {
                return dbContext.NGUOIDUNGs.Any(a => a.TenDangNhap == username);
            }
        }
    }
}
