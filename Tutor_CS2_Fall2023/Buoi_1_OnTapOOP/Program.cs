using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_OnTapOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Cat meoTrang = new Cat();
            meoTrang.BirthYear = 2020;
            meoTrang.Name = "White cat";
            meoTrang.Hight = 20;
            meoTrang.Color = "White";
            //meoTrang.InThongTin();
            //Dog cho = new Dog("BlackDOg", 12, 2020);
            //cho.InThongTin();
            meoTrang.AnCom();
            meoTrang.AnCom(4);
            meoTrang.AnCom(3,"chả");
        }
    }
}
