using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Facade_Real_BanHang_DP
{
    public class HeThongKho
    {
        public void XuatKhoTheoFIFO() => Console.WriteLine("- HeThongKho: Da xuat kho nong duoc theo phuong phap Nhap Truoc Xuat Truoc (FIFO).");
    }

    public class HeThongKeToan
    {
        public void TinhGiaBinhQuan() => Console.WriteLine("- HeThongKeToan: Ap dung gia xuat theo Binh quan gia quyen.");
    }

    public class HeThongVanChuyen
    {
        public void DieuPhoiGiaoHang() => Console.WriteLine("- HeThongVanChuyen: Da them chi phi van chuyen, len lich giao den nong trai.");
    }
}