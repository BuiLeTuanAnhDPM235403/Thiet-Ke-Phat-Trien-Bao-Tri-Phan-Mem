using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_06_SplitTemporaryVariable.After
{
    public class HinhHoc
    {
        public void InThongTin(double height, double width)
        {
            // Đã áp dụng Split Temporary Variable: Tạo 2 biến riêng biệt với tên gọi chuẩn xác

            double perimeter = 2 * (height + width);
            Console.WriteLine("Chu vi: " + perimeter);

            double area = height * width;
            Console.WriteLine("Dien tich: " + area);
        }
    }
}