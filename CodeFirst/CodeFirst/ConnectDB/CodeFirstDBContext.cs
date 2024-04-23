using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CodeFirst.Model;
namespace CodeFirst.ConnectDB
{
    class CodeFirstDBContext : DbContext
    {
        public CodeFirstDBContext() : base("myConnectStr") { }
        public DbSet<CongTy> congTys { get; set; }
        public DbSet<PhongBan> phongBans { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
    }
}
