using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_16_IntroduceForeignMethod.Real
{
    public class PhieuGhiNo
    {
        public string TenNongDan { get; set; }
        public double SoTienNo { get; set; }
        public DateTime NgayMua { get; set; }

        public PhieuGhiNo(string ten, double tienNo, DateTime ngayMua)
        {
            TenNongDan = ten;
            SoTienNo = tienNo;
            NgayMua = ngayMua;
        }

        public void InThongTinNo()
        {
            // Gọi phương thức tự chế để tìm ngày cuối cùng của tháng tiếp theo
            DateTime hanChot = TinhNgayCuoiThangToi(NgayMua);

            Console.WriteLine($"Nong dan: {TenNongDan}");
            Console.WriteLine($"So tien no: {SoTienNo:N0} VND");
            Console.WriteLine($"Han chot tra no: {hanChot.ToString("dd/MM/yyyy")} (Mien lai)");
        }

        // INTRODUCE FOREIGN METHOD: Hàm bổ trợ cho lớp DateTime của C#
        private static DateTime TinhNgayCuoiThangToi(DateTime ngayHienTai)
        {
            // Cộng thêm 1 tháng, sau đó tìm số ngày của tháng mới để ra ngày cuối cùng
            DateTime thangToi = ngayHienTai.AddMonths(1);
            int ngayCuoiCung = DateTime.DaysInMonth(thangToi.Year, thangToi.Month);
            return new DateTime(thangToi.Year, thangToi.Month, ngayCuoiCung);
        }
    }
}