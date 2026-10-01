using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_08_ReplaceMethodWithMethodObject.Real
{
    public class DonHangNongDuoc
    {
        public double TinhTienPhucTap(double donGia, int soLuong, double khoangCachKm, int diemTichLuy)
        {
            // Chuyển logic phức tạp sang Method Object
            var boTinhTien = new BoTinhTienDonHang(this, donGia, soLuong, khoangCachKm, diemTichLuy);
            return boTinhTien.ThucThiTinhToan();
        }

        public double LayPhiShipCoBan()
        {
            return 15000; // 15k/km
        }
    }

    // METHOD OBJECT: Xử lý chuyên sâu việc tính tiền
    public class BoTinhTienDonHang
    {
        private DonHangNongDuoc _donHang;
        private double _donGia;
        private int _soLuong;
        private double _khoangCachKm;
        private int _diemTichLuy;

        // Các biến lưu trữ trung gian
        private double _tienHang;
        private double _phiShip;
        private double _tienGiam;

        public BoTinhTienDonHang(DonHangNongDuoc donHang, double donGia, int soLuong, double khoangCachKm, int diemTichLuy)
        {
            _donHang = donHang;
            _donGia = donGia;
            _soLuong = soLuong;
            _khoangCachKm = khoangCachKm;
            _diemTichLuy = diemTichLuy;
        }

        public double ThucThiTinhToan()
        {
            TinhTienHangGoc();
            TinhPhiVanChuyen();
            TinhChietKhauKhachHang();

            double tongThu = _tienHang + _phiShip - _tienGiam;
            Console.WriteLine($"+ Tien hang: {_tienHang:N0}");
            Console.WriteLine($"+ Phi ship: {_phiShip:N0}");
            Console.WriteLine($"- Giam gia: {_tienGiam:N0}");
            Console.WriteLine($"=> TONG THU: {tongThu:N0} VND");

            return tongThu;
        }

        private void TinhTienHangGoc()
        {
            _tienHang = _donGia * _soLuong;
        }

        private void TinhPhiVanChuyen()
        {
            _phiShip = _khoangCachKm * _donHang.LayPhiShipCoBan();
            // Đơn hàng trên 5 triệu được hỗ trợ 50% phí vận chuyển
            if (_tienHang >= 5000000)
            {
                _phiShip *= 0.5;
            }
        }

        private void TinhChietKhauKhachHang()
        {
            _tienGiam = 0;
            // Khách có điểm tích lũy trên 500 điểm được giảm thêm 5% tiền hàng
            if (_diemTichLuy >= 500)
            {
                _tienGiam = _tienHang * 0.05;
            }
        }
    }
}