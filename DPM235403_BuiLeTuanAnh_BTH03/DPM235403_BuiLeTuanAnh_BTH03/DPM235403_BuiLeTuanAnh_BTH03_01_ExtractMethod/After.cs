using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_01_ExtractMethod.After
{
    public class PhieuNo
    {
        private string _name = "Nguyen Van A";

        public void PrintOwing()
        {
            PrintBanner();
            double outstanding = 1500.0; // Giả lập hàm getOutstanding()
            PrintDetails(outstanding);
        }

        private void PrintBanner()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("****** Customer Owes ******");
            Console.WriteLine("*****************************");
        }

        private void PrintDetails(double outstanding)
        {
            Console.WriteLine("name: " + _name);
            Console.WriteLine("amount: " + outstanding);
        }
    }
}