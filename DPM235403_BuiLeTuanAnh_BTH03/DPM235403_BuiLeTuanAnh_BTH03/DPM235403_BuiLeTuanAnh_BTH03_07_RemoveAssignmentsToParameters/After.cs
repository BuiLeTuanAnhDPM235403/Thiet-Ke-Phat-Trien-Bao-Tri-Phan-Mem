namespace DPM235403_BuiLeTuanAnh_BTH03_07_RemoveAssignmentsToParameters.After
{
    public class TinhToan
    {
        public int Discount(int inputVal, int quantity)
        {
            // Tốt: Khởi tạo biến result để tính toán, giữ nguyên tham số inputVal gốc
            int result = inputVal;

            if (inputVal > 50)
            {
                result -= 2;
            }
            if (quantity > 100)
            {
                result -= 1;
            }
            return result;
        }
    }
}