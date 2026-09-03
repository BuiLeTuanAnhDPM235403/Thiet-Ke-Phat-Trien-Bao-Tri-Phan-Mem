using System;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Factory_Real_HoaDon_DP
{
    public class HoaDonBanLe : IHoaDon
    {
        public void InHoaDon()
        {
            Console.WriteLine("In Hoa Don BAN LE: Gia thuong, khong co chiet khau si.");
        }
    }

    public class HoaDonBanSi : IHoaDon
    {
        public void InHoaDon()
        {
            Console.WriteLine("In Hoa Don BAN SI: Ap dung chiet khau cho dai ly.");
        }
    }
}