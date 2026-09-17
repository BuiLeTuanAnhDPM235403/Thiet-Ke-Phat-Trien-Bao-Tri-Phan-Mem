using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Mediator_Real_Dashboard_DP
{
    public class PhanHeBanHang : PhanHeBase
    {
        public void TaoDonHangMoi()
        {
            Console.WriteLine("1. [Ban Hang] Da tao don hang thanh cong. Bao cho Trung tam...");
            _trungTam.ThongBao(this, "DonHangMoi");
        }
    }
}