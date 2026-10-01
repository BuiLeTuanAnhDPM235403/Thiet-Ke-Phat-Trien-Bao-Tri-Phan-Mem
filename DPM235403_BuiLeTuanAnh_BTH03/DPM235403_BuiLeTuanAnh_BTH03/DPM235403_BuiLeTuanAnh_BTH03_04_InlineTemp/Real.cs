using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_04_InlineTemp.Real
{
    public class BaoPhanBon
    {
        public string? TenPhanBon { get; set; }
        public double TrongLuongKg { get; set; }

        public BaoPhanBon(string ten, double trongLuong)
        {
            TenPhanBon = ten;
            TrongLuongKg = trongLuong;
        }

        // Đã áp dụng Inline Temp: Trả thẳng về kết quả biểu thức logic
        public bool CanThueNguoiKhuanVac()
        {
            return TrongLuongKg >= 50;
        }
    }
}