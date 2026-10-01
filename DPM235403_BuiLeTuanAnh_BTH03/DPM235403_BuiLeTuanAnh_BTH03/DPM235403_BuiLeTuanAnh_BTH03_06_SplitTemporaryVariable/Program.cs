using System;

using DPM235403_BuiLeTuanAnh_BTH03_06_SplitTemporaryVariable.Before;
using DPM235403_BuiLeTuanAnh_BTH03_06_SplitTemporaryVariable.After;
using DPM235403_BuiLeTuanAnh_BTH03_06_SplitTemporaryVariable.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_06_SplitTemporaryVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. DEMO BEFORE ---");
            var hinhHocBefore = new Before.HinhHoc();
            hinhHocBefore.InThongTin(5, 10);

            Console.WriteLine("\n--- 2. DEMO AFTER ---");
            var hinhHocAfter = new After.HinhHoc();
            hinhHocAfter.InThongTin(5, 10);

            Console.WriteLine("\n--- 3. DEMO REAL (NONG DUOC) ---");
            var loUre = new LoPhanBon("Ure Ca Mau Xuat Khau", 1000, 18000); // 1 tấn (1000kg), giá 18k/kg
            loUre.InThongTinVanChuyenVaThanhToan();

            Console.ReadLine();
        }
    }
}