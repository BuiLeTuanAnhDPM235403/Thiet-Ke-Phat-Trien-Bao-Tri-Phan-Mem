using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Decorator_DP
{
    public class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}   