namespace DPM235403_BuiLeTuanAnh_BTH03_18_SelfEncapsulateField.After
{
    public class IntRange
    {
        private int _low;
        private int _high;

        // Tự đóng gói (Self-encapsulate) bằng Properties
        public int Low
        {
            get { return _low; }
            set { _low = value; }
        }

        public int High
        {
            get { return _high; }
            set { _high = value; }
        }

        public IntRange(int low, int high)
        {
            Low = low; // Dùng setter
            High = high;
        }

        public bool Includes(int arg)
        {
            // Gọi qua getter, an toàn và dễ kiểm soát hơn
            return arg >= Low && arg <= High;
        }
    }
}