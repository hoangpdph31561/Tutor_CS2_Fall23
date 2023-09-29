using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Buoi_2_Delegate_generic_anonymous.Program;

namespace Buoi_2_Delegate_generic_anonymous
{
    internal class Program
    {
        #region Phần 1: Delegate
        /*
         *  ❑ Delegate là một đối tượng chứa tham chiếu đến phương thức cần thực thi.
            ❑ Một delegate có thể trỏ tới một hoặc nhiều phương thức
            ❑ Delegate có thể gọi bất kỳ phương thức nào nó trỏ tới tại thời điểm thực thi

            ❑ Để liên kết một delegate với một phương thức cụ thể
            thì phương thức và delegate phải giống nhau ở kiểu trả về và kiểu tham số
            ❑ Cú pháp:
                <access_modifier> delegate <return_type> <delegate name> (<parameters>)
            ❑ Sử dụng delegate
                ❖Khai báo delegate
                ❖Thực hiện delegate tham chiếu tới phương thức
                ❖Tạo thể hiện của delegate
                ❖Gọi phương thức thông qua thể hiện delegate
         */
        #endregion

        #region Phần 2: C# Multicast Delegates
        /*
           ❖Có thể tham chiếu đến nhiều phương thức tại cùng một thời điểm
           ❖Kiểu tra về của multicast delegate phải là kiểu void
           ❖Dùng toán tử “+” để thêm phương thức vào delegate
         */
        #endregion

        #region Phần 3: Delegate Callback
        /*
         * Callback là khi 1 hàm sử dụng 1 hàm khác như 1 tham số truyền vào
         * Với C# thì điều này không thể thực hiện được vì 1 hàm không phải là 1 kiểu dữ liệu
         * Để thực hiện được Callback thì ta dùng delegate để tham chiếu tới hàm
         * mà ta muốn thực hiện Callback
         */
        #endregion

        #region DELEGATE EVENT

        /*
         * ❑Sự kiện (Event) là các hành động, ví dụ như nhấn phím, click, di chuyển chuột...
           ❑Trong C#, Event là một đối tượng đặc biệt của  Delegate, 
            nó là nơi chứa các phương thức, các phương thức này sẽ được thực thi khi sự kiện xảy ra
           ❑Đặc điểm của event:
               ❖Được khai báo trong các lớp hoặc interface
               ❖Được khai báo là abstract hoặc sealed, virtual
               ❖Được thực thi thông qua delegate
           ❑Tạo và sử dụng event
               ❖Đinh nghĩa delegate cho event
               ❖Tạo event thông qua delegate
               ❖Đăng ký để lắng nghe và xử lý event
               ❖Kích hoạt event
        ❑Event phải được ủy thác từ đối tượng cha của đối tượng chứa event . 
        Bằng cách += hàm Delegate tương ứng vào event của đối tượng
        (Tương tự có thể loại bỏ bằng cách -=).
         */
        #endregion

        #region Generic
        /* 
         * Generic trong C# cho phép định nghĩa một phương thức,một lớp 
           mà không cần chỉ ra đối số kiểu dữ liệu là gì.
           Tuỳ vào kiểu dữ liệu mà người dùng truyền vào thì nó sẽ hoạt động theo kiểu dữ liệu đó
            - Generic cũng là một kiểu dữ liệu trong C# như int, string, bool,… 
                nhưng nó là một kiểu dữ liệu “tự do”, tùy vào mục đích sử dụng mà nó có thể đại diện 
                cho tất cả các kiểu dữ liệu còn lại.
            - Có thể định nghĩa lớp, interface, phương thức, delegate như là kiểu generic
            - Generic được đánh dấu bởi <>
                vd <T> thì T được xem là 1 kiểu dữ liệu

         * Ưu điểm: là có thể sử dụng 1 kiểu dữ liệu chung cho nhiều lớp,
           phương thức khác mà có cấu trúc code tương tự nhau trong khi chỉ cần viết 1 lần

         * Nhược điểm: của Generic là khi các kiểu dữ liệu khác nhau có các tương 
           tác hay cách sử dụng khác nhau thì áp dụng Generic sẽ có thể gây ra lỗi chương trình
         */
        #endregion

        #region Phần 1: COLLECTION LÀ GÌ?
        /*
         * - Collection là lớp hỗ trợ lưu trữ, quản lý và thao tác với các đối tượng linh hoạt.
           - Có thể lưu trữ một tập hợp đối tượng thuộc nhiều kiểu khác nhau.
           - Hỗ trợ rất nhiều phương thức để thao tác với tập hợp như: tìm kiếm, sắp xếp, đảo ngược, . . .
           - Là một mảng có kích thước động:
               + Không cần khai báo kích thước khi khởi tạo.
               + Có thể tăng giảm số lượng phần tử trong mảng một cách linh hoạt

         *   Collections Là các class được tạo ra giúp chúng ta trong việc lưu trữ
             và quản lý dữ liệu. Collection có thể chứa được mọi kiểu dữ liệu
             - Collection được chia ra 2 loại 
                + Non-Generic Collection (ArrayList, Hashtable, SortedList,...)
                + Generic Collection (List, HashSet, Dictionary,...)
         */
        #endregion

        #region Phần 2: Các  Collection thông dụng C#

        /*
         * 1. ArrayList:  Lớp cho phép lưu trữ và quản lý các phần tử giống mảng. 
              Tuy nhiên, không giống như trong mảng, ta có thể thêm hoặc xoá phần tử một cách linh hoạt và có thể tự điều chỉnh kích cỡ một cách tự động.
         * 2. HashTable: Lớp lưu trữ dữ liệu dưới dạng cặp Key – Value. 
              Khi đó ta sẽ truy xuất các phần tử trong danh sách này thông qua Key 
              (thay vì thông qua chỉ số phần tử như mảng bình thường).
         * 3. BitArray: Lớp cho phép lưu trữ và quản lý một danh sách các bit. 
              Giống mảng các phần tử kiểu bool với true biểu thị cho bit 1 và false biểu thị cho bit 0. 
              Ngoài ra BitArray còn hỗ trợ một số phương thức cho việc tính toán trên bit. 
         * 4. SortedList: Là sự kêt hợp của ArrayList và HashTable. 
              Tức là dữ liệu sẽ lưu dưới dạng Key – Value. 
              Ta có thể truy xuất các phần tử trong danh sách thông qua Key hoặc thông qua chỉ số phần tử. 
              Đặc biệt là các phần tử trong danh sách này luôn được sắp xếp theo giá trị của Key.

         *************
         * 5. List: List là 1 Generic Collections đưa ra như một sự thay thế ArrayList 
              vì thế về khái niệm cũng như sử dụng nó hoàn toàn giống với ArrayList. 
         * 6. HashSet: là tập hợp danh sách không cho phép trùng giá trị. 
              HashSet<T> khác với các collection khác là nó cung cấp cơ chế đơn giản nhất để lưu các giá trị, 
              nó không chỉ mục thứ tự và các phần tử không sắp xếp theo thứ tự nào.
         * 7. Dictionary: là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value. 
              Dictionary chính là sự thay thế cho Collections Hashtable. 
              Cho nên về khái niệm hay sử dụng thì Dictionary đều sẽ giống Hashtable.
              - Hashtable là non-generic chứa đối tượng kiểu Object, khi truy xuất thông tin thì cần phải ép kiểu trở lại. 
              - Dictionary thường được sử dụng phổ biến hơn Hashtable. 
                (Giữa Hashtable và Dictionary<> giống như câu chuyện của ArrayList và List<>)
         * 8. LinkedList: là một tập hợp của các phần tử trong đó mỗi phần tử được liên kết (link) với phần tử trước (và sau nó)
            - Các phần tử của linked list cũng được gọi là các node.
            - Mỗi node bao gồm hai phần: phần dữ liệu, và phần tham chiếu
                + Phần dữ liệu để lưu trữ dữ liệu (giống như phần tử của mảng). 
                + Phần tham chiếu chứa địa chỉ (ô nhớ) của node khác
         *************
         * 9. Stack:  Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc LIFO (Last In First Out).
              C# includes both, generic and non-generic Stack.
         * 10. Queue:   Lớp cho phép lưu trữ và thao tác dữ liệu theo cấu trúc FIFO (First In First Out).
              C# includes both, generic and non-generic Queue

         */

        #endregion

        #region Phần 3: HashTable  
        /*
         * - Là một Collections lưu trữ dữ liệu dưới dạng cặp Key - Value.
         * - Vì Key và Value đều là kiểu object nên ta có thể lưu trữ được mọi kiểu dữ liệu
            từ những kiểu cơ sở đến kiểu phức tạp (class).

           Một số thuộc tính và phương thức hỗ trợ sẵn trong Hashtable: 
                - Count:  Trả về 1 số nguyên là số phần tử hiện có trong Hashtable.           
                - Keys:  Trả về 1 danh sách chứa các Key trong Hashtable.           
                - Values:  Trả về 1 danh sách chứa các Value trong Hashtable.
                - Add(object Key, object Value):  Thêm 1 cặp Key - Value vào Hashtable.

                - Clear():  Xoá tất cả các phần tử trong Hashtable.           
                - Clone():  Tạo 1 bản sao từ Hashtable hiện tại.           
                - ContainsKey(object Key): Kiểm tra đối tượng Key có tồn tại trong Hashtable hay không.           
                - ContainsValue(object Value):  Kiểm tra đối tượng Value có tồn tại trong Hashtable hay không.           
                - CopyTo(Array array, int Index):  Thực hiện sao chép tất cả phần tử trong Hashtable sang mảng một chiều array từ vị trí Index của array. Lưu ý: array phải là mảng các object hoặc mảng các DictionaryEntry.           
                - Remove(object Key):  Xoá đối tượng có Key xuất hiện đầu tiên trong Hashtable.
         */
        #endregion

        #region ANONYMOUS TYPED
        /*
         * Phần 1:  Định nghĩa:
             * ❑Kiểu ẩn danh (Anonymous Type) cung cấp một cách thuận tiện để đóng gói (encapsulate) 
             * một tập các thuộc tính chỉ đọc (read-only properties) vào một đối tượng 
             * mà không cần phải xác định rõ ràng loại (type) của nó ngay lúc viết code
             * ❑Cho phép tạo type mới (user-defined) mà không cần xác định tên của nó
               ❑Tạo các type ẩn danh này bằng cách sử dụng toán tử new

           Phần 2: ANONYMOUS METHOD
            ❑Phương thức vô danh (anonymous method) là một phương thức:
               ❖Không cần khai báo tên phương thức khi định nghĩa phương thức
               ❖Có thể khai báo trực tiếp ở chỗ cần dùng, không cần định nghĩa trước
               ❖Đươc dùng như tham số của delegate

            ❑Một số giới hạn Anonymous methods
                ❖Không khai báo được các lệnh goto, break or continue bên trong phương thức
                ❖Không truy cập được các tham số ref hoặc out bên ngoài
                ❖Phải được dùng kết hợp với delegate
         */
        #endregion
        public delegate void DemoDelegateVoid();
        public delegate void DemoVoidWithParameter<T>(T input);
        public delegate bool Check(int input);
        public delegate void Calculate(int a, int b);
        public delegate void ChangeName(string name);
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            #region Delegate
            //TrangRam();
            //DemoDelegateVoid play = TrangRam;
            //play();
            //DemoVoidWithParameter<string> quyetTam = DemTrang;
            //quyetTam("Trang");
            //Check ktraNamNhan = CheckNamSinh;
            //Console.WriteLine("Hãy nhập năm sinh của bạn vào đây");
            //int namSinh = Convert.ToInt32(Console.ReadLine());
            //if (ktraNamNhan(namSinh))
            //{
            //    Console.WriteLine("Anh đã được lấy vợ");
            //}
            //else
            //{
            //    Console.WriteLine("Mất tiền");
            //}
            #endregion

            #region Action, Predicate, Func
            //Action diChoi = TrangRam;
            //diChoi();
            //Action<string> crush = DemTrang;
            //crush("Hồng");
            //Predicate<int> ktra = CheckNamSinh;
            //if (ktra(2005))
            //{
            //    Console.WriteLine("Anh đã được lấy vợ");
            //}
            //else
            //{
            //    Console.WriteLine("Mất tiền");
            //}
            //Func<int, string> no = AnComNoKhong;
            //Console.WriteLine(no(1));
            #endregion

            #region Multicast
            //Action<int, int> tinhToan = Plus;
            //tinhToan(2, 3);
            //tinhToan += Minus;
            //tinhToan(5, 10);
            //tinhToan -= Plus;
            //tinhToan(10, 10);
            #endregion
            //Predicate<string> ktraSo = CheckNum;
            //GetNum(ktraSo); 
            #region Event
            //Student st = new Student();
            //st.NameChanger += St_NameChanger;
            //st.Name = "Hoàng";
            //st.Name = "Thiệu";
            #endregion

            #region Anonymous Type và Anonymous Method
            var car = new
            {
                Hang = "Honda",
                IsXang = false,
                DungTich = 440,
                XuatSu = new
                {
                    Country = "Japan",
                    City = "Tokyo"
                }
            };
            Console.WriteLine($"Tên hãng: {car.Hang}" +
                $" Máy: {(car.IsXang ? "Xăng": "Dầu")}" +
                $" Dung tích: {car.DungTich}" +
                $" Xuất sứ: {car.XuatSu.Country} Thành phố: {car.XuatSu.City}");

            Action<string> kfc = delegate (string s)
            {
                Console.WriteLine("Ăn cùng với " + s);
            };
            kfc("Cô Huyền");
            #endregion
        }

        private static void St_NameChanger(string name)
        {
            Console.WriteLine($"Tên đã đổi thành {name}");
        }

        static void TrangRam()
        {
            Console.WriteLine("Hôm nay em đi trung thu với anh nhé");
        }
        static void DemTrang(string tenCrush)
        {
            Console.WriteLine($"Hôm nay tôi sẽ rủ {tenCrush} đi chơi");
        }
        static bool CheckNamSinh(int namSinh)
        {
            if((DateTime.Now.Year - namSinh) >=20)
            {
                return true;
            }
            return false;
        }
        static string AnComNoKhong(int batCom)
        {
            if(batCom < 2)
            {
                return "Hơi đói";
            }
            else
            {
                return "No quá";
            }
        }
        static void Plus(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Minus(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static bool CheckNum(string input)
        {
            return Regex.IsMatch(input, @"^[\d]+$");
        }
        static void GetNum(Predicate<string> checkNum)
        {
            string number;
            do
            {
                Console.WriteLine("Mời nhập số");
                number = Console.ReadLine();
                if (!checkNum(number))
                {
                    Console.WriteLine("Nhập cái gì vậy");
                }
            } while (!checkNum(number));
            Console.WriteLine("Bạn thông minh đấy");
        }
    }
    class Student
    {
        public event ChangeName NameChanger;
        private string name;

        public string Name 
        { 
            get => name; 
            set
            {
                name = value;
                if(NameChanger != null)
                {
                    NameChanger(Name);
                }
            }
        }
    }
}
