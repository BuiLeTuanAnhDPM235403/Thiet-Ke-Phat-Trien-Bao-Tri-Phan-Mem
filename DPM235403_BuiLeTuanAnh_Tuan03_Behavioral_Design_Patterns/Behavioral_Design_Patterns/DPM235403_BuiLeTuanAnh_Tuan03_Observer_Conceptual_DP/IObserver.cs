using System.Runtime.InteropServices.JavaScript;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Observer_Conceptual_DP
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }
}