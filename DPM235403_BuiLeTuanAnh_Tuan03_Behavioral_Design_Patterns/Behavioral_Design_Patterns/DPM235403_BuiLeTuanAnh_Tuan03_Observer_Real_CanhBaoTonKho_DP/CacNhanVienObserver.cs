using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Observer_Real_CanhBaoTonKho_DP
{
    public class CuaHangTruong : IObserver
    {
        public void NhanThongBao(ISubject khoHang)
        {
            var kho = khoHang as KhoNongDuocSubject;
            Console.WriteLine($"-> [Cua Hang Truong] Nhan duoc tin: {kho.TenSanPham} chi con {kho.TonKho} chai. => Tien hanh lien he nha cung cap de nhap hang.");
        }
    }

    public class NhanVienKho : IObserver
    {
        public void NhanThongBao(ISubject khoHang)
        {
            var kho = khoHang as KhoNongDuocSubject;
            Console.WriteLine($"-> [Nhan Vien Kho] Nhan duoc tin: {kho.TenSanPham} sap het. => Tien hanh don dep ke hang de chuan bi don lo moi.");
        }
    }
}