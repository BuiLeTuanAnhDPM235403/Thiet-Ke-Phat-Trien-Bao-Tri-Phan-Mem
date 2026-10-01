using System;
using DPM235403_BuiLeTuanAnh_BTH03_20_ReplaceMagicNumberWithSymbolicConstant.Before;
using DPM235403_BuiLeTuanAnh_BTH03_20_ReplaceMagicNumberWithSymbolicConstant.After;
using DPM235403_BuiLeTuanAnh_BTH03_20_ReplaceMagicNumberWithSymbolicConstant.Real;
using System.Diagnostics.Metrics;

namespace DPM235403_BuiLeTuanAnh_BTH03_20_ReplaceMagicNumberWithSymbolicConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var physicsB = new Before.Physics();
            Console.WriteLine($"The nang: {physicsB.PotentialEnergy(10, 5)}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var physicsA = new After.Physics();
            Console.WriteLine($"The nang: {physicsA.PotentialEnergy(10, 5)}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var kiemDinh = new KiemDinhVanChuyen();

            // Chở 300kg (dưới giới hạn)
            kiemDinh.KiemTraChuyenHang(300);

            // Chở 650kg (vượt giới hạn)
            kiemDinh.KiemTraChuyenHang(650);

            Console.ReadLine();
        }
    }
}