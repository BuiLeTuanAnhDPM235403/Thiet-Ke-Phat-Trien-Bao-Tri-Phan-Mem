using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Proxy_DP
{
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}