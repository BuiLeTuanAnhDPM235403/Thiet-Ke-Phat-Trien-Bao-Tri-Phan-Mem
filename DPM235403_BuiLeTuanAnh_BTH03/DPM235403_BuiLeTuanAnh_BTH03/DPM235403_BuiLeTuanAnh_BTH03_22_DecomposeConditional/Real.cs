using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_22_DecomposeConditional.Real
{
    public class ChinhSachBanHang
    {
        public double TinhTienPhanBon(DateTime ngayMua, double donGia, int soLuong)
        {
            // Đã áp dụng Decompose Conditional: Đọc vào hiểu ngay quy trình
            if (LaVuLuaHeThu(ngayMua))
            {
                return TinhGiaUuDaiVuHeThu(donGia, soLuong);
            }
            else
            {
                return TinhGiaBanChuan(donGia, soLuong);
            }
        }

        // --- CÁC HÀM PHÂN RÃ NGHIỆP VỤ ---

        private bool LaVuLuaHeThu(DateTime ngay)
        {
            // Vụ Hè Thu ở An Giang thường kéo dài từ tháng 4 đến hết tháng 8
            return ngay.Month >= 4 && ngay.Month <= 8;
        }

        private double TinhGiaUuDaiVuHeThu(double donGia, int soLuong)
        {
            Console.WriteLine("=> Ap dung chuong trinh Dong hanh Vu He Thu (Giam 10%)");
            double tongTien = donGia * soLuong;
            return tongTien * 0.90; // Giảm 10%
        }

        private double TinhGiaBanChuan(double donGia, int soLuong)
        {
            Console.WriteLine("=> Ap dung Gia ban tieu chuan");
            return donGia * soLuong;
        }
    }
}