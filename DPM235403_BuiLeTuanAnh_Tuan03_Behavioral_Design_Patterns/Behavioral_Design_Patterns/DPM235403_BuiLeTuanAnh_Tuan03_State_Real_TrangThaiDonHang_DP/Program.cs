using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_State_Real_TrangThaiDonHang_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG QUAN LY TRANG THAI GIAO HANG ---");

            // Đơn hàng mới tạo sẽ ở trạng thái Chờ xác nhận
            var donHang = new DonHangContext(new TrangThaiChoXacNhan());

            // Thử xử lý đơn hàng lần 1 (Sẽ đổi sang Đang giao)
            donHang.XuLyDon();

            // Khách tự nhiên gọi đòi hủy lúc đang giao
            Console.WriteLine("\n*Khach hang goi dien doi huy don:*");
            donHang.HuyDon();

            // Tiếp tục xử lý cho xong đơn
            Console.WriteLine("\n*Tai xe tiep tuc giao:*");
            donHang.XuLyDon();

            // Đã hoàn thành rồi thì không hủy được nữa
            Console.WriteLine("\n*Khach hang choi xau doi huy sau khi nhan hang:*");
            donHang.HuyDon();

            Console.ReadLine();
        }
    }
}