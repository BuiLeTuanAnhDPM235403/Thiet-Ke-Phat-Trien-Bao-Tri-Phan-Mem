using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_21_ReplaceArrayWithObject.Real
{
    // ĐỐI TƯỢNG ĐƯỢC TẠO RA ĐỂ THAY THẾ MẢNG
    public class ChiTietNhapKho
    {
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }

        public ChiTietNhapKho(string ten, int soLuong, double donGia)
        {
            TenSanPham = ten;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public double TinhThanhTien()
        {
            return SoLuong * DonGia;
        }
    }

    public class QuanLyKho
    {
        public void GhiNhanNhapKho(ChiTietNhapKho chiTiet)
        {
            Console.WriteLine($"[NHAP KHO] {chiTiet.TenSanPham}");
            Console.WriteLine($"- So luong: {chiTiet.SoLuong} thung");
            Console.WriteLine($"- Don gia: {chiTiet.DonGia:N0} VND");
            Console.WriteLine($"- Tong gia tri lo: {chiTiet.TinhThanhTien():N0} VND\n");
        }
    }
}