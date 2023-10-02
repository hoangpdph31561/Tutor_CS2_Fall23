using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Buoi_3_Regex_co_ban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string sđt = InputPhoneNumber();
            Console.WriteLine($"Tên của tôi là: {sđt}");
        }
        static string InputName()
        {
            string name;
            do
            {
                Console.WriteLine("Xin mời nhập tên của bạn");
                name = Console.ReadLine();
                if (!Regex.IsMatch(name, @"^[\W]+$"))
                {
                    Console.WriteLine("Thứ nhập vào không phải tên người");
                }
            } while (!Regex.IsMatch(name, @"^[\W]+$"));
            return name;
        }
        static string InputPhoneNumber()
        {
            string phoneNumber;
            do
            {
                Console.WriteLine("Xin mời nhập sđt của bạn");
                phoneNumber = Console.ReadLine();
                if (!Regex.IsMatch(phoneNumber, @"^(0|\+84)(3[2-9]|5[2689]|7[06789]|8[1-689]|9[0-46-9])[0-9]{7}$"))
                {
                    Console.WriteLine("Thứ nhập vào không phải tên người");
                }
            } while (!Regex.IsMatch(phoneNumber, @"^(0|\+84)(3[2-9]|5[2689]|7[06789]|8[1-689]|9[0-46-9])[0-9]{7}$"));
            return phoneNumber;
        }
    }
}
