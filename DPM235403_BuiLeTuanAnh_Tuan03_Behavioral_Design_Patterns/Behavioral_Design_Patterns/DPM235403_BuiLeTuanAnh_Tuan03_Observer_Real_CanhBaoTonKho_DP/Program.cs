using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Observer_Real_CanhBaoTonKho_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG CANH BAO TON KHO NONG DUOC ---");

            var khoThuoc = new KhoNongDuocSubject();

            var cuaHangTruong = new CuaHangTruong();
            var nhanVienKho = new NhanVienKho();

            // Đăng ký nhận thông báo
            khoThuoc.DangKy(cuaHangTruong);
            khoThuoc.DangKy(nhanVienKho);

            // Giao dịch bình thường, chưa hết hàng
            khoThuoc.XuatKho(20);
            khoThuoc.XuatKho(15);

            // Lần xuất kho này làm tồn kho rớt xuống dưới 10
            khoThuoc.XuatKho(10);

            Console.ReadLine();
        }
    }
}