using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_03_ExtractVariable.Real
{
    public class TinhPhiVanChuyen
    {
        public double TinhPhi(string? loaiKhachHang, double tongTienDonHang, int khoangCachKm)
        {
            // Áp dụng Extract Variable để giải thích biểu thức điều kiện phức tạp
            bool laKhachVIP = (loaiKhachHang != null && loaiKhachHang.ToUpper() == "VIP");
            bool donHangGiaTriLon = tongTienDonHang >= 10000000; // Đơn trên 10 triệu
            bool giaoHangGan = khoangCachKm <= 15; // Dưới 15km

            // Nhờ tách biến, lệnh if trở nên cực kỳ rõ ràng
            if (laKhachVIP && donHangGiaTriLon && giaoHangGan)
            {
                Console.WriteLine("=> Ap dung chinh sach mien phi giao hang cho Khach VIP, don lon, o gan.");
                return 0; // Miễn phí ship
            }

            Console.WriteLine("=> Tinh phi giao hang tieu chuan.");
            return khoangCachKm * 15000; // 15.000 VNĐ / 1 km
        }
    }
}