using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_Buoi1_DeThi
{
    internal class SinhVienUDPM : SinhVien
    {
        private double diemJava;
        private double diemCSharp;
        public SinhVienUDPM()
        {
            
        }

        public SinhVienUDPM(string ten, string maSV, int namSinh, double diemTB, double diemJava, double diemCSharp) : base(ten, maSV, namSinh, diemTB)
        {
            this.diemJava = diemJava;
            this.diemCSharp = diemCSharp;
        }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Điểm Java: {diemJava} Điểm C# {diemCSharp}");
        }
    }
}
