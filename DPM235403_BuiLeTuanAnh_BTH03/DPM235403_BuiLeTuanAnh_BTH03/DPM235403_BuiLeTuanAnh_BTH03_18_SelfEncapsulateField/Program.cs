using System;
using DPM235403_BuiLeTuanAnh_BTH03_18_SelfEncapsulateField.Before;
using DPM235403_BuiLeTuanAnh_BTH03_18_SelfEncapsulateField.After;
using DPM235403_BuiLeTuanAnh_BTH03_18_SelfEncapsulateField.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_18_SelfEncapsulateField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var rangeB = new Before.IntRange(1, 10);
            Console.WriteLine($"So 5 nam trong khoang? {rangeB.Includes(5)}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var rangeA = new After.IntRange(1, 10);
            Console.WriteLine($"So 15 nam trong khoang? {rangeA.Includes(15)}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            // Kho ban đầu có 50 bao Ure
            var khoUre = new KhoPhanBon("Ure Ca Mau", 50);
            khoUre.KiemTraKho();

            // Khách mua 20 bao -> Thành công
            khoUre.XuatKho(20);
            khoUre.KiemTraKho();

            // Khách mua 40 bao -> Thất bại, Property chặn lại ngay vì kho chỉ còn 30
            khoUre.XuatKho(40);
            khoUre.KiemTraKho();

            Console.ReadLine();
        }
    }
}