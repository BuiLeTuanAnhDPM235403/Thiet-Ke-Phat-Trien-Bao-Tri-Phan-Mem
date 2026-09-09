namespace DPM235403_BuiLeTuanAnh_Tuan02_Decorator_Real_HoaDon_DP
{
    public class HoaDonGoc : IHoaDon
    {
        public string LayMoTa()
        {
            return "Hoa don ban nong duoc";
        }

        public double TinhTongTien()
        {
            return 500000; // Gia tri don hang goc gia su la 500.000 VND
        }
    }
}