namespace DPM235403_BuiLeTuanAnh_BTH03_10_MoveMethod.Before
{
    public class AccountType
    {
        public bool IsPremium { get; set; }
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

        // Hàm này xài dữ liệu của AccountType nhiều hơn, để ở đây là sai chỗ
        public double OverdraftCharge()
        {
            if (_type.IsPremium)
            {
                int result = 10;
                if (_daysOverdrawn > 7) result += (_daysOverdrawn - 7) * 85;
                return result;
            }
            return _daysOverdrawn * 175;
        }
    }
}