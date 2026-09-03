using System;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Abstract_Real_KhoXuat_DP
{
    public interface ITinhGia
    {
        void TinhGiaXuat();
    }

    public class TinhGiaFIFO : ITinhGia
    {
        public void TinhGiaXuat() => Console.WriteLine("Tinh gia: Theo phuong phap Nhap truoc Xuat truoc (FIFO).");
    }

    public class TinhGiaBinhQuan : ITinhGia
    {
        public void TinhGiaXuat() => Console.WriteLine("Tinh gia: Theo phuong phap Binh quan gia quyen.");
    }
}