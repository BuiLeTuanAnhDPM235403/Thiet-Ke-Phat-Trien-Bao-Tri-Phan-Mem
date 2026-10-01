using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_16_IntroduceForeignMethod.Before
{
    public class Report
    {
        public void GenerateReport()
        {
            DateTime previousEnd = DateTime.Now;

            // Xấu: Cứ mỗi lần muốn tìm ngày kế tiếp, ta lại phải tự tính toán như thế này
            DateTime newStart = previousEnd.AddDays(1);

            Console.WriteLine($"Bao cao tiep theo vao ngay: {newStart.ToString("dd/MM/yyyy")}");
        }
    }
}