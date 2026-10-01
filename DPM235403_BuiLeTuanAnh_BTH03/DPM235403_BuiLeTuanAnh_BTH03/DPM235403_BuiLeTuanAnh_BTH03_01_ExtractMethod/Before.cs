using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_01_ExtractMethod.Before
{
    public class PhieuNo
    {
        private string _name = "Nguyen Van A";

        public void PrintOwing()
        {
            // Print banner
            Console.WriteLine("*****************************");
            Console.WriteLine("****** Customer Owes ******");
            Console.WriteLine("*****************************");

            // Calculate outstanding
            double outstanding = 1500.0; // Giả lập hàm getOutstanding()

            // Print details
            Console.WriteLine("name: " + _name);
            Console.WriteLine("amount: " + outstanding);
        }
    }
}