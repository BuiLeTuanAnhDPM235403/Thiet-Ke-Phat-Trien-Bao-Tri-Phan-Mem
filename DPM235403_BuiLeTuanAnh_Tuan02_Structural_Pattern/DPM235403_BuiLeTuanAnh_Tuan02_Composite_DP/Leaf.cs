namespace DPM235403_BuiLeTuanAnh_Tuan02_Composite_DP
{
    class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}