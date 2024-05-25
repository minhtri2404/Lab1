using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class NhaKhoaHoc : NhanVien
    {
        public string Chucvu;
        public int SoBaiBao;
        public int SoNgayCong;
        public int BacLuong;

        public NhaKhoaHoc() { 

        }
        public NhaKhoaHoc(string hoTen, int namSinh, string bangCap, string chucvu, int soBaiBao, int soNgayCong, int bacLuong)
            : base(hoTen,namSinh,bangCap)
        {
            Chucvu = chucvu;
            SoBaiBao = soBaiBao;
            SoNgayCong = soNgayCong;
            BacLuong = bacLuong;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap chuc vu: ");
            Chucvu = Console.ReadLine();
            Console.Write("Nhap so bai bao: ");
            SoBaiBao = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay cong: ");
            SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap bac luong: ");
            BacLuong = int.Parse(Console.ReadLine());
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"Chuc vu: {Chucvu}");
            Console.WriteLine($"Bai bao: {SoBaiBao}");
            Console.WriteLine($"Ngay cong: {SoNgayCong}");
            Console.WriteLine($"Bac luong: {BacLuong}");
        }
        public int TinhLuong()
        {
            return SoNgayCong * BacLuong;
        }
    }
}
