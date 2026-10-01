using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_28_IntroduceNullObject.Real
{
    public class TheKhuyenMai
    {
        public virtual double PhanTramGiam => 0.10; // Giảm 10%
        public virtual bool IsNull => false;
    }

    public class TheKhuyenMaiRong : TheKhuyenMai
    {
        public virtual double PhanTramGiam => 0.0; // Không giảm
        public override bool IsNull => true;
    }

    public class HoaDonMuaThuoc
    {
        public string TenKhach { get; set; }
        public double TongTien { get; set; }
        private TheKhuyenMai _the;

        public HoaDonMuaThuoc(string ten, double tongTien, TheKhuyenMai the)
        {
            TenKhach = ten;
            TongTien = tongTien; // <-- Gán giá trị vào đây (lúc nãy bị thiếu dòng này nên TongTien = 0)
            _the = the ?? new TheKhuyenMaiRong();
        }

        public void TinhTien()
        {
            double soTienGiam = TongTien * _the.PhanTramGiam;
            double tienPhaiTra = TongTien - soTienGiam;

            Console.WriteLine($"Khach: {TenKhach}");
            Console.WriteLine($"- Tong tien hang: {TongTien:N0} VND");
            Console.WriteLine($"- Giam gia: {_the.PhanTramGiam * 100}%");
            Console.WriteLine($"- Phai thanh toan: {tienPhaiTra:N0} VND\n");
        }
    }
}