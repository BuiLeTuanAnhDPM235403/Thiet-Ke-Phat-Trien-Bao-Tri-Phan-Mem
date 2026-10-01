namespace DPM235403_BuiLeTuanAnh_BTH03_23_ConsolidateConditionalExpression.After
{
    public class NhanVien
    {
        private int _seniority = 1;
        private int _monthsDisabled = 13;
        private bool _isPartTime = true;

        public double DisabilityAmount()
        {
            // Tốt: Gộp tất cả lại thành 1 hàm kiểm tra, đọc vào hiểu ngay ý nghĩa
            if (IsNotEligibleForDisability()) return 0;

            return 100;
        }

        // Tách biểu thức đã gộp ra một hàm riêng
        private bool IsNotEligibleForDisability()
        {
            return _seniority < 2 || _monthsDisabled > 12 || _isPartTime;
        }
    }
}