using System.Collections;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Iterator_Conceptual_DP
{
    abstract class IteratorAggregate : IEnumerable
    {
        // Trả về một Iterator tương ứng cho collection
        public abstract IEnumerator GetEnumerator();
    }
}