using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_ChainOfResp_Real_ChietKhau_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG XET DUYET CHIET KHAU NONG DUOC ---");

            // Khởi tạo các mắt xích
            var nhanVien = new NhanVienBanHang();
            var cuaHangTruong = new CuaHangTruong();
            var giamDoc = new GiamDoc();

            // Thiết lập chuỗi: Nhân viên -> Cửa hàng trưởng -> Giám đốc
            nhanVien.ThietLapCapTren(cuaHangTruong).ThietLapCapTren(giamDoc);

            // Giả lập các yêu cầu từ khách
            nhanVien.XuLyYeuCau("Bac Sau (Mua le)", 3.0);
            nhanVien.XuLyYeuCau("Dai ly Nong Nghiep Cho Moi", 8.0);
            nhanVien.XuLyYeuCau("Hop tac xa Nong Nghiep An Giang", 15.0);
            nhanVien.XuLyYeuCau("Khach hang ao tuong", 50.0);

            Console.ReadLine();
        }
    }
}