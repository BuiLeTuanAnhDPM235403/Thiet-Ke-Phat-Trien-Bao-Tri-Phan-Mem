using System;
using DPM235403_BuiLeTuanAnh_BTH03_29_IntroduceAssertion.Before;
using DPM235403_BuiLeTuanAnh_BTH03_29_IntroduceAssertion.After;
using DPM235403_BuiLeTuanAnh_BTH03_29_IntroduceAssertion.Real;
using System.Diagnostics.Metrics;

namespace DPM235403_BuiLeTuanAnh_BTH03_29_IntroduceAssertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var expB = new Before.Expense();
            expB.SetPrimary(true);
            Console.WriteLine($"Limit: {expB.GetExpenseLimit()}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var expA = new After.Expense();
            expA.SetPrimary(true);
            expA.SetLimit(100);
            Console.WriteLine($"Limit: {expA.GetExpenseLimit()}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var mayPha = new MayPhaThuoc();

            try
            {
                Console.WriteLine("Pha 50ml thuoc vao 20 Lit nuoc:");
                mayPha.PhaChe("Amistar Top", 50, 20);

                Console.WriteLine("Pha 50ml thuoc vao 0 Lit nuoc:");
                mayPha.PhaChe("Amistar Top", 50, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[LOI ASSERTION] {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}