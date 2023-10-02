using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Buoi_3_Thuc_hanh
{
    internal class DienThoaiService
    {
        string input;
        private string GetInput(string message)
        {
            Console.WriteLine($"Xin mời nhập {message}");
            return Console.ReadLine();
        }
        private string GetRegex(string message, string regex)
        {
            
            string nhap;
            do
            {
                nhap = GetInput(message);
                if (!Regex.IsMatch(nhap, regex))
                {
                    Console.WriteLine("Sai regex, mời nhập lại");
                }
            } while (!Regex.IsMatch(nhap, regex));
            return nhap;
        }
        public void Nhap(List<DienThoai> lstDienThoai)
        {
            do
            {
                DienThoai newDienThoai = new DienThoai();
                // \d => 0-9
                // \w => chữ cả có dấu
                //Nhập id có 6 số và số đầu tiên không được là số 0
                newDienThoai.Id = Convert.ToInt32(GetRegex("id điện thoại",@"^[1-9]{1}[\d]{5}$"));
                newDienThoai.Ten = GetInput("tên điện thoại");
                newDienThoai.NhaSanXuat = GetInput("nhà sản xuất");
                newDienThoai.NamSanXuat = Convert.ToInt32(GetRegex("năm sản xuất", @"^[\d]+$"));
                lstDienThoai.Add(newDienThoai);
                do
                {
                    input = GetInput("tiếp tục hay là không");
                    if(String.Compare(input,"có",true) !=0 && String.Compare(input,"không",true) != 0)
                    {
                        Console.WriteLine("Chỉ được nhập có hoặc không");
                    }
                } while (String.Compare(input, "có", true) != 0 && String.Compare(input, "không", true) != 0);
            } while (String.Compare(input, "có", true) == 0);
        }
        private bool CheckCount(List<DienThoai> list)
        {
            if(list.Count == 0)
            {
                Console.WriteLine("Làm gì có danh sách mà đọc");
                return false;
            }
            return true;
        }
        public void Xuat(List<DienThoai> lstDienThoais)
        {
            if(CheckCount(lstDienThoais))
            {
                foreach (var item in lstDienThoais)
                {
                    item.InThongTin();
                }
            }
        }
        public void GhiFile(string path, List<DienThoai> list)
        {
            if (File.Exists(path))
            {
                if(CheckCount(list))
                {
                    foreach (var item in list)
                    {
                        string content = item.GetObj();
                        File.AppendAllText(path, content);
                    }
                    Console.WriteLine("Ghi thành công");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy file để đọc");
            }
        }

        //Đọc file cứu file
        public void DocFile(string path)
        {
            string contents  = File.ReadAllText(path);
            Console.WriteLine(contents);
        }
        //Đọc file full điểm
        public List<DienThoai> DocFileList(string path)
        {
            List<DienThoai> lstReadFile = new List<DienThoai>();
            if(File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (var item in lines)
                {
                    if(item.Trim().Length == 0)
                    {
                        continue;
                    }
                    string[] infos = item.Split('|');
                    DienThoai dt = new DienThoai();
                    dt.Id = Convert.ToInt32(infos[0].Trim());
                    dt.Ten = infos[1].Trim();
                    dt.NhaSanXuat = infos[2].Trim();
                    dt.NamSanXuat = Convert.ToInt32(infos[3].Trim());
                    lstReadFile.Add(dt);
                }
            }
            
            return lstReadFile;
        }
    }
}
