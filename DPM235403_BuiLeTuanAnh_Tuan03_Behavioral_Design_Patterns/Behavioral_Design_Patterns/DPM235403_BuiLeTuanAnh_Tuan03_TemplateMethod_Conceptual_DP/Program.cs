using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_TemplateMethod_Conceptual_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses (ConcreteClass1):");
            Client.ClientCode(new ConcreteClass1());

            Console.WriteLine("\nSame client code can work with different subclasses (ConcreteClass2):");
            Client.ClientCode(new ConcreteClass2());

            Console.ReadLine();
        }
    }
}