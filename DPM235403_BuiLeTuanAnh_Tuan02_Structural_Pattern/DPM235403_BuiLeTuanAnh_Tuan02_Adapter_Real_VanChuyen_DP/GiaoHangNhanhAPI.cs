using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Adapter_Real_VanChuyen_DP
{
    // Class này của bên thứ 3, không thể sửa đổi code bên trong
    public class GiaoHangNhanhAPI
    {
        public void CreateOrderAndShip(string orderId, string address, bool isFragile)
        {
            Console.WriteLine($"GHN API: Nhan don [{orderId}], Giao den: {address} | Hang de vo: {isFragile}");
        }
    }
}