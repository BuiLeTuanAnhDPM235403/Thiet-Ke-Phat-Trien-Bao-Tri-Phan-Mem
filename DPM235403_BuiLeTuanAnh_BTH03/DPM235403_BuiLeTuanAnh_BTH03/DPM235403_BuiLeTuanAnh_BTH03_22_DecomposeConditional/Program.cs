using System;
using DPM235403_BuiLeTuanAnh_BTH03_22_DecomposeConditional.Before;
using DPM235403_BuiLeTuanAnh_BTH03_22_DecomposeConditional.After;
using DPM235403_BuiLeTuanAnh_BTH03_22_DecomposeConditional.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_22_DecomposeConditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var billB = new Before.Billing();
            Console.WriteLine($"Tien: {billB.CalculateCharge(new DateTime(2026, 7, 15), 100)}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var billA = new After.Billing();
            Console.WriteLine($"Tien: {billA.CalculateCharge(new DateTime(2026, 7, 15), 100)}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var chinhSach = new ChinhSachBanHang();

            Console.WriteLine("Khach mua vao thang 2 (Vu Dong Xuan):");
            double tienThang2 = chinhSach.TinhTienPhanBon(new DateTime(2026, 2, 10), 500000, 10);
            Console.WriteLine($"Tong tra: {tienThang2:N0} VND\n");

            Console.WriteLine("Khach mua vao thang 6 (Vu He Thu):");
            double tienThang6 = chinhSach.TinhTienPhanBon(new DateTime(2026, 6, 15), 500000, 10);
            Console.WriteLine($"Tong tra: {tienThang6:N0} VND");

            Console.ReadLine();
        }
    }
}