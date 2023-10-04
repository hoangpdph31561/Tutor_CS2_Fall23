using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_LinQ_LamDa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //(input parameter) => Method expression
            //Action, Predicate, Func
            //Action<int> demo1 = x =>
            //{
            //    Console.WriteLine(x * 2);
            //};
            //demo1(2);
            //Predicate<int> kiemTra = x => x > 5;
            //Console.WriteLine(kiemTra(2));
            //Console.WriteLine(kiemTra(6));
            //Func<int, int, int> dupliacate = (x, y) => x * y;
            //Console.WriteLine(dupliacate(2,5));
            //Action demo2 = () =>  Console.WriteLine("Anh yêu các e");
            //demo2();
            //Func<int, string, int> demo3 = (int x, string y) =>
            //{
            //    Console.WriteLine($"Cái này để tính: {y}");
            //    return x * x;
            //};
            //Console.WriteLine(demo3(4,"nhân với chính nó"));

            //LinQ Querries. 
            List<string> lstNames = new List<string>()
            {
                "Hoàng","Ngân","Trang","Ahong","Thiệu"
            };
            //Query Syntax. Select * from ... Where ... 
            //var result = from name in lstNames
            //             where name.ToLower().Contains("h")
            //             orderby name.ToLower() descending
            //             select name;
            //Console.WriteLine("In ra danh sách tên mà có chứa ký tự H");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            List<Student> lstStudents = new List<Student>()
            {
                new Student(1,"Hoàng",2000),
                new Student(10,"Hoàng",2001),
                new Student(2,"Quân",1998),
                new Student(3,"Minh",1995),
                new Student(4,"Quý",2010),
                new Student(5,"Châu",2005),
                new Student(6,"Phí",2006),
                new Student(19,"Hoàng",2006),
                new Student(7,"Thủy",2007),
            };
            //var result = from student in lstStudents
            //             where DateTime.Now.Year - student.NamSinh <=20
            //             orderby student.Name
            //             select student;
            //foreach (var item in result)
            //{
            //    item.InThongTin();
            //}

            //Method Syntax. 
            //try
            //{
            //    var result = lstStudents.SingleOrDefault(x => x.Name.Equals("biu"));
            //    result.InThongTin();
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}
            //var result = lstStudents.Where(x => x.Name.ToLower().Contains("o") && x.NamSinh > 2000).Count();
            //Console.WriteLine(result);
            //var maxNamSinh = lstStudents.Min(x => x.NamSinh);
            //Console.WriteLine(maxNamSinh);
            //var indexStudentYear = lstStudents.FindIndex(x => x.NamSinh == 2006);
            //Console.WriteLine(indexStudentYear);
            //var result = lstStudents.SkipWhile(x => x.Name.Equals("x"));
            //foreach (var item in result)
            //{
            //    item.InThongTin();
            //}
            //var ketQua = lstStudents.OrderByDescending(x => x.Name).ThenBy(x => x.Id).ThenByDescending(x => x.NamSinh).ToList();
            //foreach (var item in ketQua)
            //{
            //    item.InThongTin();
            //}
            //Mix Syntax.
            //var result = (from student in lstStudents
            //             where DateTime.Now.Year - student.NamSinh <= 20
            //             select student).FirstOrDefault();
            //result.InThongTin();
        }


    }
}
