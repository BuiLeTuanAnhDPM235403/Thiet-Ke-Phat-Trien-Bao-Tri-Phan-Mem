namespace DPM235403_BuiLeTuanAnh_Tuan01_Builder_Real_PhieuXuat_DP
{
    public interface IHoaDonBuilder
    {
        void BuildThongTinSanPham();
        void BuildChiPhiVanChuyen();
        void BuildDichVuPhu();
        void BuildGiamGiaKhuyenMai();
        HoaDon GetHoaDon();
    }
}