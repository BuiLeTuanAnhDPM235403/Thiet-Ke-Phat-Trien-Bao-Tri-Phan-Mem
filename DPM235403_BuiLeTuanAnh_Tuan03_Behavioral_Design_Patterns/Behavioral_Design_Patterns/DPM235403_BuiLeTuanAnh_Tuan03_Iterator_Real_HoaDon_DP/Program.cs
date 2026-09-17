using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Iterator_Real_HoaDon_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- DUYET DANH SACH HOA DON NONG DUOC ---");

            var danhSach = new DanhSachHoaDon();
            danhSach.ThemHoaDon(new HoaDon("HD01", 500000));
            danhSach.ThemHoaDon(new HoaDon("HD02", 1500000)); // Hóa đơn VIP
            danhSach.ThemHoaDon(new HoaDon("HD03", 200000));
            danhSach.ThemHoaDon(new HoaDon("HD04", 3500000)); // Hóa đơn VIP

            IIterator iterator = danhSach.CreateIterator();

            Console.WriteLine("\n[Ke Toan] Danh sach toan bo hoa don trong ngay:");
            while (iterator.HasNext())
            {
                var hd = iterator.Next();
                Console.WriteLine($"- Ma HD: {hd.MaHD} | So tien: {hd.TongTien:N0} VNĐ");
            }

            Console.ReadLine();
        }
    }
}