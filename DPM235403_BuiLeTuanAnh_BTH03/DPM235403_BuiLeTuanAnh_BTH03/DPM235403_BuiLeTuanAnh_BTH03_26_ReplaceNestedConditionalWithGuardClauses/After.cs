namespace DPM235403_BuiLeTuanAnh_BTH03_26_ReplaceNestedConditionalWithGuardClauses.After
{
    public class Employee
    {
        private bool _isDead = false;
        private bool _isSeparated = false;
        private bool _isRetired = false;

        public double GetPayAmount()
        {
            // Tốt: Sử dụng Mệnh đề bảo vệ (Guard Clauses) để return sớm
            if (_isDead) return DeadAmount();
            if (_isSeparated) return SeparatedAmount();
            if (_isRetired) return RetiredAmount();

            // Kịch bản chính nằm ở cuối, không bị lồng vào bất kỳ lệnh if nào
            return NormalPayAmount();
        }

        private double DeadAmount() => 0;
        private double SeparatedAmount() => 0;
        private double RetiredAmount() => 0;
        private double NormalPayAmount() => 1000;
    }
}