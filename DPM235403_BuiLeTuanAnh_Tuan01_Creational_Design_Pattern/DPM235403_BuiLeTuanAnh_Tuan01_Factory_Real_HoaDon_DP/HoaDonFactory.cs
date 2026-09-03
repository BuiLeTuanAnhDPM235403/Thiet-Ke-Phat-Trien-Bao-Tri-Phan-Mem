namespace DPM235403_BuiLeTuanAnh_Tuan01_Factory_Real_HoaDon_DP
{
    public abstract class HoaDonFactory
    {
        public abstract IHoaDon TaoHoaDon();
    }

    public class HoaDonBanLeFactory : HoaDonFactory
    {
        public override IHoaDon TaoHoaDon() => new HoaDonBanLe();
    }

    public class HoaDonBanSiFactory : HoaDonFactory
    {
        public override IHoaDon TaoHoaDon() => new HoaDonBanSi();
    }
}