using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_Memento_Real_SaoLuuHoaDon_DP
{
    public interface IMemento
    {
        string GetTenBanSao();
        string GetNoiDungHoaDon();
        DateTime GetThoiGianLuu();
    }
}