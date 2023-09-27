using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_Buoi1_DeThi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding  = Encoding.Unicode;
            Menu();
        }
        static void Menu()
        {
            int chon;
            SinhVienService service = new SinhVienService();
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Nhập");
                Console.WriteLine("2. Xuất");
                Console.WriteLine("3. Xuất  tặng vé");
                Console.WriteLine("4. Không được tặng thì nghỉ đi");
                Console.WriteLine("5. Kế thừa");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("Chọn menu");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 0:
                        Console.WriteLine("Thoát chương trình");
                        Environment.Exit(0);
                        break;
                    case 1:
                        service.Nhap();
                        break;
                    case 2:
                        service.Xuat();
                        break;
                    case 3:
                        service.XuatSinhVienDiemTot();
                        break;
                    case 4:
                        service.XoaSVKhongDuocVe();
                        break;
                    case 5:
                        service.KeThua();
                        break;
                    default:
                        Console.WriteLine("Chọn sai rồi, chọn lại đê");
                        break;
                }
            } while (chon != 0);
        }
    }
}
