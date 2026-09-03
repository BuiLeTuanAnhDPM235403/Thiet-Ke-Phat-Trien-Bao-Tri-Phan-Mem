using System;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Singleton_Real_DangNhap_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- HE THONG QUAN LY CUA HANG NONG DUOC ---");

            // Nhan vien dang nhap
            UserSession session1 = UserSession.GetInstance();
            session1.TenNhanVien = "Bui Le Tuan Anh";
            session1.QuyenHan = "Quan ly";

            // Goi lai Session tai module khac
            UserSession session2 = UserSession.GetInstance();

            // In thong tin de kiem tra session2 co dong bo khong
            session2.HienThiThongTin();

            // Kiem tra 2 bien co cung tro ve 1 instance duy nhat
            if (session1 == session2)
            {
                Console.WriteLine("=> Singleton hoat dong dung: Chi co 1 phien dang nhap duy nhat trong he thong.");
            }

            Console.ReadLine();
        }
    }
}