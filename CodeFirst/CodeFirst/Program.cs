using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.ConnectDB;
using CodeFirst.Model;
namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            CodeFirstDBContext db = new CodeFirstDBContext();
            /*PhongBan pb = new PhongBan();
            pb.MaPhongBan = 02;
            pb.TenPhongBan="Nhan Su";
            pb.SDT="026884254";*/

            /*NhanVien nv = new NhanVien();
            nv.MaNhanVien = 004;
            nv.HoTen = "Huynh Van Toan";
            nv.QueQuan = "Quảng Trị";
            nv.GioiTinh = "Nam";
            nv.Tuoi = 40;
            /*foreach (var i in db.nhanViens)
            {
                Console.WriteLine($"{i.HoTen}");
            };
            db.nhanViens.Add(nv);
            db.SaveChanges();*/
            var nhanViens = db.nhanViens
                    .Where(nv => nv.GioiTinh == "Nam" && nv.phongBan.TenPhongBan == "Marketing" && nv.Tuoi >= 30 && nv.Tuoi <= 40)
                    .ToList();
            foreach (var nhanVien in nhanViens)
            {
                Console.WriteLine($"Tên nhân viên: {nhanVien.HoTen}, Tuổi: {nhanVien.Tuoi}, Quê quán: {nhanVien.QueQuan}");
            }
            Console.ReadKey();
        }
    }
}
