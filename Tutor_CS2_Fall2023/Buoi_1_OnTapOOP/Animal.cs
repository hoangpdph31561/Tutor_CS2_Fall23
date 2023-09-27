using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_OnTapOOP
{
    internal abstract class Animal
    {
        private string name;
        private int hight;
        private int birthYear;
        public Animal()
        {

        }

        public Animal(string name, int hight, int birthYear)
        {
            this.name = name;
            this.hight = hight;
            this.birthYear = birthYear;
        }
        public abstract int TinhTuoi();

        public string Name { get => name; set => name = value; }
        public int Hight { get => hight; set => hight = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public virtual void InThongTin()
        {
            Console.WriteLine($"Tên: {name} | Chiều cao: {hight}: Tuổi: {TinhTuoi()}");
                
        }
    }
}
