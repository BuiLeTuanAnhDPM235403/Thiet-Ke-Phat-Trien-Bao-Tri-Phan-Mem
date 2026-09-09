using System;

namespace DPM235403_BuiLeTuanAnh_Tuan02_Facade_DP
{
    class Client
    {
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
}