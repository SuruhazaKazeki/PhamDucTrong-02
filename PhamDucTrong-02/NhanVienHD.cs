using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamDucTrong_02
{
    class NhanVienHD:NhanVien
    {
        private int doanhThu;
        public NhanVienHD() : base()
        {

        }
        public NhanVienHD(string MaSo, string HoTen, int LuongCung) : base(MaSo, HoTen, LuongCung)
        {
            this.doanhThu=doanhThu;
        }
        public int DoanhThu
        {
            set { this.doanhThu= value; }
            get { return doanhThu; }
        }
        public override void Nhap()
        {
            Console.Write("-Doanh thu: ");
            this.doanhThu =int.Parse( Console.ReadLine());
        }
        public override double TinhLuong()
        {
            return Luongcung + 0.1 * doanhThu;
        }
    }
}
