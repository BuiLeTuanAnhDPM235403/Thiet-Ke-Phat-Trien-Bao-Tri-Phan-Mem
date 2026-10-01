namespace DPM235403_BuiLeTuanAnh_BTH03_19_ReplaceDataValueWithObject.Before
{
    public class Order
    {
        // Khách hàng chỉ là kiểu string, không thể lưu thêm số điện thoại hay địa chỉ
        public string Customer { get; set; }

        public Order(string customerName)
        {
            Customer = customerName;
        }
    }
}