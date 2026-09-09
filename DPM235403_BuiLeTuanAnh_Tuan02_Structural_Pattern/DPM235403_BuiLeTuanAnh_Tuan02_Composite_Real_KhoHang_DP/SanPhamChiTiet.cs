using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Composite_Real_KhoHang_DP
{
    public class SanPhamChiTiet : IKhoHang
    {
        private string _tenSanPham;
        private int _soLuong;

        public SanPhamChiTiet(string tenSanPham, int soLuong)
        {
            _tenSanPham = tenSanPham;
            _soLuong = soLuong;
        }

        public void HienThiThongTin(int mucDoThutLe)
        {
            Console.WriteLine(new String('-', mucDoThutLe) + $" San pham: {_tenSanPham} (So luong: {_soLuong})");
        }

        public int TinhTongSoLuong()
        {
            return _soLuong;
        }
    }
}