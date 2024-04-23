using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Model
{
    class CongTy
    {
        [Key]
        public int MaCongTy { get; set; }
        public string TenCongTy { get; set; }
        public string DiaChi { get; set; }
    }
}
