namespace DPM235403_BuiLeTuanAnh_BTH03_11_MoveField.After
{
    public class AccountType
    {
        // Đã di chuyển biến lãi suất sang đây cho đúng logic
        public double InterestRate { get; set; }

        public AccountType(double interestRate)
        {
            InterestRate = interestRate;
        }
    }

    public class Account
    {
        private AccountType _type;

        public Account(AccountType type)
        {
            _type = type;
        }

        public double InterestForAmount(double amount, int days)
        {
            // Lấy lãi suất từ AccountType
            return _type.InterestRate * amount * days / 365.0;
        }
    }
}