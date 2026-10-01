namespace DPM235403_BuiLeTuanAnh_BTH03_23_ConsolidateConditionalExpression.Before
{
    public class NhanVien
    {
        private int _seniority = 1;
        private int _monthsDisabled = 13;
        private bool _isPartTime = true;

        public double DisabilityAmount()
        {
            // Xấu: Rất nhiều lệnh if kiểm tra các điều kiện rác nhưng đều dẫn đến kết quả bằng 0
            if (_seniority < 2) return 0;
            if (_monthsDisabled > 12) return 0;
            if (_isPartTime) return 0;

            // Tính toán tiền trợ cấp thực sự
            return 100;
        }
    }
}