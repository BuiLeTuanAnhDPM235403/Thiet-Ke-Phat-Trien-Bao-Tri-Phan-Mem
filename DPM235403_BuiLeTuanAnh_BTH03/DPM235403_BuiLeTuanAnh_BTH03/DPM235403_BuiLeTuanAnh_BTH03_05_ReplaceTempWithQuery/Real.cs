namespace DPM235403_BuiLeTuanAnh_BTH03_05_ReplaceTempWithQuery.Real
{
    public class HoaDonThuocTruSau
    {
        public int SoLuongChai { get; set; }
        public double GiaMotChai { get; set; }

        public HoaDonThuocTruSau(int soLuong, double gia)
        {
            SoLuongChai = soLuong;
            GiaMotChai = gia;
        }

        public double TinhTienThanhToan()
        {
            // Đã áp dụng Replace Temp with Query: Thay biến tạm bằng việc gọi hàm TinhTienGoc()
            if (TinhTienGoc() >= 5000000) // Đơn trên 5 triệu giảm 10%
            {
                return TinhTienGoc() * 0.9;
            }
            return TinhTienGoc();
        }

        // Tách hẳn logic tính tiền gốc ra để sau này muốn in chi tiết hóa đơn cũng có thể gọi lại
        public double TinhTienGoc()
        {
            return SoLuongChai * GiaMotChai;
        }
    }
}