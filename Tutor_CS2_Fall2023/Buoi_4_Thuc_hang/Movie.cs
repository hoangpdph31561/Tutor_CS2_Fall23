using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_Thuc_hang
{
    internal class Movie
    {
        private Guid id;
        private string name;
        private string type;
        private int year;
        private List<string> lstActors;
        public Movie()
        {
            lstActors = new List<string>();
        }

        public Movie(Guid id, string name, string type, int year, List<string> lstActors)
        {
            this.lstActors = new List<string>();
            this.id = id;
            this.name = name;
            this.type = type;
            this.year = year;
            this.lstActors = lstActors;
        }

        public Guid Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public int Year { get => year; set => year = value; }
        public List<string> LstActors { get => lstActors; set => lstActors = value; }
        public void InThongTin()
        {
            Console.WriteLine($"ID: {id}" +
                $" Name: {name}" +
                $" Type: {type}" +
                $" Year: {year}");
            Console.WriteLine("Danh sách diễn viên của phim là");
            foreach ( var actor in lstActors )
            {
                Console.WriteLine( actor );
            }
            Console.WriteLine();
        }
    }
}
