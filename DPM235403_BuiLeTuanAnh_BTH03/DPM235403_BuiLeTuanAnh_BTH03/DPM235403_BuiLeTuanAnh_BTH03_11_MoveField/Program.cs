using System;
using DPM235403_BuiLeTuanAnh_BTH03_11_MoveField.Before;
using DPM235403_BuiLeTuanAnh_BTH03_11_MoveField.After;
using DPM235403_BuiLeTuanAnh_BTH03_11_MoveField.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_11_MoveField
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var typeB = new Before.AccountType();
            var accB = new Before.Account(typeB, 0.05);
            Console.WriteLine($"Tien lai: {accB.InterestForAmount(10000, 30)}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var typeA = new After.AccountType(0.05);
            var accA = new After.Account(typeA);
            Console.WriteLine($"Tien lai: {accA.InterestForAmount(10000, 30)}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var danhMucPhanBon = new DanhMucSanPham("Phan Bon", 0.05); // Phân bón thuế 5%
            var danhMucThuocSau = new DanhMucSanPham("Thuoc Tru Sau", 0.10); // Thuốc sâu thuế 10%

            var phanUre = new SanPhamNongDuoc("Ure Ca Mau", 500000, danhMucPhanBon);
            var thuocRegent = new SanPhamNongDuoc("Thuoc Regent 800WG", 100000, danhMucThuocSau);

            phanUre.InGiaBanLe();
            thuocRegent.InGiaBanLe();

            Console.ReadLine();
        }
    }
}