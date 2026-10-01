using System;

using DPM235403_BuiLeTuanAnh_BTH03_08_ReplaceMethodWithMethodObject.Before;
using DPM235403_BuiLeTuanAnh_BTH03_08_ReplaceMethodWithMethodObject.After;
using DPM235403_BuiLeTuanAnh_BTH03_08_ReplaceMethodWithMethodObject.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_08_ReplaceMethodWithMethodObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. DEMO BEFORE ---");
            var accountBefore = new Before.Account();
            Console.WriteLine($"Result: {accountBefore.Gamma(10, 5, 2026)}");

            Console.WriteLine("\n--- 2. DEMO AFTER ---");
            var accountAfter = new After.Account();
            Console.WriteLine($"Result: {accountAfter.Gamma(10, 5, 2026)}");

            Console.WriteLine("\n--- 3. DEMO REAL (NONG DUOC) ---");
            var donHang = new DonHangNongDuoc();

            Console.WriteLine("Trang thai 1: Khach thuong, mua it (Gia 150k, 10 san pham, 15km, 100 diem)");
            donHang.TinhTienPhucTap(150000, 10, 15, 100);

            Console.WriteLine("\nTrang thai 2: Khach VIP, mua nhieu (Gia 150k, 50 san pham, 15km, 800 diem)");
            donHang.TinhTienPhucTap(150000, 50, 15, 800);

            Console.ReadLine();
        }
    }
}