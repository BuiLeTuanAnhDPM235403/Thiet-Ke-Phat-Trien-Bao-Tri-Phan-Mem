namespace DPM235403_BuiLeTuanAnh_Tuan01_Abstract_Real_KhoXuat_DP
{
    public interface ICauHinhCuaHangFactory
    {
        IXuatKho TaoPhuongPhapXuatKho();
        ITinhGia TaoPhuongPhapTinhGia();
    }

    public class CauHinhFIFOFactory : ICauHinhCuaHangFactory
    {
        public IXuatKho TaoPhuongPhapXuatKho() => new XuatKhoFIFO();
        public ITinhGia TaoPhuongPhapTinhGia() => new TinhGiaFIFO();
    }

    public class CauHinhTuyChonFactory : ICauHinhCuaHangFactory
    {
        public IXuatKho TaoPhuongPhapXuatKho() => new XuatKhoChiDinh();
        public ITinhGia TaoPhuongPhapTinhGia() => new TinhGiaBinhQuan();
    }
}