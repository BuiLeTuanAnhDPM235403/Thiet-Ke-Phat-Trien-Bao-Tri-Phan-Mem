using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_27_ReplaceConditionalWithPolymorphism.Real
{
    // LỚP CHA: SẢN PHẨM NÔNG DƯỢC
    public abstract class SanPhamNongDuoc
    {
        public string TenSP { get; set; }
        public double KhoiLuong { get; set; }

        public SanPhamNongDuoc(string ten, double khoiLuong)
        {
            TenSP = ten;
            KhoiLuong = khoiLuong;
        }

        // Phương thức trừu tượng tính phí bảo quản
        public abstract double TinhPhiBaoQuan();

        public void InThongTinBaoQuan()
        {
            Console.WriteLine($"- {TenSP} ({KhoiLuong}kg) | Phi bao quan: {TinhPhiBaoQuan():N0} VND");
        }
    }

    // CÁC LỚP CON TỰ XỬ LÝ LOGIC CỦA MÌNH
    public class PhanUre : SanPhamNongDuoc
    {
        public PhanUre(string ten, double khoiLuong) : base(ten, khoiLuong) { }

        public override double TinhPhiBaoQuan()
        {
            return KhoiLuong * 50; // Rẻ, chỉ 50đ/kg
        }
    }

    public class PhanHuuCo : SanPhamNongDuoc
    {
        public PhanHuuCo(string ten, double khoiLuong) : base(ten, khoiLuong) { }

        public override double TinhPhiBaoQuan()
        {
            return KhoiLuong * 150; // Cần bao bì chống ẩm, 150đ/kg
        }
    }

    public class ThuocTruSau : SanPhamNongDuoc
    {
        public ThuocTruSau(string ten, double khoiLuong) : base(ten, khoiLuong) { }

        public override double TinhPhiBaoQuan()
        {
            return KhoiLuong * 500; // Cần kho lạnh an toàn, 500đ/kg
        }
    }
}