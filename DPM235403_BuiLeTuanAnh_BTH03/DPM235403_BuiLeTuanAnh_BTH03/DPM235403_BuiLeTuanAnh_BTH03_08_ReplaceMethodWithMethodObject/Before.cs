namespace DPM235403_BuiLeTuanAnh_BTH03_08_ReplaceMethodWithMethodObject.Before
{
    public class Account
    {
        public int Gamma(int inputVal, int quantity, int yearToDate)
        {
            // Hàm quá phức tạp, biến cục bộ chồng chéo không thể Extract Method
            int importantValue1 = (inputVal * quantity) + Delta();
            int importantValue2 = (inputVal * yearToDate) + 100;

            if ((yearToDate - importantValue1) > 100)
            {
                importantValue2 -= 20;
            }

            int importantValue3 = importantValue2 * 7;
            return importantValue3 - 2 * importantValue1;
        }

        private int Delta()
        {
            return 10;
        }
    }
}