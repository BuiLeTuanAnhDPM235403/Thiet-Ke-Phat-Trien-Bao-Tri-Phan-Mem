namespace DPM235403_BuiLeTuanAnh_Tuan02_Decorator_Real_HoaDon_DP
{
    public class GiamGiaDecorator : HoaDonDecorator
    {
        private double _phanTramGiam;

        public GiamGiaDecorator(IHoaDon hoaDon, double phanTramGiam) : base(hoaDon)
        {
            _phanTramGiam = phanTramGiam;
        }

        public override string LayMoTa()
        {
            return $"{base.LayMoTa()} + Giam gia khuyen mai ({_phanTramGiam}%)";
        }

        public override double TinhTongTien()
        {
            double tienGiam = base.TinhTongTien() * (_phanTramGiam / 100);
            return base.TinhTongTien() - tienGiam;
        }
    }
}