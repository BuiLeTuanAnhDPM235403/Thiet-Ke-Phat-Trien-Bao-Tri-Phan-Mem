namespace DPM235403_BuiLeTuanAnh_BTH03_29_IntroduceAssertion.Before
{
    public class Expense
    {
        private double _expenseLimit = 0;
        private bool _isPrimaryProject = false;

        public double GetExpenseLimit()
        {
            return (_expenseLimit != 0) ? _expenseLimit : (_isPrimaryProject ? 100 : 0);
        }

        public void SetLimit(double limit) => _expenseLimit = limit;
        public void SetPrimary(bool primary) => _isPrimaryProject = primary;
    }
}