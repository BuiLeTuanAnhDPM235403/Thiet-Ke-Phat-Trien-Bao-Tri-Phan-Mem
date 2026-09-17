using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Strategy_Conceptual_DP
{
    class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }
    }
}