using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Decorator_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // Wrappers lồng nhau
            ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);

            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);

            Console.ReadLine();
        }
    }
}