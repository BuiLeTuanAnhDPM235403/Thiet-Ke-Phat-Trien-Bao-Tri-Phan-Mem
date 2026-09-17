using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Memento_Real_SaoLuuHoaDon_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG BAN HANG (CO SAO LUU DRAFT) ---");

            var hoaDon = new HoaDonOriginator();
            var heThongLuuTru = new HeThongLuuTruCaretaker(hoaDon);

            hoaDon.ThemHangHoa("Phan bon Ure");
            heThongLuuTru.Backup(); // Lưu lần 1

            hoaDon.ThemHangHoa("Thuoc tru sau Regen");
            heThongLuuTru.Backup(); // Lưu lần 2

            // Lỡ tay thêm nhầm hàng
            hoaDon.ThemHangHoa("Thuoc diet co (Them nham)");

            // Hoàn tác lại trạng thái trước khi thêm nhầm
            heThongLuuTru.Undo();

            Console.ReadLine();
        }
    }
}