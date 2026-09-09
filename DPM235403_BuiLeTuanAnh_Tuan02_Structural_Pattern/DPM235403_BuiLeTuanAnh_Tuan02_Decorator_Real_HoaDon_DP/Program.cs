using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Decorator_Real_HoaDon_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG QUAN LY CONG TY NONG DUOC AN GIANG ---");

            // 1. Tạo đơn hàng gốc
            IHoaDon donHang = new HoaDonGoc();
            Console.WriteLine($"\nBuoc 1: {donHang.LayMoTa()} | Tong tien: {donHang.TinhTongTien():N0} VND");

            // 2. Khách yêu cầu giao tận nơi -> Thêm phí vận chuyển (Yêu cầu 4)
            donHang = new PhiVanChuyenDecorator(donHang, 30000); // Phí ship 30.000 VND
            Console.WriteLine($"Buoc 2: {donHang.LayMoTa()} | Tong tien: {donHang.TinhTongTien():N0} VND");

            // 3. Đang trong đợt khuyến mãi -> Thêm chiết khấu 10% (Yêu cầu 4)
            donHang = new GiamGiaDecorator(donHang, 10); // Giảm 10% trên tổng tiền
            Console.WriteLine($"Buoc 3: {donHang.LayMoTa()} | Tong tien: {donHang.TinhTongTien():N0} VND");

            Console.ReadLine();
        }
    }
}