using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Facade_Real_BanHang_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- QUY TRINH BAN HANG NONG DUOC ---");

            // Client (nhân viên thu ngân) không cần biết code bên trong phức tạp ra sao, chỉ gọi 1 lệnh duy nhất
            NghiepVuBanHangFacade facade = new NghiepVuBanHangFacade();
            facade.XuLyDonHangDongNhat();

            Console.ReadLine();
        }
    }
}