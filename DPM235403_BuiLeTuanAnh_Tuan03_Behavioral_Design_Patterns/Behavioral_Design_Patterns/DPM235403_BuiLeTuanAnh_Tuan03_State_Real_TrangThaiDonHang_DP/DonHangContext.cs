using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_State_Real_TrangThaiDonHang_DP
{
    public class DonHangContext
    {
        private TrangThaiDonHangBase _trangThai;

        public DonHangContext(TrangThaiDonHangBase trangThaiBanDau)
        {
            ChuyenTrangThai(trangThaiBanDau);
        }

        public void ChuyenTrangThai(TrangThaiDonHangBase trangThaiMoi)
        {
            _trangThai = trangThaiMoi;
            _trangThai.SetContext(this);
        }

        // Các hành động có thể thao tác trên đơn hàng
        public void XuLyDon()
        {
            _trangThai.XuLy();
        }

        public void HuyDon()
        {
            _trangThai.Huy();
        }
    }
}