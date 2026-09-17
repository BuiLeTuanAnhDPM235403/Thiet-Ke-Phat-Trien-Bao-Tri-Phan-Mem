using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Strategy_Real_ThanhToan_DP
{
    public class ThanhToanTienMat : IThanhToanStrategy
    {
        public void XuLyThanhToan(double soTien)
        {
            Console.WriteLine($"[Tien Mat] Da nhan {soTien:N0} VNĐ tien mat tai quay. Xet duyet thanh cong.");
        }
    }

    public class ThanhToanChuyenKhoan : IThanhToanStrategy
    {
        public void XuLyThanhToan(double soTien)
        {
            Console.WriteLine($"[Chuyen Khoan] Dang kiem tra bien dong so du ngan hang... Da nhan {soTien:N0} VNĐ qua Vietcombank.");
        }
    }

    public class ThanhToanGhiNo : IThanhToanStrategy
    {
        public void XuLyThanhToan(double soTien)
        {
            Console.WriteLine($"[Ghi No] Da dua {soTien:N0} VNĐ vao so cong no. Cho den vu thu hoach khach se tra.");
        }
    }
}