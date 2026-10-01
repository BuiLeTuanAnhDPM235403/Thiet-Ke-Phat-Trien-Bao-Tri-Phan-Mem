using System;

using DPM235403_BuiLeTuanAnh_BTH03_07_RemoveAssignmentsToParameters.Before;
using DPM235403_BuiLeTuanAnh_BTH03_07_RemoveAssignmentsToParameters.After;
using DPM235403_BuiLeTuanAnh_BTH03_07_RemoveAssignmentsToParameters.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_07_RemoveAssignmentsToParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. DEMO BEFORE ---");
            var ttBefore = new Before.TinhToan();
            Console.WriteLine($"Ket qua: {ttBefore.Discount(60, 150)}");

            Console.WriteLine("\n--- 2. DEMO AFTER ---");
            var ttAfter = new After.TinhToan();
            Console.WriteLine($"Ket qua: {ttAfter.Discount(60, 150)}");

            Console.WriteLine("\n--- 3. DEMO REAL (NONG DUOC) ---");
            var tinhGia = new TinhGiaNongDuoc();

            Console.WriteLine("- Khach mua 5 chai (Khong giam):");
            tinhGia.TinhGiaThucTe(250000, 5);

            Console.WriteLine("\n- Khach mua 15 chai (Giam 5%):");
            tinhGia.TinhGiaThucTe(250000, 15);

            Console.WriteLine("\n- Khach mua 60 chai (Giam 10%):");
            tinhGia.TinhGiaThucTe(250000, 60);

            Console.ReadLine();
        }
    }
}