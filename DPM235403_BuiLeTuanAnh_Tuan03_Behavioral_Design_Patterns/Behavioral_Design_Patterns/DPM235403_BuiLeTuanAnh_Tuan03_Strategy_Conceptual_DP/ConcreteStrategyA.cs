using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Strategy_Conceptual_DP
{
    class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}