using System;

namespace Factory_Real_HoaDon
{
    // Interface chung cho các loại hóa đơn
    public interface IHoaDon
    {
        void InHoaDon();
    }

    // Hóa đơn bán lẻ
    public class HoaDonBanLe : IHoaDon
    {
        public void InHoaDon()
        {
            Console.WriteLine("In Hoa Don BAN LE: Gia thuong, khong co chiet khau si.");
        }
    }

    // Hóa đơn bán sỉ
    public class HoaDonBanSi : IHoaDon
    {
        public void InHoaDon()
        {
            Console.WriteLine("In Hoa Don BAN SI: Ap dung chiet khau cho dai ly.");
        }
    }

    // Factory Class
    public abstract class HoaDonFactory
    {
        public abstract IHoaDon TaoHoaDon();
    }

    public class HoaDonBanLeFactory : HoaDonFactory
    {
        public override IHoaDon TaoHoaDon() => new HoaDonBanLe();
    }

    public class HoaDonBanSiFactory : HoaDonFactory
    {
        public override IHoaDon TaoHoaDon() => new HoaDonBanSi();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- CUA HANG NONG DUOC: PHAN HE XUAT HOA DON ---");

            // Khách lẻ mua hàng
            HoaDonFactory factoryLe = new HoaDonBanLeFactory();
            IHoaDon hoadon1 = factoryLe.TaoHoaDon();
            hoadon1.InHoaDon();

            // Đại lý mua hàng
            HoaDonFactory factorySi = new HoaDonBanSiFactory();
            IHoaDon hoadon2 = factorySi.TaoHoaDon();
            hoadon2.InHoaDon();

            Console.ReadLine();
        }
    }
}