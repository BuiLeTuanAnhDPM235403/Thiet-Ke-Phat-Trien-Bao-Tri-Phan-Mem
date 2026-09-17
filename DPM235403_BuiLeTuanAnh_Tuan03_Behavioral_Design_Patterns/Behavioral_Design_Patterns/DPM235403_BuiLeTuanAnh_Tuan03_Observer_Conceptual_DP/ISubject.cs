namespace DPM235403_BuiLeTuanAnh_Tuan03_Observer_Conceptual_DP
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }
}