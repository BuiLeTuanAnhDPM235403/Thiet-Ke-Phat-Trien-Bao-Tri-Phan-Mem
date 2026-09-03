using System;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Factory_Real_HoaDon_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CUA HANG NONG DUOC: PHAN HE XUAT HOA DON ---");

            // Khach le mua hang
            HoaDonFactory factoryLe = new HoaDonBanLeFactory();
            IHoaDon hoadon1 = factoryLe.TaoHoaDon();
            hoadon1.InHoaDon();

            // Dai ly mua hang
            HoaDonFactory factorySi = new HoaDonBanSiFactory();
            IHoaDon hoadon2 = factorySi.TaoHoaDon();
            hoadon2.InHoaDon();

            Console.ReadLine();
        }
    }
}