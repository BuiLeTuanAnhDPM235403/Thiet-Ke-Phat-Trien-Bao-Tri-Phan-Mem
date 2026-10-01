using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_17_IntroduceLocalExtension.Before
{
    public class Report
    {
        public void SendReport(DateTime previousDate)
        {
            // Nếu muốn tìm ngày kế tiếp, phải tự cộng ngày (không có tính tái sử dụng)
            DateTime nextDate = previousDate.AddDays(1);
            Console.WriteLine("Gui bao cao vao: " + nextDate.ToString("dd/MM/yyyy"));
        }
    }
}