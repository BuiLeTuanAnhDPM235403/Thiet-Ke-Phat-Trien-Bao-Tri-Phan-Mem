namespace DPM235403_BuiLeTuanAnh_Tuan03_Visitor_Real_TinhThue_DP
{
    public class ThuocHoaHoc : ISanPhamNongDuoc
    {
        public string TenThuoc { get; set; }
        public double GiaGoc { get; set; }
        public int MucDoDocHai { get; set; } // 1: Thấp, 2: Cao

        public ThuocHoaHoc(string ten, double gia, int doDoc)
        {
            TenThuoc = ten;
            GiaGoc = gia;
            MucDoDocHai = doDoc;
        }

        public void Accept(ITinhThueVisitor visitor)
        {
            visitor.VisitThuocHoaHoc(this);
        }
    }
}