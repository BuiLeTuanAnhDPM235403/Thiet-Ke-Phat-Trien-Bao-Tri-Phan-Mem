using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Mediator_Conceptual_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();

            // Khởi tạo Mediator và liên kết các component vào nó
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A.");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            component2.DoD();

            Console.ReadLine();
        }
    }
}