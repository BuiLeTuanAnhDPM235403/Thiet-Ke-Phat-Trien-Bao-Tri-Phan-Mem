using System;
using DPM235403_BuiLeTuanAnh_BTH03_19_ReplaceDataValueWithObject.Before;
using DPM235403_BuiLeTuanAnh_BTH03_19_ReplaceDataValueWithObject.After;
using DPM235403_BuiLeTuanAnh_BTH03_19_ReplaceDataValueWithObject.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_19_ReplaceDataValueWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var orderB = new Before.Order("John Doe");
            Console.WriteLine($"Don hang cua: {orderB.Customer}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var orderA = new After.Order("John Doe");
            Console.WriteLine($"Don hang cua: {orderA.Customer.Name}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var khach1 = new KhachHangNongDuoc("Chu Tam", "0971234567");
            var khach2 = new KhachHangNongDuoc("Di Chin", "0909998887");

            khach1.HienThiThongTin();
            khach2.HienThiThongTin();

            Console.ReadLine();
        }
    }
}