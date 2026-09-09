namespace DPM235403_BuiLeTuanAnh_Tuan02_Decorator_Real_HoaDon_DP
{
    public abstract class HoaDonDecorator : IHoaDon
    {
        protected IHoaDon _hoaDon;

        public HoaDonDecorator(IHoaDon hoaDon)
        {
            _hoaDon = hoaDon;
        }

        public virtual string LayMoTa()
        {
            return _hoaDon.LayMoTa();
        }

        public virtual double TinhTongTien()
        {
            return _hoaDon.TinhTongTien();
        }
    }
}