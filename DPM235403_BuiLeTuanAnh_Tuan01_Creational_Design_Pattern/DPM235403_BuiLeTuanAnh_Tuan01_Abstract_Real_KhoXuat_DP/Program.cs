using System;

namespace AbstractFactory_Real_KhoXuat
{
    // --- Abstract Products ---
    public interface IXuatKho
    {
        void XuatHang();
    }

    public interface ITinhGia
    {
        void TinhGiaXuat();
    }

    // --- Concrete Products cho Cấu hình FIFO ---
    public class XuatKhoFIFO : IXuatKho
    {
        public void XuatHang() => Console.WriteLine("Xuat kho: Tu dong chon Lo co ngay het han truoc xuat truoc.");
    }

    public class TinhGiaFIFO : ITinhGia
    {
        public void TinhGiaXuat() => Console.WriteLine("Tinh gia: Theo phuong phap Nhap truoc Xuat truoc (FIFO).");
    }

    // --- Concrete Products cho Cấu hình Tùy chọn / Bình quân ---
    public class XuatKhoChiDinh : IXuatKho
    {
        public void XuatHang() => Console.WriteLine("Xuat kho: Xuat hang theo lo chi dinh cua nguoi dung.");
    }

    public class TinhGiaBinhQuan : ITinhGia
    {
        public void TinhGiaXuat() => Console.WriteLine("Tinh gia: Theo phuong phap Binh quan gia quyen.");
    }

    // --- Abstract Factory ---
    public interface ICauHinhCuaHangFactory
    {
        IXuatKho TaoPhuongPhapXuatKho();
        ITinhGia TaoPhuongPhapTinhGia();
    }

    // --- Concrete Factories ---
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

    // --- Client ---
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CAU HINH HE THONG 1: CHUAN FIFO ---");
            HeThongQuanLyKho heThong1 = new HeThongQuanLyKho(new CauHinhFIFOFactory());
            heThong1.ThucHienXuatKho();

            Console.WriteLine("\n--- CAU HINH HE THONG 2: CHI DINH & BINH QUAN GIA QUYEN ---");
            HeThongQuanLyKho heThong2 = new HeThongQuanLyKho(new CauHinhTuyChonFactory());
            heThong2.ThucHienXuatKho();

            Console.ReadLine();
        }
    }
}