using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_30_FormTemplateMethod.Before
{
    public class LoaiHoaDonThuong
    {
        public void Calc()
        {
            Console.WriteLine("Doc du lieu...");
            Console.WriteLine("Tinh tien cho khach le (Khong chieu khau)");
            Console.WriteLine("In hoa don thanh cong.");
        }
    }

    public class LoaiHoaDonVIP
    {
        public void Calc()
        {
            Console.WriteLine("Doc du lieu...");
            Console.WriteLine("Tinh tien cho khach VIP (Giam 15%)");
            Console.WriteLine("In hoa don thanh cong.");
        }
    }
}