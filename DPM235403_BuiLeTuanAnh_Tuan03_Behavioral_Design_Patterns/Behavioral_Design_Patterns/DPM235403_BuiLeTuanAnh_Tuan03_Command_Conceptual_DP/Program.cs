using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Command_Conceptual_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();

            // Lệnh đơn giản chạy lúc bắt đầu
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));

            // Lệnh phức tạp chạy lúc kết thúc (cần Receiver xử lý)
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            // Kích hoạt Invoker
            invoker.DoSomethingImportant();

            Console.ReadLine();
        }
    }
}