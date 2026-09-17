using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_TemplateMethod_Real_XuatKho_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- QUY TRINH XUAT KHO CUA HANG NONG DUOC ---");

            Console.WriteLine("\n[Xuat kho lo hang 50 bao Phan Bon Ure]");
            QuyTrinhXuatKhoTemplate quyTrinhPhanBon = new XuatKhoPhanBon();
            quyTrinhPhanBon.XuatKho();

            Console.WriteLine("\n[Xuat kho lo hang 100 chai Thuoc diet co]");
            QuyTrinhXuatKhoTemplate quyTrinhThuoc = new XuatKhoThuocTruSau();
            quyTrinhThuoc.XuatKho();

            Console.ReadLine();
        }
    }
}