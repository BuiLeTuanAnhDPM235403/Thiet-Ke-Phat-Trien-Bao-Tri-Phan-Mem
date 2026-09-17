using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Command_Real_GiaoDichKho_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG QUAN LY KHO NONG DUOC (HO TRO UNDO) ---");

            var khoNongDuoc = new KhoNongDuocReceiver();
            var quanLy = new QuanLyGiaoDichInvoker();

            Console.WriteLine("\nNhan vien tien hanh xuat kho hop le:");
            IGiaoDichCommand lenhXuatHopLe = new LenhXuatKho(khoNongDuoc, 50);
            quanLy.ThucHienLenh(lenhXuatHopLe);

            Console.WriteLine("\nNhan vien go nham, xuat nhieu hon du kien:");
            IGiaoDichCommand lenhXuatNham = new LenhXuatKho(khoNongDuoc, 400);
            quanLy.ThucHienLenh(lenhXuatNham);

            // Phát hiện gõ nhầm, bấm Undo
            quanLy.UndoGiaoDichCuoi();

            Console.ReadLine();
        }
    }
}