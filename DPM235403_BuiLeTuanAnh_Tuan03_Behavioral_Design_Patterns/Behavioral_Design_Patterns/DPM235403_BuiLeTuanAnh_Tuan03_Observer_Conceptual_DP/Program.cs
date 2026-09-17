using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Observer_Conceptual_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();

            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            // Chạy logic lần 1 và 2 (cả A và B đều theo dõi)
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            // Hủy đăng ký B
            subject.Detach(observerB);

            // Chạy logic lần 3 (chỉ còn A theo dõi)
            subject.SomeBusinessLogic();

            Console.ReadLine();
        }
    }
}