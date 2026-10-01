namespace DPM235403_BuiLeTuanAnh_BTH03_26_ReplaceNestedConditionalWithGuardClauses.Before
{
    public class Employee
    {
        private bool _isDead = false;
        private bool _isSeparated = false;
        private bool _isRetired = false;

        public double GetPayAmount()
        {
            double result;
            // Xấu: Cấu trúc if-else lồng nhau quá sâu
            if (_isDead)
            {
                result = DeadAmount();
            }
            else
            {
                if (_isSeparated)
                {
                    result = SeparatedAmount();
                }
                else
                {
                    if (_isRetired)
                    {
                        result = RetiredAmount();
                    }
                    else
                    {
                        result = NormalPayAmount();
                    }
                }
            }
            return result;
        }

        private double DeadAmount() => 0;
        private double SeparatedAmount() => 0;
        private double RetiredAmount() => 0;
        private double NormalPayAmount() => 1000;
    }
}