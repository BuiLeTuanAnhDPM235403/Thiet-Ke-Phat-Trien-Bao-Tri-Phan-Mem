using System;
using System.Collections.Generic;

// Đảm bảo using đúng namespace chứa 3 file kia
using DPM235403_BuiLeTuanAnh_BTH03_01_ExtractMethod.Before;
using DPM235403_BuiLeTuanAnh_BTH03_01_ExtractMethod.After;
using DPM235403_BuiLeTuanAnh_BTH03_01_ExtractMethod.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_01_ExtractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // BƯỚC 1: Gọi code từ file Before.cs chạy
            Console.WriteLine("--- 1. CHAY FILE BEFORE ---");
            var phieuNoBefore = new Before.PhieuNo(); // Tạo đối tượng từ file Before
            phieuNoBefore.PrintOwing();               // Gọi hàm bên trong nó

            // BƯỚC 2: Gọi code từ file After.cs chạy
            Console.WriteLine("\n--- 2. CHAY FILE AFTER ---");
            var phieuNoAfter = new After.PhieuNo();   // Tạo đối tượng từ file After
            phieuNoAfter.PrintOwing();

            // BƯỚC 3: Gọi code từ file Real.cs chạy
            Console.WriteLine("\n--- 3. CHAY FILE REAL ---");
            var gioHang = new List<SanPham>
            {
                new SanPham { Ten = "Phan bon Ure Ca Mau", Gia = 850000 },
                new SanPham { Ten = "Thuoc tru sau Regen", Gia = 350000 }
            };
            var hoaDon = new HoaDonNongDuoc("Bac Sau", gioHang); // Tạo đối tượng từ file Real
            hoaDon.XuatHoaDon();

            Console.ReadLine(); // Dừng màn hình để xem kết quả
        }
    }
}