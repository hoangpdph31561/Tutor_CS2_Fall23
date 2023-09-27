using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_OnTapOOP
{
    internal class Cat : Animal
    {
        private string color;
        public Cat()
        {
            
        }

        public Cat(string name, int hight, int birthYear, string color) : base(name, hight, birthYear)
        {
            this.color = color;
        }

        public string Color { get => color; set => color = value; }
        public void AnCom()
        {
            Console.WriteLine("Làm gì bát mà ăn");
        }
        public void AnCom(int batCom)
        {
            Console.WriteLine($"Hôm năng ăn {batCom}");
        }
        public void AnCom(int batCom, string monAn)
        {
            Console.WriteLine($"Hôm năng ăn {batCom} ăn thêm {monAn}");
        }
        

        public override int TinhTuoi()
        {
            return DateTime.Now.Year - BirthYear;
        }
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine($"Màu sắc: {color}");
        }

    }
}
