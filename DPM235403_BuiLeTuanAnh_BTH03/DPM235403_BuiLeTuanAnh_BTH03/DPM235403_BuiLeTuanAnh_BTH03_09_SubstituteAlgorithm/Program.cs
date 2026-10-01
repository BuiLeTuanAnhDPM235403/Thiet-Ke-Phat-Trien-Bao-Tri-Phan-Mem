using System;
using DPM235403_BuiLeTuanAnh_BTH03_09_SubstituteAlgorithm.Before;
using DPM235403_BuiLeTuanAnh_BTH03_09_SubstituteAlgorithm.After;
using DPM235403_BuiLeTuanAnh_BTH03_09_SubstituteAlgorithm.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_09_SubstituteAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dsNguoi = { "Alice", "John", "Bob" };

            Console.WriteLine("--- 1. BEFORE ---");
            Console.WriteLine("Tim thay: " + new Before.Person().FoundPerson(dsNguoi));

            Console.WriteLine("\n--- 2. AFTER ---");
            Console.WriteLine("Tim thay: " + new After.Person().FoundPerson(dsNguoi));

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var kiemDinh = new KiemDinhNongDuoc();
            kiemDinh.KiemTraThuocCam("Paraquat");
            kiemDinh.KiemTraThuocCam("Phan Ure");

            Console.ReadLine();
        }
    }
}