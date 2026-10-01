using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_06_SplitTemporaryVariable.Real
{
    public class LoPhanBon
    {
        public string? TenLo { get; set; }
        public double KhoiLuongTinh { get; set; } // Khối lượng ruột phân bón
        public double DonGiaKg { get; set; }

        public LoPhanBon(string ten, double khoiLuong, double donGia)
        {
            TenLo = ten;
            KhoiLuongTinh = khoiLuong;
            DonGiaKg = donGia;
        }

        public void InThongTinVanChuyenVaThanhToan()
        {
            Console.WriteLine($"--- Thong tin lo: {TenLo} ---");

            // Biến 1: Chỉ phục vụ việc tính toán khối lượng
            double khoiLuongBaoBi = KhoiLuongTinh * 0.05; // Bao bì nặng 5% khối lượng tịnh
            double tongKhoiLuong = KhoiLuongTinh + khoiLuongBaoBi;
            Console.WriteLine($"Tong khoi luong van chuyen: {tongKhoiLuong} kg");

            // Biến 2: Chỉ phục vụ việc tính toán tiền nong
            double tongTien = KhoiLuongTinh * DonGiaKg;
            Console.WriteLine($"Tong thanh tien: {tongTien:N0} VND");
        }
    }
}