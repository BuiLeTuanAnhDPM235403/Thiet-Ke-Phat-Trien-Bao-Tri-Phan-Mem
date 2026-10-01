using System;
using DPM235403_BuiLeTuanAnh_BTH03_17_IntroduceLocalExtension.Before;
using DPM235403_BuiLeTuanAnh_BTH03_17_IntroduceLocalExtension.After;
using DPM235403_BuiLeTuanAnh_BTH03_17_IntroduceLocalExtension.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_17_IntroduceLocalExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime homNay = DateTime.Now;

            Console.WriteLine("--- 1. BEFORE ---");
            new Before.Report().SendReport(homNay);

            Console.WriteLine("\n--- 2. AFTER ---");
            new After.Report().SendReport(homNay);

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var lich = new LichNongVu();
            // Nông dân sạ lúa vào ngày 01/10/2026
            DateTime ngaySaLua = new DateTime(2026, 10, 1);
            lich.TuVanLichBonPhan("Sau Nam", ngaySaLua);

            Console.ReadLine();
        }
    }
}