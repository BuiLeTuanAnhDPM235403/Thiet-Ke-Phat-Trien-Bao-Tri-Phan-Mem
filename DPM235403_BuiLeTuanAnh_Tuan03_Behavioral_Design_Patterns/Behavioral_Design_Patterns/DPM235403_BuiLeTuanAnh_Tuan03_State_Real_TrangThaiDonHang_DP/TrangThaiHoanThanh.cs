using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_State_Real_TrangThaiDonHang_DP
{
    public class TrangThaiHoanThanh : TrangThaiDonHangBase
    {
        public override void XuLy()
        {
            Console.WriteLine("[State: Hoan Thanh] -> Don hang da xong roi, khong can xu ly nua.");
        }

        public override void Huy()
        {
            Console.WriteLine("[State: Hoan Thanh] -> Loi: Khong the huy don hang da giao hoan tat!");
        }
    }
}