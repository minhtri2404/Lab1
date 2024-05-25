using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT4
{
    internal class Test
    {
        static void Main(string[] args)
        {
            List<NhaKhoaHoc> dsNhaKhoaHoc = new List<NhaKhoaHoc>();
            List<NhaQuanLy> dsNhaQuanLy = new List<NhaQuanLy>();
            List<NhanVienPhongThiNghiem> dsNhanVienPhongThiNghiem = new List<NhanVienPhongThiNghiem>();

            Console.Write("Nhap so luong nha khoa hoc: ");
            int soLuongNhaKhoaHoc = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuongNhaKhoaHoc; i++)
            {
                Console.WriteLine($"Nhap thong tin nha khoa hoc thu {i + 1}:");
                NhaKhoaHoc nhaKhoaHoc = new NhaKhoaHoc();
                nhaKhoaHoc.NhapThongTin();
                dsNhaKhoaHoc.Add(nhaKhoaHoc);
                Console.WriteLine($"-----------------------------------------");
            }

            Console.Write("Nhap so luong nha quan ly: ");
            int soLuongNhaQuanLy = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuongNhaQuanLy; i++)
            {
                Console.WriteLine($"Nhap thong tin nha quan ly thu {i + 1}:");
                NhaQuanLy nhaQuanLy = new NhaQuanLy();
                nhaQuanLy.NhapThongTin();
                dsNhaQuanLy.Add(nhaQuanLy);
                Console.WriteLine($"-----------------------------------------");
            }

            Console.Write("Nhap so luong nhan vien phong thi nghiem: ");
            int soLuongNhanVienPhongThiNghiem = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuongNhanVienPhongThiNghiem; i++)
            {
                Console.WriteLine($"Nhap thong tin nhan vien phong thi nghiem thu {i + 1}:");
                NhanVienPhongThiNghiem nhanVienPhongThiNghiem = new NhanVienPhongThiNghiem();
                nhanVienPhongThiNghiem.NhapThongTin();
                dsNhanVienPhongThiNghiem.Add(nhanVienPhongThiNghiem);
                Console.WriteLine($"-----------------------------------------");
            }

            Console.WriteLine("\nDanh sach nha khoa hoc:");
            foreach (var nhaKhoaHoc in dsNhaKhoaHoc)
            {
                nhaKhoaHoc.XuatThongTin();
            }

            Console.WriteLine("\nDanh sach nha quan ly:");
            foreach (var nhaQuanLy in dsNhaQuanLy)
            {
                nhaQuanLy.XuatThongTin();
            }

            Console.WriteLine("\nDanh sach nhan vien phong thi nghiem:");
            foreach (var nhanVienPhongThiNghiem in dsNhanVienPhongThiNghiem)
            {
                nhanVienPhongThiNghiem.XuatThongTin();
            }
            //tongLuongNhaKhoaHoc
            int tongLuongNhaKhoaHoc = 0;
            foreach (var nhaKhoaHoc in dsNhaKhoaHoc)
            {
                tongLuongNhaKhoaHoc += nhaKhoaHoc.TinhLuong();
            }
            Console.WriteLine($"\nTong luong đa chi tra cho nha khoa hoc: {tongLuongNhaKhoaHoc}");
            //tongLuongNhaQuanLy
            int tongLuongNhaQuanLy = 0;
            foreach (var nhaQuanLy in dsNhaQuanLy)
            {
                tongLuongNhaQuanLy += nhaQuanLy.TinhLuong();
            }
            Console.WriteLine($"Tong luong đa chi tra cho nha quan ly: {tongLuongNhaQuanLy} ");
            //tongLuongNhanVienPhongThiNghiem
            int tongLuongNhanVienPhongThiNghiem = 0;
            foreach (var nhanVienPhongThiNghiem in dsNhanVienPhongThiNghiem)
            {
                tongLuongNhanVienPhongThiNghiem += nhanVienPhongThiNghiem.LuongThang;
            }
            Console.WriteLine($"Tong luong đa chi tra cho nhan vien phong thi nghiem: {tongLuongNhanVienPhongThiNghiem}");
            Console.ReadLine();
        }
    }
}
