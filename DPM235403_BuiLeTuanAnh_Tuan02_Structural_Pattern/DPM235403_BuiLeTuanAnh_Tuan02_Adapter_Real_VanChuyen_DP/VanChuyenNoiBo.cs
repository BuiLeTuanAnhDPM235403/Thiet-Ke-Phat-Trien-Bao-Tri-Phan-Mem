using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Adapter_Real_VanChuyen_DP
{
    public class VanChuyenNoiBo : IVanChuyen
    {
        public void GiaoHang(string maDon, string diaChi)
        {
            Console.WriteLine($"Xe cua cong ty dang giao don [{maDon}] den {diaChi}.");
        }
    }
}