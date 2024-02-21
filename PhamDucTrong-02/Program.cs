using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamDucTrong_02
{
    class Program
    {
        static void Main (string[]args)
        {
            Menu();
        }
        static void Menu()
        {
            QuanLyNV ql = new QuanLyNV();
            int luaChon = 0;
            do
            {
                Console.WriteLine("Chuong trinh quan ly nhan vien");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("+ 1: Nhap danh sach nhan vien.");
                Console.WriteLine("+ 2: Hien thi thong tin nhan vien.");
                Console.WriteLine("+ 3: Thong ke tien luong cong ty tra cho nhan vien.");
                Console.WriteLine("+ 4: Tinh tien luong thuc lanh trung binh.");
                Console.WriteLine("+ 5: thoat!");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Lua chon tinh nang:");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        ql.NhapDS();
                    break;
                    case 2:
                        ql.XuatDS();
                    break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Loai nhan vien khong hop le!");
                        break;
                }

            }
        }
    }
}
