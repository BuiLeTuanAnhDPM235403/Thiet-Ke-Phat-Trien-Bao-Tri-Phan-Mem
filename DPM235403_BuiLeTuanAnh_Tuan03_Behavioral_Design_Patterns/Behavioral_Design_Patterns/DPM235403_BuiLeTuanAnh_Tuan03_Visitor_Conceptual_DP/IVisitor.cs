namespace DPM235403_BuiLeTuanAnh_Tuan03_Visitor_Conceptual_DP
{
    public interface IVisitor
    {
        void VisitConcreteComponentA(ConcreteComponentA element);
        void VisitConcreteComponentB(ConcreteComponentB element);
    }
}