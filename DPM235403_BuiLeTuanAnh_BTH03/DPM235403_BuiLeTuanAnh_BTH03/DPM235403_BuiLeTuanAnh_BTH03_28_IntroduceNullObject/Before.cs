using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_28_IntroduceNullObject.Before
{
    public class Plan { public string Name = "Goi Co Ban"; }

    public class Customer
    {
        public Plan Plan { get; set; }
    }

    public class Billing
    {
        public void Process(Customer customer)
        {
            Plan plan;
            // Xấu: Phải kiểm tra null cẩn thận, nếu quên là lỗi chương trình
            if (customer == null)
            {
                plan = new Plan(); // Trả về gói mặc định
            }
            else
            {
                plan = customer.Plan;
            }
            Console.WriteLine($"Su dung: {plan.Name}");
        }
    }
}