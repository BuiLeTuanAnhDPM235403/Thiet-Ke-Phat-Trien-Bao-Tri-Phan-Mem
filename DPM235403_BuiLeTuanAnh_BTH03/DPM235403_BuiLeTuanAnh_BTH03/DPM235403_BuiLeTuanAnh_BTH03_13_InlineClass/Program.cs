using System;
using DPM235403_BuiLeTuanAnh_BTH03_13_InlineClass.Before;
using DPM235403_BuiLeTuanAnh_BTH03_13_InlineClass.After;
using DPM235403_BuiLeTuanAnh_BTH03_13_InlineClass.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_13_InlineClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var personB = new Before.Person { Name = "John" };
            personB.OfficeTelephone.AreaCode = "028";
            personB.OfficeTelephone.Number = "1234567";
            Console.WriteLine($"Lien he: {personB.OfficeTelephone.GetTelephoneNumber()}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var personA = new After.Person { Name = "John", OfficeAreaCode = "028", OfficeNumber = "1234567" };
            Console.WriteLine($"Lien he: {personA.GetTelephoneNumber()}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var mayBom1 = new MayBomThuoc("May phan thuoc Honda Kyo", 2500000, 12);
            var mayBom2 = new MayBomThuoc("Binh xit dien Oshima", 1150000, 6);

            mayBom1.InThongTin();
            mayBom2.InThongTin();

            Console.ReadLine();
        }
    }
}