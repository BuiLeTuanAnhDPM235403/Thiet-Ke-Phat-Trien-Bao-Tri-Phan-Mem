using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_19_ReplaceDataValueWithObject.Real
{
    // OBJECT MỚI: Tách số điện thoại thành đối tượng để xử lý logic riêng
    public class SoDienThoai
    {
        public string So { get; set; }

        public SoDienThoai(string so)
        {
            So = so;
        }

        public string NhanDienNhaMang()
        {
            if (So.StartsWith("086") || So.StartsWith("096") || So.StartsWith("097"))
                return "Viettel";
            if (So.StartsWith("089") || So.StartsWith("090"))
                return "Mobifone";
            return "Khac";
        }
    }

    public class KhachHangNongDuoc
    {
        public string TenKhach { get; set; }
        // Biến string đã được thay bằng Object SoDienThoai
        public SoDienThoai LienHe { get; set; }

        public KhachHangNongDuoc(string ten, string sdt)
        {
            TenKhach = ten;
            LienHe = new SoDienThoai(sdt);
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Khach: {TenKhach} | SĐT: {LienHe.So} (Mang: {LienHe.NhanDienNhaMang()})");
        }
    }
}