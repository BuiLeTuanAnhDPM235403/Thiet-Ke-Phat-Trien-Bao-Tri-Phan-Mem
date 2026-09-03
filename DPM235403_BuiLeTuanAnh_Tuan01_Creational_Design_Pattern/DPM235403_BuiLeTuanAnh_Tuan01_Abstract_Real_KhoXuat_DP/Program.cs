using System;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Abstract_Real_KhoXuat_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CAU HINH HE THONG 1: CHUAN FIFO ---");
            HeThongQuanLyKho heThong1 = new HeThongQuanLyKho(new CauHinhFIFOFactory());
            heThong1.ThucHienXuatKho();

            Console.WriteLine("\n--- CAU HINH HE THONG 2: CHI DINH & BINH QUAN GIA QUYEN ---");
            HeThongQuanLyKho heThong2 = new HeThongQuanLyKho(new CauHinhTuyChonFactory());
            heThong2.ThucHienXuatKho();

            Console.ReadLine();
        }
    }
}