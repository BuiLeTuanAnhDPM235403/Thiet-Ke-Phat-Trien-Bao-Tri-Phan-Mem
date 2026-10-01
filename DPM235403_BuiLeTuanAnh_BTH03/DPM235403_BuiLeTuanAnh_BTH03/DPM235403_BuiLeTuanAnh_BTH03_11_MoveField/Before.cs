namespace DPM235403_BuiLeTuanAnh_BTH03_11_MoveField.Before
{
    public class AccountType
    {
        // Class này đang bị trống
    }

    public class Account
    {
        private AccountType _type;
        private double _interestRate; // Đặt sai chỗ

        public Account(AccountType type, double interestRate)
        {
            _type = type;
            _interestRate = interestRate;
        }

        public double InterestForAmount(double amount, int days)
        {
            return _interestRate * amount * days / 365.0;
        }
    }
}