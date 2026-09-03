using System;

namespace Singleton_Real_DangNhap
{
    // Class quản lý phiên đăng nhập áp dụng Singleton
    public class UserSession
    {
        private static UserSession _instance;

        // Thông tin nhân viên
        public string TenNhanVien { get; set; }
        public string QuyenHan { get; set; }

        // Constructor private để không ai có thể dùng từ khóa 'new' tạo mới
        private UserSession() { }

        // Hàm duy nhất để lấy phiên đăng nhập
        public static UserSession GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserSession();
            }
            return _instance;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine($"Nhan vien dang nhap: {TenNhanVien} | Quyen: {QuyenHan}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG QUAN LY CUA HANG NONG DUOC ---");

            // Nhân viên 1 đăng nhập
            UserSession session1 = UserSession.GetInstance();
            session1.TenNhanVien = "Bui Le Tuan Anh";
            session1.QuyenHan = "Quan ly";

            // Giả sử ở một Form khác (hoặc lúc khác), có lệnh gọi lại Session
            UserSession session2 = UserSession.GetInstance();

            // In ra xem session2 có giữ được thông tin của session1 không
            session2.HienThiThongTin();

            // Kiểm tra xem 2 biến có trỏ về cùng 1 vùng nhớ không
            if (session1 == session2)
            {
                Console.WriteLine("=> Singleton hoat dong dung: Chi co 1 phien dang nhap duy nhat trong he thong.");
            }

            Console.ReadLine();
        }
    }
}