using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_LinQ_LamDa
{
    internal class Student
    {
        private int id;
        private string name;
        private int namSinh;
        public Student()
        {
            
        }

        public Student(int id, string name, int namSinh)
        {
            this.id = id;
            this.name = name;
            this.namSinh = namSinh;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public void InThongTin()
        {
            Console.WriteLine($"Id: {id} Tên: {name} Năm sinh: {namSinh}");
        }
    }
}
