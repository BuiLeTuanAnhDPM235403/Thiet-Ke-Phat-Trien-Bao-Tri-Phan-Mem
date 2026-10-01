using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_13_InlineClass.Real
{
    public class MayBomThuoc
    {
        public string TenMay { get; set; }
        public double GiaBan { get; set; }

        // Đã áp dụng INLINE CLASS: Đưa biến số tháng bảo hành thẳng vào đây 
        // thay vì tạo nguyên 1 class ThongTinBaoHanh chỉ để chứa 1 biến
        public int SoThangBaoHanh { get; set; }

        public MayBomThuoc(string ten, double gia, int soThang)
        {
            TenMay = ten;
            GiaBan = gia;
            SoThangBaoHanh = soThang;
        }

        public void InThongTin()
        {
            Console.WriteLine($"- Thiet bi: {TenMay}");
            Console.WriteLine($"  + Gia: {GiaBan:N0} VND");
            Console.WriteLine($"  + Bao hanh: {SoThangBaoHanh} thang chinh hang.");
        }
    }
}