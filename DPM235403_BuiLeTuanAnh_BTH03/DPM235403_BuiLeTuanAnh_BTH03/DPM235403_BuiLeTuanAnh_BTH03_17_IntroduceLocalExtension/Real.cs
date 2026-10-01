using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_17_IntroduceLocalExtension.Real
{
    // MỞ RỘNG (EXTENSION) CHO LĨNH VỰC NÔNG NGHIỆP
    public static class NongNghiepDateExtensions
    {
        // Thêm chữ "this" vào trước kiểu dữ liệu để biến nó thành Extension Method
        public static DateTime TinhNgayBonPhanDot2(this DateTime ngayXuongGiong)
        {
            // Cây lúa thường bón đợt 2 (thúc đẻ nhánh) vào khoảng 15-18 ngày sau sạ
            return ngayXuongGiong.AddDays(15);
        }
    }

    public class LichNongVu
    {
        public void TuVanLichBonPhan(string tenNongDan, DateTime ngayXuongGiong)
        {
            Console.WriteLine($"--- Lich cham soc lua cua chu {tenNongDan} ---");
            Console.WriteLine($"Ngay xuong giong (sa lua): {ngayXuongGiong.ToString("dd/MM/yyyy")}");

            // Nhờ Local Extension, ta gọi trực tiếp hàm nghiệp vụ từ đối tượng DateTime
            DateTime ngayBonDot2 = ngayXuongGiong.TinhNgayBonPhanDot2();

            Console.WriteLine($"=> Ngay can mua phan bon thuc dot 2 la: {ngayBonDot2.ToString("dd/MM/yyyy")}\n");
        }
    }
}