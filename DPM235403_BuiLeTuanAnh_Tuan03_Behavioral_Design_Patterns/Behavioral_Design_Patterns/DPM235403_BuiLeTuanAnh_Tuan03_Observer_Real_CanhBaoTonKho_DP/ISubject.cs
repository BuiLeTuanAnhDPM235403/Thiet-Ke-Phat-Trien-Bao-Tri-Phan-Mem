namespace DPM235403_BuiLeTuanAnh_Tuan03_Observer_Real_CanhBaoTonKho_DP
{
    public interface ISubject
    {
        void DangKy(IObserver observer);
        void HuyDangKy(IObserver observer);
        void ThongBaoMoiNguoi();
    }
}