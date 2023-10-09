using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_5_Demo_De_thi
{
    internal class LaptopService
    {
        
        private string GetInput(string message)
        {
            Console.WriteLine($"Xin mời nhập {message}");
            return Console.ReadLine();
        }
        private bool CheckCount(List<Laptop> list)
        {
            if(list.Count == 0)
            {
                Console.WriteLine("Không có danh sách");
                return false;
            }
            return true;
        }
        public void GetLaptopBeginSA(List<Laptop> laptops)
        {
            if(CheckCount(laptops))
            {
                var result = laptops.Where(x => x.Ten.ToLower().Trim().StartsWith("sa")).ToList();
                if(result.Count == 0)
                {
                    Console.WriteLine("Không có laptop nào bắt đàu bằng SA");
                }
                else
                {
                    foreach(var item in result)
                    {
                        item.InThongTin();
                    }
                }
            }
        }
        private int GetIndex(List<Laptop> laptops)
        {
            int id = Convert.ToInt32(GetInput("id laptop cần tìm"));
            return laptops.FindIndex(x => x.Id == id);
        }
        private bool CheckExist(int index)
        {
            if(index == -1)
            {
                Console.WriteLine("Không tồn tại id cần tìm");
                return false;
            }
            return true;
        }
        public void GetLaptopById(List<Laptop> laptops)
        {
            int index = GetIndex(laptops);
            if(CheckExist(index))
            {
                laptops[index].InThongTin();
            }
        }
        public void UpdateLaptopById(List<Laptop> laptops)
        {
            int index = GetIndex(laptops);
            if (CheckExist(index))
            {
                
                int chon;
                bool isUpdate = false;
                do
                {
                    Console.WriteLine("--menu sửa--");
                    Console.WriteLine("1. Tên");
                    Console.WriteLine("2. Ram");
                    chon = Convert.ToInt32(GetInput("menu mong muốn"));
                    switch (chon)
                    {
                        case 0:
                            break;
                        case 1:
                            laptops[index].Ten = GetInput("tên laptop mới");
                            isUpdate = true;
                            break;
                        case 2:
                            laptops[index].Ram = Convert.ToInt32(GetInput("ram laptop mới"));
                            isUpdate = true;
                            break;
                        default:
                            Console.WriteLine("Sai chương trình");
                            break;
                    }
                } while (chon !=0);
                if(!isUpdate)
                {
                    Console.WriteLine("Laptop ko sửa gì, thông tin vẫn là");
                    laptops[index].InThongTin();
                }
                else
                {
                    Console.WriteLine("Thông tin mới");
                    laptops[index].InThongTin();
                }
            }
        }
        public void GetMaxMinPrice(List<Laptop> laptops)
        {
            
            var lstMax = laptops.Where(x => x.Gia == laptops.Max(y => y.Gia)).ToList();
            Console.WriteLine("Max");
            foreach (var l in lstMax)
            {
                l.InThongTin();
                Console.WriteLine("Vị trí của chúng là");
                Console.WriteLine(laptops.IndexOf(l));
            }
            var lstMin = laptops.Where(x => x.Gia == laptops.Min(y => y.Gia)).ToList();
            Console.WriteLine("Min");
            foreach (var item in lstMin)
            {
                item.InThongTin();
                Console.WriteLine("Vị trí của chúng là");
                Console.WriteLine(laptops.IndexOf(item));
            }
        }
        public void GetTop3Cheapest(List<Laptop> laptops)
        {
            var lstPriceCheapest = (from lap in laptops
                                    orderby lap.Gia
                                    select lap.Gia).Distinct().Take(3).ToList();
            var lstTop3Cheapse = laptops.Where(x => x.Gia >= lstPriceCheapest[0] && x.Gia <= lstPriceCheapest[lstPriceCheapest.Count -1]);
            foreach (var item in lstTop3Cheapse)
            {
                item.InThongTin();
            }
        }
        public void GetTop3Newway(List<Laptop> laptops)
        {
            List<int> lstPrice = laptops.Select(x => x.Gia).ToList();
            SortedSet<int> lstPriceCheapest = new SortedSet<int>(lstPrice);
            SortedSet<int> top3Cheapes = new SortedSet<int>(lstPriceCheapest.Take(3));
            var lstTop3 = laptops.Where(x => x.Gia >= top3Cheapes.Min() && x.Gia <= top3Cheapes.Max());
            foreach (var item in lstTop3)
            {
                item.InThongTin();
            }
        }
    }
}
