using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Memento_Conceptual_DP
{
    public interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDate();
    }
}