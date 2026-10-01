using System;
using DPM235403_BuiLeTuanAnh_BTH03_26_ReplaceNestedConditionalWithGuardClauses.Before;
using DPM235403_BuiLeTuanAnh_BTH03_26_ReplaceNestedConditionalWithGuardClauses.After;
using DPM235403_BuiLeTuanAnh_BTH03_26_ReplaceNestedConditionalWithGuardClauses.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_26_ReplaceNestedConditionalWithGuardClauses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            Console.WriteLine($"Luong: {new Before.Employee().GetPayAmount()}");

            Console.WriteLine("\n--- 2. AFTER ---");
            Console.WriteLine($"Luong: {new After.Employee().GetPayAmount()}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            // Đại lý nợ xấu
            var dlNoXau = new DaiLyNongDuoc("Vat tu nong nghiep Bay Map", false, true, 100000000);
            dlNoXau.TinhTienThuongChietKhau();

            // Đại lý chuẩn
            var dlChuan = new DaiLyNongDuoc("Nong Duoc Xanh Long Xuyen", false, false, 80000000);
            double tienThuong = dlChuan.TinhTienThuongChietKhau();
            Console.WriteLine($"Tien thuong nhan duoc: {tienThuong:N0} VND");

            Console.ReadLine();
        }
    }
}