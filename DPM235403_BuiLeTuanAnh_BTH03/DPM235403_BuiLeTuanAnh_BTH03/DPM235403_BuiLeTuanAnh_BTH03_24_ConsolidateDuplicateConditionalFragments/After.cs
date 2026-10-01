using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_24_ConsolidateDuplicateConditionalFragments.After
{
    public class Order
    {
        public void ProcessOrder(bool isSpecialDeal, double price)
        {
            double total;
            // Khối if-else giờ đây chỉ tập trung vào sự khác biệt (tính total)
            if (isSpecialDeal)
            {
                total = price * 0.95;
            }
            else
            {
                total = price * 0.98;
            }

            // Hàm Send được kéo ra ngoài vì dù nhánh nào xảy ra thì nó cũng chạy
            Send(total);
        }

        private void Send(double amount)
        {
            Console.WriteLine($"Sending order with total: {amount}");
        }
    }
}