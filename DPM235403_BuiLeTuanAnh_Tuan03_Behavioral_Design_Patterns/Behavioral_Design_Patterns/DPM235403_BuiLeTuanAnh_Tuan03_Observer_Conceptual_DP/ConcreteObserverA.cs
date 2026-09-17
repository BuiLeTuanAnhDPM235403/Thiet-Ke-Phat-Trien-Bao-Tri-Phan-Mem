using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Observer_Conceptual_DP
{
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}