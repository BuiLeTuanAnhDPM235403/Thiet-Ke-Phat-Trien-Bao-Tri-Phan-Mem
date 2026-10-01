using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_02_InlineMethod.Real
{
    public class KhachHangNongDuoc
    {
        public string? TenKhachHang { get; set; }
        public int DiemTichLuy { get; set; }

        public KhachHangNongDuoc(string ten, int diem)
        {
            TenKhachHang = ten;
            DiemTichLuy = diem;
        }

        // Đã áp dụng Inline Method: Gộp thẳng logic "DiemTichLuy > 1000" vào hàm tính toán
        public double TinhTienSauChietKhau(double tongTienDonHang)
        {
            // Code gọn gàng, đọc vào hiểu ngay khách > 1000 điểm được giảm 10%
            double tiLeGiam = (DiemTichLuy > 1000) ? 0.1 : 0.0;

            double soTienGiam = tongTienDonHang * tiLeGiam;
            Console.WriteLine($"Khach: {TenKhachHang} | Diem: {DiemTichLuy} | Giam: {tiLeGiam * 100}%");

            return tongTienDonHang - soTienGiam;
        }
    }
}