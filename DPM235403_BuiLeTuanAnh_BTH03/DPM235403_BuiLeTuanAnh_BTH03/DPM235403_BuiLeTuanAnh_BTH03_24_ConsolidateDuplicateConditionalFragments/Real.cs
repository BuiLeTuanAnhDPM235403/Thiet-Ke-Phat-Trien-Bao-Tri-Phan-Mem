using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_24_ConsolidateDuplicateConditionalFragments.Real
{
    public class XuatHangNongDuoc
    {
        public void XuatKho(string tenThuoc, int soLuong, double donGia, bool laKhachSi)
        {
            double tongTien;

            if (laKhachSi)
            {
                tongTien = soLuong * donGia * 0.85; // Si giam 15%
            }
            else
            {
                tongTien = soLuong * donGia; // Le khong giam
            }

            // GỘP CÁC ĐOẠN MÃ TRÙNG LẶP RA NGOÀI IF-ELSE
            // Vì dù là khách nào thì cũng phải in bill và trừ kho
            InHoaDonChoKhach(tenThuoc, tongTien);
            CapNhatTonKhoMayChu(tenThuoc, soLuong);
            Console.WriteLine("------------------------------\n");
        }

        private void InHoaDonChoKhach(string tenThuoc, double tien)
        {
            Console.WriteLine($"[HOA DON] Ban {tenThuoc} | Thu vao: {tien:N0} VND");
        }

        private void CapNhatTonKhoMayChu(string tenThuoc, int soLuong)
        {
            Console.WriteLine($"[HE THONG] Da tru {soLuong} sp '{tenThuoc}' khoi kho.");
        }
    }
}