using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_1_OnTapOOP
{
    internal class Dog : Animal
    {
        public Dog()
        {
            
        }

        public Dog(string name, int hight, int birthYear) : base(name, hight, birthYear)
        {
        }
        public override int TinhTuoi()
        {
            return DateTime.Now.Year + 10 - BirthYear;
        }
        public override void InThongTin()
        {
            base.InThongTin();
        }
    }
}
