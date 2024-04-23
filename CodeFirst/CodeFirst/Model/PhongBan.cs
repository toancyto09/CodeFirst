using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Model
{
    class PhongBan
    {
        [Key]
        public int MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }
        public string SDT { get; set; }
        public virtual CongTy congTy { get; set; }
    }
}
