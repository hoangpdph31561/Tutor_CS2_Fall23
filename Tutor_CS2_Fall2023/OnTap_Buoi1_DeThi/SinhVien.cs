using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_Buoi1_DeThi
{
    internal class SinhVien
    {
        private string ten;
        private string maSV;
        private int namSinh;
        private double diemTB;
        public SinhVien()
        {
            
        }

        public SinhVien(string ten, string maSV, int namSinh, double diemTB)
        {
            this.ten = ten;
            this.maSV = maSV;
            this.namSinh = namSinh;
            this.diemTB = diemTB;
        }

        public string Ten { get => ten; set => ten = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }
        public virtual void InThongTin()
        {
            Console.WriteLine($"Tên: {ten}" +
                $"Mã sinh viên: {maSV}" +
                $"Năm sinh {namSinh}" +
                $"Điểm TB {diemTB}");
        }
        public int TinhTuoi()
        {
            return DateTime.Now.Year - namSinh;
        }
    }
}
