namespace DPM235403_BuiLeTuanAnh_Tuan01_Builder_Real_PhieuXuat_DP
{
    public class HoaDonGiaoTanNoiBuilder : IHoaDonBuilder
    {
        private HoaDon _hoaDon = new HoaDon();

        public HoaDonGiaoTanNoiBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _hoaDon = new HoaDon();
        }

        public void BuildThongTinSanPham() => _hoaDon.Add("San pham: 10 chai thuoc tru sau, 5 bao phan bon");
        public void BuildChiPhiVanChuyen() => _hoaDon.Add("Phi van chuyen: 50,000 VND (Giao bang xe tai nhe)");
        public void BuildDichVuPhu() => _hoaDon.Add("Dich vu phu: Boc xep tan kho (20,000 VND)");
        public void BuildGiamGiaKhuyenMai() => _hoaDon.Add("Giam gia: Khach hang than thiet giam 5%");

        public HoaDon GetHoaDon()
        {
            HoaDon result = _hoaDon;
            this.Reset();
            return result;
        }
    }
}