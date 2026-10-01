using System.Diagnostics;

namespace DPM235403_BuiLeTuanAnh_BTH03_29_IntroduceAssertion.After
{
    public class Expense
    {
        private double _expenseLimit = 0;
        private bool _isPrimaryProject = false;

        public double GetExpenseLimit()
        {
            Debug.Assert(_expenseLimit != 0 || !_isPrimaryProject, "Du an chinh bat buoc phai co ExpenseLimit!");
            return (_expenseLimit != 0) ? _expenseLimit : 0;
        }

        public void SetLimit(double limit) => _expenseLimit = limit;
        public void SetPrimary(bool primary) => _isPrimaryProject = primary;
    }
}