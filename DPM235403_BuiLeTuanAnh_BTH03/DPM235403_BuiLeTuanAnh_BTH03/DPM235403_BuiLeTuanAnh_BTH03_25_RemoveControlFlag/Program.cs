using System;
using DPM235403_BuiLeTuanAnh_BTH03_25_RemoveControlFlag.Before;
using DPM235403_BuiLeTuanAnh_BTH03_25_RemoveControlFlag.After;
using DPM235403_BuiLeTuanAnh_BTH03_25_RemoveControlFlag.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_25_RemoveControlFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] danhSach = { "Alice", "Bob", "John", "Don" };

            Console.WriteLine("--- 1. BEFORE ---");
            new Before.Security().CheckSecurity(danhSach);

            Console.WriteLine("\n--- 2. AFTER ---");
            new After.Security().CheckSecurity(danhSach);

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var kiemDinh = new KiemDinhChatLuong();

            string[] thanhPhanLo1 = { "Nito", "Photpho", "Kali" };
            kiemDinh.CoChuaChatCam(thanhPhanLo1);

            Console.WriteLine();

            string[] thanhPhanLo2 = { "Nito", "Asen", "Luu Huynh" };
            kiemDinh.CoChuaChatCam(thanhPhanLo2);

            Console.ReadLine();
        }
    }
}