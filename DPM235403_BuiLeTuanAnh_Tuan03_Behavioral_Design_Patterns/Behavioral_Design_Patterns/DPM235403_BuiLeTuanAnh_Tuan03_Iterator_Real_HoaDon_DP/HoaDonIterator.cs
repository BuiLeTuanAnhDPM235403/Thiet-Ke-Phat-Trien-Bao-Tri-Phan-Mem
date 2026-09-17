namespace DPM235403_BuiLeTuanAnh_Tuan03_Iterator_Real_HoaDon_DP
{
    public class HoaDonIterator : IIterator
    {
        private DanhSachHoaDon _danhSach;
        private int _currentIndex = 0;

        public HoaDonIterator(DanhSachHoaDon danhSach)
        {
            _danhSach = danhSach;
        }

        public bool HasNext()
        {
            return _currentIndex < _danhSach.Count;
        }

        public HoaDon Next()
        {
            if (HasNext())
            {
                return _danhSach.GetHoaDon(_currentIndex++);
            }
            return null;
        }
    }
}