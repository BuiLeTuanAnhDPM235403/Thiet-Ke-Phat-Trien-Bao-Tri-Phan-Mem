namespace DPM235403_BuiLeTuanAnh_Tuan01_Abstract_Real_KhoXuat_DP
{
    public class HeThongQuanLyKho
    {
        private IXuatKho _xuatKho;
        private ITinhGia _tinhGia;

        public HeThongQuanLyKho(ICauHinhCuaHangFactory factory)
        {
            _xuatKho = factory.TaoPhuongPhapXuatKho();
            _tinhGia = factory.TaoPhuongPhapTinhGia();
        }

        public void ThucHienXuatKho()
        {
            _xuatKho.XuatHang();
            _tinhGia.TinhGiaXuat();
        }
    }
}