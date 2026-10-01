using System;
using System.Collections.Generic;
using DPM235403_BuiLeTuanAnh_BTH03_27_ReplaceConditionalWithPolymorphism.Before;
using DPM235403_BuiLeTuanAnh_BTH03_27_ReplaceConditionalWithPolymorphism.After;
using DPM235403_BuiLeTuanAnh_BTH03_27_ReplaceConditionalWithPolymorphism.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_27_ReplaceConditionalWithPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var empB = new Before.Employee(Before.Employee.SALESMAN);
            Console.WriteLine($"Luong Salesman: {empB.PayAmount()}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var empA = new After.Manager();
            Console.WriteLine($"Luong Manager: {empA.PayAmount()}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            // Đa hình: Bỏ tất cả vào chung một List lớp cha, nó sẽ tự biết gọi hàm của lớp con tương ứng
            var khoHang = new List<SanPhamNongDuoc>
            {
                new PhanUre("Ure Phu My", 1000),
                new PhanHuuCo("Huu Co Vi Sinh", 500),
                new ThuocTruSau("Regent 800WG", 50)
            };

            foreach (var sp in khoHang)
            {
                sp.InThongTinBaoQuan();
            }

            Console.ReadLine();
        }
    }
}