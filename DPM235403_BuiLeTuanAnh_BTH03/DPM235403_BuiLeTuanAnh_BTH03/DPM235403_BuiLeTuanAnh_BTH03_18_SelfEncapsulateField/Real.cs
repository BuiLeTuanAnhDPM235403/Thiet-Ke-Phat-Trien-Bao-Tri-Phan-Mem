using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_18_SelfEncapsulateField.Real
{
    public class KhoPhanBon
    {
        private string _tenLo;
        private int _soLuong;

        // SELF ENCAPSULATE FIELD: Cổng gác chặn mọi sự thay đổi dữ liệu
        public int SoLuongTon
        {
            get { return _soLuong; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine($"[LOI] Khong the xuat kho! Tồn kho '{_tenLo}' không đủ.");
                    return;
                }
                _soLuong = value;
            }
        }

        public KhoPhanBon(string ten, int soLuongDauKy)
        {
            _tenLo = ten;
            SoLuongTon = soLuongDauKy; // Khởi tạo qua Property
        }

        public void XuatKho(int soLuongBan)
        {
            Console.WriteLine($"Yeu cau xuat {soLuongBan} bao {_tenLo}...");
            // Không được viết: _soLuong = _soLuong - soLuongBan;
            // Phải viết qua Property để hệ thống tự bắt lỗi:
            SoLuongTon = SoLuongTon - soLuongBan;
        }

        public void KiemTraKho()
        {
            Console.WriteLine($"=> Ton kho hien tai cua {_tenLo}: {SoLuongTon} bao.\n");
        }
    }
}