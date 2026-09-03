using System;

namespace Prototype_Real_LoHang
{
    // Interface nhân bản
    public interface ILoHangPrototype
    {
        ILoHangPrototype Clone();
    }

    // Lô hàng nông dược cụ thể
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- QUAN LY NHAP HANG THEO LO ---");

            // Tạo lô hàng gốc
            LoNongDuoc loGoc = new LoNongDuoc("LO_001", "Thuoc diet co ABC", "CTY An Giang", DateTime.Now, DateTime.Now.AddYears(1));
            Console.WriteLine("Lo hang goc:");
            loGoc.HienThi();

            // Nhân bản lô hàng cho đợt nhập tháng sau, chỉ đổi Mã lô và Ngày hết hạn
            LoNongDuoc loMoi = (LoNongDuoc)loGoc.Clone();
            loMoi.MaLo = "LO_002";
            loMoi.NgayHetHan = DateTime.Now.AddYears(2);

            Console.WriteLine("\nLo hang moi (duoc Clone va sua HSD):");
            loMoi.HienThi();

            Console.ReadLine();
        }
    }
}