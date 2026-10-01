using System;
using DPM235403_BuiLeTuanAnh_BTH03_14_HideDelegate.Before;
using DPM235403_BuiLeTuanAnh_BTH03_14_HideDelegate.After;
using DPM235403_BuiLeTuanAnh_BTH03_14_HideDelegate.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_14_HideDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var deptB = new Before.Department("Mr. Smith");
            var personB = new Before.Person { Name = "John", Department = deptB };
            // Client phải lôi cổ Department ra mới lấy được Manager (Móc xích dài)
            Console.WriteLine($"Quan ly cua John la: {personB.Department.Manager}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var deptA = new After.Department("Mr. Smith");
            var personA = new After.Person(deptA) { Name = "John" };
            // Client gọi trực tiếp hàm của Person, code gọn và an toàn hơn
            Console.WriteLine($"Quan ly cua John la: {personA.GetManager()}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var chiNhanhLongXuyen = new ChiNhanh("CH Nong Duoc Long Xuyen", "Giam Doc Tuan Anh");

            var nhanVienKho = new NhanVienNongDuoc("Anh Ba Kho", chiNhanhLongXuyen);
            nhanVienKho.InBaoCao();

            Console.ReadLine();
        }
    }
}