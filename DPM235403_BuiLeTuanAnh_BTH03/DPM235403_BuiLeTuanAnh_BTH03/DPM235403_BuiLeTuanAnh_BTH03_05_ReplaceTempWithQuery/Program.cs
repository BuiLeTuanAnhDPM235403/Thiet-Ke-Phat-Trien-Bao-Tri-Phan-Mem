using System;

using DPM235403_BuiLeTuanAnh_BTH03_05_ReplaceTempWithQuery.Before;
using DPM235403_BuiLeTuanAnh_BTH03_05_ReplaceTempWithQuery.After;
using DPM235403_BuiLeTuanAnh_BTH03_05_ReplaceTempWithQuery.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_05_ReplaceTempWithQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. DEMO BEFORE ---");
            var dhBefore = new Before.DonHang();
            Console.WriteLine($"Tong tien don hang: {dhBefore.CalculateTotal()}");

            Console.WriteLine("\n--- 2. DEMO AFTER ---");
            var dhAfter = new After.DonHang();
            Console.WriteLine($"Tong tien don hang: {dhAfter.CalculateTotal()}");

            Console.WriteLine("\n--- 3. DEMO REAL (NONG DUOC) ---");
            // Mua 10 chai, giá 150k/chai => 1.5 triệu (Không được giảm giá)
            var hoaDonKhachLe = new HoaDonThuocTruSau(10, 150000);
            Console.WriteLine($"Khach le thanh toan: {hoaDonKhachLe.TinhTienThanhToan():N0} VND");

            // Mua 50 chai, giá 150k/chai => 7.5 triệu (Được giảm 10%)
            var hoaDonKhachSi = new HoaDonThuocTruSau(50, 150000);
            Console.WriteLine($"Khach si thanh toan: {hoaDonKhachSi.TinhTienThanhToan():N0} VND");

            Console.ReadLine();
        }
    }
}