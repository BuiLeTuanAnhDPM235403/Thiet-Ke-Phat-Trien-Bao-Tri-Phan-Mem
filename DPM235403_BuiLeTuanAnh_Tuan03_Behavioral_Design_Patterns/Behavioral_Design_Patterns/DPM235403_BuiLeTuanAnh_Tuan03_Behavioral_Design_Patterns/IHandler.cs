namespace DPM235403_BuiLeTuanAnh_Tuan03_ChainOfResponsibility_Conceptual_DP
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
}