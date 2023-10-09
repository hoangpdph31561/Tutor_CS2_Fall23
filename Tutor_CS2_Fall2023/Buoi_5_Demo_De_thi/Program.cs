using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_Demo_De_thi
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
            List<Laptop> lstLaptops = new List<Laptop>()
            {
                new Laptop(1,"Hoàng",12000,4,10.3),
                new Laptop(2,"Saàng",19000,12,11.3),
                new Laptop(3,"Hoàng",14000,8,12.2),
                new Laptop(4,"Hoàng",11000,16,12.3),
                new Laptop(5,"Samsung",11000,4,12.5),
            };
            LaptopService service = new LaptopService();
            do
            {
                Console.WriteLine("--Menu--");
                Console.WriteLine("1. Nhập");
                Console.WriteLine("2. Xuất");
                Console.WriteLine("3. Lưu file");
                Console.WriteLine("4. Đọc file");
                Console.WriteLine("5. Bắt đầu bằng \"sa\"");
                Console.WriteLine("6. Chứa tên nhập từ bàn phím");
                Console.WriteLine("7. Tìm theo ID");
                Console.WriteLine("8. Sửa theo ID");
                Console.WriteLine("9. Xóa theo id");
                Console.WriteLine("10. Sắp xếp giảm dần theo giá");
                Console.WriteLine("11. Sắp xếp tăng dần theo giá");
                Console.WriteLine("12. Xuất danh sách laptop có ram 8gb và 16gb");
                Console.WriteLine("13. Xuất danh sách laptop có giá lớn nhất, bé nhất và vị trí của nó");
                Console.WriteLine("14. Tìm laptop có giá trong khoảng người dùng nhập");
                Console.WriteLine("15. Xuất top 3 laptop có giá nhỏ nhất");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("Mời chọn chương trình");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        service.GetLaptopBeginSA(lstLaptops);
                        break;
                    case 6:
                        break;
                    case 7:
                        service.GetLaptopById(lstLaptops);
                        break;
                    case 8:
                        service.UpdateLaptopById(lstLaptops);
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:

                        break;
                    case 13:
                        service.GetMaxMinPrice(lstLaptops);
                        break;
                    case 14:
                        break;
                    case 15:
                        Console.WriteLine("Cách 1");
                        service.GetTop3Cheapest(lstLaptops);
                        Console.WriteLine("Cách 2");
                        service.GetTop3Newway(lstLaptops);
                        break;
                    default:
                        Console.WriteLine("Chọn sai chương trình, mời chọn lại");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Ấn phím bất kỳ để tiếp tục");
                Console.ReadKey();
            } while (chon != 0);
        }
    }
}
