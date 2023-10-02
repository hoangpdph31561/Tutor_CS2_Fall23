using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Buoi_3_Regex_co_ban
{
    #region Khác: Regex
    /*
     * REGEX hoặc Regular Expression trong C#
     * Biểu thức chính quy, 
     * là một cấu trúc rất mạnh để mô tả một chuỗi theo cách thống nhất chung.

    Regular Expression bao gồm tập hợp các ký tự, toán tử hay ký hiệu toán học
    nhằm biểu thị một chuỗi theo cấu trúc chung mà mọi người học theo. */
    /* 
     * 1. Các lớp ký tự Regex
        Regex	Mô tả
        [...]	trả về một ký tự phù hợp
        [abc]	a, b, hoặc c
        [^abc]	Bất kỳ ký tự nào ngoại trừ a, b, hoặc c
        [a-zA-Z]	ký tự chữ từ a tới z hoặc A tới Z
        [0-9]	ký tự số 0 tới 9
     */
    /* 2. Số lượng ký tự trong Regex
     * Regex	Mô tả	Pattern	Ví dụ
     *  X   X xảy ra một lần
        X?	X xảy ra một hoặc không lần	hellos?	hello, hellos, helloss
        X+	X xảy ra một hoặc nhiều lần	Version \w-\w+	Version A-b1_1
        X*	X xảy ra không hoặc nhiều lần	A*B*C*	AAACC
        X{n}	X chỉ xảy ra n lần	\d{4}	2018, 20189, 201
        X{n,}	X xảy ra n hoặc nhiều lần	\d{4,}	2018, 20189, 201
        X{y,z}	X xảy ra ít nhất y lần nhưng nhỏ hơn z lần	\d{2,3}	2018, 201
     */

    /*3. Ký tự đặc biệt trong Regex
     * Regex	Mô tả
        .	Bất kỳ ký tự nào
        ^	Có 2 cách sử dụng.
            1. Đánh dấu bắt đầu của một dòng, một chuỗi.
            2. Nếuu sử dụng trong dấu [...] thì nó có nghĩa là phủ định.
                [0-9] [^0-9]
        $	Đánh dấu Kết thúc của một dòng
        \d	Bất kỳ chữ số nào, viết tắt của [0-9]
        \D	Bất kỳ ký tự nào không phải chữ số, viết tắt của [^0-9]
        \s	Bất kỳ ký tự trống nào (như dấu cách, tab, xuống dòng, ...), viết tắt của [\t\n\x0B\f\r]
        \S	Bất kỳ ký tự trống nào không phải ký tự trống, viết tắt của [^\s]
        \w	Bất kỳ ký tự chữ nào (chữ cái và chữ số và dấu gạch dưới), 
            viết tắt của [a-zA-Z_0-9]
        \W	Bất kỳ ký tự nào không phải chữ cái và chữ sốvà dấu gạch dưới, 
            viết tắt của [^\w]
        \b	Ranh giới của một từ
        \B	Không phải ranh giới của một từ
     */
    #endregion
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
