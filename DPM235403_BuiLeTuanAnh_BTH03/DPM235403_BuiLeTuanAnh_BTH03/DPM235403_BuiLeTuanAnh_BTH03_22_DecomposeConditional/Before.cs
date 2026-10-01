using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_22_DecomposeConditional.Before
{
    public class Billing
    {
        private DateTime _summerStart = new DateTime(2026, 6, 1);
        private DateTime _summerEnd = new DateTime(2026, 8, 31);
        private double _winterRate = 1.5;
        private double _winterServiceCharge = 10;
        private double _summerRate = 1.0;

        public double CalculateCharge(DateTime date, double quantity)
        {
            double charge;
            // Xấu: Biểu thức kiểm tra và công thức tính toán phơi bày toàn bộ sự phức tạp ra đây
            if (date < _summerStart || date > _summerEnd)
            {
                charge = quantity * _winterRate + _winterServiceCharge;
            }
            else
            {
                charge = quantity * _summerRate;
            }
            return charge;
        }
    }
}