using System;
using DPM235403_BuiLeTuanAnh_BTH03_23_ConsolidateConditionalExpression.Before;
using DPM235403_BuiLeTuanAnh_BTH03_23_ConsolidateConditionalExpression.After;
using DPM235403_BuiLeTuanAnh_BTH03_23_ConsolidateConditionalExpression.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_23_ConsolidateConditionalExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            Console.WriteLine($"Tro cap: {new Before.NhanVien().DisabilityAmount()}");

            Console.WriteLine("\n--- 2. AFTER ---");
            Console.WriteLine($"Tro cap: {new After.NhanVien().DisabilityAmount()}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            Console.WriteLine("Khach A: Mua 5 trieu, Khach thuong, Khong phai thang sinh nhat");
            var donA = new DonHangTriAn(5000000, false, false);
            donA.KiemTraQuaTang();

            Console.WriteLine("\nKhach B: Mua 2 trieu, Khach VIP");
            var donB = new DonHangTriAn(2000000, true, false);
            donB.KiemTraQuaTang();

            Console.ReadLine();
        }
    }
}