using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamDucTrong_02
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }
        public void NhapDS()
        {
            string tiepTuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.WriteLine("Cho biet loai nhan vien(1: Bien Che | 2: Hop Dong");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        nv = new NhanVienBC();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    case 2:
                        nv = new NhanVienHD();
                        nv.Nhap();
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Loai nhan vien khong hop le!");
                        break;
                }
                Console.Write("Ban co muon tiep tuc? Y/N");
                tiepTuc = Console.ReadLine();
            }
            while (tiepTuc.ToLower() == "y");
        }
        public void XuatDS()
        {
            Console.WriteLine($"Ma so{20},Ho ten{20}, Luong cung {20}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.Maso,-10},{x.Hoten,20},{x.Luongcung,20}");
            }    
        }
    }
}
