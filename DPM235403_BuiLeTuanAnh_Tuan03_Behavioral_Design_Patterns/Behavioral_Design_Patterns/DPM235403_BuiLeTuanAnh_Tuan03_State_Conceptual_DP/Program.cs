using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_State_Conceptual_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Client truyền vào trạng thái khởi điểm là A
            var context = new Context(new ConcreteStateA());

            // Yêu cầu 1 sẽ do State A xử lý, sau đó nó tự động chuyển Context sang State B
            context.Request1();

            // Yêu cầu 2 lúc này sẽ do State B xử lý (vì Context đã bị chuyển trạng thái)
            context.Request2();

            Console.ReadLine();
        }
    }
}