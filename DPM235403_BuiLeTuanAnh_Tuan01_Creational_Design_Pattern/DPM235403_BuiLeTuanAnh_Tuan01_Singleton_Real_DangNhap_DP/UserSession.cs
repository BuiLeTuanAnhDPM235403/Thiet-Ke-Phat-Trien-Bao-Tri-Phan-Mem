using System;

namespace DPM235403_BuiLeTuanAnh_Tuan01_Singleton_Real_DangNhap_DP
{
    // Class quan ly phien dang nhap ap dung Singleton
    public class UserSession
    {
        private static UserSession _instance;

        // Thong tin nhan vien
        public string TenNhanVien { get; set; }
        public string QuyenHan { get; set; }

        // Constructor private de ngan dung tu khoa 'new' tao moi tu ben ngoai
        private UserSession() { }

        // Ham duy nhat de lay the hien phien dang nhap
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
}