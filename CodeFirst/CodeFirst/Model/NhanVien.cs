using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Model
{
    class NhanVien
    {
        [Key]
        public int MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public virtual PhongBan phongBan { get; set; }
    }
}
