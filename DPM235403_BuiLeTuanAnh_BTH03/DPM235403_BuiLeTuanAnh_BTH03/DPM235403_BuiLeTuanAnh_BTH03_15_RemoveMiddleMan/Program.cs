using System;
using DPM235403_BuiLeTuanAnh_BTH03_15_RemoveMiddleMan.Before;
using DPM235403_BuiLeTuanAnh_BTH03_15_RemoveMiddleMan.After;
using DPM235403_BuiLeTuanAnh_BTH03_15_RemoveMiddleMan.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_15_RemoveMiddleMan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            var deptB = new Before.Department("Mr. Smith");
            var personB = new Before.Person(deptB) { Name = "John" };
            // Gọi qua trung gian
            Console.WriteLine($"Quan ly cua John: {personB.GetManager()}");

            Console.WriteLine("\n--- 2. AFTER ---");
            var deptA = new After.Department("Mr. Smith");
            var personA = new After.Person(deptA) { Name = "John" };
            // Gọi trực tiếp, bỏ qua trung gian
            Console.WriteLine($"Quan ly cua John: {personA.Department.Manager}");

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            var hangSyngenta = new NhaCungCap("Syngenta Viet Nam", "1800 1234");
            var thuocAmistar = new ThuocBaoVeThucVat("Amistar Top 325SC", hangSyngenta);

            // Khách hàng tự lấy thông tin nhà cung cấp từ sản phẩm rồi gọi hotline
            Console.WriteLine($"De biet cach phun {thuocAmistar.TenThuoc}, vui long goi: {thuocAmistar.ThongTinNhaCungCap.HotlineKyThuat}");

            Console.ReadLine();
        }
    }
}