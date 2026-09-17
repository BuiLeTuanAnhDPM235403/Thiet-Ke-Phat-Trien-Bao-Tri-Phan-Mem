using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Visitor_Conceptual_DP
{
    public class Client
    {
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
            }
        }
    }
}