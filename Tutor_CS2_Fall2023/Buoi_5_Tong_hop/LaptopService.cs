using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_Tong_hop
{
    internal class LaptopService
    {
        string input;
        private string GetInput(string message)
        {
            Console.WriteLine($"Xin mời nhập {message}");
            return Console.ReadLine();  
        }
        public void Nhap(List<Laptop> lstLaptops)
        {
            do
            {
                Laptop newLaptop = new Laptop();
                newLaptop.Id = Convert.ToInt32(Utility.RegexCheckInt("id máy tính"));
                newLaptop.Ten = Utility.RegexCheckName("tên laptop");
                checkGia:
                int gia = Convert.ToInt32(Utility.RegexCheckInt("giá laptop"));
                if (gia <= 0)
                {
                    Console.WriteLine("Giá chỉ được > 0");
                    goto checkGia;
                }
                newLaptop.Gia = gia;
                newLaptop.Ram = Convert.ToInt32(Utility.RegexCheckRam());
                newLaptop.KhoiLuong = Convert.ToDouble(GetInput("khối lượng laptop"));
                lstLaptops.Add(newLaptop);
                do
                {
                    input = GetInput("tiếp tục hay không");
                    if(String.Compare(input,"có",true) !=0 && String.Compare(input,"không",true) != 0)
                    {
                        Console.WriteLine("Chỉ được nhập có hoặc không");
                    }
                } while (String.Compare(input, "có", true) != 0 && String.Compare(input, "không", true) != 0);
            } while (String.Compare(input, "có", true) == 0);
        }
        private bool CheckCount(List<Laptop> lstLaptops)
        {
            if(lstLaptops.Count == 0)
            {
                Console.WriteLine("Không có danh sách laptop nào");
                return false;
            }
            return true;
        }
        public void Xuat(List<Laptop> lstLaptops)
        {
            if(CheckCount(lstLaptops))
            {
                foreach (var item in lstLaptops)
                {
                    item.InThongTin();
                }
            }
        }
        public void SaveFile(string path, List<Laptop> lstLaptops)
        {
            if(File.Exists(path))
            {
                if (CheckCount(lstLaptops))
                {
                    File.WriteAllText(path, "");
                    foreach (var item in lstLaptops)
                    {
                        //Write => ghi đè: có gì trước đấy sẽ biến mất hết
                        //Append => ghi thêm: có gì trước đấy vẫn ở đấy, tôi chỉ ghi thêm thôi
                        string contents = item.GetObj();
                        File.AppendAllText(path, contents);
                    }
                    Console.WriteLine("Lưu thành công");
                }
            }
            else
            {
                Console.WriteLine("Đường dẫn không đúng để lưu file");
            }
        }
        public List<Laptop> ReadFile(string path)
        {
            List<Laptop> lstReadFile = new List<Laptop>();
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (var item in lines)
                {
                    if(item.Trim().Length == 0)
                    {
                        continue;
                    }
                    string[] contents = item.Split('|');
                    Laptop readLaptop = new Laptop();
                    readLaptop.Id = Convert.ToInt32(contents[0].Trim());
                    readLaptop.Ten = contents[1].Trim();
                    readLaptop.Gia = Convert.ToInt32(contents[2].Trim());
                    readLaptop.Ram = Convert.ToInt32(contents[3].Trim());
                    readLaptop.KhoiLuong = Convert.ToDouble(contents[4].Trim());
                    lstReadFile.Add(readLaptop);
                }
            }
            else
            {
                Console.WriteLine("Đường dẫn không đúng để đọc file");
            }
            return lstReadFile;
        }
        public void ResultReadFile(string path)
        {
            List<Laptop> lstResultReadFile = ReadFile(path);
            if(CheckCount(lstResultReadFile))
            {
                foreach (var item in lstResultReadFile)
                {
                    item.InThongTin();
                }
            }
        }
        public void GetLaptopStartWithSA(List<Laptop> lstLaptops)
        {
            if (CheckCount(lstLaptops))
            {
                var result = from laptop in lstLaptops
                             where laptop.Ten.ToLower().Trim().StartsWith("sa")
                             select laptop;
                var result2 = lstLaptops.Where(x => x.Ten.ToLower().Trim().StartsWith("sa"));
                if (CheckCount(result.ToList()))
                {
                    foreach (var item in result)
                    {
                        item.InThongTin();
                    }
                }
            }
        }
        public void GetLaptopByInput(List<Laptop> lstLaptop)
        {
            if (CheckCount(lstLaptop))
            {
                input = GetInput("tên laptop cần tìm");
                var result = lstLaptop.Where(x => x.Ten.ToLower().Trim().Contains(input.ToLower().Trim())).ToList();
                if(CheckCount(result))
                {
                    foreach (var item in result)
                    {
                        item.InThongTin();
                    }
                }
            }
        }
        private int GetIndexById(List<Laptop> lstLaptops)
        {
            int id = Convert.ToInt32(GetInput("id cần tìm"));
            int index = lstLaptops.FindIndex(x => x.Id == id);
            return index;
        }
        //private bool CheckExistsLaptop(List<Laptop> lstLaptop)
        //{
        //    int index = GetIndexById(lstLaptop);
        //    if(index == -1)
        //    {
        //        Console.WriteLine("Không tìm thấy laptop");
        //        return false;
        //    }
        //    return true;
        //}
        public void GetLaptopById(List<Laptop> lstLaptops)
        {
            int index = GetIndexById(lstLaptops);
            if(index == -1)
            {
                Console.WriteLine("Không tồn tại laptop của bạn");
            }
            else
            {
                lstLaptops[index].InThongTin();
            }
        }
        public void GetLaptopByIdP2(List<Laptop> lstLaptops)
        {
            int id = Convert.ToInt32(GetInput("id cần tìm"));
            var result = lstLaptops.FirstOrDefault(x => x.Id == id);
            if(result != null)
            {
                result.InThongTin();
            }
            else
            {
                Console.WriteLine("Không tồn tại laptop cần tìm");
            }
        }
        public void UpdateLaptopById(List<Laptop> lstLaptops)
        {
            int index = GetIndexById(lstLaptops);
            if (index == -1)
            {
                Console.WriteLine("Không tồn tại laptop của bạn");
            }
            else
            {
                int chon;
                bool isUpdate = false;
                do
                {
                    Console.WriteLine("--Menu sửa thông tin laptop--");
                    Console.WriteLine("1. Tên");
                    Console.WriteLine("2. Giá");
                    Console.WriteLine("3. Ram");
                    Console.WriteLine("4. Khối lượng");
                    Console.WriteLine("0. Thoát sửa");
                    chon = Convert.ToInt32(GetInput("nhập thứ cần sửa"));
                    switch (chon)
                    {
                        case 0:
                            break;
                        case 1:
                            lstLaptops[index].Ten = GetInput("tên muốn sửa");
                            isUpdate = true;
                            break;
                        case 2:
                            lstLaptops[index].Gia = Convert.ToInt32(GetInput("giá cần sửa"));
                            isUpdate = true;
                            break;
                        case 3:
                            lstLaptops[index].Ram = Convert.ToInt32(GetInput("ram cần sửa"));
                            isUpdate = true;
                            break;
                        case 4:
                            lstLaptops[index].KhoiLuong = Convert.ToDouble(GetInput("khối lượng cần sửa"));
                            isUpdate = true;
                            break;
                        default:
                            Console.WriteLine("Chọn sai, mời chọn lại");
                            break;
                    }
                } while (chon !=0);
                if (!isUpdate)
                {
                    Console.WriteLine("Chả sửa gì, thông tin vẫn là");
                    lstLaptops[index].InThongTin();
                }
                else
                {
                    Console.WriteLine("Thông tin mới là");
                    lstLaptops[index].InThongTin();
                }
            }
        }
        public void RemoveLaptopById(List<Laptop> lstLaptops)
        {
            int index = GetIndexById(lstLaptops);
            if (index == -1)
            {
                Console.WriteLine("Không tồn tại laptop của bạn");
            }
            else
            {
                lstLaptops.RemoveAt(index);
                Console.WriteLine("Xóa thành công");
            }
        }
        public void RemoveLaptopByIdP2(List<Laptop> lstLaptops)
        {
            int id = Convert.ToInt32(GetInput("id cần tìm"));
            var result = lstLaptops.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                result.InThongTin();
            }
            else
            {
                lstLaptops.Remove(result);
                Console.WriteLine("Xóa thành công");
            }
        }
        public void OrderByNameDesLaptop(List<Laptop> laptops)
        {
            if (CheckCount(laptops))
            {
                foreach (var item in laptops.OrderByDescending(x => x.Ten))
                {
                    item.InThongTin();
                }
            }
        }
        public void OrderByPriceAscLaptop(List<Laptop> lstLaptops)
        {
            if (CheckCount(lstLaptops))
            {
                foreach (var item in lstLaptops.OrderBy(x => x.Gia))
                {
                    item.InThongTin();
                }
            }
        }
        public void GetLaptop8N16GB(List<Laptop> lstLaptops)
        {
            if (CheckCount(lstLaptops))
            {
                var result = lstLaptops.Where(x => x.Ram == 8 || x.Ram == 16).ToList();
                if (CheckCount(result))
                {
                    foreach (var item in result)
                    {
                        item.InThongTin();
                    }
                }
            }
        }
        public void GetMaxMinByPrice(List<Laptop> lstLaptops)
        {
            if (CheckCount(lstLaptops))
            {
                //max min là giá trị lớn nhất, nhỏ nhất và chỉ có 1.
                //nhưng đối tượng chứa giá trị max và min đó có thể nhiều
                //nếu max == min thì sao ?
                int maxPrice = lstLaptops.Max(y => y.Gia);
                int minPrice = lstLaptops.Min(y => y.Gia);
                if(maxPrice == minPrice)
                {
                    Console.WriteLine("Max = min thì muốn gì");
                    return;
                }
                var lstLaptopsMax = lstLaptops.Where(x => x.Gia == maxPrice).ToList();
                var lstLaptopsMin = lstLaptops.Where(x => x.Gia == minPrice).ToList();
                Console.WriteLine("Laptop có giá lớn nhất là");
                foreach (var item in lstLaptopsMax)
                {
                    item.InThongTin();
                    Console.WriteLine($"Vị trí của nó là: {lstLaptops.IndexOf(item)}");
                }
                Console.WriteLine("Laptop có giá lớn min là");
                foreach (var item in lstLaptopsMin)
                {
                    item.InThongTin();
                    Console.WriteLine($"Vị trí của nó là: {lstLaptops.IndexOf(item)}");
                }
            }
        }
        public void GetLaptopByPriceInput(List<Laptop> lstLaptops)
        {
            if (CheckCount(lstLaptops))
            {
                checkMaxMin:
                int min = Convert.ToInt32(GetInput("khoảng giá cận dưới muốn tìm"));
                int max = Convert.ToInt32(GetInput("khoảng giá cận dưới trên tìm"));
                if(min <0 || max <0 || min > max)
                {
                    Console.WriteLine("có biết học toán không");
                    goto checkMaxMin;
                }
                bool isExists = false;
                var result = lstLaptops.Where(x => x.Gia >= min && x.Gia <= max).ToList();
                foreach (var item in result)
                {
                    isExists = true;
                    item.InThongTin();
                }
                if(!isExists)
                {
                    Console.WriteLine("Không có danh sách laptop trong khoảng giá của bạn");
                }
            }
        }
        public void GetTop3PriceCheapest(List<Laptop> lstLaptops)
        {
            if (CheckCount(lstLaptops))
            {
                //ĐỒNG GIẢI NHẤT, đồng giải nhì, đồng giải ba
                //top 3: 3 cái giá nằm trong top. nhưng 3 giá đó có thể có nhiều đối tượng
                //top 3 giá: 1 rẻ nhất, 2 rẻ nhì, 3 rẻ thứ 3.
                //SELECT DISTINCT => DUY NHẤT
                var top3Prices = (from laptop in lstLaptops
                                 orderby laptop.Gia ascending
                                 select laptop.Gia).Distinct().Take(3);
                var result = lstLaptops.Where(x => x.Gia >= top3Prices.Min() && x.Gia <= top3Prices.Max()).ToList();
                foreach (var item in result)
                {
                    item.InThongTin();
                }

            }
        }
    }
}
