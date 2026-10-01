using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_20_ReplaceMagicNumberWithSymbolicConstant.Real
{
    public class KiemDinhVanChuyen
    {
        // Khai báo hằng số giúp việc thay đổi quy định sau này dễ dàng hơn
        // Chỉ cần đổi số ở đây, toàn bộ code sẽ cập nhật theo
        private const double GIOI_HAN_KHOI_LUONG_DOC_HAI = 500.0;
        private const double PHI_XE_CHUYEN_DUNG = 1500000;

        public void KiemTraChuyenHang(double khoiLuongThuocSau)
        {
            Console.WriteLine($"Khoi luong hang doc hai: {khoiLuongThuocSau} kg");

            // Không còn dùng "Magic Number" 500 ở đây nữa
            if (khoiLuongThuocSau > GIOI_HAN_KHOI_LUONG_DOC_HAI)
            {
                Console.WriteLine($"[CANH BAO] Vuot qua muc an toan ({GIOI_HAN_KHOI_LUONG_DOC_HAI} kg).");
                Console.WriteLine($"=> Bat buoc thue xe chuyen dung voi phi: {PHI_XE_CHUYEN_DUNG:N0} VND\n");
            }
            else
            {
                Console.WriteLine("[HOP LE] Co the dung xe tai thuong de van chuyen.\n");
            }
        }
    }
}