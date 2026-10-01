using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_12_ExtractClass.Real
{
    // EXTRACT CLASS: Tách riêng thông tin giao nhận ra khỏi Đơn hàng
    public class ThongTinGiaoHang
    {
        public string TenNguoiNhan { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChiNhan { get; set; }

        public ThongTinGiaoHang(string ten, string sdt, string diaChi)
        {
            TenNguoiNhan = ten;
            SoDienThoai = sdt;
            DiaChiNhan = diaChi;
        }

        public void InNhanGiaoHang()
        {
            Console.WriteLine($"Nguoi nhan: {TenNguoiNhan} - SĐT: {SoDienThoai}");
            Console.WriteLine($"Giao den: {DiaChiNhan}");
        }
    }

    public class DonHangNongDuoc
    {
        public string MaDon { get; set; }
        public double TongTien { get; set; }
        // Đơn hàng giờ chỉ cần tham chiếu đến đối tượng ThongTinGiaoHang
        public ThongTinGiaoHang ThongTinGiao { get; set; }

        public DonHangNongDuoc(string maDon, double tongTien, ThongTinGiaoHang thongTinGiao)
        {
            MaDon = maDon;
            TongTien = tongTien;
            ThongTinGiao = thongTinGiao;
        }

        public void XuatPhieuGiao()
        {
            Console.WriteLine($"=== PHIEU GIAO HANG [{MaDon}] ===");
            Console.WriteLine($"Gia tri don: {TongTien:N0} VND");
            ThongTinGiao.InNhanGiaoHang();
            Console.WriteLine("=================================");
        }
    }
}