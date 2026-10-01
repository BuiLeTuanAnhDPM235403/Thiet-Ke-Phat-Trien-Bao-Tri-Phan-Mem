using System;
using DPM235403_BuiLeTuanAnh_BTH03_21_ReplaceArrayWithObject.Before;
using DPM235403_BuiLeTuanAnh_BTH03_21_ReplaceArrayWithObject.After;
using DPM235403_BuiLeTuanAnh_BTH03_21_ReplaceArrayWithObject.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_21_ReplaceArrayWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            new Before.Performance().PrintTeamInfo();

            Console.WriteLine("\n--- 2. AFTER ---");
            new After.Performance().PrintTeamInfo();

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var kho = new QuanLyKho();

            // Dữ liệu được đóng gói đẹp đẽ trong Đối tượng thay vì mảng trần trụi
            var loThuoc = new ChiTietNhapKho("Thuoc tru benh Tilt Super", 50, 250000);
            kho.GhiNhanNhapKho(loThuoc);

            var loPhan = new ChiTietNhapKho("Phan bon la Boom Flower", 100, 85000);
            kho.GhiNhanNhapKho(loPhan);

            Console.ReadLine();
        }
    }
}