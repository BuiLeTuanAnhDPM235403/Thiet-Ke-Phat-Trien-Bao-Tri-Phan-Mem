using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_10_MoveMethod.Real
{
    // CLASS KHACH HANG
    public class KhachHang
    {
        public string Ten { get; set; }
        public string LoaiKhach { get; set; } // VIP hoac THUONG
        public int NamGanBo { get; set; }

        public KhachHang(string ten, string loaiKhach, int namGanBo)
        {
            Ten = ten;
            LoaiKhach = loaiKhach;
            NamGanBo = namGanBo;
        }

        // MOVE METHOD: Chuyển logic tính phần trăm chiết khấu về cho Khách Hàng tự quản lý
        public double TinhPhanTramChietKhau()
        {
            if (LoaiKhach == "VIP" && NamGanBo > 3)
            {
                return 0.15; // Giảm 15%
            }
            else if (LoaiKhach == "VIP")
            {
                return 0.10; // Giảm 10%
            }
            return 0.0; // Khách thường không giảm
        }
    }

    // CLASS HOA DON
    public class HoaDon
    {
        private KhachHang _khachHang;
        private double _tienHang;

        public HoaDon(KhachHang khachHang, double tienHang)
        {
            _khachHang = khachHang;
            _tienHang = tienHang;
        }

        public void InThanhTien()
        {
            // Hóa đơn chỉ việc "hỏi" khách hàng xem được giảm bao nhiêu phần trăm
            double tiLeGiam = _khachHang.TinhPhanTramChietKhau();
            double tienGiam = _tienHang * tiLeGiam;
            double tienPhaiTra = _tienHang - tienGiam;

            Console.WriteLine($"Khach hang: {_khachHang.Ten}");
            Console.WriteLine($"Tien hang: {_tienHang:N0} | Giam gia: {tienGiam:N0}");
            Console.WriteLine($"=> Tong thu: {tienPhaiTra:N0} VND\n");
        }
    }
}