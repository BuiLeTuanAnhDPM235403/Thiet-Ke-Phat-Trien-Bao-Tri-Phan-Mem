namespace DPM235403_BuiLeTuanAnh_BTH03_05_ReplaceTempWithQuery.After
{
    public class DonHang
    {
        private int _quantity = 10;
        private double _itemPrice = 150;

        public double CalculateTotal()
        {
            // Gọi thẳng hàm GetBasePrice() thay vì tạo biến tạm
            if (GetBasePrice() > 1000)
            {
                return GetBasePrice() * 0.95;
            }
            else
            {
                return GetBasePrice() * 0.98;
            }
        }

        // Biểu thức đã được tách ra hàm riêng, class khác hoặc hàm khác có thể dùng lại dễ dàng
        private double GetBasePrice()
        {
            return _quantity * _itemPrice;
        }
    }
}