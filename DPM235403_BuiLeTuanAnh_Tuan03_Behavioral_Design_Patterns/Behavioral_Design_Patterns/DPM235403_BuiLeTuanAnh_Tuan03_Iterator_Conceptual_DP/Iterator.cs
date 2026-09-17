using System.Collections;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Iterator_Conceptual_DP
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Trả về khóa của phần tử hiện tại
        public abstract int Key();

        // Trả về phần tử hiện tại
        public abstract object Current();

        // Chuyển tới phần tử tiếp theo
        public abstract bool MoveNext();

        // Đặt lại con trỏ về vị trí ban đầu
        public abstract void Reset();
    }
}