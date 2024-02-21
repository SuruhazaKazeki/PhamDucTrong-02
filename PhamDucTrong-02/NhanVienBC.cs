using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamDucTrong_02
{
    class NhanVienBC:NhanVien
    {
        private string mucXepLoai;
        public NhanVienBC():base()
        {
            
        }
        public NhanVienBC(string MaSo,string HoTen,int LuongCung): base(MaSo, HoTen,LuongCung)
        {
            this.mucXepLoai = mucXepLoai;
        }
        public string MucXepLoai
        {
            set { this.mucXepLoai = value; }
            get { return mucXepLoai; }
        }
        public override void Nhap()
        {
            Console.Write("- Xep loai: ");
            this.mucXepLoai = Console.ReadLine();
        }
        public override double TinhLuong()
        {
            double luong;
            if (this.mucXepLoai.ToLower() == "a")
                luong = Luongcung + 1.5 * this.Luongcung;
            else if (this.mucXepLoai.ToLower() == "b")
                luong = Luongcung + 1 * this.Luongcung;
            else
                luong = Luongcung + 0.1 * this.Luongcung;
            return luong;
        }
    }
}
