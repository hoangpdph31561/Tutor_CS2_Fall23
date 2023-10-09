using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Buoi_5_Tong_hop
{
    internal static class Utility
    {
        public static string GetInput(string message)
        {
            Console.WriteLine($"Xin mời nhập {message}");
            return Console.ReadLine();
        }
        public static string RegexCheckInt(string messages)
        {
            string input;
            do
            {
                input = GetInput(messages);
                if(!Regex.IsMatch(input, @"^[\d]+$"))
                {
                    Console.WriteLine("Thứ nhập vào không phải số. Nhập lại");
                }
            } while (!Regex.IsMatch(input, @"^[\d]+$"));
            return input;
        }
        public static string RegexCheckName(string messages)
        {
            string input;
            do
            {
                input = GetInput(messages);
                if (!Regex.IsMatch(input, @"^[\dA-Z\s]+$"))
                {
                    Console.WriteLine("Thứ nhập vào không phải tên thỏa mãn. Nhập lại");
                }
            } while (!Regex.IsMatch(input, @"^[\dA-Z\s]+$"));
            return input;
        }
        public static string RegexCheckRam()
        {
            string input;
            do
            {
                input = GetInput("ram laptop");
                if (!Regex.IsMatch(input, @"^(2|4|8|16)$"))
                {
                    Console.WriteLine("Thứ nhập vào không phải ram tồn tại. Nhập lại");
                }
            } while (!Regex.IsMatch(input, @"^(2|4|8|16)$"));
            return input;
        }
        
    }
}
