namespace DPM235403_BuiLeTuanAnh_BTH03_05_ReplaceTempWithQuery.Before
{
    public class DonHang
    {
        private int _quantity = 10;
        private double _itemPrice = 150;

        public double CalculateTotal()
        {
            // Biến tạm basePrice khiến biểu thức _quantity * _itemPrice bị kẹt trong hàm này
            double basePrice = _quantity * _itemPrice;

            if (basePrice > 1000)
            {
                return basePrice * 0.95;
            }
            else
            {
                return basePrice * 0.98;
            }
        }
    }
}