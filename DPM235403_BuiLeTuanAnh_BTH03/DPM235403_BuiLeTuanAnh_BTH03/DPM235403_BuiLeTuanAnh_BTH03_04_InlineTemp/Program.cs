using System;

using DPM235403_BuiLeTuanAnh_BTH03_04_InlineTemp.Before;
using DPM235403_BuiLeTuanAnh_BTH03_04_InlineTemp.After;
using DPM235403_BuiLeTuanAnh_BTH03_04_InlineTemp.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_04_InlineTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. DEMO BEFORE ---");
            var donHangBefore = new Before.DonHang();
            Console.WriteLine($"Co duoc khuyen mai khong? {donHangBefore.CheckKhuyenMai()}");

            Console.WriteLine("\n--- 2. DEMO AFTER ---");
            var donHangAfter = new After.DonHang();
            Console.WriteLine($"Co duoc khuyen mai khong? {donHangAfter.CheckKhuyenMai()}");

            Console.WriteLine("\n--- 3. DEMO REAL (NONG DUOC) ---");
            var baoUre = new BaoPhanBon("Phan bon Ure Ca Mau", 50);
            var phanBonsai = new BaoPhanBon("Phan bon la NPK (Goi nho)", 2);

            Console.WriteLine($"- {baoUre.TenPhanBon} ({baoUre.TrongLuongKg}kg) -> Can nguoi khuang vac? {baoUre.CanThueNguoiKhuanVac()}");
            Console.WriteLine($"- {phanBonsai.TenPhanBon} ({phanBonsai.TrongLuongKg}kg) -> Can nguoi khuang vac? {phanBonsai.CanThueNguoiKhuanVac()}");

            Console.ReadLine();
        }
    }
}