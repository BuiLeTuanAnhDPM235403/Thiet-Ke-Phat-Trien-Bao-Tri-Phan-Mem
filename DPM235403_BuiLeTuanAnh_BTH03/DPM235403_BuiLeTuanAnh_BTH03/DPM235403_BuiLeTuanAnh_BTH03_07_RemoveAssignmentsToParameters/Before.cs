namespace DPM235403_BuiLeTuanAnh_BTH03_07_RemoveAssignmentsToParameters.Before
{
    public class TinhToan
    {
        public int Discount(int inputVal, int quantity)
        {
            // Xấu: Gán đè trực tiếp làm mất đi giá trị ban đầu của tham số inputVal
            if (inputVal > 50)
            {
                inputVal -= 2;
            }
            if (quantity > 100)
            {
                inputVal -= 1;
            }
            return inputVal;
        }
    }
}