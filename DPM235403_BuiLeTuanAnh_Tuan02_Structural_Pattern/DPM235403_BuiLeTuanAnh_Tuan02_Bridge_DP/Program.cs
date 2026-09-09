using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Bridge_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;

            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);

            // Dừng màn hình console để xem kết quả
            Console.ReadLine();
        }
    }
}