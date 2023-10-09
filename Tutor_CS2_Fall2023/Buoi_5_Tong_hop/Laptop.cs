using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_Tong_hop
{
    internal class Laptop
    {
        private int id;
        private string ten;
        private int gia;
        private int ram;
        private double khoiLuong;
        public Laptop()
        {
            
        }

        public Laptop(int id, string ten, int gia, int ram, double khoiLuong)
        {
            this.id = id;
            this.ten = ten;
            this.gia = gia;
            this.ram = ram;
            this.khoiLuong = khoiLuong;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public int Gia { get => gia; set => gia = value; }
        public int Ram { get => ram; set => ram = value; }
        public double KhoiLuong { get => khoiLuong; set => khoiLuong = value; }
        public void InThongTin()
        {
            Console.WriteLine($"ID: {id} Tên: {ten} Giá: {gia} Ram: {ram} Khối lượng: {khoiLuong}");
        }
        public string GetObj()
        {
            return $"{id}|{ten}|{gia}|{ram}|{khoiLuong}\n";
        }
    }
}
