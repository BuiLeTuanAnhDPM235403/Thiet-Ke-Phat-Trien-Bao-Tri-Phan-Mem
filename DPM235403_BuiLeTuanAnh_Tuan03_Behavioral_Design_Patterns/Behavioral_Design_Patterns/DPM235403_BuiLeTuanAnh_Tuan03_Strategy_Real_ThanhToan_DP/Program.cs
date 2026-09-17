using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Strategy_Real_ThanhToan_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG THANH TOAN NONG DUOC ---");

            var mayTinhTien = new QuayThanhToanContext();
            double tongTienDonHang = 2500000; // Đơn hàng 2 triệu rưỡi

            // Khách 1: Nông dân mang tiền mặt tới mua
            Console.WriteLine("\nKhach 1 chon thanh toan tien mat:");
            mayTinhTien.SetPhuongThucThanhToan(new ThanhToanTienMat());
            mayTinhTien.TinhTien(tongTienDonHang);

            // Khách 2: Chủ vườn lớn quẹt mã QR chuyển khoản
            Console.WriteLine("\nKhach 2 chon chuyen khoan:");
            mayTinhTien.SetPhuongThucThanhToan(new ThanhToanChuyenKhoan());
            mayTinhTien.TinhTien(tongTienDonHang);

            // Khách 3: Mối quen, mua chịu tới Tết trả
            Console.WriteLine("\nKhach 3 (Moi quen) xin ghi no:");
            mayTinhTien.SetPhuongThucThanhToan(new ThanhToanGhiNo());
            mayTinhTien.TinhTien(tongTienDonHang);

            Console.ReadLine();
        }
    }
}