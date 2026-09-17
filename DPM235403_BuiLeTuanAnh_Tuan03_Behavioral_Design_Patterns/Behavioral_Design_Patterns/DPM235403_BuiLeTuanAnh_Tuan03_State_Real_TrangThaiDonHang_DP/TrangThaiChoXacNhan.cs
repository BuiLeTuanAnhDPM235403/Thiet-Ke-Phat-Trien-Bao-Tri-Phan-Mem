using System;

namespace DPM235403_BuiLeTuanAnh_Tuan03_State_Real_TrangThaiDonHang_DP
{
    public class TrangThaiChoXacNhan : TrangThaiDonHangBase
    {
        public override void XuLy()
        {
            Console.WriteLine("[State: Cho Xac Nhan] -> Da xac nhan don. Chuyen sang trang thai: Dang Giao Hang.");
            _context.ChuyenTrangThai(new TrangThaiDangGiaoHang());
        }

        public override void Huy()
        {
            Console.WriteLine("[State: Cho Xac Nhan] -> Huy don hang thanh cong. Khach chua phai den tien.");
        }
    }
}