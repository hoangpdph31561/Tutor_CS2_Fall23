using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3_Doc_ghi_File_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string path = @"E:\FPT politechnic\Tutor\Tutor_CS2_Fall23\Tutor_CS2_Fall2023\Buoi_3_Doc_ghi_File_Text\Demo1.txt";

            // \\ => \
            string[] lines = { "Hoàng", "Trang", "Đăng" };
            string[] lines2 = { "Sáng", "trưa", "tối" };
            #region Ghi file
            if (File.Exists(path))
            {
                //File.WriteAllText(path, "Cô Huyền xinh đẹp");
                //File.WriteAllLines(path, lines);
                //File.AppendAllText(path, "Hôm nay tôi buồn");
                //File.AppendAllLines(path, lines2);
            }
            #endregion

            #region Đọc file
            //string ketQua = File.ReadAllText(path);
            //Console.WriteLine(ketQua);
            string[] resultLines = File.ReadAllLines(path);
            int stt = 1;
            foreach (string line in resultLines)
            {
                Console.WriteLine($"Dòng thứ {stt}");
                Console.WriteLine(line);
                stt++;
            }
            #endregion
        }
    }
}
