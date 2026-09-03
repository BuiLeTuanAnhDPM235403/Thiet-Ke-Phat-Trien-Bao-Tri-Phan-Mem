using System;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Abstract_Real_KhoXuat_DP
{
    public interface IXuatKho
    {
        void XuatHang();
    }

    public class XuatKhoFIFO : IXuatKho
    {
        public void XuatHang() => Console.WriteLine("Xuat kho: Tu dong chon Lo co ngay het han truoc xuat truoc.");
    }

    public class XuatKhoChiDinh : IXuatKho
    {
        public void XuatHang() => Console.WriteLine("Xuat kho: Xuat hang theo lo chi dinh cua nguoi dung.");
    }
}