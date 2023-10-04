using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_4_Thuc_hang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<string> lstActors1 = new List<string>()
            {
                "Hoàng","Hoa","Quỳnh"
            };
            List<string> lstActors2 = new List<string>()
            {
                "Hoàng","Hoa","Chi"
            };
            List<string> lstActors3 = new List<string>()
            {
                "Hoàng","Quân","Quỳnh"
            };
            List<string> lstActors4 = new List<string>()
            {
                "Hoàng","Phong","Quỳnh"
            };
            List<string> lstActors5 = new List<string>()
            {
                "Minh","Hoa","Quỳnh"

            };
            List<Movie> lstMovies = new List<Movie>()
            {
                new Movie(Guid.NewGuid(), "Harry Potter","Phim phù thủy",2000,lstActors1),
                new Movie(Guid.NewGuid(), "Thoi niên thiếu","Phim chính kịch",2005,lstActors2),
                new Movie(Guid.NewGuid(), "Thoi vui vẻ","Phim hành động",2023,lstActors3),
                new Movie(Guid.NewGuid(), "Phong ba","Phim tình cảm",2019,lstActors4),
                new Movie(Guid.NewGuid(), "Bão táp","Phim lịch sử",2023,lstActors5)
            };
            
            //Liệt kê các phim bắt đầu bằng chữ T.
            var resultMovieT = (from movie in lstMovies
                               where movie.Name.Trim().StartsWith("T")
                               select movie).ToList();

            foreach (var item in resultMovieT)
            {
                item.InThongTin();
            }
            //Đếm tất cả các phim là phim hành động
            //var countAction = lstMovies.Where(x => x.Type.ToLower().Trim().Contains("hành động")).Count();
            //Console.WriteLine($"Số phim hành động là: {countAction}");
            //Tìm ra năm sản xuất phim mới nhất.
            //var maxYear = lstMovies.Max(x => x.Year);
            //Console.WriteLine($"Năm mới nhất là: {maxYear}");
            //Danh sách phim mới nhất
            //var resultNewestFilm = lstMovies.Where(x => x.Year == lstMovies.Max(y => y.Year)).ToList();
            //Console.WriteLine("Các phim mới nhất");
            //foreach (var item in resultNewestFilm)
            //{
            //    item.InThongTin();
            //}
            //Sắp xếp tăng dần theo tên.
            //var orderByNameAsc = lstMovies.OrderBy(x => x.Name);
            //Console.WriteLine("Sắp xếp theo tên tăng dần");
            //foreach (var item in orderByNameAsc)
            //{
            //    item.InThongTin();
            //}
            //Giảm dần theo thể loại giảm dần
            //var orderByTypeDesc = lstMovies.OrderByDescending(x => x.Type);
            //Console.WriteLine("Sắp xếp theo thể loại giảm dần");
            //foreach (var item in orderByTypeDesc)
            //{
            //    item.InThongTin();
            //}
            ////Tăng dần theo năm, giảm dần theo thể loại.
            //var orderByYearAndType = lstMovies.OrderBy(x => x.Year).ThenByDescending(x => x.Type);
            //foreach (var item in orderByTypeDesc)
            //{
            //    item.InThongTin();
            //}
            //Lấy 3 bộ phim đầu tiên.
            //Console.WriteLine("Lấy 3 bộ phim");
            //if (CheckCount(lstMovies))
            //{
            //    if(lstMovies.Count < 3)
            //    {
            //        foreach (var item in lstMovies)
            //        {
            //            item.InThongTin();
            //        }
            //    }
            //    else
            //    {
            //        var resultTakeThree = lstMovies.Take(3);
            //        foreach (var item in resultTakeThree)
            //        {
            //            item.InThongTin();
            //        }
            //    }
            //}
        }
        
    }
}
