namespace DPM235403_BuiLeTuanAnh_BTH03_10_MoveMethod.After
{
    public class AccountType
    {
        public bool IsPremium { get; set; }

        // Hàm đã được di chuyển sang đúng nơi nó thuộc về
        public double OverdraftCharge(int daysOverdrawn)
        {
            if (IsPremium)
            {
                int result = 10;
                if (daysOverdrawn > 7) result += (daysOverdrawn - 7) * 85;
                return result;
            }
            return daysOverdrawn * 175;
        }
    }

    public class Account
    {
        private AccountType _type;
        private int _daysOverdrawn;

        public Account(AccountType type, int daysOverdrawn)
        {
            _type = type;
            _daysOverdrawn = daysOverdrawn;
        }

        // Chỉ cần gọi hàm từ AccountType là xong
        public double BankCharge()
        {
            double result = 4.5;
            if (_daysOverdrawn > 0) result += _type.OverdraftCharge(_daysOverdrawn);
            return result;
        }
    }
}