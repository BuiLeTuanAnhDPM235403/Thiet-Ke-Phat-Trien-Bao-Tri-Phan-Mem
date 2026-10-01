using System;

// Import các file
using DPM235403_BuiLeTuanAnh_BTH03_02_InlineMethod.Before;
using DPM235403_BuiLeTuanAnh_BTH03_02_InlineMethod.After;
using DPM235403_BuiLeTuanAnh_BTH03_02_InlineMethod.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_02_InlineMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. DEMO BEFORE ---");
            var giaoHangBefore = new Before.GiaoHang();
            Console.WriteLine($"Muc danh gia: {giaoHangBefore.LayDanhGia()}");

            Console.WriteLine("\n--- 2. DEMO AFTER ---");
            var giaoHangAfter = new After.GiaoHang();
            Console.WriteLine($"Muc danh gia: {giaoHangAfter.LayDanhGia()}");

            Console.WriteLine("\n--- 3. DEMO REAL (NONG DUOC) ---");
            // Khách thường (Dưới 1000 điểm)
            var khachThuong = new KhachHangNongDuoc("Chu Nam", 500);
            double tienChuNam = khachThuong.TinhTienSauChietKhau(2000000);
            Console.WriteLine($"Thanh toan: {tienChuNam:N0} VND\n");

            // Khách VIP (Trên 1000 điểm)
            var khachVIP = new KhachHangNongDuoc("Bac Sau", 1500);
            double tienBacSau = khachVIP.TinhTienSauChietKhau(2000000);
            Console.WriteLine($"Thanh toan: {tienBacSau:N0} VND");

            Console.ReadLine();
        }
    }
}