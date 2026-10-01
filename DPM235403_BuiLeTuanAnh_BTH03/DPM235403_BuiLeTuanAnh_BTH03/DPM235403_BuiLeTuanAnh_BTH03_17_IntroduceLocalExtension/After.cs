using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_17_IntroduceLocalExtension.After
{
    // INTRODUCE LOCAL EXTENSION: Tạo Extension Method cho DateTime của hệ thống
    public static class DateTimeExtensions
    {
        public static DateTime NextDay(this DateTime date)
        {
            return date.AddDays(1);
        }
    }

    public class Report
    {
        public void SendReport(DateTime previousDate)
        {
            // Bây giờ DateTime đã "tự có" thêm hàm NextDay() như thể nó là hàm gốc của Microsoft
            DateTime nextDate = previousDate.NextDay();
            Console.WriteLine("Gui bao cao vao: " + nextDate.ToString("dd/MM/yyyy"));
        }
    }
}