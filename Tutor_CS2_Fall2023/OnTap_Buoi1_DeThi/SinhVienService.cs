using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTap_Buoi1_DeThi
{
    internal class SinhVienService
    {
        string _input;
        List<SinhVien> lstSinhViens;
        public SinhVienService()
        {
            lstSinhViens = new List<SinhVien>()
            {
                new SinhVien("giang","ph26511",2002,10),
                new SinhVien("trang","ph44444",2005,9.9),
                new SinhVien("nguyễn đăng","ph22222",2004,9.8),
                new SinhVien("trọng","ph11111",2003,9.7)
            };
        }
        private string GetInput(string message)
        {
            Console.WriteLine($"Mời anh chị nhập {message}");
            return Console.ReadLine();
        }
        public void Nhap()
        {
            do
            {
                SinhVien sv = new SinhVien();
                sv.Ten = GetInput("tên sinh viên");
                sv.MaSV = Utility.GetInput("mã sinh viên");
                sv.NamSinh = Convert.ToInt32(GetInput("năm sinh"));
                checkPoint:
                double checkDiem = Convert.ToDouble(GetInput("điểm tb của sinh viên"));
                if(checkDiem < 0 || checkDiem > 10)
                {
                    Console.WriteLine("Điểm chỉ nhập từ 0 cho đến 10 thôi");
                    goto checkPoint;
                }
                sv.DiemTB = checkDiem;
                lstSinhViens.Add(sv);
                do
                {
                    _input = GetInput("có muốn nhập tiếp không");
                    //chỉ được  nhập có hoặc không.
                    if(String.Compare(_input,"có",true) != 0 && String.Compare(_input,"không",true) != 0)
                    {
                        Console.WriteLine("Chỉ được  nhập có hoặc không");
                    }
                } while (String.Compare(_input, "có", true) != 0 && String.Compare(_input, "không", true) != 0);
            } while (String.Compare(_input, "có", true) == 0);
        }
        private bool CheckCount()
        {
            if(lstSinhViens.Count == 0)
            {
                Console.WriteLine("Làm gì có danh sách mà đọc");
                return false;
            }
            return true;
        }
        public void Xuat()
        {
            if(CheckCount())
            {
                foreach (SinhVien item in lstSinhViens)
                {
                    item.InThongTin();
                }
            }
        }
        public void XuatSinhVienDiemTot()
        {
            if(CheckCount())
            {
                bool checkDiem = false;
                foreach (SinhVien item in lstSinhViens)
                {
                    if(item.DiemTB >=8)
                    {
                        item.InThongTin();
                        checkDiem = true;
                    }
                }
                if(!checkDiem)
                {
                    Console.WriteLine("Không có sinh viên giỏi");
                }
                
            }
        }
        public void XoaSVKhongDuocVe()
        {
            //Nếu mà >=25 <=8 không được đi >=25 && <=8
            //nếu mà <25 
            if(CheckCount())
            {
                //List<SinhVien> lstXoa = new List<SinhVien>();
                //foreach (var item in lstSinhViens)
                //{
                //    if(item.TinhTuoi() >= 25 && item.DiemTB < 8)
                //    {
                //        lstXoa.Add(item);
                //    }
                //}
                //foreach (var item in lstXoa)
                //{
                //    lstSinhViens.Remove(item);
                //}
                bool checkXoa = false;
                for (int i = 0; i < lstSinhViens.Count; )
                {
                    if (lstSinhViens[i].TinhTuoi() >= 25 && lstSinhViens[i].DiemTB < 8)
                    {
                        lstSinhViens.RemoveAt(i);
                        checkXoa = true;
                        continue;
                    }
                    else
                    {
                        i++;
                    }
                }
                if(!checkXoa)
                {
                    Console.WriteLine("Không có sinh viên nào bị xóa");
                }
                else
                {
                    Console.WriteLine("Xóa thành công");
                }
            }
        }
        public void KeThua()
        {
            SinhVienUDPM sinhVienUDPM = new SinhVienUDPM("Giang","Ph32133",2003,10,10,6);
            sinhVienUDPM.InThongTin();

        }
    }
}
