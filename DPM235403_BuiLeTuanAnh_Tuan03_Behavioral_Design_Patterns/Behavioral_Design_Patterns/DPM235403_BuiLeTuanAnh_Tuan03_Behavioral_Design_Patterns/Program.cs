using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_ChainOfResponsibility_Conceptual_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập các mắt xích
            var monkey = new MonkeyHandler();
            var squirrel = new SquirrelHandler();
            var dog = new DogHandler();

            // Liên kết thành chuỗi: Khỉ -> Sóc -> Chó
            monkey.SetNext(squirrel).SetNext(dog);

            Console.WriteLine("Chain: Monkey > Squirrel > Dog\n");
            Client.ClientCode(monkey);

            Console.WriteLine();

            // Gửi thẳng yêu cầu cho Sóc (bỏ qua Khỉ)
            Console.WriteLine("Subchain: Squirrel > Dog\n");
            Client.ClientCode(squirrel);

            // Giữ màn hình console
            Console.ReadLine();
        }
    }
}