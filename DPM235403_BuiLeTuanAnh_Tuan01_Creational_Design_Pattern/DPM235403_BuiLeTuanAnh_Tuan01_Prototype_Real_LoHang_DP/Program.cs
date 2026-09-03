using System;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Prototype_Real_LoHang_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- QUAN LY NHAP HANG THEO LO ---");

            // Tạo lô hàng gốc
            LoNongDuoc loGoc = new LoNongDuoc("LO_001", "Thuoc diet co ABC", "CTY An Giang", DateTime.Now, DateTime.Now.AddYears(1));
            Console.WriteLine("Lo hang goc:");
            loGoc.HienThi();

            // Nhân bản lô hàng cho đợt nhập tháng sau, chỉ đổi Mã lô và Ngày hết hạn
            LoNongDuoc loMoi = (LoNongDuoc)loGoc.Clone();
            loMoi.MaLo = "LO_002";
            loMoi.NgayHetHan = DateTime.Now.AddYears(2);

            Console.WriteLine("\nLo hang moi (duoc Clone va sua HSD):");
            loMoi.HienThi();

            Console.ReadLine();
        }
    }
}