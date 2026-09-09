using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Bridge_Real_BaoCao_DP
{
    public class FormatPDF : IFormatBaoCao
    {
        public void InBaoCao(string noiDung) => Console.WriteLine($"[Xuat ra file PDF]: {noiDung}");
    }

    public class FormatExcel : IFormatBaoCao
    {
        public void InBaoCao(string noiDung) => Console.WriteLine($"[Xuat ra file Excel]: {noiDung}");
    }
}