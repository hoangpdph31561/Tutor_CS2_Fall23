using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_3_Thuc_hanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
        }
        static void Menu()
        {
            int chon;
            DienThoaiService service = new DienThoaiService();
            string path = @"E:\FPT politechnic\Tutor\Tutor_CS2_Fall23\Tutor_CS2_Fall2023\Buoi_3_Thuc_hanh\ListDienThoai.txt";
            List<DienThoai> lstDienThoais = new List<DienThoai>()
            
            {
                new DienThoai(1,"Iphone 15","Apple",2023),
                new DienThoai(2,"Samsung pro max","Samsung",2023),
                new DienThoai(3,"Xiaomi hihi","Trung quốc",2023),
                new DienThoai(4,"vertu 186","Giàu có",2022),
                new DienThoai(5,"Nokia cục gạch","Nokia",1998),

            };
            do
            {
                Console.WriteLine("--Menu--");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("1. Nhập điện thoại");
                Console.WriteLine("2. Xuất danh sách điện thoại");
                Console.WriteLine("3. Lưu file");
                Console.WriteLine("4. Đọc file");
                Console.WriteLine("Mời bạn chọn chương trình");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        service.Nhap(lstDienThoais);
                        break;
                    case 2:
                        service.Xuat(lstDienThoais);
                        break;
                    case 3:
                        //Quan trọng
                        File.WriteAllText(path, "");
                        service.GhiFile(path, lstDienThoais);
                        break;
                    case 4:
                        List<DienThoai> lstReadFile = service.DocFileList(path);
                        if(lstReadFile.Count ==0)
                        {
                            Console.WriteLine("Không đọc được");
                        }
                        else
                        {
                            foreach (var item in lstReadFile)
                            {
                                item.InThongTin();
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Chọn sai chương trình, mời chọn lại");
                        break;
                }

            } while (chon != 0);
        }
    }
}
