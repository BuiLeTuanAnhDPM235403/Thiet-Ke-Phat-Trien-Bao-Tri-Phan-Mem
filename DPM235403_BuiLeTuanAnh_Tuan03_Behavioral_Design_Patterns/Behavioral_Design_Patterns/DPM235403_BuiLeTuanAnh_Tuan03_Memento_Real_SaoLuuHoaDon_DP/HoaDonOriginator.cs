using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Memento_Real_SaoLuuHoaDon_DP
{
    public class HoaDonOriginator
    {
        private string _danhSachHangHoa = "";

        public void ThemHangHoa(string tenHang)
        {
            _danhSachHangHoa += tenHang + ", ";
            Console.WriteLine($"[Ban Hang] Da them: {tenHang}. Hoa don hien tai: {_danhSachHangHoa}");
        }

        public IMemento TaoBanSao()
        {
            Console.WriteLine("[He Thong] Dang tao ban sao luu (Draft)...");
            return new HoaDonMemento(_danhSachHangHoa);
        }

        public void KhoiPhuc(IMemento memento)
        {
            _danhSachHangHoa = memento.GetNoiDungHoaDon();
            Console.WriteLine($"[He Thong] Da khoi phuc hoa don ve trang thai: {_danhSachHangHoa}");
        }
    }
}