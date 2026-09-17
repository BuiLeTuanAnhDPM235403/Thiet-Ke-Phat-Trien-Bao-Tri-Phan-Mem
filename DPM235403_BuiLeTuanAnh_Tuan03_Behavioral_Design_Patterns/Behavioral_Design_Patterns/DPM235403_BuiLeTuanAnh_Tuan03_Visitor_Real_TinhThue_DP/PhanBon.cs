namespace DPM235403_BuiLeTuanAnh_Tuan03_Visitor_Real_TinhThue_DP
{
    public class PhanBon : ISanPhamNongDuoc
    {
        public string TenPhanBon { get; set; }
        public double GiaGoc { get; set; }

        public PhanBon(string ten, double gia)
        {
            TenPhanBon = ten;
            GiaGoc = gia;
        }

        public void Accept(ITinhThueVisitor visitor)
        {
            visitor.VisitPhanBon(this);
        }
    }
}