using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_Buoi1_DeThi
{
    internal static class Utility
    {

        public static string GetInput(string message)
        {
            Console.WriteLine($"Xin mời nhập {message}");
            return Console.ReadLine();
        }
    }
}
