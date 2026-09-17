using System.Collections.Generic;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Iterator_Real_HoaDon_DP
{
    public class DanhSachHoaDon : IAggregate
    {
        private List<HoaDon> _danhSach = new List<HoaDon>();

        public void ThemHoaDon(HoaDon hd)
        {
            _danhSach.Add(hd);
        }

        public int Count => _danhSach.Count;

        public HoaDon GetHoaDon(int index)
        {
            return _danhSach[index];
        }

        public IIterator CreateIterator()
        {
            return new HoaDonIterator(this);
        }
    }
}