using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class NhanVien
    {
        public string HoTen;
        public int NamSinh;
        public string BangCap;

        public NhanVien()
        {

        }
        public NhanVien(string hoTen, int namSinh, string bangCap)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            BangCap = bangCap;
        }
        public virtual void NhapThongTin()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap bang cap: ");
            BangCap = Console.ReadLine();
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Ho ten: {HoTen}");
            Console.WriteLine($"Nam sinh: {NamSinh}");
            Console.WriteLine($"Bang cap: {BangCap}");
        }
    }
}
