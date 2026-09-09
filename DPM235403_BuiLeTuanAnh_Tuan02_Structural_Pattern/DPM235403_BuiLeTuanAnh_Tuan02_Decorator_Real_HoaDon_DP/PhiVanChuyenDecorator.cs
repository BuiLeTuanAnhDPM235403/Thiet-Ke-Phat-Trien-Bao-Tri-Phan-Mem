namespace DPM235403_BuiLeTuanAnh_Tuan02_Decorator_Real_HoaDon_DP
{
    public class PhiVanChuyenDecorator : HoaDonDecorator
    {
        private double _phiVanChuyen;

        public PhiVanChuyenDecorator(IHoaDon hoaDon, double phiVanChuyen) : base(hoaDon)
        {
            _phiVanChuyen = phiVanChuyen;
        }

        public override string LayMoTa()
        {
            return $"{base.LayMoTa()} + Phi van chuyen";
        }

        public override double TinhTongTien()
        {
            return base.TinhTongTien() + _phiVanChuyen;
        }
    }
}