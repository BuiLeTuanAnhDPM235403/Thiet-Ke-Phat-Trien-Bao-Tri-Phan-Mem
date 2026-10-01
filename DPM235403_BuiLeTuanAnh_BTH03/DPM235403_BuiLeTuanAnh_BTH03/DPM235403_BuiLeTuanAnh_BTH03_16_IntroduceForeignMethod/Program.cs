using System;
using DPM235403_BuiLeTuanAnh_BTH03_16_IntroduceForeignMethod.Before;
using DPM235403_BuiLeTuanAnh_BTH03_16_IntroduceForeignMethod.After;
using DPM235403_BuiLeTuanAnh_BTH03_16_IntroduceForeignMethod.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_16_IntroduceForeignMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            new Before.Report().GenerateReport();

            Console.WriteLine("\n--- 2. AFTER ---");
            new After.Report().GenerateReport();

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            // Mua chịu phân bón vào ngày hiện tại
            var phieuNo = new PhieuGhiNo("Bac Tu Giau", 5500000, DateTime.Now);
            phieuNo.InThongTinNo();

            Console.ReadLine();
        }
    }
}