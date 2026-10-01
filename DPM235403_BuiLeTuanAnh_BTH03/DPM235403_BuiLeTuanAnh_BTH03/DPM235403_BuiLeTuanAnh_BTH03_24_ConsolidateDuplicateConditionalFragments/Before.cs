using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_24_ConsolidateDuplicateConditionalFragments.Before
{
    public class Order
    {
        public void ProcessOrder(bool isSpecialDeal, double price)
        {
            double total;
            if (isSpecialDeal)
            {
                total = price * 0.95;
                Send(total); // Bị trùng lặp
            }
            else
            {
                total = price * 0.98;
                Send(total); // Bị trùng lặp
            }
        }

        private void Send(double amount)
        {
            Console.WriteLine($"Sending order with total: {amount}");
        }
    }
}