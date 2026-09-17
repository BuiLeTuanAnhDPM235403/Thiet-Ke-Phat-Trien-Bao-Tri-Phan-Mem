using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Visitor_Real_TinhThue_DP
{
    public class ThueVietNamVisitor : ITinhThueVisitor
    {
        public void VisitPhanBon(PhanBon phanBon)
        {
            // Phân bón được ưu đãi nông nghiệp, VAT 5%
            double thue = phanBon.GiaGoc * 0.05;
            Console.WriteLine($"[Tinh Thue] {phanBon.TenPhanBon}: Gia goc {phanBon.GiaGoc:N0}d -> Thue VAT (5%): {thue:N0}d. Tong: {phanBon.GiaGoc + thue:N0}d");
        }

        public void VisitThuocHoaHoc(ThuocHoaHoc thuoc)
        {
            // Thuốc hóa học VAT 10% + Thuế môi trường tùy mức độ độc hại
            double thueVAT = thuoc.GiaGoc * 0.10;
            double thueMoiTruong = thuoc.MucDoDocHai == 2 ? thuoc.GiaGoc * 0.05 : 0; // Độc cao thêm 5%

            double tongThue = thueVAT + thueMoiTruong;
            Console.WriteLine($"[Tinh Thue] {thuoc.TenThuoc}: Gia goc {thuoc.GiaGoc:N0}d -> Thue VAT & Moi truong: {tongThue:N0}d. Tong: {thuoc.GiaGoc + tongThue:N0}d");
        }
    }
}