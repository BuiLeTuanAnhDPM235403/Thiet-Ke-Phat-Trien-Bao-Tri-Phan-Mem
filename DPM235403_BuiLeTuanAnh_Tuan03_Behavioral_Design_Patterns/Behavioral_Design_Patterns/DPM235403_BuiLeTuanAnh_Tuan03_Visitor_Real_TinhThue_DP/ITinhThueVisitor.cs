namespace DPM235403_BuiLeTuanAnh_Tuan03_Visitor_Real_TinhThue_DP
{
    public interface ITinhThueVisitor
    {
        void VisitPhanBon(PhanBon phanBon);
        void VisitThuocHoaHoc(ThuocHoaHoc thuoc);
    }
}