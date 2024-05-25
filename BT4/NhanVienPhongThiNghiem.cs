using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class NhanVienPhongThiNghiem : NhanVien
    {
        public int LuongThang;
        public NhanVienPhongThiNghiem() {

        }
        public NhanVienPhongThiNghiem(string hoTen, int namSinh, string bangCap, int luongThang)
            : base(hoTen,namSinh,bangCap)
        {
            LuongThang = luongThang;
        }
        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap luong thang: ");
            LuongThang = int.Parse(Console.ReadLine());
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Luong Thang: {LuongThang}");
        }
    }
}
