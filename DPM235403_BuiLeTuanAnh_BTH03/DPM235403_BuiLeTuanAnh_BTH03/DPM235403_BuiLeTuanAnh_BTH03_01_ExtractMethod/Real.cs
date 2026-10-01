using System;
using System.Collections.Generic;
using System.Linq;

namespace DPM235403_BuiLeTuanAnh_BTH03_01_ExtractMethod.Real
{
    public class SanPham
    {
        // Thêm dấu ? để khắc phục cảnh báo CS8618
        public string? Ten { get; set; }
        public double Gia { get; set; }
    }

    public class HoaDonNongDuoc
    {
        private string _tenKhachHang;
        private List<SanPham> _danhSachMua;

        public HoaDonNongDuoc(string tenKhachHang, List<SanPham> danhSachMua)
        {
            _tenKhachHang = tenKhachHang;
            _danhSachMua = danhSachMua;
        }

        // HÀM CHÍNH ĐÃ ĐƯỢC REFACTOR
        public void XuatHoaDon()
        {
            InTieuDeCuaHang();
            double tongTien = TinhTongTienDonHang();
            InChiTietKhachHang(tongTien);
        }

        // --- CÁC PHƯƠNG THỨC ĐƯỢC TÁCH RA (EXTRACTED METHODS) ---

        private void InTieuDeCuaHang()
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("       CUA HANG NONG DUOC AN GIANG         ");
            Console.WriteLine(" Dia chi: 18 Ung Van Khiem, Long Xuyen     ");
            Console.WriteLine("===========================================");
        }

        private double TinhTongTienDonHang()
        {
            return _danhSachMua.Sum(sp => sp.Gia);
        }

        private void InChiTietKhachHang(double tongTien)
        {
            Console.WriteLine($"Khach hang: {_tenKhachHang}");
            Console.WriteLine("Chi tiet mua hang:");
            foreach (var sp in _danhSachMua)
            {
                Console.WriteLine($"- {sp.Ten}: {sp.Gia:N0} VND");
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"TONG CONG: {tongTien:N0} VND");
            Console.WriteLine("===========================================\n");
        }
    }
}