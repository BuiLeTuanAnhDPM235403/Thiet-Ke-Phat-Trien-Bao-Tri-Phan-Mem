using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Command_Real_GiaoDichKho_DP
{
    // Receiver: Nơi chứa logic thực sự (Tồn kho)
    public class KhoNongDuocReceiver
    {
        public int TonKhoThuocTruSau { get; private set; } = 500; // Ban đầu có 500 chai

        public void NhapKho(int soLuong)
        {
            TonKhoThuocTruSau += soLuong;
            Console.WriteLine($"[Kho] Da nhap {soLuong} chai. Ton kho hien tai: {TonKhoThuocTruSau}");
        }

        public void XuatKho(int soLuong)
        {
            TonKhoThuocTruSau -= soLuong;
            Console.WriteLine($"[Kho] Da xuat {soLuong} chai. Ton kho hien tai: {TonKhoThuocTruSau}");
        }
    }
}