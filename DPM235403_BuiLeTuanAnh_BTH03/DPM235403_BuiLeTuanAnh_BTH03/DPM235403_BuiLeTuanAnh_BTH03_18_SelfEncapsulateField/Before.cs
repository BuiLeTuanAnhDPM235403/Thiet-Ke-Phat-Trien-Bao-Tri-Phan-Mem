namespace DPM235403_BuiLeTuanAnh_BTH03_18_SelfEncapsulateField.Before
{
    public class IntRange
    {
        private int _low;
        private int _high;

        public IntRange(int low, int high)
        {
            _low = low;
            _high = high;
        }

        public bool Includes(int arg)
        {
            // Truy cập trực tiếp vào biến private
            return arg >= _low && arg <= _high;
        }
    }
}