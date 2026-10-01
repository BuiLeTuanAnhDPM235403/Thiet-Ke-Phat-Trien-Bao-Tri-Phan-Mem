using System;

// Import các file
using DPM235403_BuiLeTuanAnh_BTH03_03_ExtractVariable.Before;
using DPM235403_BuiLeTuanAnh_BTH03_03_ExtractVariable.After;
using DPM235403_BuiLeTuanAnh_BTH03_03_ExtractVariable.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_03_ExtractVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. DEMO BEFORE ---");
            var browserBefore = new Before.TrinhDuyet();
            browserBefore.RenderBanner("MAC OS", "IE", 10); 

            Console.WriteLine("\n--- 2. DEMO AFTER ---");
            var browserAfter = new After.TrinhDuyet();
            browserAfter.RenderBanner("MAC OS", "IE", 10);

            Console.WriteLine("\n--- 3. DEMO REAL (NONG DUOC) ---");
            var tinhPhi = new TinhPhiVanChuyen();

            Console.WriteLine("Truong hop 1: Khach VIP mua 15 trieu, o cach 10km:");
            double phi1 = tinhPhi.TinhPhi("VIP", 15000000, 10);
            Console.WriteLine($"Phi ship: {phi1:N0} VND\n");

            Console.WriteLine("Truong hop 2: Khach thuong mua 5 trieu, o cach 20km:");
            double phi2 = tinhPhi.TinhPhi("NORMAL", 5000000, 20);
            Console.WriteLine($"Phi ship: {phi2:N0} VND");

            Console.ReadLine();
        }
    }
}