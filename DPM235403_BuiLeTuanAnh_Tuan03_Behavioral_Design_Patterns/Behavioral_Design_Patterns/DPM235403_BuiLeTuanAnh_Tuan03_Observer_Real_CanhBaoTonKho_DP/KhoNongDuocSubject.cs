using System;
using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Observer_Real_CanhBaoTonKho_DP
{
    public class KhoNongDuocSubject : ISubject
    {
        private List<IObserver> _danhSachTheoDoi = new List<IObserver>();
        public string TenSanPham { get; set; } = "Thuoc diet co Mizin";
        public int TonKho { get; private set; } = 50;

        public void DangKy(IObserver observer)
        {
            _danhSachTheoDoi.Add(observer);
        }

        public void HuyDangKy(IObserver observer)
        {
            _danhSachTheoDoi.Remove(observer);
        }

        public void ThongBaoMoiNguoi()
        {
            foreach (var observer in _danhSachTheoDoi)
            {
                observer.NhanThongBao(this);
            }
        }

        public void XuatKho(int soLuong)
        {
            TonKho -= soLuong;
            Console.WriteLine($"\n[Kho] Vua xuat {soLuong} chai {TenSanPham}. Ton kho hien tai: {TonKho}");

            // Nếu tồn kho dưới 10, phát cảnh báo
            if (TonKho < 10)
            {
                Console.WriteLine("!!! CANH BAO: Ton kho duoi muc an toan. Dang thong bao cho cac bo phan !!!");
                ThongBaoMoiNguoi();
            }
        }
    }
}