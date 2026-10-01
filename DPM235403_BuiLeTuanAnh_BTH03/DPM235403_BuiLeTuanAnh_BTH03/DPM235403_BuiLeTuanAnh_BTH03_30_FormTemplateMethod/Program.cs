using System;
using DPM235403_BuiLeTuanAnh_BTH03_30_FormTemplateMethod.Before;
using DPM235403_BuiLeTuanAnh_BTH03_30_FormTemplateMethod.After;
using DPM235403_BuiLeTuanAnh_BTH03_30_FormTemplateMethod.Real;

namespace DPM235403_BuiLeTuanAnh_BTH03_30_FormTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1 & 2. DEMO AFTER (TEMPLATE METHOD) ---");
            HoaDonTemplate hd1 = new HoaDonThuong();
            hd1.TinhToan();

            HoaDonTemplate hd2 = new HoaDonVIP();
            hd2.TinhToan();

            Console.WriteLine("--- 3. REAL (NONG DUOC) ---");
            QuyTrinhCapPhatThuoc quyTrinh1 = new NongDanThuong();
            quyTrinh1.ThucHienQuyTrinh("Chu Nam (Can Tho)");

            QuyTrinhCapPhatThuoc quyTrinh2 = new NongDanTroGia();
            quyTrinh2.ThucHienQuyTrinh("Bac Sau (An Giang)");

            Console.ReadLine();
        }
    }
}