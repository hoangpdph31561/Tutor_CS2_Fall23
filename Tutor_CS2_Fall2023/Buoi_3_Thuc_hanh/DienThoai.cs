using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3_Thuc_hanh
{
    internal class DienThoai
    {
        private int id;
        private string ten;
        private string nhaSanXuat;
        private int namSanXuat;
        public DienThoai()
        {
            
        }

        public DienThoai(int id, string ten, string nhaSanXuat, int namSanXuat)
        {
            this.id = id;
            this.ten = ten;
            this.nhaSanXuat = nhaSanXuat;
            this.namSanXuat = namSanXuat;
        }

        public int Id { get => id; set => id = value; }
        public string Ten { get => ten; set => ten = value; }
        public string NhaSanXuat { get => nhaSanXuat; set => nhaSanXuat = value; }
        public int NamSanXuat { get => namSanXuat; set => namSanXuat = value; }
        public void InThongTin()
        {
            Console.WriteLine($"ID: {id}. Tên: {ten}. Nhà sản xuất: {nhaSanXuat}. Năm sản xuất: {namSanXuat}");
        }
        public string GetObj()
        {
            return $"{id}|{ten}|{nhaSanXuat}|{namSanXuat}\n";
        }
    }
}
