using System;
using DPM235403_BuiLeTuanAnh_BTH03_12_ExtractClass.Before;
using DPM235403_BuiLeTuanAnh_BTH03_12_ExtractClass.After;
using DPM235403_BuiLeTuanAnh_BTH03_12_ExtractClass.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_12_ExtractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var personB = new Before.Person { Name = "Tuan Anh", OfficeAreaCode = "0296", OfficeNumber = "3841111" };
            Console.WriteLine($"Lien he: {personB.GetTelephoneNumber()}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var personA = new After.Person { Name = "Tuan Anh" };
            personA.OfficeTelephone.AreaCode = "0296";
            personA.OfficeTelephone.Number = "3841111";
            Console.WriteLine($"Lien he: {personA.GetTelephoneNumber()}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            // Tách bạch rõ ràng: Tạo thông tin giao hàng trước
            var diaChiKhach = new ThongTinGiaoHang("Chu Bay", "0988777666", "Xa My Luong, Huyen Cho Moi, An Giang");

            // Sau đó mới nhét vào đơn hàng
            var donHang = new DonHangNongDuoc("DH-2026-001", 12500000, diaChiKhach);
            donHang.XuatPhieuGiao();

            Console.ReadLine();
        }
    }
}