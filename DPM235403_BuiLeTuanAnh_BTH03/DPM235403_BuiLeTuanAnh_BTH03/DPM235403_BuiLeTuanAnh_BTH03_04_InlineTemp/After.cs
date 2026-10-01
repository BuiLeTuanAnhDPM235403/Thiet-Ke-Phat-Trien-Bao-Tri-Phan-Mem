namespace DPM235403_BuiLeTuanAnh_BTH03_04_InlineTemp.After
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
            // Gọi thẳng hàm lấy giá trị, tiết kiệm được 1 dòng code và 1 biến bộ nhớ
            return GetBasePrice() > 1000;
        }
    }
}