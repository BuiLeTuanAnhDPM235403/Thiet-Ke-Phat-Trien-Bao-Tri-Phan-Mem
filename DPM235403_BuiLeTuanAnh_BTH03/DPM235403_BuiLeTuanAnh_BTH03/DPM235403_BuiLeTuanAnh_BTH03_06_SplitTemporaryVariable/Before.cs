using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_06_SplitTemporaryVariable.Before
{
    public class HinhHoc
    {
        public void InThongTin(double height, double width)
        {
            // Biến temp được dùng để tính chu vi
            double temp = 2 * (height + width);
            Console.WriteLine("Chu vi: " + temp);

            // Ngay sau đó, biến temp lại bị gán giá trị mới để tính diện tích (Rất dễ gây nhầm lẫn)
            temp = height * width;
            Console.WriteLine("Dien tich: " + temp);
        }
    }
}