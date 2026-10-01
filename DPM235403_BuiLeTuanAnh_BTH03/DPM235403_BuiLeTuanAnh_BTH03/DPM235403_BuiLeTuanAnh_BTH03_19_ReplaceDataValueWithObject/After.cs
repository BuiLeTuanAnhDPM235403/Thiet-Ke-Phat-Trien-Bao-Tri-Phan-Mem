namespace DPM235403_BuiLeTuanAnh_BTH03_19_ReplaceDataValueWithObject.After
{
    // Tạo riêng một Object Customer để sau này dễ dàng mở rộng thêm thuộc tính
    public class Customer
    {
        public string Name { get; set; }
        public Customer(string name) { Name = name; }
    }

    public class Order
    {
        // Biến kiểu string đã được thay thế bằng Object Customer
        public Customer Customer { get; set; }

        public Order(string customerName)
        {
            Customer = new Customer(customerName);
        }
    }
}