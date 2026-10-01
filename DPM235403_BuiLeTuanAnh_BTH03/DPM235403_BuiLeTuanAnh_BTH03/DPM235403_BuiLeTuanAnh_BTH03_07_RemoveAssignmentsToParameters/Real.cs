using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_07_RemoveAssignmentsToParameters.Real
{
    public class TinhGiaNongDuoc
    {
        public double TinhGiaThucTe(double giaGoc, int soLuong)
        {
            // Đã áp dụng Remove Assignments to Parameters
            double giaSauGiam = giaGoc; // Tạo biến cục bộ

            if (soLuong >= 10 && soLuong < 50)
            {
                giaSauGiam = giaGoc * 0.95; // Giảm 5%
            }
            else if (soLuong >= 50)
            {
                giaSauGiam = giaGoc * 0.90; // Giảm 10%
            }

            // In ra cả giá gốc lẫn giá giảm để thấy lợi ích của việc không ghi đè tham số
            Console.WriteLine($"Gia niem yet: {giaGoc:N0} VND | Gia thuc thu: {giaSauGiam:N0} VND");

            return giaSauGiam;
        }
    }
}