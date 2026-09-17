using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Mediator_Real_Dashboard_DP
{
    public class DashboardCuaHang : ITrungTamDieuPhoi
    {
        private PhanHeBanHang _banHang;
        private PhanHeKhoHang _khoHang;

        public DashboardCuaHang(PhanHeBanHang banHang, PhanHeKhoHang khoHang)
        {
            _banHang = banHang;
            _banHang.SetTrungTam(this);

            _khoHang = khoHang;
            _khoHang.SetTrungTam(this);
        }

        public void ThongBao(object thietBiGui, string suKien)
        {
            if (suKien == "DonHangMoi")
            {
                Console.WriteLine("=> [Dashboard] Da nhan tin hieu co don hang moi. Dang dieu phoi...");
                _khoHang.TruTonKho();
            }
        }
    }
}