using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_23_ConsolidateConditionalExpression.Real
{
    public class DonHangTriAn
    {
        public double TongTien { get; set; }
        public bool LaKhachVIP { get; set; }
        public bool LaThangSinhNhat { get; set; }

        public DonHangTriAn(double tongTien, bool laVip, bool laSinhNhat)
        {
            TongTien = tongTien;
            LaKhachVIP = laVip;
            LaThangSinhNhat = laSinhNhat;
        }

        public void KiemTraQuaTang()
        {
            // Đã áp dụng Consolidate Conditional Expression
            if (DuocNhanAoMua())
            {
                Console.WriteLine("=> Don hang duoc TANG KEM 1 ao mua Nong Duoc An Giang.");
            }
            else
            {
                Console.WriteLine("=> Don hang khong co qua tang kem.");
            }
        }

        // Gộp tất cả điều kiện trúng thưởng vào 1 hàm duy nhất
        private bool DuocNhanAoMua()
        {
            return TongTien > 10000000 || LaKhachVIP || LaThangSinhNhat;
        }
    }
}