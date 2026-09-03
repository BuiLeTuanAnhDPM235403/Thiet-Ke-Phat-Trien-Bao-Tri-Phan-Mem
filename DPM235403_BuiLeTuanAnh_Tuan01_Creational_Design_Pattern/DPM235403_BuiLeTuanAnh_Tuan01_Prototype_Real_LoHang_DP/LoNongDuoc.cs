using System;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Prototype_Real_LoHang_DP
{
    public class LoNongDuoc : ILoHangPrototype
    {
        public string MaLo { get; set; }
        public string TenThuoc { get; set; }
        public string NhaSanXuat { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DateTime NgayHetHan { get; set; }

        public LoNongDuoc(string maLo, string tenThuoc, string nhaSanXuat, DateTime ngaySX, DateTime ngayHH)
        {
            MaLo = maLo;
            TenThuoc = tenThuoc;
            NhaSanXuat = nhaSanXuat;
            NgaySanXuat = ngaySX;
            NgayHetHan = ngayHH;
        }

        // Tạo bản sao nông (Shallow Copy)
        public ILoHangPrototype Clone()
        {
            return (ILoHangPrototype)this.MemberwiseClone();
        }

        public void HienThi()
        {
            Console.WriteLine($"Lo: {MaLo} | SP: {TenThuoc} | NSX: {NhaSanXuat} | HSD: {NgayHetHan.ToString("dd/MM/yyyy")}");
        }
    }
}