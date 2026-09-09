using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Facade_Real_BanHang_DP
{
    public class NghiepVuBanHangFacade
    {
        private HeThongKho _kho = new HeThongKho();
        private HeThongKeToan _keToan = new HeThongKeToan();
        private HeThongVanChuyen _vanChuyen = new HeThongVanChuyen();

        public void XuLyDonHangDongNhat()
        {
            Console.WriteLine("Facade: Dang xu ly quy trinh ban hang tu dong...");
            _keToan.TinhGiaBinhQuan();
            _kho.XuatKhoTheoFIFO();
            _vanChuyen.DieuPhoiGiaoHang();
            Console.WriteLine("Facade: Don hang da hoan tat thanh cong!");
        }
    }
}