namespace DPM235403_BuiLeTuanAnh_Tuan01_Builder_Real_PhieuXuat_DP
{
    public class NhanVienBanHang
    {
        private IHoaDonBuilder _builder;

        public IHoaDonBuilder Builder
        {
            set { _builder = value; }
        }

        public void LapHoaDonDayDu()
        {
            _builder.BuildThongTinSanPham();
            _builder.BuildChiPhiVanChuyen();
            _builder.BuildDichVuPhu();
            _builder.BuildGiamGiaKhuyenMai();
        }
    }
}