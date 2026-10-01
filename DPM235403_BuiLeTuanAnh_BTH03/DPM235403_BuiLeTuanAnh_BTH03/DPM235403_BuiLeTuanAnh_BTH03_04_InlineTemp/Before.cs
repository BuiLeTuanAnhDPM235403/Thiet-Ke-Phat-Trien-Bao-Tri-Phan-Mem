namespace DPM235403_BuiLeTuanAnh_BTH03_04_InlineTemp.Before
{
    public class DonHang
    {
        private double _basePrice = 1500;

        public double GetBasePrice()
        {
            return _basePrice;
        }

        public bool CheckKhuyenMai()
        {
            // Biến tạm basePrice chỉ để lưu tạm rồi ném vào lệnh return, rất dư thừa
            double basePrice = GetBasePrice();
            return basePrice > 1000;
        }
    }
}