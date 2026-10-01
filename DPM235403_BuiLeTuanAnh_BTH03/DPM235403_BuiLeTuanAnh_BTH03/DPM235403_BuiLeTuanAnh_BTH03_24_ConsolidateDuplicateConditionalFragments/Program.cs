using System;
using DPM235403_BuiLeTuanAnh_BTH03_24_ConsolidateDuplicateConditionalFragments.Before;
using DPM235403_BuiLeTuanAnh_BTH03_24_ConsolidateDuplicateConditionalFragments.After;
using DPM235403_BuiLeTuanAnh_BTH03_24_ConsolidateDuplicateConditionalFragments.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_24_ConsolidateDuplicateConditionalFragments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            new Before.Order().ProcessOrder(true, 100);

            Console.WriteLine("\n--- 2. AFTER ---");
            new After.Order().ProcessOrder(false, 100);

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var xuatHang = new XuatHangNongDuoc();

            Console.WriteLine("Truong hop 1: Khach Si mua 100 chai Regent (100k/chai)");
            xuatHang.XuatKho("Regent 800WG", 100, 100000, true);

            Console.WriteLine("Truong hop 2: Khach Le mua 5 chai Regent (100k/chai)");
            xuatHang.XuatKho("Regent 800WG", 5, 100000, false);

            Console.ReadLine();
        }
    }
}