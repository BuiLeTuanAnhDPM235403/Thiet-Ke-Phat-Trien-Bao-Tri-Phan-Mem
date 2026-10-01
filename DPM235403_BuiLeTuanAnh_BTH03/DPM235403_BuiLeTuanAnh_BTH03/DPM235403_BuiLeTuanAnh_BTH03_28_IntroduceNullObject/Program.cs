using System;
using DPM235403_BuiLeTuanAnh_BTH03_28_IntroduceNullObject.Before;
using DPM235403_BuiLeTuanAnh_BTH03_28_IntroduceNullObject.After;
using DPM235403_BuiLeTuanAnh_BTH03_28_IntroduceNullObject.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_28_IntroduceNullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1. BEFORE ---");
            new Before.Billing().Process(null); // Gây nguy hiểm nếu thiếu khối if

            Console.WriteLine("\n--- 2. AFTER ---");
            // Truyền đối tượng Null một cách an toàn
            new After.Billing().Process(new After.NullCustomer());

            Console.WriteLine("\n--- 3. REAL (NONG DUOC) ---");
            // Khách có thẻ
            var khachVip = new HoaDonMuaThuoc("Bac Sau", 1000000, new TheKhuyenMai());
            khachVip.TinhTien();

            // Khách vãng lai (Truyền null)
            var khachVangLai = new HoaDonMuaThuoc("Thanh Nien", 1000000, null);
            khachVangLai.TinhTien(); // Chạy mượt mà nhờ TheKhuyenMaiRong

            Console.ReadLine();
        }
    }
}