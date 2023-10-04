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
        #region Lamda
        /*
      * Biểu thức lambda còn gọi là biểu thức (Anonymous), 
      * một biểu thức khai báo giống phương thức nhưng thiếu tên. 
      * Cú pháp để khai báo biểu thức lambda là sử dụng toán tử lambda => 
      * như sau:
       - Công thức 1:
           (tham_số) => biểu_thức;
       - Công thức 2:
           (tham_số) =>
               {
                  các câu lệnh
                  Sử dụng return nếu có giá trị trả về
               }            
      */
        #endregion
        #region LINQ là gì
        /*
       *  LINQ: Language Integrated Query
       *  Định nghĩa:  ngôn ngữ truy vấn tích hợp -
       *  nó tích hợp cú pháp truy vấn (gần giống các câu lệnh SQL) 
       *  vào bên trong ngôn ngữ lập trình C#, cho nó khả năng truy cập
       *  các nguồn dữ liệu khác nhau (SQL Db, XML, List ...) 
       *  với cùng cú pháp.
       * Ưu điểm:
       * ➢Ưu điểm lớn nhất của Linq đó chính là sự mạch lạc trong code, xậy dựng nhanh, ít gây lỗi
         ➢Linq cung cấp nhiều phương thức trong truy vấn dữ liệu, nếu cùng một chức năng, khi sử dụng truy vẫn thuần có thể phải code nhiều gấp 2, 3 lần khi sử dụng linq (tùy ứng dụng)
         ➢Cách tiếp cận khai báo giúp truy vấn dễ hiểu và gọn hơn
       * Nhược điểm:
       *➢Tốc độ chậm nếu viết linq không khéo
          Linq query syntax:
                              from object in datasource
                              where condition
                              select object
          from: Từ nguồn dữ liệu mà truy vấn sẽ thực hiện
          in: bên trong nguồn giá trị nào
          datasource: tập giá trị nguồn
          where: lọc dữ liệu theo điều kiện condition
          select object: Lấy ra kết quả có thể là giá trị hoặc tập giá trị
          Ngoài ra chúng ta cũng thấy việc áp dụng lambda cơ bản với những câu lọc dữ liệu ngắn sẽ đơn giản nhưng khi join vào nhiều datasource sẽ không dễ đọc với người chưa có kinh nghiệm
       */
        #endregion
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
