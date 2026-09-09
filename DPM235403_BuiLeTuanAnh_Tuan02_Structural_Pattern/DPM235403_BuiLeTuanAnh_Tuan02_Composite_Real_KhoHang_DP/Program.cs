using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Composite_Real_KhoHang_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- QUAN LY CAU TRUC KHO HANG ---");

            // Tạo các chai/bao nông dược lẻ (Leaf)
            IKhoHang thuocTruSau1 = new SanPhamChiTiet("Thuoc tru sau A", 50);
            IKhoHang thuocTruSau2 = new SanPhamChiTiet("Thuoc tru sau B", 100);
            IKhoHang phanBon1 = new SanPhamChiTiet("Phan bon NPK", 200);

            // Gom vào các thùng (Composite)
            KhuVucKho thungThuoc = new KhuVucKho("Thung chua Thuoc Tru Sau");
            thungThuoc.ThemThanhPhan(thuocTruSau1);
            thungThuoc.ThemThanhPhan(thuocTruSau2);

            KhuVucKho thungPhanBon = new KhuVucKho("Thung chua Phan Bon");
            thungPhanBon.ThemThanhPhan(phanBon1);

            // Gom tất cả vào Kho chính (Composite lớn nhất)
            KhuVucKho khoChinh = new KhuVucKho("KHO CHINH TAI AN GIANG");
            khoChinh.ThemThanhPhan(thungThuoc);
            khoChinh.ThemThanhPhan(thungPhanBon);

            // Hiển thị toàn bộ cây kho hàng
            khoChinh.HienThiThongTin(1);
            Console.WriteLine($"\n=> TONG SO LUONG HANG TRONG KHO: {khoChinh.TinhTongSoLuong()} don vi.");

            Console.ReadLine();
        }
    }
}