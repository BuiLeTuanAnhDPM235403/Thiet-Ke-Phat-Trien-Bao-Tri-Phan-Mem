using System;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Builder_Real_PhieuXuat_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVienBanHang nhanVien = new NhanVienBanHang();
            HoaDonGiaoTanNoiBuilder builder = new HoaDonGiaoTanNoiBuilder();
            nhanVien.Builder = builder;

            Console.WriteLine("Yeu cau: Lap hoa don ban hang day du phi van chuyen va giam gia...");
            nhanVien.LapHoaDonDayDu();
            builder.GetHoaDon().HienThi();

            Console.ReadLine();
        }
    }
}