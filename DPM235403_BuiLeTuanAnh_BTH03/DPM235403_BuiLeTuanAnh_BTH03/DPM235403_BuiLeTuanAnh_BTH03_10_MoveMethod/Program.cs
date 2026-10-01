using System;
using DPM235403_BuiLeTuanAnh_BTH03_10_MoveMethod.Before;
using DPM235403_BuiLeTuanAnh_BTH03_10_MoveMethod.After;
using DPM235403_BuiLeTuanAnh_BTH03_10_MoveMethod.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_10_MoveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var typeB = new Before.AccountType { IsPremium = true };
            var accB = new Before.Account(typeB, 10);
            Console.WriteLine($"Phi thau chi: {accB.OverdraftCharge()}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var typeA = new After.AccountType { IsPremium = true };
            var accA = new After.Account(typeA, 10);
            Console.WriteLine($"Tong phi ngan hang: {accA.BankCharge()}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var khachVip = new KhachHang("Bac Bay", "VIP", 5);
            var hoaDonVip = new HoaDon(khachVip, 5000000); // Mua 5 triệu
            hoaDonVip.InThanhTien();

            var khachThuong = new KhachHang("Chu Muoi", "THUONG", 1);
            var hoaDonThuong = new HoaDon(khachThuong, 2000000);
            hoaDonThuong.InThanhTien();

            Console.ReadLine();
        }
    }
}