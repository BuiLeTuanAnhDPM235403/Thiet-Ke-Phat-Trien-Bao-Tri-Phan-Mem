using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Bridge_Real_BaoCao_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- XUAT BAO CAO THONG KE ---");

            string tuNgay = "01/01/2026";
            string denNgay = "31/01/2026";

            // Sếp yêu cầu xuất báo cáo ra file PDF
            Console.WriteLine("\n[Yeu cau 1: Bao cao PDF]");
            BaoCao baoCaoPdf = new BaoCaoTonKho(new FormatPDF());
            baoCaoPdf.TaoVaInBaoCao(tuNgay, denNgay);

            // Kế toán yêu cầu xuất báo cáo ra file Excel để tính toán
            Console.WriteLine("\n[Yeu cau 2: Bao cao Excel]");
            BaoCao baoCaoExcel = new BaoCaoTonKho(new FormatExcel());
            baoCaoExcel.TaoVaInBaoCao(tuNgay, denNgay);

            Console.ReadLine();
        }
    }
}