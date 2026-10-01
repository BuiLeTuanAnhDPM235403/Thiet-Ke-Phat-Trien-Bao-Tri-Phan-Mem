using System;

namespace DPM235403_BuiLeTuanAnh_BTH03_22_DecomposeConditional.After
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
            // Tốt: Phân rã điều kiện giúp code đọc như tiếng Anh (Nếu là mùa hè -> Tính tiền mùa hè)
            if (IsSummer(date))
            {
                return SummerCharge(quantity);
            }
            else
            {
                return WinterCharge(quantity);
            }
        }

        // --- CÁC HÀM ĐƯỢC PHÂN RÃ ---
        private bool IsSummer(DateTime date)
        {
            return date >= _summerStart && date <= _summerEnd;
        }

        private double SummerCharge(double quantity)
        {
            return quantity * _summerRate;
        }

        private double WinterCharge(double quantity)
        {
            return quantity * _winterRate + _winterServiceCharge;
        }
    }
}