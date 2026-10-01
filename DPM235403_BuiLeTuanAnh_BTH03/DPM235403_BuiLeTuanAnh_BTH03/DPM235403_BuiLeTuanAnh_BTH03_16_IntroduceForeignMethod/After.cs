using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_16_IntroduceForeignMethod.After
{
    public class Report
    {
        public void GenerateReport()
        {
            DateTime previousEnd = DateTime.Now;

            // Tốt: Sử dụng phương thức ngoại biên để xử lý
            DateTime newStart = NextDay(previousEnd);

            Console.WriteLine($"Bao cao tiep theo vao ngay: {newStart.ToString("dd/MM/yyyy")}");
        }

        // INTRODUCE FOREIGN METHOD: Tạo hàm đóng vai trò như một chức năng mở rộng cho DateTime
        private static DateTime NextDay(DateTime arg)
        {
            return arg.AddDays(1);
        }
    }
}