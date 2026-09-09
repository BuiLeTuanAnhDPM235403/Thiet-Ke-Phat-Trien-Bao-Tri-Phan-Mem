using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Flyweight_Real_LoHang_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- TOI UU DU LIEU NHAP HANG THEO LO ---");

            NongDuocFactory factory = new NongDuocFactory();

            // Lô 1: Nhập 2 chai Thuốc trừ sâu (Lần đầu -> Tạo mới bộ nhớ)
            var mauThuoc1 = factory.LayMauThuoc("Thuoc Tru Sau ABC", "CTY An Giang", "Hoat chat X");
            mauThuoc1.HienThiChiTiet("SR_001", new DateTime(2027, 12, 31));
            mauThuoc1.HienThiChiTiet("SR_002", new DateTime(2027, 12, 31));

            // Lô 2: Vẫn là loại thuốc đó nhưng nhập đợt sau (Tái sử dụng bộ nhớ cũ)
            var mauThuoc2 = factory.LayMauThuoc("Thuoc Tru Sau ABC", "CTY An Giang", "Hoat chat X");
            mauThuoc2.HienThiChiTiet("SR_003", new DateTime(2028, 05, 15));

            Console.WriteLine("\n=> He thong hoat dong toi uu: Thong tin chung chi luu 1 lan trong RAM.");

            Console.ReadLine();
        }
    }
}