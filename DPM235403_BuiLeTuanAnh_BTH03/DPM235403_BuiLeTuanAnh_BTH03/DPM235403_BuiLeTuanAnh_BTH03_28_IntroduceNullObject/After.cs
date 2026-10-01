using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_28_IntroduceNullObject.After
{
    public class Plan { public string Name = "Goi Co Ban"; }

    public class Customer
    {
        public virtual Plan Plan { get; set; } = new Plan { Name = "Goi VIP" };
        public virtual bool IsNull => false;
    }

    // Tốt: Đối tượng Null chứa sẵn hành vi an toàn
    public class NullCustomer : Customer
    {
        public override Plan Plan => new Plan(); // Tự động trả về gói cơ bản
        public override bool IsNull => true;
    }

    public class Billing
    {
        public void Process(Customer customer)
        {
            // Không cần if (customer == null) nữa, cứ thế mà gọi thẳng
            Console.WriteLine($"Su dung: {customer.Plan.Name}");
        }
    }
}