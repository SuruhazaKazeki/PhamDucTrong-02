using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamDucTrong_02
{
    class NhanVien
    {
        private string MaSo, HoTen;
        private int LuongCung;
        public NhanVien()
        {
            
        }
        public NhanVien (string MaSo, string HoTen, int LuongCung)
        {
            this.MaSo = MaSo;
            this.HoTen = HoTen;
            this.LuongCung = LuongCung;
        }
        public string Maso
        {
            set { this.MaSo = value; }
            get { return HoTen; }
        }
        public string Hoten
        {
            set { this.HoTen = value; }
            get { return HoTen; }
        }
        public int Luongcung
        {
            set { this.LuongCung = value; }
            get { return LuongCung; }
        }
        public virtual void Nhap()
        {
            Console.Write("-Nhap ma so: ");
            this.MaSo = Console.ReadLine();
            Console.Write("-Nhap ho ten: ");
            this.HoTen = Console.ReadLine();
            Console.Write("Nhap luong cung: ");
            this.LuongCung = int.Parse(Console.ReadLine());
        }
        public virtual double TinhLuong()
        {
            return 0;
        }
    }
}
