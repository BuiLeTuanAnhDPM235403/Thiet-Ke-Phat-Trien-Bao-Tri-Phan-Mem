using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Memento_Real_SaoLuuHoaDon_DP
{
    public class HoaDonMemento : IMemento
    {
        private string _noiDungHoaDon;
        private DateTime _thoiGianLuu;

        public HoaDonMemento(string noiDung)
        {
            _noiDungHoaDon = noiDung;
            _thoiGianLuu = DateTime.Now;
        }

        public string GetNoiDungHoaDon() => _noiDungHoaDon;
        public string GetTenBanSao() => $"Ban nhap luc {_thoiGianLuu:HH:mm:ss} - {_noiDungHoaDon.Substring(0, Math.Min(15, _noiDungHoaDon.Length))}...";
        public DateTime GetThoiGianLuu() => _thoiGianLuu;
    }
}